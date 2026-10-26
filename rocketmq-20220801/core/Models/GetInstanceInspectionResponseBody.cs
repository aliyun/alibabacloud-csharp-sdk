// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetInstanceInspectionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public GetInstanceInspectionResponseBodyConfig Config { get; set; }
        public class GetInstanceInspectionResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;templateCode&quot;:&quot;rmq.consumer-health&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;1h&quot;}},{&quot;templateCode&quot;:&quot;rmq.traffic-capacity&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;6h&quot;}}]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetInstanceInspectionResponseBodyConfigItems> Items { get; set; }
            public class GetInstanceInspectionResponseBodyConfigItems : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;lookback&quot;:&quot;1h&quot;,&quot;consumerDelayThresholdSeconds&quot;:600}</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public object Parameters { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq.consumer-health</para>
                /// </summary>
                [NameInMap("templateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;mode&quot;:&quot;All&quot;}</para>
            /// </summary>
            [NameInMap("resourceScope")]
            [Validation(Required=false)]
            public GetInstanceInspectionResponseBodyConfigResourceScope ResourceScope { get; set; }
            public class GetInstanceInspectionResponseBodyConfigResourceScope : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;orders-g1&quot;]</para>
                /// </summary>
                [NameInMap("consumerGroups")]
                [Validation(Required=false)]
                public List<string> ConsumerGroups { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;orders&quot;]</para>
                /// </summary>
                [NameInMap("topics")]
                [Validation(Required=false)]
                public List<string> Topics { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;enabled&quot;:true,&quot;cron&quot;:&quot;0 3 * * *&quot;}</para>
            /// </summary>
            [NameInMap("schedule")]
            [Validation(Required=false)]
            public GetInstanceInspectionResponseBodyConfigSchedule Schedule { get; set; }
            public class GetInstanceInspectionResponseBodyConfigSchedule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0 3 * * *</para>
                /// </summary>
                [NameInMap("cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("configured")]
        [Validation(Required=false)]
        public bool? Configured { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rmq-cn-example</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<GetInstanceInspectionResponseBodyItems> Items { get; set; }
        public class GetInstanceInspectionResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>检查消费延迟和消费健康度</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>消费健康巡检</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("resourceCount")]
            [Validation(Required=false)]
            public long? ResourceCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;ConsumerGroup&quot;]</para>
            /// </summary>
            [NameInMap("resourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rmq.consumer-health</para>
            /// </summary>
            [NameInMap("templateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("lastRun")]
        [Validation(Required=false)]
        public GetInstanceInspectionResponseBodyLastRun LastRun { get; set; }
        public class GetInstanceInspectionResponseBodyLastRun : TeaModel {
            /// <summary>
            /// <para>每次巡检结果由 LLM 总结；包含生成状态及成功后的原文，未生成时为空。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("aiSummary")]
            [Validation(Required=false)]
            public GetInstanceInspectionResponseBodyLastRunAiSummary AiSummary { get; set; }
            public class GetInstanceInspectionResponseBodyLastRunAiSummary : TeaModel {
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
            /// <para>{}</para>
            /// </summary>
            [NameInMap("configSnapshot")]
            [Validation(Required=false)]
            public GetInstanceInspectionResponseBodyLastRunConfigSnapshot ConfigSnapshot { get; set; }
            public class GetInstanceInspectionResponseBodyLastRunConfigSnapshot : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;templateCode&quot;:&quot;rmq.consumer-health&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;1h&quot;}},{&quot;templateCode&quot;:&quot;rmq.traffic-capacity&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;6h&quot;}}]</para>
                /// </summary>
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<GetInstanceInspectionResponseBodyLastRunConfigSnapshotItems> Items { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunConfigSnapshotItems : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;lookback&quot;:&quot;1h&quot;,&quot;consumerDelayThresholdSeconds&quot;:600}</para>
                    /// </summary>
                    [NameInMap("parameters")]
                    [Validation(Required=false)]
                    public object Parameters { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rmq.consumer-health</para>
                    /// </summary>
                    [NameInMap("templateCode")]
                    [Validation(Required=false)]
                    public string TemplateCode { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;mode&quot;:&quot;All&quot;}</para>
                /// </summary>
                [NameInMap("resourceScope")]
                [Validation(Required=false)]
                public GetInstanceInspectionResponseBodyLastRunConfigSnapshotResourceScope ResourceScope { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunConfigSnapshotResourceScope : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[&quot;orders-g1&quot;]</para>
                    /// </summary>
                    [NameInMap("consumerGroups")]
                    [Validation(Required=false)]
                    public List<string> ConsumerGroups { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>All</para>
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[&quot;orders&quot;]</para>
                    /// </summary>
                    [NameInMap("topics")]
                    [Validation(Required=false)]
                    public List<string> Topics { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;enabled&quot;:true,&quot;cron&quot;:&quot;0 3 * * *&quot;}</para>
                /// </summary>
                [NameInMap("schedule")]
                [Validation(Required=false)]
                public GetInstanceInspectionResponseBodyLastRunConfigSnapshotSchedule Schedule { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunConfigSnapshotSchedule : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0 3 * * *</para>
                    /// </summary>
                    [NameInMap("cron")]
                    [Validation(Required=false)]
                    public string Cron { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

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
            /// <para>[]</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetInstanceInspectionResponseBodyLastRunItems> Items { get; set; }
            public class GetInstanceInspectionResponseBodyLastRunItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>检查消费延迟和消费健康度</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;templateCode&quot;:&quot;rmq.consumer-health&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;1h&quot;}}</para>
                /// </summary>
                [NameInMap("effectiveConfig")]
                [Validation(Required=false)]
                public GetInstanceInspectionResponseBodyLastRunItemsEffectiveConfig EffectiveConfig { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunItemsEffectiveConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;lookback&quot;:&quot;1h&quot;,&quot;consumerDelayThresholdSeconds&quot;:600}</para>
                    /// </summary>
                    [NameInMap("parameters")]
                    [Validation(Required=false)]
                    public object Parameters { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rmq.consumer-health</para>
                    /// </summary>
                    [NameInMap("templateCode")]
                    [Validation(Required=false)]
                    public string TemplateCode { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INSPECTION_EXECUTION_INTERRUPTED</para>
                /// </summary>
                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>消费延迟超过阈值</para>
                /// </summary>
                [NameInMap("headline")]
                [Validation(Required=false)]
                public string Headline { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("metrics")]
                [Validation(Required=false)]
                public List<GetInstanceInspectionResponseBodyLastRunItemsMetrics> Metrics { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunItemsMetrics : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("bad")]
                    [Validation(Required=false)]
                    public bool? Bad { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("good")]
                    [Validation(Required=false)]
                    public bool? Good { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>消费延迟</para>
                    /// </summary>
                    [NameInMap("k")]
                    [Validation(Required=false)]
                    public string K { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>320 秒</para>
                    /// </summary>
                    [NameInMap("v")]
                    [Validation(Required=false)]
                    public string V { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>消费健康巡检</para>
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
                /// <para>3</para>
                /// </summary>
                [NameInMap("resourceCount")]
                [Validation(Required=false)]
                public long? ResourceCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;infoCount&quot;:2,&quot;riskCount&quot;:1}</para>
                /// </summary>
                [NameInMap("resourceSummary")]
                [Validation(Required=false)]
                public GetInstanceInspectionResponseBodyLastRunItemsResourceSummary ResourceSummary { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunItemsResourceSummary : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
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
                /// <para>[&quot;ConsumerGroup&quot;]</para>
                /// </summary>
                [NameInMap("resourceTypes")]
                [Validation(Required=false)]
                public List<string> ResourceTypes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Risk</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>warning</para>
                /// </summary>
                [NameInMap("severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

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
                public GetInstanceInspectionResponseBodyLastRunItemsTimeRange TimeRange { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunItemsTimeRange : TeaModel {
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
            /// <para>{}</para>
            /// </summary>
            [NameInMap("notification")]
            [Validation(Required=false)]
            public GetInstanceInspectionResponseBodyLastRunNotification Notification { get; set; }
            public class GetInstanceInspectionResponseBodyLastRunNotification : TeaModel {
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
            /// <para>{}</para>
            /// </summary>
            [NameInMap("report")]
            [Validation(Required=false)]
            public GetInstanceInspectionResponseBodyLastRunReport Report { get; set; }
            public class GetInstanceInspectionResponseBodyLastRunReport : TeaModel {
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
                public List<GetInstanceInspectionResponseBodyLastRunReportCoverage> Coverage { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunReportCoverage : TeaModel {
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
                    public GetInstanceInspectionResponseBodyLastRunReportCoverageTimeRange TimeRange { get; set; }
                    public class GetInstanceInspectionResponseBodyLastRunReportCoverageTimeRange : TeaModel {
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
                public List<GetInstanceInspectionResponseBodyLastRunReportFindings> Findings { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunReportFindings : TeaModel {
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
                    public GetInstanceInspectionResponseBodyLastRunReportFindingsResource Resource { get; set; }
                    public class GetInstanceInspectionResponseBodyLastRunReportFindingsResource : TeaModel {
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
                    public GetInstanceInspectionResponseBodyLastRunReportFindingsTimeRange TimeRange { get; set; }
                    public class GetInstanceInspectionResponseBodyLastRunReportFindingsTimeRange : TeaModel {
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
                public GetInstanceInspectionResponseBodyLastRunReportReportSummary ReportSummary { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunReportReportSummary : TeaModel {
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
                public GetInstanceInspectionResponseBodyLastRunReportTimeRange TimeRange { get; set; }
                public class GetInstanceInspectionResponseBodyLastRunReportTimeRange : TeaModel {
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
            public GetInstanceInspectionResponseBodyLastRunSummary Summary { get; set; }
            public class GetInstanceInspectionResponseBodyLastRunSummary : TeaModel {
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
            public GetInstanceInspectionResponseBodyLastRunTimeRange TimeRange { get; set; }
            public class GetInstanceInspectionResponseBodyLastRunTimeRange : TeaModel {
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
        /// <para>2026-09-09T03:00:00+08:00</para>
        /// </summary>
        [NameInMap("nextRunAt")]
        [Validation(Required=false)]
        public string NextRunAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("revision")]
        [Validation(Required=false)]
        public long? Revision { get; set; }

    }

}
