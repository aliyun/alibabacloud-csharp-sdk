// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PreviewDataPipelineRequest : TeaModel {
        /// <summary>
        /// <para>The pipeline description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Preview error span routing.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The start time of the preview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784563200</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The pipeline type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The named outputs.</para>
        /// </summary>
        [NameInMap("outputs")]
        [Validation(Required=false)]
        public List<PreviewDataPipelineRequestOutputs> Outputs { get; set; }
        public class PreviewDataPipelineRequestOutputs : TeaModel {
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
            public List<PreviewDataPipelineRequestOutputsProcessors> Processors { get; set; }
            public class PreviewDataPipelineRequestOutputsProcessors : TeaModel {
                /// <summary>
                /// <para>The processor configuration.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public PreviewDataPipelineRequestOutputsProcessorsConfig Config { get; set; }
                public class PreviewDataPipelineRequestOutputsProcessorsConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of applications.</para>
                    /// </summary>
                    [NameInMap("applications")]
                    [Validation(Required=false)]
                    public List<string> Applications { get; set; }

                    /// <summary>
                    /// <para>The list of field assignments.</para>
                    /// </summary>
                    [NameInMap("assignments")]
                    [Validation(Required=false)]
                    public List<PreviewDataPipelineRequestOutputsProcessorsConfigAssignments> Assignments { get; set; }
                    public class PreviewDataPipelineRequestOutputsProcessorsConfigAssignments : TeaModel {
                        /// <summary>
                        /// <para>The assignment expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>duration / 1000000.0</para>
                        /// </summary>
                        [NameInMap("expression")]
                        [Validation(Required=false)]
                        public string Expression { get; set; }

                        /// <summary>
                        /// <para>The output field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>latency_ms</para>
                        /// </summary>
                        [NameInMap("field")]
                        [Validation(Required=false)]
                        public string Field { get; set; }

                    }

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
                    /// <para>The extended parameters.</para>
                    /// </summary>
                    [NameInMap("parameters")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Parameters { get; set; }

                    /// <summary>
                    /// <para>The list of field projections.</para>
                    /// </summary>
                    [NameInMap("projections")]
                    [Validation(Required=false)]
                    public List<PreviewDataPipelineRequestOutputsProcessorsConfigProjections> Projections { get; set; }
                    public class PreviewDataPipelineRequestOutputsProcessorsConfigProjections : TeaModel {
                        /// <summary>
                        /// <para>The source field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>serviceName</para>
                        /// </summary>
                        [NameInMap("source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                        /// <summary>
                        /// <para>The target field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>service</para>
                        /// </summary>
                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public string Target { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of masking rules.</para>
                    /// </summary>
                    [NameInMap("rules")]
                    [Validation(Required=false)]
                    public List<PreviewDataPipelineRequestOutputsProcessorsConfigRules> Rules { get; set; }
                    public class PreviewDataPipelineRequestOutputsProcessorsConfigRules : TeaModel {
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
                    /// <para>The pipeline processing scope.</para>
                    /// </summary>
                    [NameInMap("scope")]
                    [Validation(Required=false)]
                    public PreviewDataPipelineRequestOutputsProcessorsConfigScope Scope { get; set; }
                    public class PreviewDataPipelineRequestOutputsProcessorsConfigScope : TeaModel {
                        /// <summary>
                        /// <para>The additional field conditions.</para>
                        /// </summary>
                        [NameInMap("conditions")]
                        [Validation(Required=false)]
                        public List<PreviewDataPipelineRequestOutputsProcessorsConfigScopeConditions> Conditions { get; set; }
                        public class PreviewDataPipelineRequestOutputsProcessorsConfigScopeConditions : TeaModel {
                            /// <summary>
                            /// <para>The field reference.</para>
                            /// </summary>
                            [NameInMap("field")]
                            [Validation(Required=false)]
                            public PreviewDataPipelineRequestOutputsProcessorsConfigScopeConditionsField Field { get; set; }
                            public class PreviewDataPipelineRequestOutputsProcessorsConfigScopeConditionsField : TeaModel {
                                /// <summary>
                                /// <para>The JSON object container.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>attributes</para>
                                /// </summary>
                                [NameInMap("container")]
                                [Validation(Required=false)]
                                public string Container { get; set; }

                                /// <summary>
                                /// <para>The reference data type.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>field</para>
                                /// </summary>
                                [NameInMap("kind")]
                                [Validation(Required=false)]
                                public string Kind { get; set; }

                                /// <summary>
                                /// <para>The field or dimension name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>service.name</para>
                                /// </summary>
                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// <para>The JSON literal key path.</para>
                                /// </summary>
                                [NameInMap("path")]
                                [Validation(Required=false)]
                                public List<string> Path { get; set; }

                            }

                            /// <summary>
                            /// <para>The matching method.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>EXACT</para>
                            /// </summary>
                            [NameInMap("matchType")]
                            [Validation(Required=false)]
                            public string MatchType { get; set; }

                            /// <summary>
                            /// <para>The match values.</para>
                            /// </summary>
                            [NameInMap("values")]
                            [Validation(Required=false)]
                            public List<string> Values { get; set; }

                        }

                        /// <summary>
                        /// <para>The metric name scope.</para>
                        /// </summary>
                        [NameInMap("metricName")]
                        [Validation(Required=false)]
                        public PreviewDataPipelineRequestOutputsProcessorsConfigScopeMetricName MetricName { get; set; }
                        public class PreviewDataPipelineRequestOutputsProcessorsConfigScopeMetricName : TeaModel {
                            /// <summary>
                            /// <para>The matching method.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>EXACT</para>
                            /// </summary>
                            [NameInMap("matchType")]
                            [Validation(Required=false)]
                            public string MatchType { get; set; }

                            /// <summary>
                            /// <para>The metric names.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>[&quot;http_requests_total&quot;]</para>
                            /// </summary>
                            [NameInMap("values")]
                            [Validation(Required=false)]
                            public List<string> Values { get; set; }

                        }

                        /// <summary>
                        /// <para>The service name scope.</para>
                        /// </summary>
                        [NameInMap("serviceName")]
                        [Validation(Required=false)]
                        public PreviewDataPipelineRequestOutputsProcessorsConfigScopeServiceName ServiceName { get; set; }
                        public class PreviewDataPipelineRequestOutputsProcessorsConfigScopeServiceName : TeaModel {
                            /// <summary>
                            /// <para>The matching method.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>EXACT</para>
                            /// </summary>
                            [NameInMap("matchType")]
                            [Validation(Required=false)]
                            public string MatchType { get; set; }

                            /// <summary>
                            /// <para>The match values.</para>
                            /// </summary>
                            [NameInMap("values")]
                            [Validation(Required=false)]
                            public List<string> Values { get; set; }

                        }

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
                    public PreviewDataPipelineRequestOutputsProcessorsConfigSelector Selector { get; set; }
                    public class PreviewDataPipelineRequestOutputsProcessorsConfigSelector : TeaModel {
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
                    public PreviewDataPipelineRequestOutputsProcessorsConfigTarget Target { get; set; }
                    public class PreviewDataPipelineRequestOutputsProcessorsConfigTarget : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>trace-archive-routing</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The common processors.</para>
        /// </summary>
        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<PreviewDataPipelineRequestProcessors> Processors { get; set; }
        public class PreviewDataPipelineRequestProcessors : TeaModel {
            /// <summary>
            /// <para>The processor configuration.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public PreviewDataPipelineRequestProcessorsConfig Config { get; set; }
            public class PreviewDataPipelineRequestProcessorsConfig : TeaModel {
                /// <summary>
                /// <para>The list of applications.</para>
                /// </summary>
                [NameInMap("applications")]
                [Validation(Required=false)]
                public List<string> Applications { get; set; }

                /// <summary>
                /// <para>The list of field assignments.</para>
                /// </summary>
                [NameInMap("assignments")]
                [Validation(Required=false)]
                public List<PreviewDataPipelineRequestProcessorsConfigAssignments> Assignments { get; set; }
                public class PreviewDataPipelineRequestProcessorsConfigAssignments : TeaModel {
                    /// <summary>
                    /// <para>The assignment expression.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>duration / 1000000.0</para>
                    /// </summary>
                    [NameInMap("expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para>The output field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>latency_ms</para>
                    /// </summary>
                    [NameInMap("field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                }

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
                /// <para>The extended parameters.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The list of field projections.</para>
                /// </summary>
                [NameInMap("projections")]
                [Validation(Required=false)]
                public List<PreviewDataPipelineRequestProcessorsConfigProjections> Projections { get; set; }
                public class PreviewDataPipelineRequestProcessorsConfigProjections : TeaModel {
                    /// <summary>
                    /// <para>The source field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>serviceName</para>
                    /// </summary>
                    [NameInMap("source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// <para>The target field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>service</para>
                    /// </summary>
                    [NameInMap("target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                }

                /// <summary>
                /// <para>The list of masking rules.</para>
                /// </summary>
                [NameInMap("rules")]
                [Validation(Required=false)]
                public List<PreviewDataPipelineRequestProcessorsConfigRules> Rules { get; set; }
                public class PreviewDataPipelineRequestProcessorsConfigRules : TeaModel {
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
                /// <para>The scope in which pipeline processing takes effect.</para>
                /// </summary>
                [NameInMap("scope")]
                [Validation(Required=false)]
                public PreviewDataPipelineRequestProcessorsConfigScope Scope { get; set; }
                public class PreviewDataPipelineRequestProcessorsConfigScope : TeaModel {
                    /// <summary>
                    /// <para>The additional field conditions.</para>
                    /// </summary>
                    [NameInMap("conditions")]
                    [Validation(Required=false)]
                    public List<PreviewDataPipelineRequestProcessorsConfigScopeConditions> Conditions { get; set; }
                    public class PreviewDataPipelineRequestProcessorsConfigScopeConditions : TeaModel {
                        /// <summary>
                        /// <para>The field reference.</para>
                        /// </summary>
                        [NameInMap("field")]
                        [Validation(Required=false)]
                        public PreviewDataPipelineRequestProcessorsConfigScopeConditionsField Field { get; set; }
                        public class PreviewDataPipelineRequestProcessorsConfigScopeConditionsField : TeaModel {
                            /// <summary>
                            /// <para>The JSON object container.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>resources</para>
                            /// </summary>
                            [NameInMap("container")]
                            [Validation(Required=false)]
                            public string Container { get; set; }

                            /// <summary>
                            /// <para>The reference data type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>field</para>
                            /// </summary>
                            [NameInMap("kind")]
                            [Validation(Required=false)]
                            public string Kind { get; set; }

                            /// <summary>
                            /// <para>The field or dimension name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>service.name</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The JSON literal key path.</para>
                            /// </summary>
                            [NameInMap("path")]
                            [Validation(Required=false)]
                            public List<string> Path { get; set; }

                        }

                        /// <summary>
                        /// <para>The matching method.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EXACT</para>
                        /// </summary>
                        [NameInMap("matchType")]
                        [Validation(Required=false)]
                        public string MatchType { get; set; }

                        /// <summary>
                        /// <para>The match values.</para>
                        /// </summary>
                        [NameInMap("values")]
                        [Validation(Required=false)]
                        public List<string> Values { get; set; }

                    }

                    /// <summary>
                    /// <para>The metric name scope.</para>
                    /// </summary>
                    [NameInMap("metricName")]
                    [Validation(Required=false)]
                    public PreviewDataPipelineRequestProcessorsConfigScopeMetricName MetricName { get; set; }
                    public class PreviewDataPipelineRequestProcessorsConfigScopeMetricName : TeaModel {
                        /// <summary>
                        /// <para>The matching method.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EXACT</para>
                        /// </summary>
                        [NameInMap("matchType")]
                        [Validation(Required=false)]
                        public string MatchType { get; set; }

                        /// <summary>
                        /// <para>The metric names.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[&quot;http_requests_total&quot;]</para>
                        /// </summary>
                        [NameInMap("values")]
                        [Validation(Required=false)]
                        public List<string> Values { get; set; }

                    }

                    /// <summary>
                    /// <para>The service name scope.</para>
                    /// </summary>
                    [NameInMap("serviceName")]
                    [Validation(Required=false)]
                    public PreviewDataPipelineRequestProcessorsConfigScopeServiceName ServiceName { get; set; }
                    public class PreviewDataPipelineRequestProcessorsConfigScopeServiceName : TeaModel {
                        /// <summary>
                        /// <para>The matching method.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EXACT</para>
                        /// </summary>
                        [NameInMap("matchType")]
                        [Validation(Required=false)]
                        public string MatchType { get; set; }

                        /// <summary>
                        /// <para>The match values.</para>
                        /// </summary>
                        [NameInMap("values")]
                        [Validation(Required=false)]
                        public List<string> Values { get; set; }

                    }

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
                public PreviewDataPipelineRequestProcessorsConfigSelector Selector { get; set; }
                public class PreviewDataPipelineRequestProcessorsConfigSelector : TeaModel {
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
                public PreviewDataPipelineRequestProcessorsConfigTarget Target { get; set; }
                public class PreviewDataPipelineRequestProcessorsConfigTarget : TeaModel {
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
        /// <para>The output destinations.</para>
        /// </summary>
        [NameInMap("sinks")]
        [Validation(Required=false)]
        public List<PreviewDataPipelineRequestSinks> Sinks { get; set; }
        public class PreviewDataPipelineRequestSinks : TeaModel {
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
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public PreviewDataPipelineRequestSource Source { get; set; }
        public class PreviewDataPipelineRequestSource : TeaModel {
            /// <summary>
            /// <para>The datasource config.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public PreviewDataPipelineRequestSourceConfig Config { get; set; }
            public class PreviewDataPipelineRequestSourceConfig : TeaModel {
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
                public PreviewDataPipelineRequestSourceConfigTimeRange TimeRange { get; set; }
                public class PreviewDataPipelineRequestSourceConfigTimeRange : TeaModel {
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
        /// <para>The end time for the preview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784566800</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
