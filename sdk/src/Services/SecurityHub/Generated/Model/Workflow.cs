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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the status of the investigation into a finding.
    /// </summary>
    public partial class Workflow
    {
        private WorkflowStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the investigation into the finding. The workflow status is specific
        /// to an individual finding. It does not affect the generation of new findings. For example,
        /// setting the workflow status to <code>SUPPRESSED</code> or <code>RESOLVED</code> does
        /// not prevent a new finding for the same issue.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NEW</code> - The initial state of a finding, before it is reviewed.
        /// </para>
        ///  
        /// <para>
        /// Security Hub also resets the workflow status from <code>NOTIFIED</code> or <code>RESOLVED</code>
        /// to <code>NEW</code> in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RecordState</code> changes from <code>ARCHIVED</code> to <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ComplianceStatus</code> changes from <code>PASSED</code> to either <code>WARNING</code>,
        /// <code>FAILED</code>, or <code>NOT_AVAILABLE</code>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>NOTIFIED</code> - Indicates that you notified the resource owner about the
        /// security issue. Used when the initial reviewer is not the resource owner, and needs
        /// intervention from the resource owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUPPRESSED</code> - Indicates that you reviewed the finding and do not believe
        /// that any action is needed. The finding is no longer updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RESOLVED</code> - The finding was reviewed and remediated and is now considered
        /// resolved. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkflowStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}