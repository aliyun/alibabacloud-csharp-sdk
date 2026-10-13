// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListContextDatabaseSyncRunsResponseBody : TeaModel {
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
        public ListContextDatabaseSyncRunsResponseBodyData Data { get; set; }
        public class ListContextDatabaseSyncRunsResponseBodyData : TeaModel {
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
            /// <para>The list of runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;RunId&quot;:&quot;run-as1llqmkol****&quot;, &quot;JobId&quot;:&quot;job-as1llqmkol****&quot;, &quot;JobName&quot;:&quot;R&amp;D team document import&quot;, &quot;KnowledgeBaseId&quot;:&quot;kb-as1llqmkol****&quot;}]</para>
            /// </summary>
            [NameInMap("Runs")]
            [Validation(Required=false)]
            public List<ListContextDatabaseSyncRunsResponseBodyDataRuns> Runs { get; set; }
            public class ListContextDatabaseSyncRunsResponseBodyDataRuns : TeaModel {
                /// <summary>
                /// <para>The number of attempts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Attempt")]
                [Validation(Required=false)]
                public int? Attempt { get; set; }

                /// <summary>
                /// <para>The time when the cancellation was requested.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-23T10:00:00+08:00</para>
                /// </summary>
                [NameInMap("CancelRequestedAt")]
                [Validation(Required=false)]
                public string CancelRequestedAt { get; set; }

                /// <summary>
                /// <para>Specifies whether the run is a dry run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-23T10:00:00+08:00</para>
                /// </summary>
                [NameInMap("FinishedAt")]
                [Validation(Required=false)]
                public string FinishedAt { get; set; }

                /// <summary>
                /// <para>The configuration version number of the import job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("JobConfigVersion")]
                [Validation(Required=false)]
                public int? JobConfigVersion { get; set; }

                /// <summary>
                /// <para>The job ID, which is a system-generated UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>550e8400-e29b-41d4-a716-446655440000</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The name of the import job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>R&amp;D team document import</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The ID of the destination knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kb-as1llqmkol****</para>
                /// </summary>
                [NameInMap("KnowledgeBaseId")]
                [Validation(Required=false)]
                public string KnowledgeBaseId { get; set; }

                /// <summary>
                /// <para>The latest error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data source authorization has expired</para>
                /// </summary>
                [NameInMap("LastError")]
                [Validation(Required=false)]
                public string LastError { get; set; }

                /// <summary>
                /// <para>The plugin reference.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:dingtalk@1.0.0">dingtalk@1.0.0</a></para>
                /// </summary>
                [NameInMap("PluginRef")]
                [Validation(Required=false)]
                public string PluginRef { get; set; }

                /// <summary>
                /// <para>The request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1B2C3D4E-5F6A-4B7C-8D9E-0F1A2B3C4D5E</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The run ID, which is a system-generated UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>550e8400-e29b-41d4-a716-446655440000</para>
                /// </summary>
                [NameInMap("RunId")]
                [Validation(Required=false)]
                public string RunId { get; set; }

                /// <summary>
                /// <para>The scheduled run time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-23T10:00:00+08:00</para>
                /// </summary>
                [NameInMap("ScheduledAt")]
                [Validation(Required=false)]
                public string ScheduledAt { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-23T10:00:00+08:00</para>
                /// </summary>
                [NameInMap("StartedAt")]
                [Validation(Required=false)]
                public string StartedAt { get; set; }

                /// <summary>
                /// <para>The run status. Valid values: queued, running, cancelling, succeeded, partial, failed, cancelled, skipped, and dead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The summary of the run results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;uploaded&quot;:12,&quot;unchanged&quot;:3,&quot;skipped&quot;:1,&quot;deferred&quot;:0,&quot;failed&quot;:0,&quot;processing&quot;:0}</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public ListContextDatabaseSyncRunsResponseBodyDataRunsSummary Summary { get; set; }
                public class ListContextDatabaseSyncRunsResponseBodyDataRunsSummary : TeaModel {
                    /// <summary>
                    /// <para>The number of canceled items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Cancelled")]
                    [Validation(Required=false)]
                    public int? Cancelled { get; set; }

                    /// <summary>
                    /// <para>The number of deferred items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Deferred")]
                    [Validation(Required=false)]
                    public int? Deferred { get; set; }

                    /// <summary>
                    /// <para>The number of failed items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Failed")]
                    [Validation(Required=false)]
                    public int? Failed { get; set; }

                    /// <summary>
                    /// <para>The number of items with updated metadata.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("MetadataUpdated")]
                    [Validation(Required=false)]
                    public int? MetadataUpdated { get; set; }

                    /// <summary>
                    /// <para>The number of items being processed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Processing")]
                    [Validation(Required=false)]
                    public int? Processing { get; set; }

                    /// <summary>
                    /// <para>The number of skipped items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Skipped")]
                    [Validation(Required=false)]
                    public int? Skipped { get; set; }

                    /// <summary>
                    /// <para>The number of unchanged items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Unchanged")]
                    [Validation(Required=false)]
                    public int? Unchanged { get; set; }

                    /// <summary>
                    /// <para>The number of accepted uploads.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("UploadAccepted")]
                    [Validation(Required=false)]
                    public int? UploadAccepted { get; set; }

                    /// <summary>
                    /// <para>The number of uploaded items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Uploaded")]
                    [Validation(Required=false)]
                    public int? Uploaded { get; set; }

                }

                /// <summary>
                /// <para>The trigger method of the run. Valid values: manual, schedule, and retry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>manual</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public string Trigger { get; set; }

            }

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
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
