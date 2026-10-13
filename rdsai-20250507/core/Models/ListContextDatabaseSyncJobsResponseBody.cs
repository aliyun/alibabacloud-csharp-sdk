// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ListContextDatabaseSyncJobsResponseBody : TeaModel {
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
        public ListContextDatabaseSyncJobsResponseBodyData Data { get; set; }
        public class ListContextDatabaseSyncJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of import tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Id&quot;:&quot;job-as1llqmkol****&quot;, &quot;SourceId&quot;:&quot;src-as1llqmkol****&quot;, &quot;TargetId&quot;:&quot;tg-as1llqmkol****&quot;, &quot;KnowledgeBaseId&quot;:&quot;kb-as1llqmkol****&quot;}]</para>
            /// </summary>
            [NameInMap("Jobs")]
            [Validation(Required=false)]
            public List<ListContextDatabaseSyncJobsResponseBodyDataJobs> Jobs { get; set; }
            public class ListContextDatabaseSyncJobsResponseBodyDataJobs : TeaModel {
                /// <summary>
                /// <para>The reason for automatic pause.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Failed 3 consecutive times</para>
                /// </summary>
                [NameInMap("AutoPauseReason")]
                [Validation(Required=false)]
                public string AutoPauseReason { get; set; }

                /// <summary>
                /// <para>Indicates whether the task is automatically paused.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoPaused")]
                [Validation(Required=false)]
                public bool? AutoPaused { get; set; }

                /// <summary>
                /// <para>The configuration version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ConfigVersion")]
                [Validation(Required=false)]
                public int? ConfigVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the task is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The filter conditions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;include&quot;:[&quot;/研发文档/<b>&quot;],&quot;exclude&quot;:[&quot;/归档文档/</b>&quot;],&quot;excludedDocumentIds&quot;:[],&quot;sizeLimit&quot;:2147483648,&quot;typeAllowlist&quot;:[&quot;docx&quot;,&quot;pdf&quot;]}</para>
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public ListContextDatabaseSyncJobsResponseBodyDataJobsFilters Filters { get; set; }
                public class ListContextDatabaseSyncJobsResponseBodyDataJobsFilters : TeaModel {
                    /// <summary>
                    /// <para>The list of exclusion rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;/Archived Documents&quot;]</para>
                    /// </summary>
                    [NameInMap("Exclude")]
                    [Validation(Required=false)]
                    public List<string> Exclude { get; set; }

                    /// <summary>
                    /// <para>The list of excluded document IDs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;doc-as1llqmkol****&quot;]</para>
                    /// </summary>
                    [NameInMap("ExcludedDocumentIds")]
                    [Validation(Required=false)]
                    public List<string> ExcludedDocumentIds { get; set; }

                    /// <summary>
                    /// <para>The list of inclusion rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;/R&amp;D Documents&quot;]</para>
                    /// </summary>
                    [NameInMap("Include")]
                    [Validation(Required=false)]
                    public List<string> Include { get; set; }

                    /// <summary>
                    /// <para>The size limit in bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2147483648</para>
                    /// </summary>
                    [NameInMap("SizeLimit")]
                    [Validation(Required=false)]
                    public long? SizeLimit { get; set; }

                    /// <summary>
                    /// <para>The list of allowed document types.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;docx&quot;, &quot;pdf&quot;]</para>
                    /// </summary>
                    [NameInMap("TypeAllowlist")]
                    [Validation(Required=false)]
                    public List<string> TypeAllowlist { get; set; }

                }

                /// <summary>
                /// <para>The task ID, which is a system-generated UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>550e8400-e29b-41d4-a716-446655440000</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The ID of the target knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kb-as1llqmkol****</para>
                /// </summary>
                [NameInMap("KnowledgeBaseId")]
                [Validation(Required=false)]
                public string KnowledgeBaseId { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>R&amp;D Team Document Import</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The time of the next run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-23T10:00:00+08:00</para>
                /// </summary>
                [NameInMap("NextRunAt")]
                [Validation(Required=false)]
                public string NextRunAt { get; set; }

                /// <summary>
                /// <para>The scheduling type. Valid values: interval, daily-times.</para>
                /// 
                /// <b>Example:</b>
                /// <para>daily-times</para>
                /// </summary>
                [NameInMap("ScheduleType")]
                [Validation(Required=false)]
                public string ScheduleType { get; set; }

                /// <summary>
                /// <para>The data source ID, which is a system-generated UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>550e8400-e29b-41d4-a716-446655440000</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The target ID, which is a system-generated UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>550e8400-e29b-41d4-a716-446655440000</para>
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

            }

            /// <summary>
            /// <para>The page number. The value starts from 1.</para>
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
        /// <para>The response message.</para>
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
