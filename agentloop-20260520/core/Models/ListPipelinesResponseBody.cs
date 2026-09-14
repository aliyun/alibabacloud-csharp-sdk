// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListPipelinesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("pipelines")]
        [Validation(Required=false)]
        public List<ListPipelinesResponseBodyPipelines> Pipelines { get; set; }
        public class ListPipelinesResponseBodyPipelines : TeaModel {
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
            public ListPipelinesResponseBodyPipelinesExecutePolicy ExecutePolicy { get; set; }
            public class ListPipelinesResponseBodyPipelinesExecutePolicy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>RunOnce</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("runOnce")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesExecutePolicyRunOnce RunOnce { get; set; }
                public class ListPipelinesResponseBodyPipelinesExecutePolicyRunOnce : TeaModel {
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
                public ListPipelinesResponseBodyPipelinesExecutePolicyScheduled Scheduled { get; set; }
                public class ListPipelinesResponseBodyPipelinesExecutePolicyScheduled : TeaModel {
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
            /// <para>None</para>
            /// </summary>
            [NameInMap("scheduleStatus")]
            [Validation(Required=false)]
            public string ScheduleStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RunOnce</para>
            /// </summary>
            [NameInMap("scheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            [NameInMap("sink")]
            [Validation(Required=false)]
            public ListPipelinesResponseBodyPipelinesSink Sink { get; set; }
            public class ListPipelinesResponseBodyPipelinesSink : TeaModel {
                [NameInMap("condition")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesSinkCondition Condition { get; set; }
                public class ListPipelinesResponseBodyPipelinesSinkCondition : TeaModel {
                    [NameInMap("defaultSink")]
                    [Validation(Required=false)]
                    public ListPipelinesResponseBodyPipelinesSinkConditionDefaultSink DefaultSink { get; set; }
                    public class ListPipelinesResponseBodyPipelinesSinkConditionDefaultSink : TeaModel {
                        [NameInMap("dataset")]
                        [Validation(Required=false)]
                        public ListPipelinesResponseBodyPipelinesSinkConditionDefaultSinkDataset Dataset { get; set; }
                        public class ListPipelinesResponseBodyPipelinesSinkConditionDefaultSinkDataset : TeaModel {
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
                    public List<ListPipelinesResponseBodyPipelinesSinkConditionRoutes> Routes { get; set; }
                    public class ListPipelinesResponseBodyPipelinesSinkConditionRoutes : TeaModel {
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
                        public ListPipelinesResponseBodyPipelinesSinkConditionRoutesSink Sink { get; set; }
                        public class ListPipelinesResponseBodyPipelinesSinkConditionRoutesSink : TeaModel {
                            [NameInMap("dataset")]
                            [Validation(Required=false)]
                            public ListPipelinesResponseBodyPipelinesSinkConditionRoutesSinkDataset Dataset { get; set; }
                            public class ListPipelinesResponseBodyPipelinesSinkConditionRoutesSinkDataset : TeaModel {
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
                public ListPipelinesResponseBodyPipelinesSinkDataset Dataset { get; set; }
                public class ListPipelinesResponseBodyPipelinesSinkDataset : TeaModel {
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
            public ListPipelinesResponseBodyPipelinesSource Source { get; set; }
            public class ListPipelinesResponseBodyPipelinesSource : TeaModel {
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesSourceDataset Dataset { get; set; }
                public class ListPipelinesResponseBodyPipelinesSourceDataset : TeaModel {
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

                [NameInMap("logstore")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesSourceLogstore Logstore { get; set; }
                public class ListPipelinesResponseBodyPipelinesSourceLogstore : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
