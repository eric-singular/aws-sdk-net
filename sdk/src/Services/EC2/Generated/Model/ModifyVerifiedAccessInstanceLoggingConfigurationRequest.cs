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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVerifiedAccessInstanceLoggingConfiguration operation.
    /// Modifies the logging configuration for the specified Amazon Web Services Verified
    /// Access instance.
    /// </summary>
    public partial class ModifyVerifiedAccessInstanceLoggingConfigurationRequest : AmazonEC2Request
    {
        private VerifiedAccessLogOptions _accessLogs;
        private string _clientToken;
        private string _verifiedAccessInstanceId;

        /// <summary>
        /// Gets and sets the property AccessLogs. 
        /// <para>
        /// The configuration options for Amazon Web Services Verified Access instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VerifiedAccessLogOptions AccessLogs
        {
            get { return this._accessLogs; }
            set { this._accessLogs = value; }
        }

        // Check to see if AccessLogs property is set
        internal bool IsSetAccessLogs()
        {
            return this._accessLogs != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure idempotency of your modification
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessInstanceId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VerifiedAccessInstanceId
        {
            get { return this._verifiedAccessInstanceId; }
            set { this._verifiedAccessInstanceId = value; }
        }

        // Check to see if VerifiedAccessInstanceId property is set
        internal bool IsSetVerifiedAccessInstanceId()
        {
            return this._verifiedAccessInstanceId != null;
        }

    }
}