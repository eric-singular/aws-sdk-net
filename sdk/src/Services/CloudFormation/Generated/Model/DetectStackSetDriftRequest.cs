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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the DetectStackSetDrift operation.
    /// Detect drift on a stack set. When CloudFormation performs drift detection on a stack
    /// set, it performs drift detection on the stack associated with each stack instance
    /// in the stack set. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">How
    /// CloudFormation performs drift detection on a stack set</a>.
    /// 
    ///  
    /// <para>
    ///  <code>DetectStackSetDrift</code> returns the <code>OperationId</code> of the stack
    /// set drift detection operation. Use this operation id with <code> <a>DescribeStackSetOperation</a>
    /// </code> to monitor the progress of the drift detection operation. The drift detection
    /// operation may take some time, depending on the number of stack instances included
    /// in the stack set, in addition to the number of resources included in each stack.
    /// </para>
    ///  
    /// <para>
    /// Once the operation has completed, use the following actions to return drift information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use <code> <a>DescribeStackSet</a> </code> to return detailed information about the
    /// stack set, including detailed information about the last <i>completed</i> drift operation
    /// performed on the stack set. (Information about drift operations that are in progress
    /// isn't included.)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <code> <a>ListStackInstances</a> </code> to return a list of stack instances belonging
    /// to the stack set, including the drift status and last drift time checked of each instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <code> <a>DescribeStackInstance</a> </code> to return detailed information about
    /// a specific stack instance, including its drift status and last drift time checked.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about performing a drift detection operation on a stack set,
    /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-drift.html">Detecting
    /// unmanaged changes in stack sets</a>.
    /// </para>
    ///  
    /// <para>
    /// You can only run a single drift detection operation on a given stack set at one time.
    /// </para>
    ///  
    /// <para>
    /// To stop a drift detection stack set operation, use <code> <a>StopStackSetOperation</a>
    /// </code>.
    /// </para>
    /// </summary>
    public partial class DetectStackSetDriftRequest : AmazonCloudFormationRequest
    {
        private CallAs _callAs;
        private string _operationId;
        private StackSetOperationPreferences _operationPreferences;
        private string _stackSetName;

        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// [Service-managed permissions] Specifies whether you are acting as an account administrator
        /// in the organization's management account or as a delegated administrator in a member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// By default, <code>SELF</code> is specified. Use <code>SELF</code> for stack sets with
        /// self-managed permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <code>SELF</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <code>DELEGATED_ADMIN</code>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs
        {
            get { return this._callAs; }
            set { this._callAs = value; }
        }

        // Check to see if CallAs property is set
        internal bool IsSetCallAs()
        {
            return this._callAs != null;
        }

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        ///  <i>The ID of the stack set operation.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

        /// <summary>
        /// Gets and sets the property OperationPreferences.
        /// </summary>
        public StackSetOperationPreferences OperationPreferences
        {
            get { return this._operationPreferences; }
            set { this._operationPreferences = value; }
        }

        // Check to see if OperationPreferences property is set
        internal bool IsSetOperationPreferences()
        {
            return this._operationPreferences != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name of the stack set on which to perform the drift detection operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

    }
}