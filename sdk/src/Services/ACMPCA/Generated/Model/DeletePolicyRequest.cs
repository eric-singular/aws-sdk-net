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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePolicy operation.
    /// Deletes the resource-based policy attached to a private CA. Deletion will remove any
    /// access that the policy has granted. If there is no policy attached to the private
    /// CA, this action will return successful.
    /// 
    ///  
    /// <para>
    /// If you delete a policy that was applied through Amazon Web Services Resource Access
    /// Manager (RAM), the CA will be removed from all shares in which it was included. 
    /// </para>
    ///  
    /// <para>
    /// The Certificate Manager Service Linked Role that the policy supports is not affected
    /// when you delete the policy. 
    /// </para>
    ///  
    /// <para>
    /// The current policy can be shown with <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetPolicy.html">GetPolicy</a>
    /// and updated with <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_PutPolicy.html">PutPolicy</a>.
    /// </para>
    ///  <p class="title"> <b>About Policies</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A policy grants access on a private CA to an Amazon Web Services customer account,
    /// to Amazon Web Services Organizations, or to an Amazon Web Services Organizations unit.
    /// Policies are under the control of a CA administrator. For more information, see <a
    /// href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-rbp.html">Using a
    /// Resource Based Policy with Amazon Web Services Private CA</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A policy permits a user of Certificate Manager (ACM) to issue ACM certificates signed
    /// by a CA in another account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For ACM to manage automatic renewal of these certificates, the ACM user must configure
    /// a Service Linked Role (SLR). The SLR allows the ACM service to assume the identity
    /// of the user, subject to confirmation against the Amazon Web Services Private CA policy.
    /// For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-slr.html">Using
    /// a Service Linked Role with ACM</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Updates made in Amazon Web Services Resource Manager (RAM) are reflected in policies.
    /// For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-ram.html">Attach
    /// a Policy for Cross-Account Access</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeletePolicyRequest : AmazonACMPCARequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the private CA that will have its policy deleted.
        /// You can find the CA's ARN by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>
        /// action. The ARN value must have the form <code>arn:aws:acm-pca:region:account:certificate-authority/01234567-89ab-cdef-0123-0123456789ab</code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=200)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}