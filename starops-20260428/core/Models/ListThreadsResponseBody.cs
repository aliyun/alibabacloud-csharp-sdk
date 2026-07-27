// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class ListThreadsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return. The maximum value is 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>A token to retrieve the next page of results. If this parameter is absent, no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD8BA7D6-995D-578D-9941-xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The thread ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thread-123123</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <para>A list of threads.</para>
        /// </summary>
        [NameInMap("threads")]
        [Validation(Required=false)]
        public List<ListThreadsResponseBodyThreads> Threads { get; set; }
        public class ListThreadsResponseBodyThreads : TeaModel {
            /// <summary>
            /// <para>A map of key-value pairs that you can attach to the thread.</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> Attributes { get; set; }

            /// <summary>
            /// <para>The creation time of the thread, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-19T15:19:55.040403272+08:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The digital employee name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("digitalEmployeeName")]
            [Validation(Required=false)]
            public string DigitalEmployeeName { get; set; }

            /// <summary>
            /// <para>The thread status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The thread ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>thread-123123</para>
            /// </summary>
            [NameInMap("threadId")]
            [Validation(Required=false)]
            public string ThreadId { get; set; }

            /// <summary>
            /// <para>The thread title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The last update time of the thread, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-19T15:19:55.040403272+08:00</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The thread variables.</para>
            /// </summary>
            [NameInMap("variables")]
            [Validation(Required=false)]
            public ListThreadsResponseBodyThreadsVariables Variables { get; set; }
            public class ListThreadsResponseBodyThreadsVariables : TeaModel {
                /// <summary>
                /// <para>The project in SLS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <para>The thread version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123123</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The total number of threads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
