// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListPipelinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page that is specified in the request. This value is echoed in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. An empty string indicates that the current page is the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of pipelines.</para>
        /// </summary>
        [NameInMap("pipelines")]
        [Validation(Required=false)]
        public List<ListPipelinesResponseBodyPipelines> Pipelines { get; set; }
        public class ListPipelinesResponseBodyPipelines : TeaModel {
            /// <summary>
            /// <para>The timestamp of the committed watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1767225600</para>
            /// </summary>
            [NameInMap("committedWatermark")]
            [Validation(Required=false)]
            public long? CommittedWatermark { get; set; }

            /// <summary>
            /// <para>The time when the pipeline was created. The time is in the ISO 8601 standard in UTC.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My pipeline</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The execution policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;mode&quot;:&quot;RunOnce&quot;,&quot;runOnce&quot;:{&quot;fromTime&quot;:1735660800,&quot;toTime&quot;:1735664400}}</para>
            /// </summary>
            [NameInMap("executePolicy")]
            [Validation(Required=false)]
            public ListPipelinesResponseBodyPipelinesExecutePolicy ExecutePolicy { get; set; }
            public class ListPipelinesResponseBodyPipelinesExecutePolicy : TeaModel {
                /// <summary>
                /// <para>The continuous execution configuration. This configuration is used when type is set to trace. The processing frequency is a fixed value managed by the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;fromTime&quot;:1735660800}</para>
                /// </summary>
                [NameInMap("continuous")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesExecutePolicyContinuous Continuous { get; set; }
                public class ListPipelinesResponseBodyPipelinesExecutePolicyContinuous : TeaModel {
                    /// <summary>
                    /// <para>The historical start time for bootstrap. The value is a UNIX timestamp in seconds, which has the same precision as runOnce/scheduled.fromTime. Millisecond values greater than or equal to 1e12 are automatically converted. The cursor starts from this time aligned to the grid and catches up window by window. After catching up, it switches to minute intervals. By default, it starts from the current time and processes only incremental data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1735660800</para>
                    /// </summary>
                    [NameInMap("fromTime")]
                    [Validation(Required=false)]
                    public long? FromTime { get; set; }

                }

                /// <summary>
                /// <para>The scheduling mode. Valid values: RunOnce (single execution), Scheduled (periodic execution), and Continuous (continuous execution, applicable only to trace data sources; the processing frequency is a fixed value managed by the server, and automatic processing occurs at the minute level after trace completion).</para>
                /// 
                /// <b>Example:</b>
                /// <para>RunOnce</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The parameters for single execution. This field has a value only when mode is set to RunOnce.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;fromTime&quot;:1735660800,&quot;toTime&quot;:1735664400}</para>
                /// </summary>
                [NameInMap("runOnce")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesExecutePolicyRunOnce RunOnce { get; set; }
                public class ListPipelinesResponseBodyPipelinesExecutePolicyRunOnce : TeaModel {
                    /// <summary>
                    /// <para>The start time of the time slice. The value is a UNIX timestamp in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1735660800</para>
                    /// </summary>
                    [NameInMap("fromTime")]
                    [Validation(Required=false)]
                    public long? FromTime { get; set; }

                    /// <summary>
                    /// <para>The end time of the time slice. The value is a UNIX timestamp in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1735747200</para>
                    /// </summary>
                    [NameInMap("toTime")]
                    [Validation(Required=false)]
                    public long? ToTime { get; set; }

                }

                /// <summary>
                /// <para>The parameters for periodic scheduling. This field has a value only when mode is set to Scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;interval&quot;:&quot;1h&quot;,&quot;fromTime&quot;:1735660800}</para>
                /// </summary>
                [NameInMap("scheduled")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesExecutePolicyScheduled Scheduled { get; set; }
                public class ListPipelinesResponseBodyPipelinesExecutePolicyScheduled : TeaModel {
                    /// <summary>
                    /// <para>The start time of the scheduling. The value is a UNIX timestamp in seconds.</para>
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
            /// <para>The timestamp for the next scheduled trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1767229200</para>
            /// </summary>
            [NameInMap("nextTriggerTime")]
            [Validation(Required=false)]
            public long? NextTriggerTime { get; set; }

            /// <summary>
            /// <para>The reason why scheduling is paused.</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("pausedReason")]
            [Validation(Required=false)]
            public string PausedReason { get; set; }

            /// <summary>
            /// <para>The pipeline orchestration configuration.</para>
            /// </summary>
            [NameInMap("pipeline")]
            [Validation(Required=false)]
            public ListPipelinesResponseBodyPipelinesPipeline Pipeline { get; set; }
            public class ListPipelinesResponseBodyPipelinesPipeline : TeaModel {
                /// <summary>
                /// <para>The list of orchestration nodes.</para>
                /// </summary>
                [NameInMap("nodes")]
                [Validation(Required=false)]
                public List<ListPipelinesResponseBodyPipelinesPipelineNodes> Nodes { get; set; }
                public class ListPipelinesResponseBodyPipelinesPipelineNodes : TeaModel {
                    /// <summary>
                    /// <para>The node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>stage_1</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The node parameters. This is a key-value structure that varies based on the node type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;stageId&quot;:&quot;stage_1&quot;}</para>
                    /// </summary>
                    [NameInMap("parameters")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Parameters { get; set; }

                    /// <summary>
                    /// <para>The node type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>annotation-stage</para>
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
            /// <para>The name of the pipeline.</para>
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
            /// <para>The schedule status. Valid values: None (no scheduling, for RunOnce pipelines), Active, Paused, and Terminated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
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
            /// <para>The pipeline sink, which is the destination for writing data.</para>
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public ListPipelinesResponseBodyPipelinesSink Sink { get; set; }
            public class ListPipelinesResponseBodyPipelinesSink : TeaModel {
                /// <summary>
                /// <para>The conditional routing configuration. This parameter is used only when the sink type is condition.</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesSinkCondition Condition { get; set; }
                public class ListPipelinesResponseBodyPipelinesSinkCondition : TeaModel {
                    /// <summary>
                    /// <para>The default sink used when no conditional route is matched.</para>
                    /// </summary>
                    [NameInMap("defaultSink")]
                    [Validation(Required=false)]
                    public ListPipelinesResponseBodyPipelinesSinkConditionDefaultSink DefaultSink { get; set; }
                    public class ListPipelinesResponseBodyPipelinesSinkConditionDefaultSink : TeaModel {
                        /// <summary>
                        /// <para>The default destination dataset.</para>
                        /// </summary>
                        [NameInMap("dataset")]
                        [Validation(Required=false)]
                        public ListPipelinesResponseBodyPipelinesSinkConditionDefaultSinkDataset Dataset { get; set; }
                        public class ListPipelinesResponseBodyPipelinesSinkConditionDefaultSinkDataset : TeaModel {
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
                        /// <para>The default sink type. Only dataset is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dataset</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The route matching mode. Only all is supported.</para>
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
                    public List<ListPipelinesResponseBodyPipelinesSinkConditionRoutes> Routes { get; set; }
                    public class ListPipelinesResponseBodyPipelinesSinkConditionRoutes : TeaModel {
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
                        /// <para>The sink for the route.</para>
                        /// </summary>
                        [NameInMap("sink")]
                        [Validation(Required=false)]
                        public ListPipelinesResponseBodyPipelinesSinkConditionRoutesSink Sink { get; set; }
                        public class ListPipelinesResponseBodyPipelinesSinkConditionRoutesSink : TeaModel {
                            /// <summary>
                            /// <para>The destination dataset for the route.</para>
                            /// </summary>
                            [NameInMap("dataset")]
                            [Validation(Required=false)]
                            public ListPipelinesResponseBodyPipelinesSinkConditionRoutesSinkDataset Dataset { get; set; }
                            public class ListPipelinesResponseBodyPipelinesSinkConditionRoutesSinkDataset : TeaModel {
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
                            /// <para>The sink type for the route. Only dataset is supported.</para>
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
                public ListPipelinesResponseBodyPipelinesSinkDataset Dataset { get; set; }
                public class ListPipelinesResponseBodyPipelinesSinkDataset : TeaModel {
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
            /// <para>The data source of the pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;logstore&quot;,&quot;logstore&quot;:{&quot;project&quot;:&quot;my-sls-project&quot;,&quot;logstore&quot;:&quot;agent-logs&quot;},&quot;inputFields&quot;:[{&quot;name&quot;:&quot;question&quot;,&quot;type&quot;:&quot;text&quot;}]}</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public ListPipelinesResponseBodyPipelinesSource Source { get; set; }
            public class ListPipelinesResponseBodyPipelinesSource : TeaModel {
                /// <summary>
                /// <para>The dataset datasource config under the current AgentSpace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;dataset&quot;:&quot;my-dataset&quot;,&quot;filter&quot;:&quot;status = &quot;pending&quot;&quot;}</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesSourceDataset Dataset { get; set; }
                public class ListPipelinesResponseBodyPipelinesSourceDataset : TeaModel {
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
                    /// <para>The filter conditions for the dataset data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>status = &quot;pending&quot;</para>
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
                public List<ListPipelinesResponseBodyPipelinesSourceInputFields> InputFields { get; set; }
                public class ListPipelinesResponseBodyPipelinesSourceInputFields : TeaModel {
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
                public ListPipelinesResponseBodyPipelinesSourceLogstore Logstore { get; set; }
                public class ListPipelinesResponseBodyPipelinesSourceLogstore : TeaModel {
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
                    /// <para>The filtered query statement (Simple Log Service query and analysis syntax).</para>
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
                /// <para>The trajectory data configuration. This configuration is optional and takes effect only when type is set to trace. It obtains ATIF standard trajectory data from the trajectory scrubbing service and extends it based on features.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;enrich&quot;:{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}}</para>
                /// </summary>
                [NameInMap("trajectory")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesSourceTrajectory Trajectory { get; set; }
                public class ListPipelinesResponseBodyPipelinesSourceTrajectory : TeaModel {
                    /// <summary>
                    /// <para>The trajectory enrichment configuration. It mounts trajectory data into the scrubbing results based on the trace_id. When writing to a dataset, the data is stored in a fixed column named agent_trajectory, and the column value contains the trajectory JSON content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}</para>
                    /// </summary>
                    [NameInMap("enrich")]
                    [Validation(Required=false)]
                    public ListPipelinesResponseBodyPipelinesSourceTrajectoryEnrich Enrich { get; set; }
                    public class ListPipelinesResponseBodyPipelinesSourceTrajectoryEnrich : TeaModel {
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
                /// <para>The type of the data source. Valid values: logstore, dataset, and trace. The trace type indicates a processing mode driven by trajectory signals. The validity of the enumerated values is verified by the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataset</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The time when the pipeline was last updated. The time is in the ISO 8601 standard in UTC.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-02T00:00:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The version number of the pipeline configuration.</para>
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

        /// <summary>
        /// <para>The request ID, which is used to locate the request when you troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pipelines that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
