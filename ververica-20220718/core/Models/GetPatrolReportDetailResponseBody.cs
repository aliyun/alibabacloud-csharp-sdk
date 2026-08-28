// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetPatrolReportDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The inspection report details.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPatrolReportDetailResponseBodyData Data { get; set; }
        public class GetPatrolReportDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The completion time.</para>
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
            /// <para>1772936711518</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

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
            /// <para>The inspection overview.</para>
            /// </summary>
            [NameInMap("overview")]
            [Validation(Required=false)]
            public GetPatrolReportDetailResponseBodyDataOverview Overview { get; set; }
            public class GetPatrolReportDetailResponseBodyDataOverview : TeaModel {
                /// <summary>
                /// <para>The problem summary.</para>
                /// </summary>
                [NameInMap("problemSummary")]
                [Validation(Required=false)]
                public GetPatrolReportDetailResponseBodyDataOverviewProblemSummary ProblemSummary { get; set; }
                public class GetPatrolReportDetailResponseBodyDataOverviewProblemSummary : TeaModel {
                    /// <summary>
                    /// <para>The number of jobs with delay and backpressure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("delayAndBackpressure")]
                    [Validation(Required=false)]
                    public int? DelayAndBackpressure { get; set; }

                    /// <summary>
                    /// <para>The number of unhealthy jobs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("unhealthy")]
                    [Validation(Required=false)]
                    public int? Unhealthy { get; set; }

                    /// <summary>
                    /// <para>The number of jobs with unhealthy checkpoints.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("unhealthyCheckpoints")]
                    [Validation(Required=false)]
                    public int? UnhealthyCheckpoints { get; set; }

                }

                /// <summary>
                /// <para>The risk summary.</para>
                /// </summary>
                [NameInMap("riskSummary")]
                [Validation(Required=false)]
                public GetPatrolReportDetailResponseBodyDataOverviewRiskSummary RiskSummary { get; set; }
                public class GetPatrolReportDetailResponseBodyDataOverviewRiskSummary : TeaModel {
                    /// <summary>
                    /// <para>The number of critical-level jobs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("critical")]
                    [Validation(Required=false)]
                    public int? Critical { get; set; }

                    /// <summary>
                    /// <para>The number of info-level jobs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("info")]
                    [Validation(Required=false)]
                    public int? Info { get; set; }

                    /// <summary>
                    /// <para>The number of warning-level jobs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("warning")]
                    [Validation(Required=false)]
                    public int? Warning { get; set; }

                }

                /// <summary>
                /// <para>The total number of jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// <para>The report ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inspection-cf8f8843-64e4-4b45-9500-06790107130f</para>
            /// </summary>
            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The inspection scope configuration.</para>
            /// </summary>
            [NameInMap("scopeConfig")]
            [Validation(Required=false)]
            public GetPatrolReportDetailResponseBodyDataScopeConfig ScopeConfig { get; set; }
            public class GetPatrolReportDetailResponseBodyDataScopeConfig : TeaModel {
                /// <summary>
                /// <para>The list of deployment IDs. This parameter is valid only when scopeType is set to DEPLOYMENTS.</para>
                /// </summary>
                [NameInMap("deploymentIds")]
                [Validation(Required=false)]
                public List<string> DeploymentIds { get; set; }

                /// <summary>
                /// <para>The tag mapping. This parameter is valid only when scopeType is set to TAGS. The key is the tag name, and the value is the list of tag values.</para>
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
            /// <para>The trigger type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CRON</para>
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>The list of unhealthy jobs.</para>
            /// </summary>
            [NameInMap("unhealthyJobs")]
            [Validation(Required=false)]
            public List<GetPatrolReportDetailResponseBodyDataUnhealthyJobs> UnhealthyJobs { get; set; }
            public class GetPatrolReportDetailResponseBodyDataUnhealthyJobs : TeaModel {
                /// <summary>
                /// <para>The analysis.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The job has experienced continuous backpressure in the last 30 minutes.</para>
                /// </summary>
                [NameInMap("analysis")]
                [Validation(Required=false)]
                public string Analysis { get; set; }

                /// <summary>
                /// <para>The deployment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18b8ceaa-207d-417b-833e-a5845bb31beb</para>
                /// </summary>
                [NameInMap("deploymentId")]
                [Validation(Required=false)]
                public string DeploymentId { get; set; }

                /// <summary>
                /// <para>The deployment name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rlt_cust_no_apitime</para>
                /// </summary>
                [NameInMap("deploymentName")]
                [Validation(Required=false)]
                public string DeploymentName { get; set; }

                /// <summary>
                /// <para>The problem description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Job backpressure</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db201864-e0df-4f8c-81f0-d62103095ff6</para>
                /// </summary>
                [NameInMap("jobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The recommendation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Check the processing capacity of the downstream operator.</para>
                /// </summary>
                [NameInMap("recommendation")]
                [Validation(Required=false)]
                public string Recommendation { get; set; }

                /// <summary>
                /// <para>The risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>info</para>
                /// </summary>
                [NameInMap("riskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The list of tags diagnosed by AI for the job.</para>
                /// </summary>
                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

            /// <summary>
            /// <para>The update time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758248445816</para>
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
        /// <para>The business status code, which is always 200. Use success to determine whether the business request was successful.</para>
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
