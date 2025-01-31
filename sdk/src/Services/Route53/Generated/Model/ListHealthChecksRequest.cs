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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListHealthChecks operation.
    /// Retrieve a list of the health checks that are associated with the current Amazon Web
    /// Services account.
    /// </summary>
    public partial class ListHealthChecksRequest : AmazonRoute53Request
    {
        private string _marker;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>true</code>,
        /// you have more health checks. To get another group, submit another <code>ListHealthChecks</code>
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// For the value of <code>marker</code>, specify the value of <code>NextMarker</code>
        /// from the previous response, which is the ID of the first health check that Amazon
        /// Route 53 will return if you submit another request.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>false</code>,
        /// there are no more health checks to get.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of health checks that you want <code>ListHealthChecks</code> to
        /// return in response to the current request. Amazon Route 53 returns a maximum of 100
        /// items. If you set <code>MaxItems</code> to a value greater than 100, Route 53 returns
        /// only the first 100 health checks. 
        /// </para>
        /// </summary>
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}