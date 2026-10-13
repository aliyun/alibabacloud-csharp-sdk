// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListContextDatabaseSyncJobDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListContextDatabaseSyncJobDocumentsResponseBodyData Data { get; set; }
        public class ListContextDatabaseSyncJobDocumentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of documents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;ProviderDocumentId&quot;:&quot;doc-1234567890&quot;, &quot;Status&quot;:&quot;completed&quot;, &quot;ContentHash&quot;:&quot;sha256:4b3b7b2e5f6a1c9d8e0f1234567890abcdef1234567890abcdef1234567890ab&quot;, &quot;SourceUpdateTime&quot;:&quot;2026-09-23T10:00:00+08:00&quot;}]</para>
            /// </summary>
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<ListContextDatabaseSyncJobDocumentsResponseBodyDataDocuments> Documents { get; set; }
            public class ListContextDatabaseSyncJobDocumentsResponseBodyDataDocuments : TeaModel {
                /// <summary>
                /// <para>The content hash.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sha256:4b3b7b2e5f6a1c9d8e0f1234567890abcdef1234567890abcdef1234567890ab</para>
                /// </summary>
                [NameInMap("ContentHash")]
                [Validation(Required=false)]
                public string ContentHash { get; set; }

                /// <summary>
                /// <para>The ContextDB document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cd-as1llqmkol****</para>
                /// </summary>
                [NameInMap("CtxdbDocumentId")]
                [Validation(Required=false)]
                public string CtxdbDocumentId { get; set; }

                /// <summary>
                /// <para>The source document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doc-1234567890</para>
                /// </summary>
                [NameInMap("ProviderDocumentId")]
                [Validation(Required=false)]
                public string ProviderDocumentId { get; set; }

                /// <summary>
                /// <para>The retirement time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-23T10:00:00+08:00</para>
                /// </summary>
                [NameInMap("RetiredAt")]
                [Validation(Required=false)]
                public string RetiredAt { get; set; }

                /// <summary>
                /// <para>The source update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-23T10:00:00+08:00</para>
                /// </summary>
                [NameInMap("SourceUpdateTime")]
                [Validation(Required=false)]
                public string SourceUpdateTime { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>completed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-23T10:00:00+08:00</para>
                /// </summary>
                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

            /// <summary>
            /// <para>The page number, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
