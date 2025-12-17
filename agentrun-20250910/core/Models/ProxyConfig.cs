// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ProxyConfig : TeaModel {
        [NameInMap("endpoints")]
        [Validation(Required=false)]
        public List<ProxyConfigEndpoints> Endpoints { get; set; }
        public class ProxyConfigEndpoints : TeaModel {
            [NameInMap("baseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            [NameInMap("modelNames")]
            [Validation(Required=false)]
            public List<string> ModelNames { get; set; }

            [NameInMap("modelServiceName")]
            [Validation(Required=false)]
            public string ModelServiceName { get; set; }

            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        [NameInMap("policies")]
        [Validation(Required=false)]
        public ProxyConfigPolicies Policies { get; set; }
        public class ProxyConfigPolicies : TeaModel {
            [NameInMap("aiGuardrailConfig")]
            [Validation(Required=false)]
            public ProxyConfigPoliciesAiGuardrailConfig AiGuardrailConfig { get; set; }
            public class ProxyConfigPoliciesAiGuardrailConfig : TeaModel {
                [NameInMap("blockOnContentModeration")]
                [Validation(Required=false)]
                public bool? BlockOnContentModeration { get; set; }

                [NameInMap("blockOnMaliciousUrl")]
                [Validation(Required=false)]
                public bool? BlockOnMaliciousUrl { get; set; }

                [NameInMap("blockOnModelHallucination")]
                [Validation(Required=false)]
                public bool? BlockOnModelHallucination { get; set; }

                [NameInMap("blockOnPromptAttack")]
                [Validation(Required=false)]
                public bool? BlockOnPromptAttack { get; set; }

                [NameInMap("blockOnSensitiveData")]
                [Validation(Required=false)]
                public bool? BlockOnSensitiveData { get; set; }

                [NameInMap("checkRequest")]
                [Validation(Required=false)]
                public bool? CheckRequest { get; set; }

                [NameInMap("checkResponse")]
                [Validation(Required=false)]
                public bool? CheckResponse { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("maxTextLength")]
                [Validation(Required=false)]
                public int? MaxTextLength { get; set; }

            }

            [NameInMap("cache")]
            [Validation(Required=false)]
            public bool? Cache { get; set; }

            [NameInMap("concurrencyLimit")]
            [Validation(Required=false)]
            public int? ConcurrencyLimit { get; set; }

            [NameInMap("fallbacks")]
            [Validation(Required=false)]
            public List<ProxyConfigPoliciesFallbacks> Fallbacks { get; set; }
            public class ProxyConfigPoliciesFallbacks : TeaModel {
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("modelServiceName")]
                [Validation(Required=false)]
                public string ModelServiceName { get; set; }

            }

            [NameInMap("numRetries")]
            [Validation(Required=false)]
            public int? NumRetries { get; set; }

            [NameInMap("requestTimeout")]
            [Validation(Required=false)]
            public int? RequestTimeout { get; set; }

            [NameInMap("tokenRateLimiter")]
            [Validation(Required=false)]
            public ProxyConfigPoliciesTokenRateLimiter TokenRateLimiter { get; set; }
            public class ProxyConfigPoliciesTokenRateLimiter : TeaModel {
                [NameInMap("tpd")]
                [Validation(Required=false)]
                public int? Tpd { get; set; }

                [NameInMap("tph")]
                [Validation(Required=false)]
                public int? Tph { get; set; }

                [NameInMap("tpm")]
                [Validation(Required=false)]
                public int? Tpm { get; set; }

                [NameInMap("tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

        }

    }

}
