// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListContextDatabaseSyncRunItemsResponseBody : TeaModel {
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
        public ListContextDatabaseSyncRunItemsResponseBodyData Data { get; set; }
        public class ListContextDatabaseSyncRunItemsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;SourceRecordId&quot;:&quot;sr-as1llqmkol****&quot;, &quot;ArtifactIndex&quot;:0, &quot;ProviderDocumentId&quot;:&quot;doc-1234567890&quot;, &quot;Title&quot;:&quot;Project Plan&quot;}]</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListContextDatabaseSyncRunItemsResponseBodyDataItems> Items { get; set; }
            public class ListContextDatabaseSyncRunItemsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The document shard index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ArtifactIndex")]
                [Validation(Required=false)]
                public int? ArtifactIndex { get; set; }

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
                /// <para>The fine-grained execution status of the current synchronization item, which indicates the processing result of a single document in the current run. Common valid values include uploaded, uploaded-pending-review, upload-accepted, upload-busy, metadata-updating, metadata-updated, migrated, failed, source-failed, replace, warning, deferred, resume, skip, skipped, unsupported, and cancelled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>uploaded</para>
                /// </summary>
                [NameInMap("Decision")]
                [Validation(Required=false)]
                public string Decision { get; set; }

                /// <summary>
                /// <para>The aggregated display status of the current synchronization item. Known mappings include success, failure, processing, and skipped. Unknown Decision values are passed through as-is.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("DecisionCategory")]
                [Validation(Required=false)]
                public string DecisionCategory { get; set; }

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
                /// <para>The processing reason or failure reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The data source authorization has expired</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The size in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1048576</para>
                /// </summary>
                [NameInMap("SizeBytes")]
                [Validation(Required=false)]
                public long? SizeBytes { get; set; }

                /// <summary>
                /// <para>The source path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/Development Documents/Project Plan</para>
                /// </summary>
                [NameInMap("SourcePath")]
                [Validation(Required=false)]
                public string SourcePath { get; set; }

                /// <summary>
                /// <para>The source record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sr-as1llqmkol****</para>
                /// </summary>
                [NameInMap("SourceRecordId")]
                [Validation(Required=false)]
                public string SourceRecordId { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Project Plan</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

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
            /// <para>The page number. Pages start from 1.</para>
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
        /// <para>Indicates whether the request succeeded.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
