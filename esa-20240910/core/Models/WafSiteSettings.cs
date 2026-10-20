// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafSiteSettings : TeaModel {
        /// <summary>
        /// <para>The configuration for adding bot protection headers.</para>
        /// </summary>
        [NameInMap("AddBotProtectionHeaders")]
        [Validation(Required=false)]
        public WafSiteSettingsAddBotProtectionHeaders AddBotProtectionHeaders { get; set; }
        public class WafSiteSettingsAddBotProtectionHeaders : TeaModel {
            /// <summary>
            /// <para>The enable status.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The configuration for adding security headers.</para>
        /// </summary>
        [NameInMap("AddSecurityHeaders")]
        [Validation(Required=false)]
        public WafSiteSettingsAddSecurityHeaders AddSecurityHeaders { get; set; }
        public class WafSiteSettingsAddSecurityHeaders : TeaModel {
            /// <summary>
            /// <para>The enable status.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The bandwidth abuse protection.</para>
        /// </summary>
        [NameInMap("BandwidthAbuseProtection")]
        [Validation(Required=false)]
        public WafSiteSettingsBandwidthAbuseProtection BandwidthAbuseProtection { get; set; }
        public class WafSiteSettingsBandwidthAbuseProtection : TeaModel {
            /// <summary>
            /// <para>The action performed by the bandwidth abuse protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The ID of the bandwidth abuse protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The enable status of the bandwidth abuse protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The bot management.</para>
        /// </summary>
        [NameInMap("BotManagement")]
        [Validation(Required=false)]
        public WafSiteSettingsBotManagement BotManagement { get; set; }
        public class WafSiteSettingsBotManagement : TeaModel {
            /// <summary>
            /// <para>The definite bots.</para>
            /// </summary>
            [NameInMap("DefiniteBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementDefiniteBots DefiniteBots { get; set; }
            public class WafSiteSettingsBotManagementDefiniteBots : TeaModel {
                /// <summary>
                /// <para>The action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>captcha</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20000001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the rule applies to static resource requests.</para>
            /// </summary>
            [NameInMap("EffectOnStatic")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementEffectOnStatic EffectOnStatic { get; set; }
            public class WafSiteSettingsBotManagementEffectOnStatic : TeaModel {
                /// <summary>
                /// <para>The enable status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// <para>The JavaScript detection.</para>
            /// </summary>
            [NameInMap("JSDetection")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementJSDetection JSDetection { get; set; }
            public class WafSiteSettingsBotManagementJSDetection : TeaModel {
                /// <summary>
                /// <para>The enable status.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// <para>The likely bots.</para>
            /// </summary>
            [NameInMap("LikelyBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementLikelyBots LikelyBots { get; set; }
            public class WafSiteSettingsBotManagementLikelyBots : TeaModel {
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
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20000002</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            /// <summary>
            /// <para>The verified bots.</para>
            /// </summary>
            [NameInMap("VerifiedBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementVerifiedBots VerifiedBots { get; set; }
            public class WafSiteSettingsBotManagementVerifiedBots : TeaModel {
                /// <summary>
                /// <para>The action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bypass</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20000003</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        /// <summary>
        /// <para>The client IP identification.</para>
        /// </summary>
        [NameInMap("ClientIpIdentifier")]
        [Validation(Required=false)]
        public WafSiteSettingsClientIpIdentifier ClientIpIdentifier { get; set; }
        public class WafSiteSettingsClientIpIdentifier : TeaModel {
            /// <summary>
            /// <para>The specified headers.</para>
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<string> Headers { get; set; }

            /// <summary>
            /// <para>The identification mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>headers</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

        /// <summary>
        /// <para>The configuration for disabling the security module.</para>
        /// </summary>
        [NameInMap("DisableSecurityModule")]
        [Validation(Required=false)]
        public WafSiteSettingsDisableSecurityModule DisableSecurityModule { get; set; }
        public class WafSiteSettingsDisableSecurityModule : TeaModel {
            /// <summary>
            /// <para>The enable status for disabling the security module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request body inspection configuration. This configuration controls the deep packet inspection behavior of WAF for HTTP request bodies. For example, matching based on request body content, such as SQL injection and XSS, takes effect only after this feature is enabled. This configuration can include the following fields:</para>
        /// <list type="bullet">
        /// <item><description>Id: The unique identifier of the built-in inspection rule.</description></item>
        /// <item><description>SizeLimit: The maximum size of the request body to be inspected.</description></item>
        /// <item><description>Action: The action to take when the size limit is exceeded.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("RequestBodyInspection")]
        [Validation(Required=false)]
        public WafSiteSettingsRequestBodyInspection RequestBodyInspection { get; set; }
        public class WafSiteSettingsRequestBodyInspection : TeaModel {
            /// <summary>
            /// <para>The action to take when the request body size exceeds the SizeLimit.
            /// Common valid values (the complete enumeration is subject to the server configuration):</para>
            /// <list type="bullet">
            /// <item><description>allow: Allows the request directly without performing deep packet inspection on the exceeded part.<remarks>
            /// <para>The complete enumeration is subject to the WAF server configuration.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The ID of the request body inspection rule, which is the unique identifier of the built-in rule. When request body inspection is enabled, the server uses this ID to associate the matching logic of the built-in inspection rule. The valid values of the ID are subject to the WAF built-in rule list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The maximum size of the request body to be inspected, in bytes.</para>
            /// <list type="bullet">
            /// <item><description>If the request body is less than or equal to this value, the complete content is used for WAF matching.</description></item>
            /// <item><description>If the request body exceeds this value, the action specified by the Action field is performed, such as inspecting only the first N bytes, blocking, or allowing.<remarks>
            /// <para>The specific valid values and default value are subject to the WAF server configuration.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>16KB</para>
            /// </summary>
            [NameInMap("SizeLimit")]
            [Validation(Required=false)]
            public string SizeLimit { get; set; }

        }

        /// <summary>
        /// <para>The security level.</para>
        /// </summary>
        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public WafSiteSettingsSecurityLevel SecurityLevel { get; set; }
        public class WafSiteSettingsSecurityLevel : TeaModel {
            /// <summary>
            /// <para>The security level rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The security level value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
