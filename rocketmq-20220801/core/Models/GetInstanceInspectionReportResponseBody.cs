// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetInstanceInspectionReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>complete</para>
        /// </summary>
        [NameInMap("completion")]
        [Validation(Required=false)]
        public string Completion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("coverage")]
        [Validation(Required=false)]
        public List<GetInstanceInspectionReportResponseBodyCoverage> Coverage { get; set; }
        public class GetInstanceInspectionReportResponseBodyCoverage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("diagnosisStatus")]
            [Validation(Required=false)]
            public string DiagnosisStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>消费健康</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-01T01:00:00Z</para>
            /// </summary>
            [NameInMap("observedAt")]
            [Validation(Required=false)]
            public string ObservedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>risk</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rmq.consumer-health</para>
            /// </summary>
            [NameInMap("templateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;startTime&quot;:&quot;2026-09-01T00:00:00Z&quot;,&quot;endTime&quot;:&quot;2026-09-01T01:00:00Z&quot;}</para>
            /// </summary>
            [NameInMap("timeRange")]
            [Validation(Required=false)]
            public GetInstanceInspectionReportResponseBodyCoverageTimeRange TimeRange { get; set; }
            public class GetInstanceInspectionReportResponseBodyCoverageTimeRange : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-09-08T00:00:00Z</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-09-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("findings")]
        [Validation(Required=false)]
        public List<GetInstanceInspectionReportResponseBodyFindings> Findings { get; set; }
        public class GetInstanceInspectionReportResponseBodyFindings : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("alternatives")]
            [Validation(Required=false)]
            public List<string> Alternatives { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>消费环节</para>
            /// </summary>
            [NameInMap("boundary")]
            [Validation(Required=false)]
            public string Boundary { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>消费者处理速度可能不足</para>
            /// </summary>
            [NameInMap("cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>likely</para>
            /// </summary>
            [NameInMap("confidence")]
            [Validation(Required=false)]
            public string Confidence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;消费延迟 60 秒&quot;]</para>
            /// </summary>
            [NameInMap("evidence")]
            [Validation(Required=false)]
            public List<string> Evidence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>消息处理延迟升高</para>
            /// </summary>
            [NameInMap("impact")]
            [Validation(Required=false)]
            public string Impact { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>消费组监控</para>
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("missingEvidence")]
            [Validation(Required=false)]
            public List<string> MissingEvidence { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("observations")]
            [Validation(Required=false)]
            public List<string> Observations { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-01T01:00:00Z</para>
            /// </summary>
            [NameInMap("observedAt")]
            [Validation(Required=false)]
            public string ObservedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;检查消费者处理耗时&quot;]</para>
            /// </summary>
            [NameInMap("recommendations")]
            [Validation(Required=false)]
            public List<string> Recommendations { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public GetInstanceInspectionReportResponseBodyFindingsResource Resource { get; set; }
            public class GetInstanceInspectionReportResponseBodyFindingsResource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>GID-orders</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>订单消费组</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>group</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>消费延迟</para>
            /// </summary>
            [NameInMap("riskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>script</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rmq.consumer-health</para>
            /// </summary>
            [NameInMap("templateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("timeRange")]
            [Validation(Required=false)]
            public GetInstanceInspectionReportResponseBodyFindingsTimeRange TimeRange { get; set; }
            public class GetInstanceInspectionReportResponseBodyFindingsTimeRange : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-09-08T00:00:00Z</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-09-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("verification")]
            [Validation(Required=false)]
            public List<string> Verification { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-09-18T08:02:00Z</para>
        /// </summary>
        [NameInMap("finishedAt")]
        [Validation(Required=false)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <h1>实例巡检诊断报告</h1>
        /// </summary>
        [NameInMap("html")]
        [Validation(Required=false)]
        public string Html { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>irun-example</para>
        /// </summary>
        [NameInMap("inspectionRunId")]
        [Validation(Required=false)]
        public string InspectionRunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rmq-cn-example</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>订单实例</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <h1>实例巡检诊断报告</h1>
        /// </summary>
        [NameInMap("markdown")]
        [Validation(Required=false)]
        public string Markdown { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>消费延迟与容量限制可能相关</para>
        /// </summary>
        [NameInMap("overview")]
        [Validation(Required=false)]
        public string Overview { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>irpt-example</para>
        /// </summary>
        [NameInMap("reportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("reportSummary")]
        [Validation(Required=false)]
        public GetInstanceInspectionReportResponseBodyReportSummary ReportSummary { get; set; }
        public class GetInstanceInspectionReportResponseBodyReportSummary : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("infoCount")]
            [Validation(Required=false)]
            public int? InfoCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("riskCount")]
            [Validation(Required=false)]
            public int? RiskCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>inspection-v2.1</para>
        /// </summary>
        [NameInMap("templateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("timeRange")]
        [Validation(Required=false)]
        public GetInstanceInspectionReportResponseBodyTimeRange TimeRange { get; set; }
        public class GetInstanceInspectionReportResponseBodyTimeRange : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-08T00:00:00Z</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

    }

}
