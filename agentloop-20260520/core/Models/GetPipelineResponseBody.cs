// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The committed watermark. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660800</para>
        /// </summary>
        [NameInMap("committedWatermark")]
        [Validation(Required=false)]
        public long? CommittedWatermark { get; set; }

        /// <summary>
        /// <para>The time when the pipeline was created, in ISO 8601 UTC format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The pipeline description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My pipeline</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The scheduling method.</para>
        /// </summary>
        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyExecutePolicy ExecutePolicy { get; set; }
        public class GetPipelineResponseBodyExecutePolicy : TeaModel {
            /// <summary>
            /// <para>The scheduling mode. For example, scheduled (timed scheduling) or runOnce (one-time execution).</para>
            /// 
            /// <b>Example:</b>
            /// <para>scheduled</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The configuration for one-time execution.</para>
            /// </summary>
            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyExecutePolicyRunOnce RunOnce { get; set; }
            public class GetPipelineResponseBodyExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <para>The start time for data processing. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The end time for data processing. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735747200000</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            /// <summary>
            /// <para>The timed scheduling configuration.</para>
            /// </summary>
            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyExecutePolicyScheduled Scheduled { get; set; }
            public class GetPipelineResponseBodyExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <para>The scheduling start time. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The scheduling interval. For example, 1h.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1h</para>
                /// </summary>
                [NameInMap("interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

            }

        }

        /// <summary>
        /// <para>The next scheduling trigger time. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735661100</para>
        /// </summary>
        [NameInMap("nextTriggerTime")]
        [Validation(Required=false)]
        public long? NextTriggerTime { get; set; }

        /// <summary>
        /// <para>The pipeline configuration for node orchestration.</para>
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<GetPipelineResponseBodyPipelineNodes> Nodes { get; set; }
            public class GetPipelineResponseBodyPipelineNodes : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node parameters in key-value structure, which vary depending on the node type.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>transform</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The pipeline name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scheduling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None: No scheduling.</description></item>
        /// <item><description>Active: Active.</description></item>
        /// <item><description>Paused: Paused.</description></item>
        /// <item><description>Terminated: Terminated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("scheduleStatus")]
        [Validation(Required=false)]
        public string ScheduleStatus { get; set; }

        /// <summary>
        /// <para>The pipeline sink, which is the data write destination.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public GetPipelineResponseBodySink Sink { get; set; }
        public class GetPipelineResponseBodySink : TeaModel {
            /// <summary>
            /// <para>The conditional routing configuration. This parameter is used only when sink.type is set to condition.</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySinkCondition Condition { get; set; }
            public class GetPipelineResponseBodySinkCondition : TeaModel {
                /// <summary>
                /// <para>The default write destination used when no conditional route is matched.</para>
                /// </summary>
                [NameInMap("defaultSink")]
                [Validation(Required=false)]
                public GetPipelineResponseBodySinkConditionDefaultSink DefaultSink { get; set; }
                public class GetPipelineResponseBodySinkConditionDefaultSink : TeaModel {
                    /// <summary>
                    /// <para>The default destination dataset.</para>
                    /// </summary>
                    [NameInMap("dataset")]
                    [Validation(Required=false)]
                    public GetPipelineResponseBodySinkConditionDefaultSinkDataset Dataset { get; set; }
                    public class GetPipelineResponseBodySinkConditionDefaultSinkDataset : TeaModel {
                        /// <summary>
                        /// <para>The name of the AgentSpace to which the default destination dataset belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>my-agent-space</para>
                        /// </summary>
                        [NameInMap("agentSpace")]
                        [Validation(Required=false)]
                        public string AgentSpace { get; set; }

                        /// <summary>
                        /// <para>The name of the default destination dataset.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>other-result</para>
                        /// </summary>
                        [NameInMap("dataset")]
                        [Validation(Required=false)]
                        public string Dataset { get; set; }

                    }

                    /// <summary>
                    /// <para>The default destination type. Currently, only dataset is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dataset</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The route match mode. Currently, only all is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("matchMode")]
                [Validation(Required=false)]
                public string MatchMode { get; set; }

                /// <summary>
                /// <para>The list of conditional routes.</para>
                /// </summary>
                [NameInMap("routes")]
                [Validation(Required=false)]
                public List<GetPipelineResponseBodySinkConditionRoutes> Routes { get; set; }
                public class GetPipelineResponseBodySinkConditionRoutes : TeaModel {
                    /// <summary>
                    /// <para>The route expression in SPL. Only where, project, and extend are supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description>| where intent = \&quot;refund\&quot;</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para>The route ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>refund</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The route write destination.</para>
                    /// </summary>
                    [NameInMap("sink")]
                    [Validation(Required=false)]
                    public GetPipelineResponseBodySinkConditionRoutesSink Sink { get; set; }
                    public class GetPipelineResponseBodySinkConditionRoutesSink : TeaModel {
                        /// <summary>
                        /// <para>The route destination dataset.</para>
                        /// </summary>
                        [NameInMap("dataset")]
                        [Validation(Required=false)]
                        public GetPipelineResponseBodySinkConditionRoutesSinkDataset Dataset { get; set; }
                        public class GetPipelineResponseBodySinkConditionRoutesSinkDataset : TeaModel {
                            /// <summary>
                            /// <para>The name of the AgentSpace to which the destination dataset belongs.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>my-agent-space</para>
                            /// </summary>
                            [NameInMap("agentSpace")]
                            [Validation(Required=false)]
                            public string AgentSpace { get; set; }

                            /// <summary>
                            /// <para>The name of the destination dataset.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>refund-result</para>
                            /// </summary>
                            [NameInMap("dataset")]
                            [Validation(Required=false)]
                            public string Dataset { get; set; }

                        }

                        /// <summary>
                        /// <para>The route destination type. Currently, only dataset is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dataset</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The target dataset configuration for the dataset sink. This parameter is used only when sink.type is set to dataset.</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySinkDataset Dataset { get; set; }
            public class GetPipelineResponseBodySinkDataset : TeaModel {
                /// <summary>
                /// <para>The name of the AgentSpace to which the target dataset belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <para>The target dataset name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-dataset</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public string Dataset { get; set; }

            }

            /// <summary>
            /// <para>The sink type. Valid values: dataset and condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>condition</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The pipeline data source.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public GetPipelineResponseBodySource Source { get; set; }
        public class GetPipelineResponseBodySource : TeaModel {
            /// <summary>
            /// <para>The dataset datasource config under the current AgentSpace.</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySourceDataset Dataset { get; set; }
            public class GetPipelineResponseBodySourceDataset : TeaModel {
                /// <summary>
                /// <para>The source dataset name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-dataset</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public string Dataset { get; set; }

                /// <summary>
                /// <para>The dataset data filter condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status = \&quot;pending\&quot;</para>
                /// </summary>
                [NameInMap("filter")]
                [Validation(Required=false)]
                public string Filter { get; set; }

            }

            /// <summary>
            /// <para>The input fields and field types, applicable to all data source types.</para>
            /// </summary>
            [NameInMap("inputFields")]
            [Validation(Required=false)]
            public List<GetPipelineResponseBodySourceInputFields> InputFields { get; set; }
            public class GetPipelineResponseBodySourceInputFields : TeaModel {
                /// <summary>
                /// <para>The field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>question</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The field type. Valid values: text, long, double, and json.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The SLS Logstore datasource config.</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySourceLogstore Logstore { get; set; }
            public class GetPipelineResponseBodySourceLogstore : TeaModel {
                /// <summary>
                /// <para>The SLS Logstore name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-sls-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The SLS project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-sls-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The data filtered query statement in SLS query/analysis syntax.</para>
                /// 
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
            /// <para>The data source type. Valid values: logstore and dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataset</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The time when the pipeline was last updated, in ISO 8601 UTC format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-02T00:00:00Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The workspace associated with the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-workspace</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
