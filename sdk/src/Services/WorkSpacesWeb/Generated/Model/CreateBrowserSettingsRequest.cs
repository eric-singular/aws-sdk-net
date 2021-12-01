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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBrowserSettings operation.
    /// Creates a browser settings resource that can be associated with a web portal. Once
    /// associated with a web portal, browser settings control how the browser will behave
    /// once a user starts a streaming session for the web portal.
    /// </summary>
    public partial class CreateBrowserSettingsRequest : AmazonWorkSpacesWebRequest
    {
        private Dictionary<string, string> _additionalEncryptionContext = new Dictionary<string, string>();
        private string _browserPolicy;
        private string _clientToken;
        private string _customerManagedKey;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// Additional encryption context of the browser settings.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdditionalEncryptionContext
        {
            get { return this._additionalEncryptionContext; }
            set { this._additionalEncryptionContext = value; }
        }

        // Check to see if AdditionalEncryptionContext property is set
        internal bool IsSetAdditionalEncryptionContext()
        {
            return this._additionalEncryptionContext != null && this._additionalEncryptionContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BrowserPolicy. 
        /// <para>
        /// A JSON string containing Chrome Enterprise policies that will be applied to all streaming
        /// sessions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=131072)]
        public string BrowserPolicy
        {
            get { return this._browserPolicy; }
            set { this._browserPolicy = value; }
        }

        // Check to see if BrowserPolicy property is set
        internal bool IsSetBrowserPolicy()
        {
            return this._browserPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully, subsequent retries
        /// with the same client token returns the result from the original successful request.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a client token, one is automatically generated by the AWS SDK.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property CustomerManagedKey. 
        /// <para>
        /// The custom managed key of the browser settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CustomerManagedKey
        {
            get { return this._customerManagedKey; }
            set { this._customerManagedKey = value; }
        }

        // Check to see if CustomerManagedKey property is set
        internal bool IsSetCustomerManagedKey()
        {
            return this._customerManagedKey != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the browser settings resource. A tag is a key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}