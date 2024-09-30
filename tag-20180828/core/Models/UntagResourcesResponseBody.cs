// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class UntagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the resources from which tags fail to be removed.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If tags are removed from all resources, the value of FailedResources is empty.</para>
        /// </description></item>
        /// <item><description><para>If tags fail to be removed from some or all resources, the value of FailedResources contains the detailed information about the resources.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("FailedResources")]
        [Validation(Required=false)]
        public UntagResourcesResponseBodyFailedResources FailedResources { get; set; }
        public class UntagResourcesResponseBodyFailedResources : TeaModel {
            [NameInMap("FailedResource")]
            [Validation(Required=false)]
            public List<UntagResourcesResponseBodyFailedResourcesFailedResource> FailedResource { get; set; }
            public class UntagResourcesResponseBodyFailedResourcesFailedResource : TeaModel {
                /// <summary>
                /// <para>The ARN of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>arn:acs:ecs:cn-hangzhou:123456789****:instance/i-xxxxxxxxxx1</para>
                /// </summary>
                [NameInMap("ResourceARN")]
                [Validation(Required=false)]
                public string ResourceARN { get; set; }

                /// <summary>
                /// <para>The information about the error.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public UntagResourcesResponseBodyFailedResourcesFailedResourceResult Result { get; set; }
                public class UntagResourcesResponseBodyFailedResourcesFailedResourceResult : TeaModel {
                    /// <summary>
                    /// <para>The error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InvalidResourceId.NotFound</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The specified ResourceIds are not found in our records.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43D12436-B10F-4469-8136-FD1C5D2B2083</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
