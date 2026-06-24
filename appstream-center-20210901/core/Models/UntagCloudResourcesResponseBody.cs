// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UntagCloudResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of failed resources and tag information.</para>
        /// </summary>
        [NameInMap("FailedResources")]
        [Validation(Required=false)]
        public List<UntagCloudResourcesResponseBodyFailedResources> FailedResources { get; set; }
        public class UntagCloudResourcesResponseBodyFailedResources : TeaModel {
            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UNTAG_RESOURCE_FAILED</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to untag resource.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-00000001</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The cloud resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AppInstanceGroupId</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The list of failed tag information.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<UntagCloudResourcesResponseBodyFailedResourcesTags> Tags { get; set; }
            public class UntagCloudResourcesResponseBodyFailedResourcesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Resolution</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E25FC620-6B6F-12D2-A992-AD8727DC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
