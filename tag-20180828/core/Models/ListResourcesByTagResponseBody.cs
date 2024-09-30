// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListResourcesByTagResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the <c>next query</c> is required.</para>
        /// <list type="bullet">
        /// <item><description>If the value of this parameter is empty (<c>&quot;NextToken&quot;: &quot;&quot;</c>), all results are returned, and the <c>next query</c> is not required.</description></item>
        /// <item><description>If the value of this parameter is not empty, the next query is required, and the value is the <c>token</c> used to start the next query.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>7D61FF74-61C2-5768-B01F-05FC97F24F35</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListResourcesByTagResponseBodyResources> Resources { get; set; }
        public class ListResourcesByTagResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9pifyuw26esxd05****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The information of the tags.</para>
            /// <para>This parameter is returned only if the <c>IncludeAllTags</c> parameter is set to <c>True</c>.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListResourcesByTagResponseBodyResourcesTags> Tags { get; set; }
            public class ListResourcesByTagResponseBodyResourcesTags : TeaModel {
                /// <summary>
                /// <para>The type of the tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>custom</description></item>
                /// <item><description>system</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
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
