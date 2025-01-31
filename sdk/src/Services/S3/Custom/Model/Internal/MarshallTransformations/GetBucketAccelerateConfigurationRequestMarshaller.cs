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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Get Object Accelerate Configuration Request Marshaller
    /// </summary>       
    public class GetBucketAccelerateConfigurationRequestMarshaller : IMarshaller<IRequest, GetBucketAccelerateConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((GetBucketAccelerateConfigurationRequest)input);
        }

        public IRequest Marshall(GetBucketAccelerateConfigurationRequest getBucketAccelerateRequest)
        {
            IRequest request = new DefaultRequest(getBucketAccelerateRequest, "AmazonS3");

            request.HttpMethod = "GET";

            if (getBucketAccelerateRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(getBucketAccelerateRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(getBucketAccelerateRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "GetBucketAccelerateConfigurationRequest.BucketName");

            request.ResourcePath = "/";
            request.AddSubResource("accelerate");
            request.UseQueryString = true;
            
            return request;
        }

        private static GetBucketAccelerateConfigurationRequestMarshaller _instance;

        public static GetBucketAccelerateConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketAccelerateConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
    
