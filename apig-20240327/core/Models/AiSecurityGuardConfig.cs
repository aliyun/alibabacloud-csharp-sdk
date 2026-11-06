// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiSecurityGuardConfig : TeaModel {
        /// <summary>
        /// <para>The size of the response buffer in KB. Default value: 1000. Valid values: 1 to 1500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("bufferLimit")]
        [Validation(Required=false)]
        public int? BufferLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the request content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkRequest")]
        [Validation(Required=false)]
        public bool? CheckRequest { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the request images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("checkRequestImage")]
        [Validation(Required=false)]
        public bool? CheckRequestImage { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the response content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkResponse")]
        [Validation(Required=false)]
        public bool? CheckResponse { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the response images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("checkResponseImage")]
        [Validation(Required=false)]
        public bool? CheckResponseImage { get; set; }

        /// <summary>
        /// <para>The bindings between consumers and security guardrail configurations. An empty array explicitly clears the pending configurations.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("consumerConfigBindings")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerConfigBindings> ConsumerConfigBindings { get; set; }
        public class AiSecurityGuardConfigConsumerConfigBindings : TeaModel {
            /// <summary>
            /// <para>The match type for consumer names. Valid values: exact (exact match), prefix (prefix match), regexp (regular expression match), and all (matches any consumer). Rules of the all type must be placed at the end of the binding list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exact</para>
            /// </summary>
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The match condition for the consumer name. If matchType is exact, enter the full consumer name. If matchType is prefix, enter the name prefix. If matchType is regexp, enter a regular expression. The value cannot be empty for these three types. If matchType is all, the value must be an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-consumer</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the bound security guardrail configuration. This parameter cannot be empty. You can query the ID by calling the ListAiSecurityGuardConfigs operation and use the returned templateId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apig_0123456789abcdef</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The consumer-level request check service configuration.</para>
        /// </summary>
        [NameInMap("consumerRequestCheckService")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerRequestCheckService> ConsumerRequestCheckService { get; set; }
        public class AiSecurityGuardConfigConsumerRequestCheckService : TeaModel {
            /// <summary>
            /// <para>The consumer match type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exact</para>
            /// </summary>
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The modality type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Text</para>
            /// </summary>
            [NameInMap("modalityType")]
            [Validation(Required=false)]
            public string ModalityType { get; set; }

            /// <summary>
            /// <para>The consumer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>consumer-a</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The check service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>query_security_check</para>
            /// </summary>
            [NameInMap("requestCheckService")]
            [Validation(Required=false)]
            public string RequestCheckService { get; set; }

            /// <summary>
            /// <para>The image check service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img_query_guard</para>
            /// </summary>
            [NameInMap("requestImageCheckService")]
            [Validation(Required=false)]
            public string RequestImageCheckService { get; set; }

        }

        /// <summary>
        /// <para>The consumer-level response check service configuration.</para>
        /// </summary>
        [NameInMap("consumerResponseCheckService")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerResponseCheckService> ConsumerResponseCheckService { get; set; }
        public class AiSecurityGuardConfigConsumerResponseCheckService : TeaModel {
            /// <summary>
            /// <para>The consumer match type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exact</para>
            /// </summary>
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The modality type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Text</para>
            /// </summary>
            [NameInMap("modalityType")]
            [Validation(Required=false)]
            public string ModalityType { get; set; }

            /// <summary>
            /// <para>The consumer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>consumer-a</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The check service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>query_security_check</para>
            /// </summary>
            [NameInMap("responseCheckService")]
            [Validation(Required=false)]
            public string ResponseCheckService { get; set; }

            /// <summary>
            /// <para>The image check service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img_query_guard</para>
            /// </summary>
            [NameInMap("responseImageCheckService")]
            [Validation(Required=false)]
            public string ResponseImageCheckService { get; set; }

        }

        /// <summary>
        /// <para>The consumer-level risk level configuration.</para>
        /// </summary>
        [NameInMap("consumerRiskLevel")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerRiskLevel> ConsumerRiskLevel { get; set; }
        public class AiSecurityGuardConfigConsumerRiskLevel : TeaModel {
            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The consumer match type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exact</para>
            /// </summary>
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The consumer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>consumer-a</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The risk dimension type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ContentModeration</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the entire security guardrail policy is populated by default for this query. Returns true only for synthesized policies. For existing policies, returns false or is not returned. This is a read-only field. It is ignored upon submission, is not saved, and does not affect the start or stop status.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("defaultGenerated")]
        [Validation(Required=false)]
        public bool? DefaultGenerated { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the long-term solution. If omitted or set to null, the original value is retained during an update.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("longTermEnabled")]
        [Validation(Required=false)]
        public bool? LongTermEnabled { get; set; }

        /// <summary>
        /// <para>The running status of the plug-in.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>The ServiceCode of the request text check service. The system injects the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>query_security_check</para>
        /// </summary>
        [NameInMap("requestCheckService")]
        [Validation(Required=false)]
        public string RequestCheckService { get; set; }

        /// <summary>
        /// <para>The ServiceCode of the request image check service. The system injects the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img_query_guard</para>
        /// </summary>
        [NameInMap("requestImageCheckService")]
        [Validation(Required=false)]
        public string RequestImageCheckService { get; set; }

        /// <summary>
        /// <para>The ServiceCode of the response text check service. The system injects the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>response_security_check</para>
        /// </summary>
        [NameInMap("responseCheckService")]
        [Validation(Required=false)]
        public string ResponseCheckService { get; set; }

        /// <summary>
        /// <para>The ServiceCode of the response image check service. The system injects the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img_response_guard</para>
        /// </summary>
        [NameInMap("responseImageCheckService")]
        [Validation(Required=false)]
        public string ResponseImageCheckService { get; set; }

        /// <summary>
        /// <para>The global risk alert level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("riskAlertLevel")]
        [Validation(Required=false)]
        public string RiskAlertLevel { get; set; }

        /// <summary>
        /// <para>The list of risk dimension configurations. The system injects this list, which is generated by normalizing ConsumerRiskLevel.</para>
        /// </summary>
        [NameInMap("riskConfig")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigRiskConfig> RiskConfig { get; set; }
        public class AiSecurityGuardConfigRiskConfig : TeaModel {
            /// <summary>
            /// <para>The consumer-level match rules.</para>
            /// </summary>
            [NameInMap("consumerRules")]
            [Validation(Required=false)]
            public AiSecurityGuardConfigRiskConfigConsumerRules ConsumerRules { get; set; }
            public class AiSecurityGuardConfigRiskConfigConsumerRules : TeaModel {
                /// <summary>
                /// <para>The match type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("matchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>The consumer match pattern value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>consumer-a</para>
                /// </summary>
                [NameInMap("pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

            }

            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The risk dimension type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ContentModeration</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The address of the security guardrail service, which is the green-cip endpoint. If the gateway and the security guardrail are in the same region, use the VPC internal network address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://green-cip-vpc.cn-shanghai.aliyuncs.com">https://green-cip-vpc.cn-shanghai.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("serviceAddress")]
        [Validation(Required=false)]
        public string ServiceAddress { get; set; }

    }

}
