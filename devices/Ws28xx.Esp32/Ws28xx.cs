// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using nanoFramework.Hardware.Esp32.Rmt;
using System;

namespace Iot.Device.Ws28xx.Esp32
{
    /// <summary>
    /// Represents base class for WS28XX LED drivers (i.e. WS2812B or WS2808)
    /// </summary>
    public class Ws28xx
    {
        /// <summary>
        /// SPI device used for communication with the LED driver
        /// </summary>
        protected readonly int _gpioPin;

        /// <summary>
        /// The One pulse command
        /// </summary>
        internal RmtCommand OnePulse { get; set; }

        /// <summary>
        /// The zero pulse command
        /// </summary>
        internal RmtCommand ZeroPulse { get; set; }

        /// <summary>
        /// The reset command
        /// </summary>
        internal RmtCommand ResetCommand { get; set; }

        /// <summary>
        /// Gets or sets the clock divider
        /// </summary>
        internal byte ClockDivider { get; set; } = 2;

        /// <summary>
        /// Backing image to be updated on the driver
        /// </summary>
        public BitmapImage Image { get; }

        /// <summary>
        /// Constructs Ws28xx instance
        /// </summary>
        /// <param name="gpioPin">The GPIO pin used for communication with the LED driver</param>
        /// <param name="image">The bitmap that represents the screen or led strip.</param>
        public Ws28xx(int gpioPin, BitmapImage image)
        {
            if (gpioPin < 0)
            {
                throw new ArgumentException();
            }

            _gpioPin = gpioPin;
            Image = image;
        }

        /// <summary>
        /// Sends backing image to the LED driver
        /// </summary>
        public void Update()
        {
            var transmitter = new TransmitterChannel(_gpioPin);
            transmitter.CarrierEnabled = false;
            // this value for the clock divider considers a clock source of 80MHz which is what we have fixed in native
            transmitter.ClockDivider = ClockDivider;
            transmitter.IdleLevel = false;
            for(int i=0; i<Image.Data.Length; i++)
            {
                SerializeColor(Image.Data[i], transmitter);
            }

            transmitter.AddCommand(ResetCommand);
            transmitter.Send(true);
            transmitter.Dispose();
        }

        private void SerializeColor(byte b, TransmitterChannel transmitter)
        {
            for (var i = 0; i < 8; ++i)
            {
                transmitter.AddCommand(((b & (1u << 7)) != 0) ? OnePulse : ZeroPulse);
                b <<= 1;
            }
        }
    }
}
