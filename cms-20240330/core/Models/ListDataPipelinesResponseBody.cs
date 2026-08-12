// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListDataPipelinesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwfQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of data pipelines.</para>
        /// </summary>
        [NameInMap("pipelines")]
        [Validation(Required=false)]
        public List<ListDataPipelinesResponseBodyPipelines> Pipelines { get; set; }
        public class ListDataPipelinesResponseBodyPipelines : TeaModel {
            /// <summary>
            /// <para>The time when the pipeline was created.</para>
            /// <para>This parameter is required.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-10T05:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Export selected trace services to the target workspace.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the pipeline.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>export</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The named outputs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("outputs")]
            [Validation(Required=false)]
            public List<ListDataPipelinesResponseBodyPipelinesOutputs> Outputs { get; set; }
            public class ListDataPipelinesResponseBodyPipelinesOutputs : TeaModel {
                /// <summary>
                /// <para>The output name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>checkout_route</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The branch processors.</para>
                /// </summary>
                [NameInMap("processors")]
                [Validation(Required=false)]
                public List<ListDataPipelinesResponseBodyPipelinesOutputsProcessors> Processors { get; set; }
                public class ListDataPipelinesResponseBodyPipelinesOutputsProcessors : TeaModel {
                    /// <summary>
                    /// <para>The processor configuration.</para>
                    /// </summary>
                    [NameInMap("config")]
                    [Validation(Required=false)]
                    public ListDataPipelinesResponseBodyPipelinesOutputsProcessorsConfig Config { get; set; }
                    public class ListDataPipelinesResponseBodyPipelinesOutputsProcessorsConfig : TeaModel {
                        /// <summary>
                        /// <para>The list of applications.</para>
                        /// </summary>
                        [NameInMap("applications")]
                        [Validation(Required=false)]
                        public List<string> Applications { get; set; }

                        /// <summary>
                        /// <para>The filter expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>attributes[&quot;http.route&quot;] != &quot;/health&quot;</para>
                        /// </summary>
                        [NameInMap("expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>The list of fields.</para>
                        /// </summary>
                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<string> Fields { get; set; }

                        /// <summary>
                        /// <para>The list of masking rules.</para>
                        /// </summary>
                        [NameInMap("rules")]
                        [Validation(Required=false)]
                        public List<ListDataPipelinesResponseBodyPipelinesOutputsProcessorsConfigRules> Rules { get; set; }
                        public class ListDataPipelinesResponseBodyPipelinesOutputsProcessorsConfigRules : TeaModel {
                            /// <summary>
                            /// <para>The length of the prefix to keep.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("keepPrefix")]
                            [Validation(Required=false)]
                            public int? KeepPrefix { get; set; }

                            /// <summary>
                            /// <para>The length of the suffix to keep.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("keepSuffix")]
                            [Validation(Required=false)]
                            public int? KeepSuffix { get; set; }

                            /// <summary>
                            /// <para>The sensitive keywords.</para>
                            /// </summary>
                            [NameInMap("keys")]
                            [Validation(Required=false)]
                            public List<string> Keys { get; set; }

                            /// <summary>
                            /// <para>The mask character.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <list type="bullet">
                            /// <item><description></description></item>
                            /// </list>
                            /// </summary>
                            [NameInMap("maskChar")]
                            [Validation(Required=false)]
                            public string MaskChar { get; set; }

                            /// <summary>
                            /// <para>The masking mode.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>keyword</para>
                            /// </summary>
                            [NameInMap("mode")]
                            [Validation(Required=false)]
                            public string Mode { get; set; }

                            /// <summary>
                            /// <para>The built-in sensitive types.</para>
                            /// </summary>
                            [NameInMap("types")]
                            [Validation(Required=false)]
                            public List<string> Types { get; set; }

                        }

                        /// <summary>
                        /// <para>The SPL script.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <list type="bullet">
                        /// <item><description>| extend latency_ms = duration / 1000000</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("script")]
                        [Validation(Required=false)]
                        public string Script { get; set; }

                        /// <summary>
                        /// <para>The service selector.</para>
                        /// </summary>
                        [NameInMap("selector")]
                        [Validation(Required=false)]
                        public ListDataPipelinesResponseBodyPipelinesOutputsProcessorsConfigSelector Selector { get; set; }
                        public class ListDataPipelinesResponseBodyPipelinesOutputsProcessorsConfigSelector : TeaModel {
                            /// <summary>
                            /// <para>The list of service names.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>[&quot;checkout-*&quot;,&quot;order-service&quot;]</para>
                            /// </summary>
                            [NameInMap("serviceNames")]
                            [Validation(Required=false)]
                            public List<string> ServiceNames { get; set; }

                        }

                        /// <summary>
                        /// <para>The processing target.</para>
                        /// </summary>
                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public ListDataPipelinesResponseBodyPipelinesOutputsProcessorsConfigTarget Target { get; set; }
                        public class ListDataPipelinesResponseBodyPipelinesOutputsProcessorsConfigTarget : TeaModel {
                            /// <summary>
                            /// <para>The target workspace.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>target-checkout-ws</para>
                            /// </summary>
                            [NameInMap("workspace")]
                            [Validation(Required=false)]
                            public string Workspace { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The name of the processor.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>drop-health-check</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the processor.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>filter</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the pipeline.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>export-traces-to-prod</para>
            /// </summary>
            [NameInMap("pipelineName")]
            [Validation(Required=false)]
            public string PipelineName { get; set; }

            /// <summary>
            /// <para>The common processors.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("processors")]
            [Validation(Required=false)]
            public List<ListDataPipelinesResponseBodyPipelinesProcessors> Processors { get; set; }
            public class ListDataPipelinesResponseBodyPipelinesProcessors : TeaModel {
                /// <summary>
                /// <para>The processor configuration.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public ListDataPipelinesResponseBodyPipelinesProcessorsConfig Config { get; set; }
                public class ListDataPipelinesResponseBodyPipelinesProcessorsConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of applications.</para>
                    /// </summary>
                    [NameInMap("applications")]
                    [Validation(Required=false)]
                    public List<string> Applications { get; set; }

                    /// <summary>
                    /// <para>The filter expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>attributes[&quot;http.route&quot;] != &quot;/health&quot;</para>
                    /// </summary>
                    [NameInMap("expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para>The list of fields.</para>
                    /// </summary>
                    [NameInMap("fields")]
                    [Validation(Required=false)]
                    public List<string> Fields { get; set; }

                    /// <summary>
                    /// <para>The list of masking rules.</para>
                    /// </summary>
                    [NameInMap("rules")]
                    [Validation(Required=false)]
                    public List<ListDataPipelinesResponseBodyPipelinesProcessorsConfigRules> Rules { get; set; }
                    public class ListDataPipelinesResponseBodyPipelinesProcessorsConfigRules : TeaModel {
                        /// <summary>
                        /// <para>The length of the prefix to keep.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("keepPrefix")]
                        [Validation(Required=false)]
                        public int? KeepPrefix { get; set; }

                        /// <summary>
                        /// <para>The length of the suffix to keep.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("keepSuffix")]
                        [Validation(Required=false)]
                        public int? KeepSuffix { get; set; }

                        /// <summary>
                        /// <para>The sensitive keywords.</para>
                        /// </summary>
                        [NameInMap("keys")]
                        [Validation(Required=false)]
                        public List<string> Keys { get; set; }

                        /// <summary>
                        /// <para>The mask character.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <list type="bullet">
                        /// <item><description></description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("maskChar")]
                        [Validation(Required=false)]
                        public string MaskChar { get; set; }

                        /// <summary>
                        /// <para>The masking mode.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>keyword</para>
                        /// </summary>
                        [NameInMap("mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// <para>The built-in sensitive types.</para>
                        /// </summary>
                        [NameInMap("types")]
                        [Validation(Required=false)]
                        public List<string> Types { get; set; }

                    }

                    /// <summary>
                    /// <para>The SPL script.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description>| extend latency_ms = duration / 1000000</description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("script")]
                    [Validation(Required=false)]
                    public string Script { get; set; }

                    /// <summary>
                    /// <para>The service selector.</para>
                    /// </summary>
                    [NameInMap("selector")]
                    [Validation(Required=false)]
                    public ListDataPipelinesResponseBodyPipelinesProcessorsConfigSelector Selector { get; set; }
                    public class ListDataPipelinesResponseBodyPipelinesProcessorsConfigSelector : TeaModel {
                        /// <summary>
                        /// <para>The list of service names.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[&quot;checkout-*&quot;,&quot;order-service&quot;]</para>
                        /// </summary>
                        [NameInMap("serviceNames")]
                        [Validation(Required=false)]
                        public List<string> ServiceNames { get; set; }

                    }

                    /// <summary>
                    /// <para>The processing target.</para>
                    /// </summary>
                    [NameInMap("target")]
                    [Validation(Required=false)]
                    public ListDataPipelinesResponseBodyPipelinesProcessorsConfigTarget Target { get; set; }
                    public class ListDataPipelinesResponseBodyPipelinesProcessorsConfigTarget : TeaModel {
                        /// <summary>
                        /// <para>The target workspace.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>target-checkout-ws</para>
                        /// </summary>
                        [NameInMap("workspace")]
                        [Validation(Required=false)]
                        public string Workspace { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the processor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drop-health-check</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the processor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filter</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The signal type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>traces</para>
            /// </summary>
            [NameInMap("signalType")]
            [Validation(Required=false)]
            public string SignalType { get; set; }

            /// <summary>
            /// <para>The output destinations.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sinks")]
            [Validation(Required=false)]
            public List<ListDataPipelinesResponseBodyPipelinesSinks> Sinks { get; set; }
            public class ListDataPipelinesResponseBodyPipelinesSinks : TeaModel {
                /// <summary>
                /// <para>The list of datasets.</para>
                /// </summary>
                [NameInMap("datasets")]
                [Validation(Required=false)]
                public List<string> Datasets { get; set; }

                /// <summary>
                /// <para>SLS Logstore</para>
                /// 
                /// <b>Example:</b>
                /// <para>error-spans</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the output destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>error-archive</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>SLS Project</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer-project</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The type of the output destination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>logstore</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The data source.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public ListDataPipelinesResponseBodyPipelinesSource Source { get; set; }
            public class ListDataPipelinesResponseBodyPipelinesSource : TeaModel {
                /// <summary>
                /// <para>The datasource config.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public ListDataPipelinesResponseBodyPipelinesSourceConfig Config { get; set; }
                public class ListDataPipelinesResponseBodyPipelinesSourceConfig : TeaModel {
                    /// <summary>
                    /// <para>The run mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>continuous</para>
                    /// </summary>
                    [NameInMap("runMode")]
                    [Validation(Required=false)]
                    public string RunMode { get; set; }

                    /// <summary>
                    /// <para>The read start point.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>latest</para>
                    /// </summary>
                    [NameInMap("startFrom")]
                    [Validation(Required=false)]
                    public string StartFrom { get; set; }

                    /// <summary>
                    /// <para>The backfill time range.</para>
                    /// </summary>
                    [NameInMap("timeRange")]
                    [Validation(Required=false)]
                    public ListDataPipelinesResponseBodyPipelinesSourceConfigTimeRange TimeRange { get; set; }
                    public class ListDataPipelinesResponseBodyPipelinesSourceConfigTimeRange : TeaModel {
                        /// <summary>
                        /// <para>The start time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1722844800</para>
                        /// </summary>
                        [NameInMap("from")]
                        [Validation(Required=false)]
                        public long? From { get; set; }

                        /// <summary>
                        /// <para>The end time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1722848400</para>
                        /// </summary>
                        [NameInMap("to")]
                        [Validation(Required=false)]
                        public long? To { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>traces-default</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The running status.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The status message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pipeline is running.</para>
            /// </summary>
            [NameInMap("statusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

            /// <summary>
            /// <para>The time when the pipeline was last updated.</para>
            /// <para>This parameter is required.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-10T05:10:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The configuration version.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of data pipelines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
