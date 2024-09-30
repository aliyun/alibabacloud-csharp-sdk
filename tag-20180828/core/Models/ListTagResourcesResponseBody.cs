// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the <c>next query</c> is required.</para>
        /// <list type="bullet">
        /// <item><description>If the value of this parameter is empty (<c>&quot;NextToken&quot;: &quot;&quot;</c>), all results are returned, and the <c>next query</c> is not required.</description></item>
        /// <item><description>If the value of this parameter is not empty, the next query is required, and the value is the <c>token</c> used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>014738E0-3C7F-47D8-8FB9-469500C6F387</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the tags that are added to the resources.</para>
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public List<ListTagResourcesResponseBodyTagResources> TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            /// <summary>
            /// <para>The ARN of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arn:acs:ecs:cn-hangzhou:123456789****:instance/i-bp15hr53jws84akg****</para>
            /// </summary>
            [NameInMap("ResourceARN")]
            [Validation(Required=false)]
            public string ResourceARN { get; set; }

            /// <summary>
            /// <para>The information of the tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTagResourcesResponseBodyTagResourcesTags> Tags { get; set; }
            public class ListTagResourcesResponseBodyTagResourcesTags : TeaModel {
                /// <summary>
                /// <para>The type of the tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Custom</description></item>
                /// <item><description>System</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
