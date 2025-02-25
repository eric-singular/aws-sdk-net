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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGroup operation.
    /// Creates a new group in the specified user pool.
    /// 
    ///  
    /// <para>
    /// Calling this action requires developer credentials.
    /// </para>
    /// </summary>
    public partial class CreateGroupRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _description;
        private string _groupName;
        private int? _precedence;
        private string _roleArn;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A string containing the description of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group. Must be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property Precedence. 
        /// <para>
        /// A non-negative integer value that specifies the precedence of this group relative
        /// to the other groups that a user can belong to in the user pool. Zero is the highest
        /// precedence value. Groups with lower <code>Precedence</code> values take precedence
        /// over groups with higher or null <code>Precedence</code> values. If a user belongs
        /// to two or more groups, it is the group with the lowest precedence value whose role
        /// ARN is given in the user's tokens for the <code>cognito:roles</code> and <code>cognito:preferred_role</code>
        /// claims.
        /// </para>
        ///  
        /// <para>
        /// Two groups can have the same <code>Precedence</code> value. If this happens, neither
        /// group takes precedence over the other. If two groups with the same <code>Precedence</code>
        /// have the same role ARN, that role is used in the <code>cognito:preferred_role</code>
        /// claim in tokens for users in each group. If the two groups have different role ARNs,
        /// the <code>cognito:preferred_role</code> claim isn't set in users' tokens.
        /// </para>
        ///  
        /// <para>
        /// The default <code>Precedence</code> value is null. The maximum <code>Precedence</code>
        /// value is <code>2^31-1</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int Precedence
        {
            get { return this._precedence.GetValueOrDefault(); }
            set { this._precedence = value; }
        }

        // Check to see if Precedence property is set
        internal bool IsSetPrecedence()
        {
            return this._precedence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role Amazon Resource Name (ARN) for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}