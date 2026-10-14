// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListPipelinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page specified in the request.</para>
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
                /// <para>The continuous execution configuration. This is used when the type is trace. The processing frequency is a fixed value managed by the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;fromTime&quot;:1735660800}</para>
                /// </summary>
                [NameInMap("continuous")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesExecutePolicyContinuous Continuous { get; set; }
                public class ListPipelinesResponseBodyPipelinesExecutePolicyContinuous : TeaModel {
                    /// <summary>
                    /// <para>The bootstrap history start time as a UNIX timestamp in seconds. It has the same precision as runOnce or scheduled fromTime. Millisecond values greater than or equal to 1e12 are automatically converted. The cursor starts from the grid-aligned time and catches up window by window. After catching up, it switches to minute intervals. By default, it starts from the current time and only processes incremental data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1735660800</para>
                    /// </summary>
                    [NameInMap("fromTime")]
                    [Validation(Required=false)]
                    public long? FromTime { get; set; }

                }

                /// <summary>
                /// <para>The scheduling mode. Valid values: RunOnce for single execution, Scheduled for periodic execution, and Continuous for continuous execution. Continuous mode is only for trace data sources. The processing frequency is a fixed value managed by the server, and data is automatically processed at minute intervals after the trace is completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RunOnce</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The parameters for single execution. This field has a value only when the mode is RunOnce.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;fromTime&quot;:1735660800,&quot;toTime&quot;:1735664400}</para>
                /// </summary>
                [NameInMap("runOnce")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesExecutePolicyRunOnce RunOnce { get; set; }
                public class ListPipelinesResponseBodyPipelinesExecutePolicyRunOnce : TeaModel {
                    /// <summary>
                    /// <para>The start time of the time slice as a UNIX timestamp in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1735660800</para>
                    /// </summary>
                    [NameInMap("fromTime")]
                    [Validation(Required=false)]
                    public long? FromTime { get; set; }

                    /// <summary>
                    /// <para>The end time of the time slice as a UNIX timestamp in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1735747200</para>
                    /// </summary>
                    [NameInMap("toTime")]
                    [Validation(Required=false)]
                    public long? ToTime { get; set; }

                }

                /// <summary>
                /// <para>The parameters for periodic scheduling. This field has a value only when the mode is Scheduled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;interval&quot;:&quot;1h&quot;,&quot;fromTime&quot;:1735660800}</para>
                /// </summary>
                [NameInMap("scheduled")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesExecutePolicyScheduled Scheduled { get; set; }
                public class ListPipelinesResponseBodyPipelinesExecutePolicyScheduled : TeaModel {
                    /// <summary>
                    /// <para>The scheduling start time as a UNIX timestamp in seconds.</para>
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
            /// <para>The scheduling status. Valid values: None for no scheduling in RunOnce pipelines, Active, Paused, and Terminated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("scheduleStatus")]
            [Validation(Required=false)]
            public string ScheduleStatus { get; set; }

            /// <summary>
            /// <para>The scheduling type. Valid values: RunOnce for single execution, Scheduled for periodic scheduling, and Continuous for continuous execution driven by trace source signals.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RunOnce</para>
            /// </summary>
            [NameInMap("scheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <para>The pipeline sink, which is the destination for data writing.</para>
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public ListPipelinesResponseBodyPipelinesSink Sink { get; set; }
            public class ListPipelinesResponseBodyPipelinesSink : TeaModel {
                /// <summary>
                /// <para>The conditional routing configuration. This is used only when the sink type is condition.</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesSinkCondition Condition { get; set; }
                public class ListPipelinesResponseBodyPipelinesSinkCondition : TeaModel {
                    /// <summary>
                    /// <para>The default write destination used when no conditional route is matched.</para>
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
                    public List<ListPipelinesResponseBodyPipelinesSinkConditionRoutes> Routes { get; set; }
                    public class ListPipelinesResponseBodyPipelinesSinkConditionRoutes : TeaModel {
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
                        /// <para>The ID of the route.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>refund</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The write destination of the route.</para>
                        /// </summary>
                        [NameInMap("sink")]
                        [Validation(Required=false)]
                        public ListPipelinesResponseBodyPipelinesSinkConditionRoutesSink Sink { get; set; }
                        public class ListPipelinesResponseBodyPipelinesSinkConditionRoutesSink : TeaModel {
                            /// <summary>
                            /// <para>The destination dataset of the route.</para>
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
                            /// <para>The destination type of the route. Currently, only dataset is supported.</para>
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
                /// <para>The destination dataset configuration for the dataset sink. This is used only when the sink type is dataset.</para>
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
                /// <para>The destination type. Valid values: dataset, condition.</para>
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
                /// <para>The dataset datasource config in the current AgentSpace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;dataset&quot;:&quot;my-dataset&quot;,&quot;filter&quot;:&quot;status = \&quot;pending\&quot;&quot;}</para>
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
                /// <para>The input fields and their types, applicable to all data source types.</para>
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
                public ListPipelinesResponseBodyPipelinesSourceLogstore Logstore { get; set; }
                public class ListPipelinesResponseBodyPipelinesSourceLogstore : TeaModel {
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
                    /// <para>The data filtered query statement, which uses the SLS query and analysis syntax.</para>
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
                /// <para>The trajectory data configuration. This parameter is optional and takes effect only when the type is trace. It obtains ATIF standard trajectory data from the trajectory scrubbing service and extends it by feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;enrich&quot;:{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}}</para>
                /// </summary>
                [NameInMap("trajectory")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesSourceTrajectory Trajectory { get; set; }
                public class ListPipelinesResponseBodyPipelinesSourceTrajectory : TeaModel {
                    /// <summary>
                    /// <para>The trajectory enrichment configuration. It mounts trajectory data into the scrubbing result based on the trace_id. When writing to the dataset, the data is stored in the fixed column agent_trajectory, and the column value is the trajectory JSON content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;enabled&quot;:true,&quot;columns&quot;:[&quot;input&quot;,&quot;output&quot;]}</para>
                    /// </summary>
                    [NameInMap("enrich")]
                    [Validation(Required=false)]
                    public ListPipelinesResponseBodyPipelinesSourceTrajectoryEnrich Enrich { get; set; }
                    public class ListPipelinesResponseBodyPipelinesSourceTrajectoryEnrich : TeaModel {
                        /// <summary>
                        /// <para>The list of enrichment columns. This parameter is retained for compatibility. The current implementation outputs only the fixed column agent_trajectory, and this parameter no longer affects the output.</para>
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
                /// <para>The data source type. Valid values: logstore, dataset, and trace. The trace value indicates a trajectory signal-driven processing mode. The validity of the enumerated values is verified by the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataset</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The time when the pipeline was last updated. The time is in the ISO 8601 UTC format.</para>
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

        /// <summary>
        /// <para>The request ID, which is used to locate the request during troubleshooting.</para>
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
