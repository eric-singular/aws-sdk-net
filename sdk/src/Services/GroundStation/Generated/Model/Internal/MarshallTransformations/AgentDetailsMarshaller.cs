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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AgentDetails Marshaller
    /// </summary>
    public class AgentDetailsMarshaller : IRequestMarshaller<AgentDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AgentDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAgentVersion())
            {
                context.Writer.WritePropertyName("agentVersion");
                context.Writer.Write(requestObject.AgentVersion);
            }

            if(requestObject.IsSetComponentVersions())
            {
                context.Writer.WritePropertyName("componentVersions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectComponentVersionsListValue in requestObject.ComponentVersions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ComponentVersionMarshaller.Instance;
                    marshaller.Marshall(requestObjectComponentVersionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("instanceId");
                context.Writer.Write(requestObject.InstanceId);
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("instanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetReservedCpuCores())
            {
                context.Writer.WritePropertyName("reservedCpuCores");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReservedCpuCoresListValue in requestObject.ReservedCpuCores)
                {
                        context.Writer.Write(requestObjectReservedCpuCoresListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AgentDetailsMarshaller Instance = new AgentDetailsMarshaller();

    }
}