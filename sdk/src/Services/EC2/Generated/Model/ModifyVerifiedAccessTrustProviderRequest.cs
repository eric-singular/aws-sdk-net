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
    /// Container for the parameters to the ModifyVerifiedAccessTrustProvider operation.
    /// Modifies the configuration of the specified Amazon Web Services Verified Access trust
    /// provider.
    /// </summary>
    public partial class ModifyVerifiedAccessTrustProviderRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private ModifyVerifiedAccessTrustProviderOidcOptions _oidcOptions;
        private string _verifiedAccessTrustProviderId;

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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Web Services Verified Access trust provider.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property OidcOptions. 
        /// <para>
        /// The OpenID Connect details for an <code>oidc</code>-type, user-identity based trust
        /// provider.
        /// </para>
        /// </summary>
        public ModifyVerifiedAccessTrustProviderOidcOptions OidcOptions
        {
            get { return this._oidcOptions; }
            set { this._oidcOptions = value; }
        }

        // Check to see if OidcOptions property is set
        internal bool IsSetOidcOptions()
        {
            return this._oidcOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessTrustProviderId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access trust provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VerifiedAccessTrustProviderId
        {
            get { return this._verifiedAccessTrustProviderId; }
            set { this._verifiedAccessTrustProviderId = value; }
        }

        // Check to see if VerifiedAccessTrustProviderId property is set
        internal bool IsSetVerifiedAccessTrustProviderId()
        {
            return this._verifiedAccessTrustProviderId != null;
        }

    }
}