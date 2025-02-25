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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes a source code repository.
    /// </summary>
    public partial class CodeRepository
    {
        private CodeConfiguration _codeConfiguration;
        private string _repositoryUrl;
        private SourceCodeVersion _sourceCodeVersion;

        /// <summary>
        /// Gets and sets the property CodeConfiguration. 
        /// <para>
        /// Configuration for building and running the service from a source code repository.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>CodeConfiguration</code> is required only for <code>CreateService</code> request.
        /// </para>
        ///  </note>
        /// </summary>
        public CodeConfiguration CodeConfiguration
        {
            get { return this._codeConfiguration; }
            set { this._codeConfiguration = value; }
        }

        // Check to see if CodeConfiguration property is set
        internal bool IsSetCodeConfiguration()
        {
            return this._codeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryUrl. 
        /// <para>
        /// The location of the repository that contains the source code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=51200)]
        public string RepositoryUrl
        {
            get { return this._repositoryUrl; }
            set { this._repositoryUrl = value; }
        }

        // Check to see if RepositoryUrl property is set
        internal bool IsSetRepositoryUrl()
        {
            return this._repositoryUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCodeVersion. 
        /// <para>
        /// The version that should be used within the source code repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceCodeVersion SourceCodeVersion
        {
            get { return this._sourceCodeVersion; }
            set { this._sourceCodeVersion = value; }
        }

        // Check to see if SourceCodeVersion property is set
        internal bool IsSetSourceCodeVersion()
        {
            return this._sourceCodeVersion != null;
        }

    }
}