// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The committed watermark in UNIX seconds.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mode&quot;:&quot;RunOnce&quot;,&quot;runOnce&quot;:{&quot;fromTime&quot;:1735660800,&quot;toTime&quot;:1735664400}}</para>
        /// </summary>
        [NameInMap("executePolicy")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyExecutePolicy ExecutePolicy { get; set; }
        public class GetPipelineResponseBodyExecutePolicy : TeaModel {
            /// <summary>
            /// <para>The continuous execution configuration. This is used when type is set to trace. The processing frequency is a fixed value managed by the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fromTime&quot;:1735660800}</para>
            /// </summary>
            [NameInMap("continuous")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyExecutePolicyContinuous Continuous { get; set; }
            public class GetPipelineResponseBodyExecutePolicyContinuous : TeaModel {
                /// <summary>
                /// <para>The bootstrap history start time as a UNIX timestamp in seconds. It shares the same precision as runOnce/scheduled.fromTime. Millisecond values greater than or equal to 1e12 are automatically converted. The cursor starts from this time aligned to the grid and catches up window by window. After catching up, it switches to minute intervals. By default, it starts from the current time and processes only incremental data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

            }

            /// <summary>
            /// <para>The scheduling mode. Valid values: RunOnce (single execution), Scheduled (periodic execution), and Continuous (continuous execution, applicable only to trace data sources; the processing frequency is a fixed value managed by the server, and processing automatically occurs at minute intervals after trace completion).</para>
            /// 
            /// <b>Example:</b>
            /// <para>scheduled</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The single execution configuration. This parameter is required only when mode is set to RunOnce.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fromTime&quot;:1735660800,&quot;toTime&quot;:1735664400}</para>
            /// </summary>
            [NameInMap("runOnce")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyExecutePolicyRunOnce RunOnce { get; set; }
            public class GetPipelineResponseBodyExecutePolicyRunOnce : TeaModel {
                /// <summary>
                /// <para>The start time of the data processing window in UNIX seconds. The value must be less than toTime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735660800</para>
                /// </summary>
                [NameInMap("fromTime")]
                [Validation(Required=false)]
                public long? FromTime { get; set; }

                /// <summary>
                /// <para>The end time of the data processing window in UNIX seconds. The value must be greater than fromTime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1735747200</para>
                /// </summary>
                [NameInMap("toTime")]
                [Validation(Required=false)]
                public long? ToTime { get; set; }

            }

            /// <summary>
            /// <para>The periodic scheduling configuration. This parameter is required only when mode is set to Scheduled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;interval&quot;:&quot;1h&quot;,&quot;fromTime&quot;:1735660800}</para>
            /// </summary>
            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public GetPipelineResponseBodyExecutePolicyScheduled Scheduled { get; set; }
            public class GetPipelineResponseBodyExecutePolicyScheduled : TeaModel {
                /// <summary>
                /// <para>The scheduling start time as a UNIX timestamp in seconds. It shares the same precision as runOnce.fromTime. Millisecond values greater than or equal to 1e12 are automatically converted.</para>
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
        /// <para>The ID of the last run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>run-20260101-0001</para>
        /// </summary>
        [NameInMap("lastRunId")]
        [Validation(Required=false)]
        public string LastRunId { get; set; }

        /// <summary>
        /// <para>The status of the last run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("lastRunStatus")]
        [Validation(Required=false)]
        public string LastRunStatus { get; set; }

        /// <summary>
        /// <para>The next schedule trigger time in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735661100</para>
        /// </summary>
        [NameInMap("nextTriggerTime")]
        [Validation(Required=false)]
        public long? NextTriggerTime { get; set; }

        /// <summary>
        /// <para>The pipeline configuration, which defines the node orchestration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;nodes&quot;:[{&quot;id&quot;:&quot;select-fields&quot;,&quot;type&quot;:&quot;project&quot;,&quot;parameters&quot;:{&quot;question&quot;:&quot;user_query&quot;}}]}</para>
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The list of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;id&quot;:&quot;select-fields&quot;,&quot;type&quot;:&quot;project&quot;,&quot;parameters&quot;:{}}]</para>
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
                /// <para>The node parameters. It uses a key-value structure and varies depending on the node type.</para>
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
        /// <para>The pipeline type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ORCHESTRATION</para>
        /// </summary>
        [NameInMap("pipelineKind")]
        [Validation(Required=false)]
        public string PipelineKind { get; set; }

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
        /// <para>The request ID, which is used to locate the request when troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The schedule status. Valid values: None (no schedule), Active (active), Paused (paused), and Terminated (terminated).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("scheduleStatus")]
        [Validation(Required=false)]
        public string ScheduleStatus { get; set; }

        /// <summary>
        /// <para>The schedule type. Valid values: RunOnce (single execution), Scheduled (periodic scheduling), and Continuous (continuous execution, driven by trace source signals).</para>
        /// 
        /// <b>Example:</b>
        /// <para>RunOnce</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>The pipeline sink, which specifies the data write destination.</para>
        /// </summary>
        [NameInMap("sink")]
        [Validation(Required=false)]
        public GetPipelineResponseBodySink Sink { get; set; }
        public class GetPipelineResponseBodySink : TeaModel {
            /// <summary>
            /// <para>The conditional routing configuration. This parameter is used only when the sink type is condition.</para>
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
                /// <para>The route matching mode. Currently, only all is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("matchMode")]
                [Validation(Required=false)]
                public string MatchMode { get; set; }

                /// <summary>
                /// <para>The conditional route list.</para>
                /// </summary>
                [NameInMap("routes")]
                [Validation(Required=false)]
                public List<GetPipelineResponseBodySinkConditionRoutes> Routes { get; set; }
                public class GetPipelineResponseBodySinkConditionRoutes : TeaModel {
                    /// <summary>
                    /// <para>The route expression in Search Processing Language (SPL). Only where, project, and extend are supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description>| where intent = &quot;refund&quot;</description></item>
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
            /// <para>The destination dataset configuration for the dataset sink. This parameter is used only when the sink type is dataset.</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySinkDataset Dataset { get; set; }
            public class GetPipelineResponseBodySinkDataset : TeaModel {
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
        /// <para>The pipeline data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;logstore&quot;,&quot;logstore&quot;:{&quot;project&quot;:&quot;my-sls-project&quot;,&quot;logstore&quot;:&quot;agent-logs&quot;},&quot;inputFields&quot;:[{&quot;name&quot;:&quot;question&quot;,&quot;type&quot;:&quot;text&quot;}]}</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public GetPipelineResponseBodySource Source { get; set; }
        public class GetPipelineResponseBodySource : TeaModel {
            /// <summary>
            /// <para>The dataset datasource config under the current AgentSpace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;dataset&quot;:&quot;my-dataset&quot;,&quot;filter&quot;:&quot;status = &quot;pending&quot;&quot;}</para>
            /// </summary>
            [NameInMap("dataset")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySourceDataset Dataset { get; set; }
            public class GetPipelineResponseBodySourceDataset : TeaModel {
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
                /// <para>status = &quot;pending&quot;</para>
                /// </summary>
                [NameInMap("filter")]
                [Validation(Required=false)]
                public string Filter { get; set; }

            }

            /// <summary>
            /// <para>The input fields and their data types, applicable to all data source types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;question&quot;,&quot;type&quot;:&quot;text&quot;}]</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;project&quot;:&quot;my-sls-project&quot;,&quot;logstore&quot;:&quot;agent-logs&quot;}</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySourceLogstore Logstore { get; set; }
            public class GetPipelineResponseBodySourceLogstore : TeaModel {
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
                /// <para>The filtered query statement, which uses the SLS query and analysis syntax.</para>
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
            /// <para>The trace data configuration. This parameter is optional and takes effect only when the type is trace. It retrieves ATIF standard trace data from the trace cleaning service and extends it by feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;enrich&quot;:{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}}</para>
            /// </summary>
            [NameInMap("trajectory")]
            [Validation(Required=false)]
            public GetPipelineResponseBodySourceTrajectory Trajectory { get; set; }
            public class GetPipelineResponseBodySourceTrajectory : TeaModel {
                /// <summary>
                /// <para>The trace enrichment configuration. It mounts trace data into the cleaning result by trace_id. When writing to a dataset, it uses the fixed column agent_trajectory to store the data, where the column value is the trace JSON content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}</para>
                /// </summary>
                [NameInMap("enrich")]
                [Validation(Required=false)]
                public GetPipelineResponseBodySourceTrajectoryEnrich Enrich { get; set; }
                public class GetPipelineResponseBodySourceTrajectoryEnrich : TeaModel {
                    /// <summary>
                    /// <para>The list of enrichment columns. This parameter is retained for compatibility. The current implementation outputs a single fixed column named agent_trajectory, and this parameter no longer affects the output.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;input&quot;,&quot;output&quot;,&quot;session_id&quot;]</para>
                    /// </summary>
                    [NameInMap("columns")]
                    [Validation(Required=false)]
                    public List<string> Columns { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable trace enrichment.</para>
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
            /// <para>The data source type. Valid values: logstore, dataset, and trace. The trace value indicates the trace signal-driven processing mode. The server validates the enum values.</para>
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
        /// <para>The pipeline configuration version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

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
