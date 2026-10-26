// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListInstanceInspectionRunsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInstanceInspectionRunsResponseBodyData> Data { get; set; }
        public class ListInstanceInspectionRunsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>每次巡检结果由 LLM 总结；包含生成状态及成功后的原文，未生成时为空。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("aiSummary")]
            [Validation(Required=false)]
            public ListInstanceInspectionRunsResponseBodyDataAiSummary AiSummary { get; set; }
            public class ListInstanceInspectionRunsResponseBodyDataAiSummary : TeaModel {
                /// <summary>
                /// <para>Pending 等待、Running 生成中、Succeeded 已生成、Failed 生成失败；不改变巡检结果。</para>
                /// 
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>仅生成成功时返回，最多 200 字，不由前端拼接或截取。</para>
                /// 
                /// <b>Example:</b>
                /// <para>本次巡检未发现风险，实例运行正常。</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-08T00:01:00Z</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

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
            /// <para>{}</para>
            /// </summary>
            [NameInMap("notification")]
            [Validation(Required=false)]
            public ListInstanceInspectionRunsResponseBodyDataNotification Notification { get; set; }
            public class ListInstanceInspectionRunsResponseBodyDataNotification : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>inspection-event-001</para>
                /// </summary>
                [NameInMap("eventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Sent</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-10-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("reportFinishedAt")]
            [Validation(Required=false)]
            public string ReportFinishedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>irpt-one</para>
            /// </summary>
            [NameInMap("reportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("reportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-08T00:00:00Z</para>
            /// </summary>
            [NameInMap("requestedAt")]
            [Validation(Required=false)]
            public string RequestedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>inspection-run-001</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public ListInstanceInspectionRunsResponseBodyDataSummary Summary { get; set; }
            public class ListInstanceInspectionRunsResponseBodyDataSummary : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("infoCount")]
                [Validation(Required=false)]
                public int? InfoCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>risk</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

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
            /// <para>{}</para>
            /// </summary>
            [NameInMap("timeRange")]
            [Validation(Required=false)]
            public ListInstanceInspectionRunsResponseBodyDataTimeRange TimeRange { get; set; }
            public class ListInstanceInspectionRunsResponseBodyDataTimeRange : TeaModel {
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
            /// <para>manual</para>
            /// </summary>
            [NameInMap("triggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
