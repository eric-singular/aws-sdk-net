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
    public partial class PhoneNumber
    {
        private List<PhoneNumberAssociation> _associations = new List<PhoneNumberAssociation>();
        private string _callingName;
        private CallingNameStatus _callingNameStatus;
        private PhoneNumberCapabilities _capabilities;
        private string _country;
        private DateTime? _createdTimestamp;
        private DateTime? _deletionTimestamp;
        private string _e164PhoneNumber;
        private string _orderId;
        private string _phoneNumberId;
        private PhoneNumberProductType _productType;
        private PhoneNumberStatus _status;
        private PhoneNumberType _type;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property Associations.
        /// </summary>
        public List<PhoneNumberAssociation> Associations
        {
            get { return this._associations; }
            set { this._associations = value; }
        }

        // Check to see if Associations property is set
        internal bool IsSetAssociations()
        {
            return this._associations != null && this._associations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CallingName.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CallingName
        {
            get { return this._callingName; }
            set { this._callingName = value; }
        }

        // Check to see if CallingName property is set
        internal bool IsSetCallingName()
        {
            return this._callingName != null;
        }

        /// <summary>
        /// Gets and sets the property CallingNameStatus.
        /// </summary>
        public CallingNameStatus CallingNameStatus
        {
            get { return this._callingNameStatus; }
            set { this._callingNameStatus = value; }
        }

        // Check to see if CallingNameStatus property is set
        internal bool IsSetCallingNameStatus()
        {
            return this._callingNameStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Capabilities.
        /// </summary>
        public PhoneNumberCapabilities Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null;
        }

        /// <summary>
        /// Gets and sets the property Country.
        /// </summary>
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp.
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionTimestamp.
        /// </summary>
        public DateTime DeletionTimestamp
        {
            get { return this._deletionTimestamp.GetValueOrDefault(); }
            set { this._deletionTimestamp = value; }
        }

        // Check to see if DeletionTimestamp property is set
        internal bool IsSetDeletionTimestamp()
        {
            return this._deletionTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property E164PhoneNumber.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string E164PhoneNumber
        {
            get { return this._e164PhoneNumber; }
            set { this._e164PhoneNumber = value; }
        }

        // Check to see if E164PhoneNumber property is set
        internal bool IsSetE164PhoneNumber()
        {
            return this._e164PhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property OrderId.
        /// </summary>
        public string OrderId
        {
            get { return this._orderId; }
            set { this._orderId = value; }
        }

        // Check to see if OrderId property is set
        internal bool IsSetOrderId()
        {
            return this._orderId != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberId.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PhoneNumberId
        {
            get { return this._phoneNumberId; }
            set { this._phoneNumberId = value; }
        }

        // Check to see if PhoneNumberId property is set
        internal bool IsSetPhoneNumberId()
        {
            return this._phoneNumberId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductType.
        /// </summary>
        public PhoneNumberProductType ProductType
        {
            get { return this._productType; }
            set { this._productType = value; }
        }

        // Check to see if ProductType property is set
        internal bool IsSetProductType()
        {
            return this._productType != null;
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public PhoneNumberStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public PhoneNumberType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp.
        /// </summary>
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}