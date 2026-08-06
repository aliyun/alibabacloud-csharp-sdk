// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class SearchMemoriesResponseBody : TeaModel {
        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of results.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<SearchMemoriesResponseBodyResults> Results { get; set; }
        public class SearchMemoriesResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-26T08:25:44Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The memory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>423</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The memory content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The agent to which the memory belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent1</para>
            /// </summary>
            [NameInMap("MemoryAgentId")]
            [Validation(Required=false)]
            public string MemoryAgentId { get; set; }

            /// <summary>
            /// <para>The user to whom the memory belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("MemoryUserId")]
            [Validation(Required=false)]
            public string MemoryUserId { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;tags\&quot;:\&quot;Issue_date_2023-11-30,VD_现行有效\&quot;}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            /// <summary>
            /// <para>The score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-16T02:27:33Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public string TotalPages { get; set; }

    }

}
