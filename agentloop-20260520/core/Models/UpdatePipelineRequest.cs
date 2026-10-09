// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The description of the pipeline, which helps business users understand its purpose.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My pipeline</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The scheduling policy. If this parameter is specified, the existing policy is completely overwritten.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mode&quot;:&quot;RunOnce&quot;,&quot;runOnce&quot;:{&quot;fromTime&quot;:1735660800,&quot;toTime&quot;:1735664400}}</para>
        /// </summary>
        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public UpdatePipelineRequestExecutePolicy ExecutePolicy { get; set; }
        public class UpdatePipelineRequestExecutePolicy : TeaModel {
            /// <summary>
            /// <para>The continuous execution configuration. This parameter is used when the type is trace. The processing frequency is a fixed value managed by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fromTime&quot;:1735660800}</para>
            /// </summary>
            [NameInMap("continuous")]
            [Validation(Required=false)]
            public UpdatePipelineRequestExecutePolicyContinuous Continuous { get; set; }
            public class UpdatePipelineRequestExecutePolicyContinuous : TeaModel {
                /// <summary>
                /// <para>The bootstrap start time, specified as a UNIX timestamp in seconds. The precision is the same as that of runOnce or scheduled.fromTime. Millisecond values greater than or equal to 1e12 are automatically converted to seconds. The cursor starts from this time aligned to the grid and catches up window by window. After catching up, it switches to minute intervals. By default, the cursor starts from the current time and processes only incremental data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

            }

            /// <summary>
            /// <para>The scheduling mode. Valid values: RunOnce (single execution), Scheduled (periodic execution), and Continuous (continuous execution, applicable only to trace data sources). For Continuous mode, the processing frequency is a fixed value managed by the server, and data is automatically processed at minute intervals after the trace is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The single execution configuration. This parameter is required only when the mode is set to RunOnce.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fromTime&quot;:1735660800,&quot;toTime&quot;:1735664400}</para>
            /// </summary>
            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public UpdatePipelineRequestExecutePolicyRunOnce RunOnce { get; set; }
            public class UpdatePipelineRequestExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <para>The start time of the data processing window, specified as a UNIX timestamp in seconds. The value must be less than the value of toTime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The end time of the data processing window, specified as a UNIX timestamp in seconds. The value must be greater than the value of fromTime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735747200</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            /// <summary>
            /// <para>The periodic scheduling configuration. This parameter is required only when the mode is set to Scheduled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;interval&quot;:&quot;1h&quot;,&quot;fromTime&quot;:1735660800}</para>
            /// </summary>
            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public UpdatePipelineRequestExecutePolicyScheduled Scheduled { get; set; }
            public class UpdatePipelineRequestExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <para>The scheduling start time, specified as a UNIX timestamp in seconds. The precision is the same as that of runOnce.fromTime. Millisecond values greater than or equal to 1e12 are automatically converted to seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The scheduling interval. Valid values: 1h, 6h, 12h, and 1d.</para>
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
        /// <para>The pipeline configuration, which defines node orchestration. If this parameter is specified, the existing configuration is completely overwritten.</para>
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public UpdatePipelineRequestPipeline Pipeline { get; set; }
        public class UpdatePipelineRequestPipeline : TeaModel {
            /// <summary>
            /// <para>The list of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;id&quot;:&quot;select-fields&quot;,&quot;type&quot;:&quot;project&quot;,&quot;parameters&quot;:{}}]</para>
            /// </summary>
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<UpdatePipelineRequestPipelineNodes> Nodes { get; set; }
            public class UpdatePipelineRequestPipelineNodes : TeaModel {
                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>node-1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The parameters of the node. The parameters use a key-value structure and vary based on the node type.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The type of the node.</para>
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
        /// <para>The pipeline sink (data write destination). Passing this parameter overwrites the entire configuration.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public UpdatePipelineRequestSink Sink { get; set; }
        public class UpdatePipelineRequestSink : TeaModel {
            /// <summary>
            /// <para>The conditional routing configuration. This parameter is used only when sink.type is set to condition.</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public UpdatePipelineRequestSinkCondition Condition { get; set; }
            public class UpdatePipelineRequestSinkCondition : TeaModel {
                /// <summary>
                /// <para>The default sink used when no conditional route is matched.</para>
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
                    /// <para>The route expression in Search Processing Language (SPL). Only where, project, and extend are supported.</para>
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
                    /// <para>The sink for the route.</para>
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
            /// <para>The destination dataset configuration for the dataset sink. This parameter is used only when sink.type is set to dataset.</para>
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
            /// <para>The destination type. Valid values: dataset and condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>condition</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The pipeline data source. Passing this parameter overwrites the entire configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;logstore&quot;,&quot;logstore&quot;:{&quot;project&quot;:&quot;my-sls-project&quot;,&quot;logstore&quot;:&quot;agent-logs&quot;},&quot;inputFields&quot;:[{&quot;name&quot;:&quot;question&quot;,&quot;type&quot;:&quot;text&quot;}]}</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public UpdatePipelineRequestSource Source { get; set; }
        public class UpdatePipelineRequestSource : TeaModel {
            /// <summary>
            /// <para>The dataset datasource config in the current AgentSpace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;dataset&quot;:&quot;my-dataset&quot;,&quot;filter&quot;:&quot;status = \&quot;pending\&quot;&quot;}</para>
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
                /// <para>The data filter condition for the dataset.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;question&quot;,&quot;type&quot;:&quot;text&quot;}]</para>
            /// </summary>
            [NameInMap("inputFields")]
            [Validation(Required=false)]
            public List<UpdatePipelineRequestSourceInputFields> InputFields { get; set; }
            public class UpdatePipelineRequestSourceInputFields : TeaModel {
                /// <summary>
                /// <para>The name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>question</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the field. Valid values: text, long, double, and json.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The Simple Log Service (SLS) Logstore datasource config.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;project&quot;:&quot;my-sls-project&quot;,&quot;logstore&quot;:&quot;agent-logs&quot;}</para>
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
                /// <para>The filtered query statement in SLS query and analysis syntax.</para>
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
            /// <para>The trajectory data configuration. This parameter is optional and takes effect only when type is set to trace. It obtains ATIF standard trajectory data from the trajectory scrubbing service and extends it by feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;enrich&quot;:{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}}</para>
            /// </summary>
            [NameInMap("trajectory")]
            [Validation(Required=false)]
            public UpdatePipelineRequestSourceTrajectory Trajectory { get; set; }
            public class UpdatePipelineRequestSourceTrajectory : TeaModel {
                /// <summary>
                /// <para>The trajectory enrichment. It mounts trajectory data into the scrubbing result by trace_id. When writing to a dataset, the data is carried in the fixed column agent_trajectory, where the column value is the trajectory JSON content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}</para>
                /// </summary>
                [NameInMap("enrich")]
                [Validation(Required=false)]
                public UpdatePipelineRequestSourceTrajectoryEnrich Enrich { get; set; }
                public class UpdatePipelineRequestSourceTrajectoryEnrich : TeaModel {
                    /// <summary>
                    /// <para>The list of enrichment columns. This parameter is retained for compatibility. The current implementation outputs a single fixed column agent_trajectory, and this parameter no longer affects the output.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;input&quot;,&quot;output&quot;,&quot;session_id&quot;]</para>
                    /// </summary>
                    [NameInMap("columns")]
                    [Validation(Required=false)]
                    public List<string> Columns { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable trajectory enrichment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            /// <summary>
            /// <para>The data source type. Valid values: logstore, dataset, and trace. The trace value indicates a trajectory signal-driven processing mode. The validity of the enum values is verified by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataset</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token. It is a unique string generated by the client to ensure the idempotence of the update operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
