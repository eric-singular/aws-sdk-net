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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for avail suppression, also known as ad suppression. For more information
    /// about ad suppression, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/ad-behavior.html">Ad
    /// Suppression</a>.
    /// </summary>
    public partial class AvailSuppression
    {
        private Mode _mode;
        private string _value;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Sets the ad suppression mode. By default, ad suppression is off and all ad breaks
        /// are filled with ads or slate. When Mode is set to <code>BEHIND_LIVE_EDGE</code>, ad
        /// suppression is active and MediaTailor won't fill ad breaks on or behind the ad suppression
        /// Value time in the manifest lookback window.
        /// </para>
        /// </summary>
        public Mode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A live edge offset time in HH:MM:SS. MediaTailor won't fill ad breaks on or behind
        /// this time in the manifest lookback window. If Value is set to 00:00:00, it is in sync
        /// with the live edge, and MediaTailor won't fill any ad breaks on or behind the live
        /// edge. If you set a Value time, MediaTailor won't fill any ad breaks on or behind this
        /// time in the manifest lookback window. For example, if you set 00:45:00, then MediaTailor
        /// will fill ad breaks that occur within 45 minutes behind the live edge, but won't fill
        /// ad breaks on or behind 45 minutes behind the live edge.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}