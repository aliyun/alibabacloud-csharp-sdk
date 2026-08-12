// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateDataPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The data pipeline.</para>
        /// </summary>
        [NameInMap("pipeline")]
        [Validation(Required=false)]
        public CreateDataPipelineResponseBodyPipeline Pipeline { get; set; }
        public class CreateDataPipelineResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
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
            /// <para>The pipeline description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Export selected trace services to the target workspace.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The pipeline type.</para>
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
            public List<CreateDataPipelineResponseBodyPipelineOutputs> Outputs { get; set; }
            public class CreateDataPipelineResponseBodyPipelineOutputs : TeaModel {
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
                public List<CreateDataPipelineResponseBodyPipelineOutputsProcessors> Processors { get; set; }
                public class CreateDataPipelineResponseBodyPipelineOutputsProcessors : TeaModel {
                    /// <summary>
                    /// <para>The processor configuration.</para>
                    /// </summary>
                    [NameInMap("config")]
                    [Validation(Required=false)]
                    public CreateDataPipelineResponseBodyPipelineOutputsProcessorsConfig Config { get; set; }
                    public class CreateDataPipelineResponseBodyPipelineOutputsProcessorsConfig : TeaModel {
                        /// <summary>
                        /// <para>The application list.</para>
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
                        /// <para>The field list.</para>
                        /// </summary>
                        [NameInMap("fields")]
                        [Validation(Required=false)]
                        public List<string> Fields { get; set; }

                        /// <summary>
                        /// <para>The masking rule list.</para>
                        /// </summary>
                        [NameInMap("rules")]
                        [Validation(Required=false)]
                        public List<CreateDataPipelineResponseBodyPipelineOutputsProcessorsConfigRules> Rules { get; set; }
                        public class CreateDataPipelineResponseBodyPipelineOutputsProcessorsConfigRules : TeaModel {
                            /// <summary>
                            /// <para>The length of the prefix to retain.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("keepPrefix")]
                            [Validation(Required=false)]
                            public int? KeepPrefix { get; set; }

                            /// <summary>
                            /// <para>The length of the suffix to retain.</para>
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
                        public CreateDataPipelineResponseBodyPipelineOutputsProcessorsConfigSelector Selector { get; set; }
                        public class CreateDataPipelineResponseBodyPipelineOutputsProcessorsConfigSelector : TeaModel {
                            /// <summary>
                            /// <para>The service name list.</para>
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
                        public CreateDataPipelineResponseBodyPipelineOutputsProcessorsConfigTarget Target { get; set; }
                        public class CreateDataPipelineResponseBodyPipelineOutputsProcessorsConfigTarget : TeaModel {
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
                    /// <para>The processor name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>drop-health-check</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The processor type.</para>
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
            /// <para>The pipeline name.</para>
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
            public List<CreateDataPipelineResponseBodyPipelineProcessors> Processors { get; set; }
            public class CreateDataPipelineResponseBodyPipelineProcessors : TeaModel {
                /// <summary>
                /// <para>The processor configuration.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public CreateDataPipelineResponseBodyPipelineProcessorsConfig Config { get; set; }
                public class CreateDataPipelineResponseBodyPipelineProcessorsConfig : TeaModel {
                    /// <summary>
                    /// <para>The application list.</para>
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
                    /// <para>The field list.</para>
                    /// </summary>
                    [NameInMap("fields")]
                    [Validation(Required=false)]
                    public List<string> Fields { get; set; }

                    /// <summary>
                    /// <para>The masking rule list.</para>
                    /// </summary>
                    [NameInMap("rules")]
                    [Validation(Required=false)]
                    public List<CreateDataPipelineResponseBodyPipelineProcessorsConfigRules> Rules { get; set; }
                    public class CreateDataPipelineResponseBodyPipelineProcessorsConfigRules : TeaModel {
                        /// <summary>
                        /// <para>The length of the prefix to retain.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("keepPrefix")]
                        [Validation(Required=false)]
                        public int? KeepPrefix { get; set; }

                        /// <summary>
                        /// <para>The length of the suffix to retain.</para>
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
                    public CreateDataPipelineResponseBodyPipelineProcessorsConfigSelector Selector { get; set; }
                    public class CreateDataPipelineResponseBodyPipelineProcessorsConfigSelector : TeaModel {
                        /// <summary>
                        /// <para>The service name list.</para>
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
                    public CreateDataPipelineResponseBodyPipelineProcessorsConfigTarget Target { get; set; }
                    public class CreateDataPipelineResponseBodyPipelineProcessorsConfigTarget : TeaModel {
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
                /// <para>The processor name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drop-health-check</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The processor type.</para>
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
            public List<CreateDataPipelineResponseBodyPipelineSinks> Sinks { get; set; }
            public class CreateDataPipelineResponseBodyPipelineSinks : TeaModel {
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
            public CreateDataPipelineResponseBodyPipelineSource Source { get; set; }
            public class CreateDataPipelineResponseBodyPipelineSource : TeaModel {
                /// <summary>
                /// <para>The datasource config.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public CreateDataPipelineResponseBodyPipelineSourceConfig Config { get; set; }
                public class CreateDataPipelineResponseBodyPipelineSourceConfig : TeaModel {
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
                    public CreateDataPipelineResponseBodyPipelineSourceConfigTimeRange TimeRange { get; set; }
                    public class CreateDataPipelineResponseBodyPipelineSourceConfigTimeRange : TeaModel {
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
                /// <para>The data source type.</para>
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
            /// <para>The update time.</para>
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

    }

}
