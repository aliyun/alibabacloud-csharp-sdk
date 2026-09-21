// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateDataPipelineRequest : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>export</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The named outputs.</para>
        /// </summary>
        [NameInMap("outputs")]
        [Validation(Required=false)]
        public List<CreateDataPipelineRequestOutputs> Outputs { get; set; }
        public class CreateDataPipelineRequestOutputs : TeaModel {
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
            public List<CreateDataPipelineRequestOutputsProcessors> Processors { get; set; }
            public class CreateDataPipelineRequestOutputsProcessors : TeaModel {
                /// <summary>
                /// <para>The processor configuration.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public CreateDataPipelineRequestOutputsProcessorsConfig Config { get; set; }
                public class CreateDataPipelineRequestOutputsProcessorsConfig : TeaModel {
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
                    public List<CreateDataPipelineRequestOutputsProcessorsConfigAssignments> Assignments { get; set; }
                    public class CreateDataPipelineRequestOutputsProcessorsConfigAssignments : TeaModel {
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
                    public List<CreateDataPipelineRequestOutputsProcessorsConfigProjections> Projections { get; set; }
                    public class CreateDataPipelineRequestOutputsProcessorsConfigProjections : TeaModel {
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
                    public List<CreateDataPipelineRequestOutputsProcessorsConfigRules> Rules { get; set; }
                    public class CreateDataPipelineRequestOutputsProcessorsConfigRules : TeaModel {
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
                    public CreateDataPipelineRequestOutputsProcessorsConfigScope Scope { get; set; }
                    public class CreateDataPipelineRequestOutputsProcessorsConfigScope : TeaModel {
                        /// <summary>
                        /// <para>The additional field conditions.</para>
                        /// </summary>
                        [NameInMap("conditions")]
                        [Validation(Required=false)]
                        public List<CreateDataPipelineRequestOutputsProcessorsConfigScopeConditions> Conditions { get; set; }
                        public class CreateDataPipelineRequestOutputsProcessorsConfigScopeConditions : TeaModel {
                            /// <summary>
                            /// <para>The field reference.</para>
                            /// </summary>
                            [NameInMap("field")]
                            [Validation(Required=false)]
                            public CreateDataPipelineRequestOutputsProcessorsConfigScopeConditionsField Field { get; set; }
                            public class CreateDataPipelineRequestOutputsProcessorsConfigScopeConditionsField : TeaModel {
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
                                /// <para>label</para>
                                /// </summary>
                                [NameInMap("kind")]
                                [Validation(Required=false)]
                                public string Kind { get; set; }

                                /// <summary>
                                /// <para>The field or dimension name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>serviceName</para>
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
                        public CreateDataPipelineRequestOutputsProcessorsConfigScopeMetricName MetricName { get; set; }
                        public class CreateDataPipelineRequestOutputsProcessorsConfigScopeMetricName : TeaModel {
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
                        public CreateDataPipelineRequestOutputsProcessorsConfigScopeServiceName ServiceName { get; set; }
                        public class CreateDataPipelineRequestOutputsProcessorsConfigScopeServiceName : TeaModel {
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
                    public CreateDataPipelineRequestOutputsProcessorsConfigSelector Selector { get; set; }
                    public class CreateDataPipelineRequestOutputsProcessorsConfigSelector : TeaModel {
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
                    public CreateDataPipelineRequestOutputsProcessorsConfigTarget Target { get; set; }
                    public class CreateDataPipelineRequestOutputsProcessorsConfigTarget : TeaModel {
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
        /// <para>export-traces-to-prod</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The common processors.</para>
        /// </summary>
        [NameInMap("processors")]
        [Validation(Required=false)]
        public List<CreateDataPipelineRequestProcessors> Processors { get; set; }
        public class CreateDataPipelineRequestProcessors : TeaModel {
            /// <summary>
            /// <para>The processor configuration.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public CreateDataPipelineRequestProcessorsConfig Config { get; set; }
            public class CreateDataPipelineRequestProcessorsConfig : TeaModel {
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
                public List<CreateDataPipelineRequestProcessorsConfigAssignments> Assignments { get; set; }
                public class CreateDataPipelineRequestProcessorsConfigAssignments : TeaModel {
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
                public List<CreateDataPipelineRequestProcessorsConfigProjections> Projections { get; set; }
                public class CreateDataPipelineRequestProcessorsConfigProjections : TeaModel {
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
                public List<CreateDataPipelineRequestProcessorsConfigRules> Rules { get; set; }
                public class CreateDataPipelineRequestProcessorsConfigRules : TeaModel {
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
                /// <para>The pipeline processing scope in which the processor takes effect.</para>
                /// </summary>
                [NameInMap("scope")]
                [Validation(Required=false)]
                public CreateDataPipelineRequestProcessorsConfigScope Scope { get; set; }
                public class CreateDataPipelineRequestProcessorsConfigScope : TeaModel {
                    /// <summary>
                    /// <para>The additional field conditions.</para>
                    /// </summary>
                    [NameInMap("conditions")]
                    [Validation(Required=false)]
                    public List<CreateDataPipelineRequestProcessorsConfigScopeConditions> Conditions { get; set; }
                    public class CreateDataPipelineRequestProcessorsConfigScopeConditions : TeaModel {
                        /// <summary>
                        /// <para>The field reference.</para>
                        /// </summary>
                        [NameInMap("field")]
                        [Validation(Required=false)]
                        public CreateDataPipelineRequestProcessorsConfigScopeConditionsField Field { get; set; }
                        public class CreateDataPipelineRequestProcessorsConfigScopeConditionsField : TeaModel {
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
                            /// <para>serviceName</para>
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
                    public CreateDataPipelineRequestProcessorsConfigScopeMetricName MetricName { get; set; }
                    public class CreateDataPipelineRequestProcessorsConfigScopeMetricName : TeaModel {
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
                    public CreateDataPipelineRequestProcessorsConfigScopeServiceName ServiceName { get; set; }
                    public class CreateDataPipelineRequestProcessorsConfigScopeServiceName : TeaModel {
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
                public CreateDataPipelineRequestProcessorsConfigSelector Selector { get; set; }
                public class CreateDataPipelineRequestProcessorsConfigSelector : TeaModel {
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
                public CreateDataPipelineRequestProcessorsConfigTarget Target { get; set; }
                public class CreateDataPipelineRequestProcessorsConfigTarget : TeaModel {
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
        public List<CreateDataPipelineRequestSinks> Sinks { get; set; }
        public class CreateDataPipelineRequestSinks : TeaModel {
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
        public CreateDataPipelineRequestSource Source { get; set; }
        public class CreateDataPipelineRequestSource : TeaModel {
            /// <summary>
            /// <para>The datasource config.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public CreateDataPipelineRequestSourceConfig Config { get; set; }
            public class CreateDataPipelineRequestSourceConfig : TeaModel {
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
                public CreateDataPipelineRequestSourceConfigTimeRange TimeRange { get; set; }
                public class CreateDataPipelineRequestSourceConfigTimeRange : TeaModel {
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

    }

}
