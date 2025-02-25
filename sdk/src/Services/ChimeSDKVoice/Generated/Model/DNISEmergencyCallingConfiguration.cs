/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DNISEmergencyCallingConfiguration
    {
        private string _callingCountry;
        private string _emergencyPhoneNumber;
        private string _testPhoneNumber;

        /// <summary>
        /// Gets and sets the property CallingCountry.
        /// </summary>
        [AWSProperty(Required=true)]
        public string CallingCountry
        {
            get { return this._callingCountry; }
            set { this._callingCountry = value; }
        }

        // Check to see if CallingCountry property is set
        internal bool IsSetCallingCountry()
        {
            return this._callingCountry != null;
        }

        /// <summary>
        /// Gets and sets the property EmergencyPhoneNumber.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string EmergencyPhoneNumber
        {
            get { return this._emergencyPhoneNumber; }
            set { this._emergencyPhoneNumber = value; }
        }

        // Check to see if EmergencyPhoneNumber property is set
        internal bool IsSetEmergencyPhoneNumber()
        {
            return this._emergencyPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property TestPhoneNumber.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string TestPhoneNumber
        {
            get { return this._testPhoneNumber; }
            set { this._testPhoneNumber = value; }
        }

        // Check to see if TestPhoneNumber property is set
        internal bool IsSetTestPhoneNumber()
        {
            return this._testPhoneNumber != null;
        }

    }
}