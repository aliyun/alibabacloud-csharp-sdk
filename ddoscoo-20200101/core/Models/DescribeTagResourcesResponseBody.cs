// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The query token that is returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RGuYpqDdKhzXb8C3.D1BwQgc1tMBsoxdGiEKHHUUCf****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36E698F7-48A4-48D0-9554-0BB4BAAB99B3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tags that are added to the Anti-DDoS Proxy (Chinese Mainland) instance.</para>
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public DescribeTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class DescribeTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<DescribeTagResourcesResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class DescribeTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// <para>The ID of the Anti-DDoS Proxy (Chinese Mainland) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddoscoo-cn-zz121ogz****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type. The value is fixed as <b>INSTANCE</b>, which indicates an Anti-DDoS Proxy instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INSTANCE</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The key of the tag that is added to the Anti-DDoS Proxy (Chinese Mainland) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testvalue</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag that is added to the Anti-DDoS Proxy (Chinese Mainland) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testkey</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
