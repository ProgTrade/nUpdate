﻿/**
 *  Class to sign data with the RSA-class
 *  
 *  Author: Tim Schiewe (timmi31061)
 *  License: GPL v3
 *  Created: 09th December 2013
 *  Modified: Dominic B. (Trade) - 15.12.13 - Improved design of constructor
 *  Modified: Tim Schiewe (timmi31061) - 04.01.14 - Parameter validation added; more IntelliSense.
 *  Modified: Tim Schiewe (timmi31061) - 04.01.14 - Critical security update
 *  Modified: Dominic B. (Trade) - 23.01.2014 - Changed language of comments
 */

using System;
using System.Security.Cryptography;

namespace nUpdate.Administration.Core
{
    /// <summary>
    ///     Class to sign data with the RSA-class.
    /// </summary>
    public class RsaSignature
    {
        /// <summary>
        ///     The default key size in bits.
        /// </summary>
        public const int DEFAULT_KEY_SIZE = 8192;

        private readonly RSACryptoServiceProvider _rsa;

        /// <summary>
        ///     Creates a new instance of the RsaSignature-class.
        /// </summary>
        /// <param name="rsaKey">The key to use.</param>
        public RsaSignature(string rsaKey)
        {
            if (string.IsNullOrEmpty(rsaKey)) // If a corrupt or no key was entered...
                throw new ArgumentNullException("rsaKey"); // Throw ArgumentException...

            _rsa = new RSACryptoServiceProvider(); // Key was given...
            _rsa.FromXmlString(rsaKey); // ...so we import it.
            _rsa.PersistKeyInCsp = false; // Make sure, that .NET does not save the key.
        }

        /// <summary>
        ///     Creates a new instance of the RsaSignature-class and creates a new key pair.
        /// </summary>
        public RsaSignature()
        {
            _rsa = new RSACryptoServiceProvider(DEFAULT_KEY_SIZE); // Create a new key pair with the default key size.
            _rsa.ToXmlString(true); // A dummy to create the key.
            _rsa.PersistKeyInCsp = false; // Make sure, that .NET does not save the key.
        }

        /// <summary>
        ///     Returns the public key.
        /// </summary>
        public string PublicKey
        {
            get { return _rsa.ToXmlString(false); // Export public key
            }
        }

        /// <summary>
        ///     Returns private key.
        /// </summary>
        public string PrivateKey
        {
            get { return _rsa.ToXmlString(true); // Export private key and public key
            }
        }

        /// <summary>
        ///     Calculates the signature for the given data.
        /// </summary>
        /// <param name="data">The data to calculate the signature for.</param>
        /// <returns>The calculated signature.</returns>
        public byte[] SignData(byte[] data)
        {
            return _rsa.SignData(data, typeof (SHA512)); // Calculates the signature and returns it...
        }

        /// <summary>
        ///     Checks the signature for the given data.
        /// </summary>
        /// <param name="data">The data to check.</param>
        /// <param name="signature">The signature to check.</param>
        /// <returns>Return "true" if the signature is correct, otherwise return "false".</returns>
        public bool VerifyData(byte[] data, byte[] signature)
        {
            return _rsa.VerifyData(data, typeof (SHA512), signature);
            // Checks if the signature for the given signature is correct.
        }
    }
}