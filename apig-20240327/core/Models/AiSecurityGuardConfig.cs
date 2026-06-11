// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiSecurityGuardConfig : TeaModel {
        /// <summary>
        /// <para>The buffer limit in bytes for streaming content checks. The service buffers content up to this limit before sending it for analysis.</para>
        /// </summary>
        [NameInMap("bufferLimit")]
        [Validation(Required=false)]
        public int? BufferLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the content of incoming requests.</para>
        /// </summary>
        [NameInMap("checkRequest")]
        [Validation(Required=false)]
        public bool? CheckRequest { get; set; }

        /// <summary>
        /// <para>Specifies whether to check incoming requests for image content. Requires <c>checkRequest</c> to be <c>true</c>.</para>
        /// </summary>
        [NameInMap("checkRequestImage")]
        [Validation(Required=false)]
        public bool? CheckRequestImage { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the content of outgoing responses.</para>
        /// </summary>
        [NameInMap("checkResponse")]
        [Validation(Required=false)]
        public bool? CheckResponse { get; set; }

        /// <summary>
        /// <para>Specifies whether to check outgoing responses for image content. Requires <c>checkResponse</c> to be <c>true</c>.</para>
        /// </summary>
        [NameInMap("checkResponseImage")]
        [Validation(Required=false)]
        public bool? CheckResponseImage { get; set; }

        /// <summary>
        /// <para>Specifies consumer-specific configurations for the request check service.</para>
        /// </summary>
        [NameInMap("consumerRequestCheckService")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerRequestCheckService> ConsumerRequestCheckService { get; set; }
        public class AiSecurityGuardConfigConsumerRequestCheckService : TeaModel {
            /// <summary>
            /// <para>The match type for identifying the consumer. For example: <c>header</c> or <c>query</c>.</para>
            /// </summary>
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The modality type for this rule. For example: <c>text</c> or <c>image</c>.</para>
            /// </summary>
            [NameInMap("modalityType")]
            [Validation(Required=false)]
            public string ModalityType { get; set; }

            /// <summary>
            /// <para>The identifier of the consumer.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The identifier of the request check service for text content for this consumer.</para>
            /// </summary>
            [NameInMap("requestCheckService")]
            [Validation(Required=false)]
            public string RequestCheckService { get; set; }

            /// <summary>
            /// <para>The identifier of the request check service for image content for this consumer.</para>
            /// </summary>
            [NameInMap("requestImageCheckService")]
            [Validation(Required=false)]
            public string RequestImageCheckService { get; set; }

        }

        /// <summary>
        /// <para>Specifies consumer-specific configurations for the response check service.</para>
        /// </summary>
        [NameInMap("consumerResponseCheckService")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerResponseCheckService> ConsumerResponseCheckService { get; set; }
        public class AiSecurityGuardConfigConsumerResponseCheckService : TeaModel {
            /// <summary>
            /// <para>The match type for identifying the consumer. For example: <c>header</c> or <c>query</c>.</para>
            /// </summary>
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The modality type for this rule. For example: <c>text</c> or <c>image</c>.</para>
            /// </summary>
            [NameInMap("modalityType")]
            [Validation(Required=false)]
            public string ModalityType { get; set; }

            /// <summary>
            /// <para>The identifier of the consumer.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The identifier of the response check service for text content for this consumer.</para>
            /// </summary>
            [NameInMap("responseCheckService")]
            [Validation(Required=false)]
            public string ResponseCheckService { get; set; }

            /// <summary>
            /// <para>The identifier of the response check service for image content for this consumer.</para>
            /// </summary>
            [NameInMap("responseImageCheckService")]
            [Validation(Required=false)]
            public string ResponseImageCheckService { get; set; }

        }

        /// <summary>
        /// <para>Specifies customized risk thresholds for different consumers.</para>
        /// </summary>
        [NameInMap("consumerRiskLevel")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerRiskLevel> ConsumerRiskLevel { get; set; }
        public class AiSecurityGuardConfigConsumerRiskLevel : TeaModel {
            /// <summary>
            /// <para>The risk level to apply to the specified consumer and risk type. For example: <c>low</c>, <c>medium</c>, or <c>high</c>.</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The match type for identifying the consumer. For example: <c>header</c> or <c>query</c>.</para>
            /// </summary>
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The identifier of the consumer.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of risk to configure. For example: <c>profanity</c> or <c>spam</c>.</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Controls whether the AI Security Guard plugin is enabled or disabled.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        /// <summary>
        /// <para>The identifier of the request check service for text content.</para>
        /// </summary>
        [NameInMap("requestCheckService")]
        [Validation(Required=false)]
        public string RequestCheckService { get; set; }

        /// <summary>
        /// <para>The identifier of the request check service for image content.</para>
        /// </summary>
        [NameInMap("requestImageCheckService")]
        [Validation(Required=false)]
        public string RequestImageCheckService { get; set; }

        /// <summary>
        /// <para>The identifier of the response check service for text content.</para>
        /// </summary>
        [NameInMap("responseCheckService")]
        [Validation(Required=false)]
        public string ResponseCheckService { get; set; }

        /// <summary>
        /// <para>The identifier of the response check service for image content.</para>
        /// </summary>
        [NameInMap("responseImageCheckService")]
        [Validation(Required=false)]
        public string ResponseImageCheckService { get; set; }

        /// <summary>
        /// <para>The risk alert level. The service triggers an alert when a detected risk meets or exceeds this level.</para>
        /// </summary>
        [NameInMap("riskAlertLevel")]
        [Validation(Required=false)]
        public string RiskAlertLevel { get; set; }

        /// <summary>
        /// <para>Specifies general risk configurations.</para>
        /// </summary>
        [NameInMap("riskConfig")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigRiskConfig> RiskConfig { get; set; }
        public class AiSecurityGuardConfigRiskConfig : TeaModel {
            /// <summary>
            /// <para>Contains rules that override the default settings for specific consumers.</para>
            /// </summary>
            [NameInMap("consumerRules")]
            [Validation(Required=false)]
            public AiSecurityGuardConfigRiskConfigConsumerRules ConsumerRules { get; set; }
            public class AiSecurityGuardConfigRiskConfigConsumerRules : TeaModel {
                /// <summary>
                /// <para>The location in the request to search for the <c>pattern</c>. For example: <c>header</c> or <c>query</c>.</para>
                /// </summary>
                [NameInMap("matchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                /// <summary>
                /// <para>The pattern for matching a consumer. This can be a regular expression.</para>
                /// </summary>
                [NameInMap("pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

            }

            /// <summary>
            /// <para>The default risk level for this risk type. For example: <c>low</c>, <c>medium</c>, or <c>high</c>.</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The type of risk to configure. For example: <c>profanity</c> or <c>spam</c>.</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The service address of the security check endpoint.</para>
        /// </summary>
        [NameInMap("serviceAddress")]
        [Validation(Required=false)]
        public string ServiceAddress { get; set; }

    }

}
