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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The display options of a control.
    /// </summary>
    public partial class DateTimePickerControlDisplayOptions
    {
        private string _dateTimeFormat;
        private LabelOptions _titleOptions;

        /// <summary>
        /// Gets and sets the property DateTimeFormat. 
        /// <para>
        /// Customize how dates are formatted in controls.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DateTimeFormat
        {
            get { return this._dateTimeFormat; }
            set { this._dateTimeFormat = value; }
        }

        // Check to see if DateTimeFormat property is set
        internal bool IsSetDateTimeFormat()
        {
            return this._dateTimeFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TitleOptions. 
        /// <para>
        /// The options to configure the title visibility, name, and font size.
        /// </para>
        /// </summary>
        public LabelOptions TitleOptions
        {
            get { return this._titleOptions; }
            set { this._titleOptions = value; }
        }

        // Check to see if TitleOptions property is set
        internal bool IsSetTitleOptions()
        {
            return this._titleOptions != null;
        }

    }
}