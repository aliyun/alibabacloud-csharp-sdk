// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafRuleConfig : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Actions")]
        [Validation(Required=false)]
        public WafRuleConfigActions Actions { get; set; }
        public class WafRuleConfigActions : TeaModel {
            [NameInMap("Bypass")]
            [Validation(Required=false)]
            public WafRuleConfigActionsBypass Bypass { get; set; }
            public class WafRuleConfigActionsBypass : TeaModel {
                [NameInMap("CustomRules")]
                [Validation(Required=false)]
                public List<long?> CustomRules { get; set; }

                [NameInMap("RegularRules")]
                [Validation(Required=false)]
                public List<long?> RegularRules { get; set; }

                [NameInMap("RegularTypes")]
                [Validation(Required=false)]
                public List<string> RegularTypes { get; set; }

                [NameInMap("Skip")]
                [Validation(Required=false)]
                public string Skip { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

            [NameInMap("Response")]
            [Validation(Required=false)]
            public WafRuleConfigActionsResponse Response { get; set; }
            public class WafRuleConfigActionsResponse : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        [NameInMap("AppPackage")]
        [Validation(Required=false)]
        public WafRuleConfigAppPackage AppPackage { get; set; }
        public class WafRuleConfigAppPackage : TeaModel {
            [NameInMap("PackageSigns")]
            [Validation(Required=false)]
            public List<WafRuleConfigAppPackagePackageSigns> PackageSigns { get; set; }
            public class WafRuleConfigAppPackagePackageSigns : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

            }

        }

        [NameInMap("AppSdk")]
        [Validation(Required=false)]
        public WafRuleConfigAppSdk AppSdk { get; set; }
        public class WafRuleConfigAppSdk : TeaModel {
            [NameInMap("CustomSign")]
            [Validation(Required=false)]
            public WafRuleConfigAppSdkCustomSign CustomSign { get; set; }
            public class WafRuleConfigAppSdkCustomSign : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("CustomSignStatus")]
            [Validation(Required=false)]
            public string CustomSignStatus { get; set; }

            [NameInMap("FeatureAbnormal")]
            [Validation(Required=false)]
            public List<string> FeatureAbnormal { get; set; }

        }

        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("ManagedGroupId")]
        [Validation(Required=false)]
        public long? ManagedGroupId { get; set; }

        [NameInMap("ManagedList")]
        [Validation(Required=false)]
        public string ManagedList { get; set; }

        [NameInMap("ManagedRulesets")]
        [Validation(Required=false)]
        public List<WafRuleConfigManagedRulesets> ManagedRulesets { get; set; }
        public class WafRuleConfigManagedRulesets : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            [NameInMap("ManagedRules")]
            [Validation(Required=false)]
            public List<WafRuleConfigManagedRulesetsManagedRules> ManagedRules { get; set; }
            public class WafRuleConfigManagedRulesetsManagedRules : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("NumberEnabled")]
            [Validation(Required=false)]
            public int? NumberEnabled { get; set; }

            [NameInMap("NumberTotal")]
            [Validation(Required=false)]
            public int? NumberTotal { get; set; }

            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public int? ProtectionLevel { get; set; }

        }

        [NameInMap("Match")]
        [Validation(Required=false)]
        public WafRuleMatch Match { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RateLimit")]
        [Validation(Required=false)]
        public WafRuleConfigRateLimit RateLimit { get; set; }
        public class WafRuleConfigRateLimit : TeaModel {
            [NameInMap("Characteristics")]
            [Validation(Required=false)]
            public WafRuleMatch2 Characteristics { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            [NameInMap("OnHit")]
            [Validation(Required=false)]
            public bool? OnHit { get; set; }

            [NameInMap("TTL")]
            [Validation(Required=false)]
            public int? TTL { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public WafRuleConfigRateLimitThreshold Threshold { get; set; }
            public class WafRuleConfigRateLimitThreshold : TeaModel {
                [NameInMap("DistinctManagedRules")]
                [Validation(Required=false)]
                public int? DistinctManagedRules { get; set; }

                [NameInMap("ManagedRulesBlocked")]
                [Validation(Required=false)]
                public int? ManagedRulesBlocked { get; set; }

                [NameInMap("Request")]
                [Validation(Required=false)]
                public int? Request { get; set; }

                [NameInMap("ResponseStatus")]
                [Validation(Required=false)]
                public WafRuleConfigRateLimitThresholdResponseStatus ResponseStatus { get; set; }
                public class WafRuleConfigRateLimitThresholdResponseStatus : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public int? Ratio { get; set; }

                }

                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public string Traffic { get; set; }

            }

        }

        [NameInMap("Sigchl")]
        [Validation(Required=false)]
        public List<string> Sigchl { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Timer")]
        [Validation(Required=false)]
        public WafTimer Timer { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
