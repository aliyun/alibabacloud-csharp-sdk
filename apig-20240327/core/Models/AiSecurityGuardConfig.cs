// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiSecurityGuardConfig : TeaModel {
        /// <summary>
        /// <para>The response buffer size in KB. Default value: 1000. Valid values: 1 to 1500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("bufferLimit")]
        [Validation(Required=false)]
        public int? BufferLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to check request content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkRequest")]
        [Validation(Required=false)]
        public bool? CheckRequest { get; set; }

        /// <summary>
        /// <para>Specifies whether to check request images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("checkRequestImage")]
        [Validation(Required=false)]
        public bool? CheckRequestImage { get; set; }

        /// <summary>
        /// <para>Specifies whether to check response content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkResponse")]
        [Validation(Required=false)]
        public bool? CheckResponse { get; set; }

        /// <summary>
        /// <para>Specifies whether to check response images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("checkResponseImage")]
        [Validation(Required=false)]
        public bool? CheckResponseImage { get; set; }

        /// <summary>
        /// <para>The consumer-level request detection service configuration.</para>
        /// </summary>
        [NameInMap("consumerRequestCheckService")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerRequestCheckService> ConsumerRequestCheckService { get; set; }
        public class AiSecurityGuardConfigConsumerRequestCheckService : TeaModel {
            /// <summary>
            /// <para>The consumer matching method.</para>
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
        /// <para>The consumer-level response detection service configuration.</para>
        /// </summary>
        [NameInMap("consumerResponseCheckService")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerResponseCheckService> ConsumerResponseCheckService { get; set; }
        public class AiSecurityGuardConfigConsumerResponseCheckService : TeaModel {
            /// <summary>
            /// <para>The consumer matching method.</para>
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
            /// <para>The consumer matching method.</para>
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
        /// <para>The plugin running status.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>The ServiceCode of the request text detection service (system-injected default value).</para>
        /// 
        /// <b>Example:</b>
        /// <para>query_security_check</para>
        /// </summary>
        [NameInMap("requestCheckService")]
        [Validation(Required=false)]
        public string RequestCheckService { get; set; }

        /// <summary>
        /// <para>The ServiceCode of the request image detection service (system-injected default value).</para>
        /// 
        /// <b>Example:</b>
        /// <para>img_query_guard</para>
        /// </summary>
        [NameInMap("requestImageCheckService")]
        [Validation(Required=false)]
        public string RequestImageCheckService { get; set; }

        /// <summary>
        /// <para>The ServiceCode of the response text detection service (system-injected default value).</para>
        /// 
        /// <b>Example:</b>
        /// <para>response_security_check</para>
        /// </summary>
        [NameInMap("responseCheckService")]
        [Validation(Required=false)]
        public string ResponseCheckService { get; set; }

        /// <summary>
        /// <para>The ServiceCode of the response image detection service (system-injected default value).</para>
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
        /// <para>The risk dimension configuration list (system-injected, normalized from ConsumerRiskLevel).</para>
        /// </summary>
        [NameInMap("riskConfig")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigRiskConfig> RiskConfig { get; set; }
        public class AiSecurityGuardConfigRiskConfig : TeaModel {
            /// <summary>
            /// <para>The consumer-level matching rules.</para>
            /// </summary>
            [NameInMap("consumerRules")]
            [Validation(Required=false)]
            public AiSecurityGuardConfigRiskConfigConsumerRules ConsumerRules { get; set; }
            public class AiSecurityGuardConfigRiskConfigConsumerRules : TeaModel {
                /// <summary>
                /// <para>The matching method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("matchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>The consumer matching pattern value.</para>
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
        /// <para>The security guardrail service address (green-cip endpoint). Use the VPC internal address when the gateway and security guardrail are in the same region.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://green-cip-vpc.cn-shanghai.aliyuncs.com">https://green-cip-vpc.cn-shanghai.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("serviceAddress")]
        [Validation(Required=false)]
        public string ServiceAddress { get; set; }

    }

}
