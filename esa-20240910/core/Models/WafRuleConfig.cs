// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafRuleConfig : TeaModel {
        /// <summary>
        /// <para>The operation to perform after the WAF rule is matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deny</para>
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The extended action configurations.</para>
        /// </summary>
        [NameInMap("Actions")]
        [Validation(Required=false)]
        public WafRuleConfigActions Actions { get; set; }
        public class WafRuleConfigActions : TeaModel {
            /// <summary>
            /// <para>The skip configuration specified by the whitelist rule.</para>
            /// </summary>
            [NameInMap("Bypass")]
            [Validation(Required=false)]
            public WafRuleConfigActionsBypass Bypass { get; set; }
            public class WafRuleConfigActionsBypass : TeaModel {
                /// <summary>
                /// <para>The IDs of custom rules.</para>
                /// </summary>
                [NameInMap("CustomRules")]
                [Validation(Required=false)]
                public List<long?> CustomRules { get; set; }

                /// <summary>
                /// <para>The IDs of managed rules.</para>
                /// </summary>
                [NameInMap("RegularRules")]
                [Validation(Required=false)]
                public List<long?> RegularRules { get; set; }

                /// <summary>
                /// <para>The types of managed rules.</para>
                /// </summary>
                [NameInMap("RegularTypes")]
                [Validation(Required=false)]
                public List<string> RegularTypes { get; set; }

                /// <summary>
                /// <para>The skip scope applied when requests match conditions defined in the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>part</para>
                /// </summary>
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public string Skip { get; set; }

                /// <summary>
                /// <para>The skipped rule categories when requests match conditions defined in the whitelist rule.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

            /// <summary>
            /// <para>The custom error page.</para>
            /// </summary>
            [NameInMap("Response")]
            [Validation(Required=false)]
            public WafRuleConfigActionsResponse Response { get; set; }
            public class WafRuleConfigActionsResponse : TeaModel {
                /// <summary>
                /// <para>The custom response code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>403</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>The ID of the custom error page, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850223.html">ListPages</a> operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        /// <summary>
        /// <para>The configuration of secondary package detection.</para>
        /// </summary>
        [NameInMap("AppPackage")]
        [Validation(Required=false)]
        public WafRuleConfigAppPackage AppPackage { get; set; }
        public class WafRuleConfigAppPackage : TeaModel {
            /// <summary>
            /// <para>The package signatures.</para>
            /// </summary>
            [NameInMap("PackageSigns")]
            [Validation(Required=false)]
            public List<WafRuleConfigAppPackagePackageSigns> PackageSigns { get; set; }
            public class WafRuleConfigAppPackagePackageSigns : TeaModel {
                /// <summary>
                /// <para>The valid package name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The valid package signature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sign</para>
                /// </summary>
                [NameInMap("Sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

            }

        }

        /// <summary>
        /// <para>The SDK configuration for apps.</para>
        /// </summary>
        [NameInMap("AppSdk")]
        [Validation(Required=false)]
        public WafRuleConfigAppSdk AppSdk { get; set; }
        public class WafRuleConfigAppSdk : TeaModel {
            /// <summary>
            /// <para>The custom signature field.</para>
            /// </summary>
            [NameInMap("CustomSign")]
            [Validation(Required=false)]
            public WafRuleConfigAppSdkCustomSign CustomSign { get; set; }
            public class WafRuleConfigAppSdkCustomSign : TeaModel {
                /// <summary>
                /// <para>The field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sign</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The field value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>examplesignvalue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether to configure the custom signature field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("CustomSignStatus")]
            [Validation(Required=false)]
            public string CustomSignStatus { get; set; }

            /// <summary>
            /// <para>The app anomalies.</para>
            /// </summary>
            [NameInMap("FeatureAbnormal")]
            [Validation(Required=false)]
            public List<string> FeatureAbnormal { get; set; }

        }

        /// <summary>
        /// <para>The match expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip.src eq 1.1.1.1</para>
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The ID of the WAF rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20000001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The ID of the managed rule group, which is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000001</para>
        /// </summary>
        [NameInMap("ManagedGroupId")]
        [Validation(Required=false)]
        public long? ManagedGroupId { get; set; }

        /// <summary>
        /// <para>The managed list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>intelligence_crawler</para>
        /// </summary>
        [NameInMap("ManagedList")]
        [Validation(Required=false)]
        public string ManagedList { get; set; }

        /// <summary>
        /// <para>The managed rulesets.</para>
        /// </summary>
        [NameInMap("ManagedRulesets")]
        [Validation(Required=false)]
        public List<WafRuleConfigManagedRulesets> ManagedRulesets { get; set; }
        public class WafRuleConfigManagedRulesets : TeaModel {
            /// <summary>
            /// <para>The action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The attack type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            /// <summary>
            /// <para>The managed rules.</para>
            /// </summary>
            [NameInMap("ManagedRules")]
            [Validation(Required=false)]
            public List<WafRuleConfigManagedRulesetsManagedRules> ManagedRules { get; set; }
            public class WafRuleConfigManagedRulesetsManagedRules : TeaModel {
                /// <summary>
                /// <para>The action performed on requests that match the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>deny</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The ID of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The status of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The number of enabled rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("NumberEnabled")]
            [Validation(Required=false)]
            public int? NumberEnabled { get; set; }

            /// <summary>
            /// <para>The total number of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NumberTotal")]
            [Validation(Required=false)]
            public int? NumberTotal { get; set; }

            /// <summary>
            /// <para>The protection level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ProtectionLevel")]
            [Validation(Required=false)]
            public int? ProtectionLevel { get; set; }

        }

        /// <summary>
        /// <para>The name of the WAF rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example notes</para>
        /// </summary>
        [NameInMap("Notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// <para>The configuration of the rate limiting rule.</para>
        /// </summary>
        [NameInMap("RateLimit")]
        [Validation(Required=false)]
        public WafRuleConfigRateLimit RateLimit { get; set; }
        public class WafRuleConfigRateLimit : TeaModel {
            /// <summary>
            /// <para>The statistical objects to which the rule applies.</para>
            /// </summary>
            [NameInMap("Characteristics")]
            [Validation(Required=false)]
            public WafRatelimitCharacteristics Characteristics { get; set; }

            /// <summary>
            /// <para>The statistical interval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>Indicates whether to apply the rule to requests that hit the cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OnHit")]
            [Validation(Required=false)]
            public bool? OnHit { get; set; }

            /// <summary>
            /// <para>The timeout period for creating the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TTL")]
            [Validation(Required=false)]
            public int? TTL { get; set; }

            /// <summary>
            /// <para>The thresholds.</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public WafRuleConfigRateLimitThreshold Threshold { get; set; }
            public class WafRuleConfigRateLimitThreshold : TeaModel {
                /// <summary>
                /// <para>The maximum number of managed rules that are triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("DistinctManagedRules")]
                [Validation(Required=false)]
                public int? DistinctManagedRules { get; set; }

                /// <summary>
                /// <para>The maximum number of times that the managed rule is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ManagedRulesBlocked")]
                [Validation(Required=false)]
                public int? ManagedRulesBlocked { get; set; }

                /// <summary>
                /// <para>The request threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Request")]
                [Validation(Required=false)]
                public int? Request { get; set; }

                /// <summary>
                /// <para>The configuration of the status code threshold.</para>
                /// </summary>
                [NameInMap("ResponseStatus")]
                [Validation(Required=false)]
                public WafRuleConfigRateLimitThresholdResponseStatus ResponseStatus { get; set; }
                public class WafRuleConfigRateLimitThresholdResponseStatus : TeaModel {
                    /// <summary>
                    /// <para>The HTTP status code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>404</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// <para>The maximum number of times that the status code is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>The percentage of the occurrences of the status code to total status codes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Ratio")]
                    [Validation(Required=false)]
                    public int? Ratio { get; set; }

                }

                /// <summary>
                /// <para>The traffic threshold, which is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10Gb</para>
                /// </summary>
                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public string Traffic { get; set; }

            }

        }

        /// <summary>
        /// <para>The security level.</para>
        /// </summary>
        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public WafRuleConfigSecurityLevel SecurityLevel { get; set; }
        public class WafRuleConfigSecurityLevel : TeaModel {
            /// <summary>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>off</description></item>
            /// <item><description>essentially_off</description></item>
            /// <item><description>low</description></item>
            /// <item><description>medium</description></item>
            /// <item><description>high</description></item>
            /// <item><description>under_attack</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The token verification configurations.</para>
        /// </summary>
        [NameInMap("Sigchl")]
        [Validation(Required=false)]
        public List<string> Sigchl { get; set; }

        /// <summary>
        /// <para>The status of the WAF rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The timer.</para>
        /// </summary>
        [NameInMap("Timer")]
        [Validation(Required=false)]
        public WafTimer Timer { get; set; }

        /// <summary>
        /// <para>The name of the WAF rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_custom</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Defines whether the IP can access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.1</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
