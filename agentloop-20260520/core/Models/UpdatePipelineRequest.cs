// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The description of the pipeline, which helps users understand its purpose.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My pipeline</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The scheduling policy. If provided, the entire scheduling policy is overwritten.</para>
        /// </summary>
        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public UpdatePipelineRequestExecutePolicy ExecutePolicy { get; set; }
        public class UpdatePipelineRequestExecutePolicy : TeaModel {
            /// <summary>
            /// <para>The scheduling mode. For example, Scheduled (timed scheduling) or RunOnce (one-time execution).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The configuration for one-time execution.</para>
            /// </summary>
            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public UpdatePipelineRequestExecutePolicyRunOnce RunOnce { get; set; }
            public class UpdatePipelineRequestExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <para>The start time for data processing, in UNIX millisecond timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The end time for data processing, in UNIX millisecond timestamp.</para>
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
            public UpdatePipelineRequestExecutePolicyScheduled Scheduled { get; set; }
            public class UpdatePipelineRequestExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <para>The scheduling start time, in UNIX millisecond timestamp.</para>
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
        /// <para>The pipeline configuration (node orchestration). If specified, the existing pipeline configuration is entirely overwritten.</para>
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public UpdatePipelineRequestPipeline Pipeline { get; set; }
        public class UpdatePipelineRequestPipeline : TeaModel {
            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<UpdatePipelineRequestPipelineNodes> Nodes { get; set; }
            public class UpdatePipelineRequestPipelineNodes : TeaModel {
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
                /// <para>The node parameters in key-value format. The parameters vary depending on the node type.</para>
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
        /// <para>The pipeline sink (data write destination). If provided, the entire sink configuration is overwritten.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public UpdatePipelineRequestSink Sink { get; set; }
        public class UpdatePipelineRequestSink : TeaModel {
            /// <summary>
            /// <para>The conditional routing configuration. This parameter takes effect only when sink.type is set to condition.</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public UpdatePipelineRequestSinkCondition Condition { get; set; }
            public class UpdatePipelineRequestSinkCondition : TeaModel {
                /// <summary>
                /// <para>The default write destination used when no conditional route is matched.</para>
                /// </summary>
                [NameInMap("defaultSink")]
                [Validation(Required=false)]
                public UpdatePipelineRequestSinkConditionDefaultSink DefaultSink { get; set; }
                public class UpdatePipelineRequestSinkConditionDefaultSink : TeaModel {
                    /// <summary>
                    /// <para>The default destination dataset.</para>
                    /// </summary>
                    [NameInMap("dataset")]
                    [Validation(Required=false)]
                    public UpdatePipelineRequestSinkConditionDefaultSinkDataset Dataset { get; set; }
                    public class UpdatePipelineRequestSinkConditionDefaultSinkDataset : TeaModel {
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
                /// <para>The route matching mode. Currently, only all is supported.</para>
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
                public List<UpdatePipelineRequestSinkConditionRoutes> Routes { get; set; }
                public class UpdatePipelineRequestSinkConditionRoutes : TeaModel {
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
                    /// <para>The write destination for the route.</para>
                    /// </summary>
                    [NameInMap("sink")]
                    [Validation(Required=false)]
                    public UpdatePipelineRequestSinkConditionRoutesSink Sink { get; set; }
                    public class UpdatePipelineRequestSinkConditionRoutesSink : TeaModel {
                        /// <summary>
                        /// <para>The destination dataset for the route.</para>
                        /// </summary>
                        [NameInMap("dataset")]
                        [Validation(Required=false)]
                        public UpdatePipelineRequestSinkConditionRoutesSinkDataset Dataset { get; set; }
                        public class UpdatePipelineRequestSinkConditionRoutesSinkDataset : TeaModel {
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
            /// <para>The destination dataset configuration for the dataset sink. This parameter takes effect only when sink.type is set to dataset.</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public UpdatePipelineRequestSinkDataset Dataset { get; set; }
            public class UpdatePipelineRequestSinkDataset : TeaModel {
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
        /// <para>The pipeline data source. If specified, the existing source configuration is entirely overwritten.</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public UpdatePipelineRequestSource Source { get; set; }
        public class UpdatePipelineRequestSource : TeaModel {
            /// <summary>
            /// <para>The dataset datasource config within the current AgentSpace.</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public UpdatePipelineRequestSourceDataset Dataset { get; set; }
            public class UpdatePipelineRequestSourceDataset : TeaModel {
                /// <summary>
                /// <para>The name of the source dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-dataset</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public string Dataset { get; set; }

                /// <summary>
                /// <para>The filter condition for the dataset data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status = \&quot;pending\&quot;</para>
                /// </summary>
                [NameInMap("filter")]
                [Validation(Required=false)]
                public string Filter { get; set; }

            }

            /// <summary>
            /// <para>The input fields and their types. This parameter applies to all data source types.</para>
            /// </summary>
            [NameInMap("inputFields")]
            [Validation(Required=false)]
            public List<UpdatePipelineRequestSourceInputFields> InputFields { get; set; }
            public class UpdatePipelineRequestSourceInputFields : TeaModel {
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
            public UpdatePipelineRequestSourceLogstore Logstore { get; set; }
            public class UpdatePipelineRequestSourceLogstore : TeaModel {
                /// <summary>
                /// <para>The name of the SLS Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-sls-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the SLS project.</para>
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
        /// <para>The idempotency token. A unique string generated by the client to ensure the idempotency of the update operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
