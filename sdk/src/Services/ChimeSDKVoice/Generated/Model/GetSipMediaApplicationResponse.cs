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
    /// This is the response object from the GetSipMediaApplication operation.
    /// </summary>
    public partial class GetSipMediaApplicationResponse : AmazonWebServiceResponse
    {
        private SipMediaApplication _sipMediaApplication;

        /// <summary>
        /// Gets and sets the property SipMediaApplication.
        /// </summary>
        public SipMediaApplication SipMediaApplication
        {
            get { return this._sipMediaApplication; }
            set { this._sipMediaApplication = value; }
        }

        // Check to see if SipMediaApplication property is set
        internal bool IsSetSipMediaApplication()
        {
            return this._sipMediaApplication != null;
        }

    }
}