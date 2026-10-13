// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseSyncJobResponseBody : TeaModel {
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
        public GetContextDatabaseSyncJobResponseBodyData Data { get; set; }
        public class GetContextDatabaseSyncJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason for the automatic pause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3 consecutive execution failures</para>
            /// </summary>
            [NameInMap("AutoPauseReason")]
            [Validation(Required=false)]
            public string AutoPauseReason { get; set; }

            /// <summary>
            /// <para>Indicates whether the job is automatically paused.</para>
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
            /// <para>Indicates whether the job is enabled.</para>
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
            /// <para>{&quot;include&quot;:[&quot;/R&amp;D documents/<b>&quot;],&quot;exclude&quot;:[&quot;/Archived documents/</b>&quot;],&quot;excludedDocumentIds&quot;:[],&quot;sizeLimit&quot;:2147483648,&quot;typeAllowlist&quot;:[&quot;docx&quot;,&quot;pdf&quot;]}</para>
            /// </summary>
            [NameInMap("Filters")]
            [Validation(Required=false)]
            public GetContextDatabaseSyncJobResponseBodyDataFilters Filters { get; set; }
            public class GetContextDatabaseSyncJobResponseBodyDataFilters : TeaModel {
                /// <summary>
                /// <para>The list of exclusion rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;/Archived documents&quot;]</para>
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
                /// <para>[&quot;/R&amp;D documents&quot;]</para>
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
            /// <para>The job ID, which is a system-generated UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The target knowledge base ID.</para>
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
            /// <para>R&amp;D team document import</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The next execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("NextRunAt")]
            [Validation(Required=false)]
            public string NextRunAt { get; set; }

            /// <summary>
            /// <para>The schedule type. Valid values: interval and daily-times.</para>
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
