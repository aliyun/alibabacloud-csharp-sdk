// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListPipelinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page that was specified in the request. This value is echoed back.</para>
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
            /// </summary>
            [NameInMap("executePolicy")]
            [Validation(Required=false)]
            public ListPipelinesResponseBodyPipelinesExecutePolicy ExecutePolicy { get; set; }
            public class ListPipelinesResponseBodyPipelinesExecutePolicy : TeaModel {
                /// <summary>
                /// <para>The scheduling mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RunOnce: one-time execution.</description></item>
                /// <item><description>Scheduled: periodic scheduling.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RunOnce</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The parameters for one-time execution. This parameter has a value only when mode is set to RunOnce.</para>
                /// </summary>
                [NameInMap("runOnce")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesExecutePolicyRunOnce RunOnce { get; set; }
                public class ListPipelinesResponseBodyPipelinesExecutePolicyRunOnce : TeaModel {
                    /// <summary>
                    /// <para>The start of the time slice, in UNIX millisecond timestamp format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1735660800000</para>
                    /// </summary>
                    [NameInMap("fromTime")]
                    [Validation(Required=false)]
                    public long? FromTime { get; set; }

                    /// <summary>
                    /// <para>The end of the time slice, in UNIX millisecond timestamp format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1735747200000</para>
                    /// </summary>
                    [NameInMap("toTime")]
                    [Validation(Required=false)]
                    public long? ToTime { get; set; }

                }

                /// <summary>
                /// <para>The parameters for periodic scheduling. This parameter has a value only when mode is set to Scheduled.</para>
                /// </summary>
                [NameInMap("scheduled")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesExecutePolicyScheduled Scheduled { get; set; }
                public class ListPipelinesResponseBodyPipelinesExecutePolicyScheduled : TeaModel {
                    /// <summary>
                    /// <para>The scheduling start time, in UNIX millisecond timestamp format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1735660800000</para>
                    /// </summary>
                    [NameInMap("fromTime")]
                    [Validation(Required=false)]
                    public long? FromTime { get; set; }

                    /// <summary>
                    /// <para>The scheduling interval, such as 1h or 30m.</para>
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
            /// <para>The scheduling status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>None: no scheduling. This value is returned for RunOnce pipelines.</description></item>
            /// <item><description>Active: active.</description></item>
            /// <item><description>Paused: paused.</description></item>
            /// <item><description>Terminated: terminated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("scheduleStatus")]
            [Validation(Required=false)]
            public string ScheduleStatus { get; set; }

            /// <summary>
            /// <para>The scheduling type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RunOnce: one-time execution.</description></item>
            /// <item><description>Scheduled: periodic scheduling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RunOnce</para>
            /// </summary>
            [NameInMap("scheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <para>The pipeline sink (data write destination).</para>
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public ListPipelinesResponseBodyPipelinesSink Sink { get; set; }
            public class ListPipelinesResponseBodyPipelinesSink : TeaModel {
                /// <summary>
                /// <para>The conditional routing configuration. This parameter is used only when sink.type is set to condition.</para>
                /// </summary>
                [NameInMap("condition")]
                [Validation(Required=false)]
                public ListPipelinesResponseBodyPipelinesSinkCondition Condition { get; set; }
                public class ListPipelinesResponseBodyPipelinesSinkCondition : TeaModel {
                    /// <summary>
                    /// <para>The default write destination that is used when no condition route is matched.</para>
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
                        /// <para>The type of the default destination. Currently, only dataset is supported.</para>
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
                    /// <para>The list of condition routes.</para>
                    /// </summary>
                    [NameInMap("routes")]
                    [Validation(Required=false)]
                    public List<ListPipelinesResponseBodyPipelinesSinkConditionRoutes> Routes { get; set; }
                    public class ListPipelinesResponseBodyPipelinesSinkConditionRoutes : TeaModel {
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
                            /// <para>The type of the route destination. Currently, only dataset is supported.</para>
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
                /// <para>The destination type. Valid values: dataset or condition.</para>
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
            public ListPipelinesResponseBodyPipelinesSource Source { get; set; }
            public class ListPipelinesResponseBodyPipelinesSource : TeaModel {
                /// <summary>
                /// <para>The dataset datasource config in the current AgentSpace.</para>
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
                /// <para>The Simple Log Service (SLS) Logstore datasource config.</para>
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
                /// <para>The data source type. Valid values: logstore or dataset.</para>
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
        /// <para>The total number of pipelines that match the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
