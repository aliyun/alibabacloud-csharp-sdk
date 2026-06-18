// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListMemoryNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The array of memory nodes.</para>
        /// </summary>
        [NameInMap("memoryNodes")]
        [Validation(Required=false)]
        public List<ListMemoryNodesResponseBodyMemoryNodes> MemoryNodes { get; set; }
        public class ListMemoryNodesResponseBodyMemoryNodes : TeaModel {
            /// <summary>
            /// <para>The content of the memory node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>用户喜欢吃西红柿炒鸡蛋</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The memory node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68de06c95368463a8be4a84efc872cc5</para>
            /// </summary>
            [NameInMap("memoryNodeId")]
            [Validation(Required=false)]
            public string MemoryNodeId { get; set; }

        }

        /// <summary>
        /// <para>The token used for token-based pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc270401186b433f975d7e1faaa34e0e</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a71f2d9-f1c9-913b-818b-114029103cad</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of memory nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
