// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListPatrolReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated data of inspection reports.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListPatrolReportsResponseBodyData Data { get; set; }
        public class ListPatrolReportsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of inspection reports.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListPatrolReportsResponseBodyDataItems> Items { get; set; }
            public class ListPatrolReportsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The inspection completion time.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>1785981634652</para>
                /// </summary>
                [NameInMap("completedAt")]
                [Validation(Required=false)]
                public string CompletedAt { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>1755158793586</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The number of inspected jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("inspectedJobs")]
                [Validation(Required=false)]
                public int? InspectedJobs { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default-namespace</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The number of jobs with delay and backpressure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("problemDelayBackpressureCount")]
                [Validation(Required=false)]
                public int? ProblemDelayBackpressureCount { get; set; }

                /// <summary>
                /// <para>The number of jobs with unhealthy checkpoints.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("problemUnhealthyCheckpointCount")]
                [Validation(Required=false)]
                public int? ProblemUnhealthyCheckpointCount { get; set; }

                /// <summary>
                /// <para>The number of unhealthy jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("problemUnhealthyCount")]
                [Validation(Required=false)]
                public int? ProblemUnhealthyCount { get; set; }

                /// <summary>
                /// <para>The report ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e7fd2601edc24a37baaba7eec5f64312</para>
                /// </summary>
                [NameInMap("reportId")]
                [Validation(Required=false)]
                public string ReportId { get; set; }

                /// <summary>
                /// <para>The number of jobs with a Critical risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("riskCriticalCount")]
                [Validation(Required=false)]
                public int? RiskCriticalCount { get; set; }

                /// <summary>
                /// <para>The number of jobs with an Info risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("riskInfoCount")]
                [Validation(Required=false)]
                public int? RiskInfoCount { get; set; }

                /// <summary>
                /// <para>The number of jobs with a Warning risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("riskWarningCount")]
                [Validation(Required=false)]
                public int? RiskWarningCount { get; set; }

                /// <summary>
                /// <para>The inspection scope configuration.</para>
                /// </summary>
                [NameInMap("scopeConfig")]
                [Validation(Required=false)]
                public ListPatrolReportsResponseBodyDataItemsScopeConfig ScopeConfig { get; set; }
                public class ListPatrolReportsResponseBodyDataItemsScopeConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of deployment IDs. This field is valid only when scopeType is set to DEPLOYMENTS.</para>
                    /// </summary>
                    [NameInMap("deploymentIds")]
                    [Validation(Required=false)]
                    public List<string> DeploymentIds { get; set; }

                    /// <summary>
                    /// <para>The tag mapping. This field is valid only when scopeType is set to TAGS. The key is the tag name, and the value is a list of tag values.</para>
                    /// </summary>
                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public Dictionary<string, List<string>> Tags { get; set; }

                }

                /// <summary>
                /// <para>The inspection scope type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("scopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// <para>The inspection start time.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>1755158793586</para>
                /// </summary>
                [NameInMap("startedAt")]
                [Validation(Required=false)]
                public string StartedAt { get; set; }

                /// <summary>
                /// <para>The report status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PENDING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The total number of jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("totalJobs")]
                [Validation(Required=false)]
                public int? TotalJobs { get; set; }

                /// <summary>
                /// <para>The trigger type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CRON</para>
                /// </summary>
                [NameInMap("triggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>1784168829417</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a14bd5d90a****</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The business error code. This value is not empty when success is false. This value is empty when success is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The business error message. This value is not empty when success is false. This value is empty when success is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The business status code, which is always 200. Use the success field to determine whether the business request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBC799F0-AS7S-1D30-8A4F-882ED4DD****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the business request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
