// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class TagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the resources to which tags fail to be added.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If tags are added to all resources, the value of <c>FailedResources</c> is empty.</para>
        /// </description></item>
        /// <item><description><para>If tags fail to be added to some or all resources, the value of <c>FailedResources</c> contains the detailed information about the resources.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("FailedResources")]
        [Validation(Required=false)]
        public TagResourcesResponseBodyFailedResources FailedResources { get; set; }
        public class TagResourcesResponseBodyFailedResources : TeaModel {
            [NameInMap("FailedResource")]
            [Validation(Required=false)]
            public List<TagResourcesResponseBodyFailedResourcesFailedResource> FailedResource { get; set; }
            public class TagResourcesResponseBodyFailedResourcesFailedResource : TeaModel {
                /// <summary>
                /// <para>The ARN of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>arn:acs:vpc:cn-hangzhou:123456789****:vpc/vpc-bp19dd90tkt6tz7wu****</para>
                /// </summary>
                [NameInMap("ResourceARN")]
                [Validation(Required=false)]
                public string ResourceARN { get; set; }

                /// <summary>
                /// <para>The information about the error.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public TagResourcesResponseBodyFailedResourcesFailedResourceResult Result { get; set; }
                public class TagResourcesResponseBodyFailedResourcesFailedResourceResult : TeaModel {
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
        /// <para>72086426-9F8C-4A60-852B-864048FD1199</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
