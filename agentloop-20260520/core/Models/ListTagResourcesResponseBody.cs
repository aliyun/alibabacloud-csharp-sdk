// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token. If no next page exists, this value is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJsYXN0SWQiOjEyMH0=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB27D183-8F6C-5C5A-A6A3-E0508AF54F78</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tag information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{
        ///     &quot;resourceType&quot;: &quot;agentspace&quot;,
        ///     &quot;resourceId&quot;: &quot;space-a&quot;,
        ///     &quot;tagKey&quot;: &quot;key1&quot;,
        ///     &quot;tagValue&quot;: &quot;value1&quot;
        /// }]</para>
        /// </summary>
        [NameInMap("tagResources")]
        [Validation(Required=false)]
        public List<ListTagResourcesResponseBodyTagResources> TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>space-a</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type. Set the value to agentspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentspace</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("tagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value. If this parameter is omitted, the system matches resources that have the specified key. An empty string exactly matches an empty value. Null values are not allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("tagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
