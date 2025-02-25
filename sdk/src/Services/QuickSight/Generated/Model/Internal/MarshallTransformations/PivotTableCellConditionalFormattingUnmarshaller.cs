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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PivotTableCellConditionalFormatting Object
    /// </summary>  
    public class PivotTableCellConditionalFormattingUnmarshaller : IUnmarshaller<PivotTableCellConditionalFormatting, XmlUnmarshallerContext>, IUnmarshaller<PivotTableCellConditionalFormatting, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PivotTableCellConditionalFormatting IUnmarshaller<PivotTableCellConditionalFormatting, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PivotTableCellConditionalFormatting Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PivotTableCellConditionalFormatting unmarshalledObject = new PivotTableCellConditionalFormatting();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FieldId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FieldId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Scope", targetDepth))
                {
                    var unmarshaller = PivotTableConditionalFormattingScopeUnmarshaller.Instance;
                    unmarshalledObject.Scope = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TextFormat", targetDepth))
                {
                    var unmarshaller = TextConditionalFormatUnmarshaller.Instance;
                    unmarshalledObject.TextFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PivotTableCellConditionalFormattingUnmarshaller _instance = new PivotTableCellConditionalFormattingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PivotTableCellConditionalFormattingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}