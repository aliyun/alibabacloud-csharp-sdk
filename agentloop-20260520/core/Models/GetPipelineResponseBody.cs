// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetPipelineResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1735660800</para>
        /// </summary>
        [NameInMap("committedWatermark")]
        [Validation(Required=false)]
        public long? CommittedWatermark { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>我的流水线</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyExecutePolicy ExecutePolicy { get; set; }
        public class GetPipelineResponseBodyExecutePolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>scheduled</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyExecutePolicyRunOnce RunOnce { get; set; }
            public class GetPipelineResponseBodyExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1735747200000</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyExecutePolicyScheduled Scheduled { get; set; }
            public class GetPipelineResponseBodyExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1h</para>
                /// </summary>
                [NameInMap("interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1735661100</para>
        /// </summary>
        [NameInMap("nextTriggerTime")]
        [Validation(Required=false)]
        public long? NextTriggerTime { get; set; }

        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineResponseBodyPipeline : TeaModel {
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<GetPipelineResponseBodyPipelineNodes> Nodes { get; set; }
            public class GetPipelineResponseBodyPipelineNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>node-1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>transform</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("scheduleStatus")]
        [Validation(Required=false)]
        public string ScheduleStatus { get; set; }

        [NameInMap("sink")]
        [Validation(Required=false)]
        public GetPipelineResponseBodySink Sink { get; set; }
        public class GetPipelineResponseBodySink : TeaModel {
            [NameInMap("condition")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySinkCondition Condition { get; set; }
            public class GetPipelineResponseBodySinkCondition : TeaModel {
                [NameInMap("defaultSink")]
                [Validation(Required=false)]
                public GetPipelineResponseBodySinkConditionDefaultSink DefaultSink { get; set; }
                public class GetPipelineResponseBodySinkConditionDefaultSink : TeaModel {
                    [NameInMap("dataset")]
                    [Validation(Required=false)]
                    public GetPipelineResponseBodySinkConditionDefaultSinkDataset Dataset { get; set; }
                    public class GetPipelineResponseBodySinkConditionDefaultSinkDataset : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>my-agent-space</para>
                        /// </summary>
                        [NameInMap("agentSpace")]
                        [Validation(Required=false)]
                        public string AgentSpace { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>other-result</para>
                        /// </summary>
                        [NameInMap("dataset")]
                        [Validation(Required=false)]
                        public string Dataset { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dataset</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("matchMode")]
                [Validation(Required=false)]
                public string MatchMode { get; set; }

                [NameInMap("routes")]
                [Validation(Required=false)]
                public List<GetPipelineResponseBodySinkConditionRoutes> Routes { get; set; }
                public class GetPipelineResponseBodySinkConditionRoutes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description>| where intent = \&quot;refund\&quot;</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>refund</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("sink")]
                    [Validation(Required=false)]
                    public GetPipelineResponseBodySinkConditionRoutesSink Sink { get; set; }
                    public class GetPipelineResponseBodySinkConditionRoutesSink : TeaModel {
                        [NameInMap("dataset")]
                        [Validation(Required=false)]
                        public GetPipelineResponseBodySinkConditionRoutesSinkDataset Dataset { get; set; }
                        public class GetPipelineResponseBodySinkConditionRoutesSinkDataset : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>my-agent-space</para>
                            /// </summary>
                            [NameInMap("agentSpace")]
                            [Validation(Required=false)]
                            public string AgentSpace { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>refund-result</para>
                            /// </summary>
                            [NameInMap("dataset")]
                            [Validation(Required=false)]
                            public string Dataset { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>dataset</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

            }

            [NameInMap("dataset")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySinkDataset Dataset { get; set; }
            public class GetPipelineResponseBodySinkDataset : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my-dataset</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public string Dataset { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>condition</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("source")]
        [Validation(Required=false)]
        public GetPipelineResponseBodySource Source { get; set; }
        public class GetPipelineResponseBodySource : TeaModel {
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySourceDataset Dataset { get; set; }
            public class GetPipelineResponseBodySourceDataset : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-dataset</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public string Dataset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>status = \&quot;pending\&quot;</para>
                /// </summary>
                [NameInMap("filter")]
                [Validation(Required=false)]
                public string Filter { get; set; }

            }

            [NameInMap("inputFields")]
            [Validation(Required=false)]
            public List<GetPipelineResponseBodySourceInputFields> InputFields { get; set; }
            public class GetPipelineResponseBodySourceInputFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>question</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("logstore")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySourceLogstore Logstore { get; set; }
            public class GetPipelineResponseBodySourceLogstore : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-sls-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my-sls-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>| SELECT *</description></item>
                /// </list>
                /// </summary>
                [NameInMap("query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dataset</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-02T00:00:00Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-workspace</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
