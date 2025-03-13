// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListTagCloudResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the next query is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAYRHtOLVQzCYj17y+OP7LZRrUJaF4rnBGQkWwMiVHlLZBB1w3Us37CVvhvyM0TXavA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tags added to the cloud resources.</para>
        /// </summary>
        [NameInMap("ResourceTags")]
        [Validation(Required=false)]
        public List<ListTagCloudResourcesResponseBodyResourceTags> ResourceTags { get; set; }
        public class ListTagCloudResourcesResponseBodyResourceTags : TeaModel {
            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aig-0001</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the cloud resource.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AppId: app ID.</description></item>
            /// <item><description>WyId: Alibaba Cloud Workspace user ID.</description></item>
            /// <item><description>AppInstanceGroupId: delivery group ID.</description></item>
            /// <item><description>AliUid: tenant ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AppInstanceGroupId</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTagCloudResourcesResponseBodyResourceTagsTags> Tags { get; set; }
            public class ListTagCloudResourcesResponseBodyResourceTagsTags : TeaModel {
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
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Custom: custom tag.</description></item>
                /// <item><description>System: system tag.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1080p</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
