// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListMemoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of long-term memory entities per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The list of long-term memory entities.</para>
        /// </summary>
        [NameInMap("memories")]
        [Validation(Required=false)]
        public List<ListMemoriesResponseBodyMemories> Memories { get; set; }
        public class ListMemoriesResponseBodyMemories : TeaModel {
            /// <summary>
            /// <para>The description of the long-term memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Long-term memory of user A for my large model application $APP_ID</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The long-term memory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3fc531f4519444beaafffa4538f6xxxx</para>
            /// </summary>
            [NameInMap("memoryId")]
            [Validation(Required=false)]
            public string MemoryId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc270401186b433f975d7e1faaa3xxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a71f2d9-f1c9-913b-818b-11402910xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>105</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The workspace ID to which the long-term memory list belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-3z7uw7fwz0vexxxx</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
