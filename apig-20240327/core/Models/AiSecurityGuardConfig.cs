// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiSecurityGuardConfig : TeaModel {
        [NameInMap("bufferLimit")]
        [Validation(Required=false)]
        public int? BufferLimit { get; set; }

        [NameInMap("checkRequest")]
        [Validation(Required=false)]
        public bool? CheckRequest { get; set; }

        [NameInMap("checkRequestImage")]
        [Validation(Required=false)]
        public bool? CheckRequestImage { get; set; }

        [NameInMap("checkResponse")]
        [Validation(Required=false)]
        public bool? CheckResponse { get; set; }

        [NameInMap("checkResponseImage")]
        [Validation(Required=false)]
        public bool? CheckResponseImage { get; set; }

        [NameInMap("consumerRequestCheckService")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerRequestCheckService> ConsumerRequestCheckService { get; set; }
        public class AiSecurityGuardConfigConsumerRequestCheckService : TeaModel {
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("modalityType")]
            [Validation(Required=false)]
            public string ModalityType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("requestCheckService")]
            [Validation(Required=false)]
            public string RequestCheckService { get; set; }

            [NameInMap("requestImageCheckService")]
            [Validation(Required=false)]
            public string RequestImageCheckService { get; set; }

        }

        [NameInMap("consumerResponseCheckService")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerResponseCheckService> ConsumerResponseCheckService { get; set; }
        public class AiSecurityGuardConfigConsumerResponseCheckService : TeaModel {
            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("modalityType")]
            [Validation(Required=false)]
            public string ModalityType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("responseCheckService")]
            [Validation(Required=false)]
            public string ResponseCheckService { get; set; }

            [NameInMap("responseImageCheckService")]
            [Validation(Required=false)]
            public string ResponseImageCheckService { get; set; }

        }

        [NameInMap("consumerRiskLevel")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigConsumerRiskLevel> ConsumerRiskLevel { get; set; }
        public class AiSecurityGuardConfigConsumerRiskLevel : TeaModel {
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("matchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("pluginStatus")]
        [Validation(Required=false)]
        public AiPluginStatus PluginStatus { get; set; }

        [NameInMap("requestCheckService")]
        [Validation(Required=false)]
        public string RequestCheckService { get; set; }

        [NameInMap("requestImageCheckService")]
        [Validation(Required=false)]
        public string RequestImageCheckService { get; set; }

        [NameInMap("responseCheckService")]
        [Validation(Required=false)]
        public string ResponseCheckService { get; set; }

        [NameInMap("responseImageCheckService")]
        [Validation(Required=false)]
        public string ResponseImageCheckService { get; set; }

        [NameInMap("riskAlertLevel")]
        [Validation(Required=false)]
        public string RiskAlertLevel { get; set; }

        [NameInMap("riskConfig")]
        [Validation(Required=false)]
        public List<AiSecurityGuardConfigRiskConfig> RiskConfig { get; set; }
        public class AiSecurityGuardConfigRiskConfig : TeaModel {
            [NameInMap("consumerRules")]
            [Validation(Required=false)]
            public AiSecurityGuardConfigRiskConfigConsumerRules ConsumerRules { get; set; }
            public class AiSecurityGuardConfigRiskConfigConsumerRules : TeaModel {
                [NameInMap("matchType")]
                [Validation(Required=false)]
                public string MatchType { get; set; }

                [NameInMap("pattern")]
                [Validation(Required=false)]
                public string Pattern { get; set; }

            }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("serviceAddress")]
        [Validation(Required=false)]
        public string ServiceAddress { get; set; }

    }

}
