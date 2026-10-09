// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The description of the pipeline. Maximum length: 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Collect trace data from SLS and perform data cleaning into a dataset</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The scheduling method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mode&quot;:&quot;RunOnce&quot;,&quot;runOnce&quot;:{&quot;fromTime&quot;:1735660800,&quot;toTime&quot;:1735664400}}</para>
        /// </summary>
        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public CreatePipelineRequestExecutePolicy ExecutePolicy { get; set; }
        public class CreatePipelineRequestExecutePolicy : TeaModel {
            /// <summary>
            /// <para>The continuous execution configuration. This is used when the type is trace. The processing frequency is a fixed value managed by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fromTime&quot;:1735660800}</para>
            /// </summary>
            [NameInMap("continuous")]
            [Validation(Required=false)]
            public CreatePipelineRequestExecutePolicyContinuous Continuous { get; set; }
            public class CreatePipelineRequestExecutePolicyContinuous : TeaModel {
                /// <summary>
                /// <para>The bootstrap start time in UNIX seconds. It has the same precision as runOnce or scheduled fromTime. Millisecond values greater than or equal to 1e12 are automatically converted. The cursor starts from this time aligned to the grid and catches up window by window. After catching up, it switches to minute intervals. By default, it starts from the current time and processes only incremental data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

            }

            /// <summary>
            /// <para>The scheduling mode. Valid values: RunOnce (single execution) and Scheduled (periodic scheduling).</para>
            /// 
            /// <b>Example:</b>
            /// <para>RunOnce</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The single execution configuration. This parameter is required only when the mode is RunOnce.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fromTime&quot;:1735660800,&quot;toTime&quot;:1735664400}</para>
            /// </summary>
            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public CreatePipelineRequestExecutePolicyRunOnce RunOnce { get; set; }
            public class CreatePipelineRequestExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <para>The start time of the data processing window in UNIX seconds. The value must be less than the toTime value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The end time of the data processing window in UNIX seconds. The value must be greater than the fromTime value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735747200</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            /// <summary>
            /// <para>The periodic scheduling configuration. This parameter is required only when the mode is Scheduled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;interval&quot;:&quot;1h&quot;,&quot;fromTime&quot;:1735660800}</para>
            /// </summary>
            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public CreatePipelineRequestExecutePolicyScheduled Scheduled { get; set; }
            public class CreatePipelineRequestExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <para>The start time of the scheduling in UNIX milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800000</para>
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
        /// <para>The pipeline configuration, including node orchestration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;nodes&quot;:[{&quot;id&quot;:&quot;select-fields&quot;,&quot;type&quot;:&quot;project&quot;,&quot;parameters&quot;:{&quot;question&quot;:&quot;user_query&quot;}}]}</para>
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public CreatePipelineRequestPipeline Pipeline { get; set; }
        public class CreatePipelineRequestPipeline : TeaModel {
            /// <summary>
            /// <para>The list of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;id&quot;:&quot;select-fields&quot;,&quot;type&quot;:&quot;project&quot;,&quot;parameters&quot;:{}}]</para>
            /// </summary>
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<CreatePipelineRequestPipelineNodes> Nodes { get; set; }
            public class CreatePipelineRequestPipelineNodes : TeaModel {
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
                /// <para>The parameters of the node. This is a key-value structure and varies based on the node type.</para>
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
        /// <para>The name of the pipeline. The name must be 3 to 63 characters in length and can contain only lowercase letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The pipeline sink, which is the data write destination.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public CreatePipelineRequestSink Sink { get; set; }
        public class CreatePipelineRequestSink : TeaModel {
            /// <summary>
            /// <para>The conditional routing configuration. This is used only when sink.type is set to condition.</para>
            /// </summary>
            [NameInMap("condition")]
            [Validation(Required=false)]
            public CreatePipelineRequestSinkCondition Condition { get; set; }
            public class CreatePipelineRequestSinkCondition : TeaModel {
                /// <summary>
                /// <para>The default write destination used when no conditional route is matched.</para>
                /// </summary>
                [NameInMap("defaultSink")]
                [Validation(Required=false)]
                public CreatePipelineRequestSinkConditionDefaultSink DefaultSink { get; set; }
                public class CreatePipelineRequestSinkConditionDefaultSink : TeaModel {
                    /// <summary>
                    /// <para>The default destination dataset.</para>
                    /// </summary>
                    [NameInMap("dataset")]
                    [Validation(Required=false)]
                    public CreatePipelineRequestSinkConditionDefaultSinkDataset Dataset { get; set; }
                    public class CreatePipelineRequestSinkConditionDefaultSinkDataset : TeaModel {
                        /// <summary>
                        /// <para>The name of the agent space to which the default destination dataset belongs.</para>
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
                public List<CreatePipelineRequestSinkConditionRoutes> Routes { get; set; }
                public class CreatePipelineRequestSinkConditionRoutes : TeaModel {
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
                    /// <para>The write destination for the route.</para>
                    /// </summary>
                    [NameInMap("sink")]
                    [Validation(Required=false)]
                    public CreatePipelineRequestSinkConditionRoutesSink Sink { get; set; }
                    public class CreatePipelineRequestSinkConditionRoutesSink : TeaModel {
                        /// <summary>
                        /// <para>The destination dataset for the route.</para>
                        /// </summary>
                        [NameInMap("dataset")]
                        [Validation(Required=false)]
                        public CreatePipelineRequestSinkConditionRoutesSinkDataset Dataset { get; set; }
                        public class CreatePipelineRequestSinkConditionRoutesSinkDataset : TeaModel {
                            /// <summary>
                            /// <para>The name of the agent space to which the destination dataset belongs.</para>
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
                        /// <para>The destination type for the route. Currently, only dataset is supported.</para>
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
            /// <para>The destination dataset configuration for the dataset sink. This is used only when sink.type is set to dataset.</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public CreatePipelineRequestSinkDataset Dataset { get; set; }
            public class CreatePipelineRequestSinkDataset : TeaModel {
                /// <summary>
                /// <para>The name of the agent space to which the destination dataset belongs.</para>
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
            /// <para>The destination type. Currently, dataset is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dataset</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The data source for the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;logstore&quot;,&quot;logstore&quot;:{&quot;project&quot;:&quot;my-sls-project&quot;,&quot;logstore&quot;:&quot;agent-logs&quot;},&quot;inputFields&quot;:[{&quot;name&quot;:&quot;question&quot;,&quot;type&quot;:&quot;text&quot;}]}</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public CreatePipelineRequestSource Source { get; set; }
        public class CreatePipelineRequestSource : TeaModel {
            /// <summary>
            /// <para>The dataset datasource config under the current agent space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;dataset&quot;:&quot;my-dataset&quot;,&quot;filter&quot;:&quot;status = \&quot;pending\&quot;&quot;}</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public CreatePipelineRequestSourceDataset Dataset { get; set; }
            public class CreatePipelineRequestSourceDataset : TeaModel {
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
            /// <para>The input fields and their data types. This applies to all data source types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;question&quot;,&quot;type&quot;:&quot;text&quot;}]</para>
            /// </summary>
            [NameInMap("inputFields")]
            [Validation(Required=false)]
            public List<CreatePipelineRequestSourceInputFields> InputFields { get; set; }
            public class CreatePipelineRequestSourceInputFields : TeaModel {
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
                /// <para>The data type of the field. Valid values: text, long, double, and json.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The Simple Log Service Logstore datasource config.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;project&quot;:&quot;my-sls-project&quot;,&quot;logstore&quot;:&quot;agent-logs&quot;}</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public CreatePipelineRequestSourceLogstore Logstore { get; set; }
            public class CreatePipelineRequestSourceLogstore : TeaModel {
                /// <summary>
                /// <para>The name of the Simple Log Service Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-sls-logstore</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the Simple Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-sls-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The data filtered query statement, which uses the Simple Log Service query and analysis syntax.</para>
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
            /// <para>The trajectory data configuration. This is optional and takes effect only when the type is set to trace. It retrieves ATIF standard trajectory data from the trajectory scrubbing service and extends it based on features.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;enrich&quot;:{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}}</para>
            /// </summary>
            [NameInMap("trajectory")]
            [Validation(Required=false)]
            public CreatePipelineRequestSourceTrajectory Trajectory { get; set; }
            public class CreatePipelineRequestSourceTrajectory : TeaModel {
                /// <summary>
                /// <para>The trajectory enrichment configuration. It mounts trajectory data into the scrubbing results based on the trace_id. When writing to a dataset, the data is stored in the fixed agent_trajectory column, where the column value is the trajectory JSON content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}</para>
                /// </summary>
                [NameInMap("enrich")]
                [Validation(Required=false)]
                public CreatePipelineRequestSourceTrajectoryEnrich Enrich { get; set; }
                public class CreatePipelineRequestSourceTrajectoryEnrich : TeaModel {
                    /// <summary>
                    /// <para>The list of enrichment columns. This parameter is retained for backward compatibility. The current implementation outputs only the fixed agent_trajectory column, and this parameter no longer affects the output.</para>
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
            /// <para>The data source type. Currently, Simple Log Service is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token. This is a unique string generated by the client to ensure the idempotency of the create operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
