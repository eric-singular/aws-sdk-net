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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KeyManagementService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Verify Request Marshaller
    /// </summary>       
    public class VerifyRequestMarshaller : IMarshaller<IRequest, VerifyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((VerifyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(VerifyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KeyManagementService");
            string target = "TrentService.Verify";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetGrantTokens())
                {
                    context.Writer.WritePropertyName("GrantTokens");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGrantTokensListValue in publicRequest.GrantTokens)
                    {
                            context.Writer.Write(publicRequestGrantTokensListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetKeyId())
                {
                    context.Writer.WritePropertyName("KeyId");
                    context.Writer.Write(publicRequest.KeyId);
                }

                if(publicRequest.IsSetMessage())
                {
                    context.Writer.WritePropertyName("Message");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.Message));
                }

                if(publicRequest.IsSetMessageType())
                {
                    context.Writer.WritePropertyName("MessageType");
                    context.Writer.Write(publicRequest.MessageType);
                }

                if(publicRequest.IsSetSignature())
                {
                    context.Writer.WritePropertyName("Signature");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.Signature));
                }

                if(publicRequest.IsSetSigningAlgorithm())
                {
                    context.Writer.WritePropertyName("SigningAlgorithm");
                    context.Writer.Write(publicRequest.SigningAlgorithm);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static VerifyRequestMarshaller _instance = new VerifyRequestMarshaller();        

        internal static VerifyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VerifyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}