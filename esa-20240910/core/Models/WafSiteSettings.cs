// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafSiteSettings : TeaModel {
        /// <summary>
        /// <para>The bot protection headers.</para>
        /// </summary>
        [NameInMap("AddBotProtectionHeaders")]
        [Validation(Required=false)]
        public WafSiteSettingsAddBotProtectionHeaders AddBotProtectionHeaders { get; set; }
        public class WafSiteSettingsAddBotProtectionHeaders : TeaModel {
            /// <summary>
            /// <para>The switch.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The security headers.</para>
        /// </summary>
        [NameInMap("AddSecurityHeaders")]
        [Validation(Required=false)]
        public WafSiteSettingsAddSecurityHeaders AddSecurityHeaders { get; set; }
        public class WafSiteSettingsAddSecurityHeaders : TeaModel {
            /// <summary>
            /// <para>The switch.</para>
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
            /// <para>The action of the bandwidth abuse protection rule.</para>
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
            /// <para>The switch status of the bandwidth abuse protection rule.</para>
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
                /// <para>The switch.</para>
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
                /// <para>The switch.</para>
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
        /// <para>The disable security module configuration.</para>
        /// </summary>
        [NameInMap("DisableSecurityModule")]
        [Validation(Required=false)]
        public WafSiteSettingsDisableSecurityModule DisableSecurityModule { get; set; }
        public class WafSiteSettingsDisableSecurityModule : TeaModel {
            /// <summary>
            /// <para>The status switch for disabling the security module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request body inspection configuration. Controls the deep packet inspection behavior of WAF for HTTP request bodies. After this feature is enabled, content-based matching rules such as SQL injection and XSS detection take effect on request bodies.</para>
        /// <para>This configuration can contain the following fields:</para>
        /// <list type="bullet">
        /// <item><description><c>Id</c>: The unique identifier of the built-in inspection rule.</description></item>
        /// <item><description><c>SizeLimit</c>: The maximum size of the request body to inspect.</description></item>
        /// <item><description><c>Action</c>: The action to take when the request body exceeds the size limit.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("RequestBodyInspection")]
        [Validation(Required=false)]
        public WafSiteSettingsRequestBodyInspection RequestBodyInspection { get; set; }
        public class WafSiteSettingsRequestBodyInspection : TeaModel {
            /// <summary>
            /// <para>The action to take when the request body size exceeds <c>SizeLimit</c>.</para>
            /// <para>Common values (the complete enumeration is subject to the server-side configuration):</para>
            /// <list type="bullet">
            /// <item><description><c>allow</c>: Allow directly without performing deep packet inspection on the excess portion.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The complete enum is subject to the WAF server-side configuration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The request body inspection rule ID (unique identifier of the built-in rule). When request body inspection is enabled, the server uses this ID to associate the matching logic of the built-in inspection rule. The ID value is subject to the WAF built-in rule list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The maximum size of the request body to inspect, in bytes.</para>
            /// <list type="bullet">
            /// <item><description>When the request body is less than or equal to this value, the entire content is subject to WAF matching.</description></item>
            /// <item><description>When the request body exceeds this value, the action specified in the <c>Action</c> field is taken (for example, inspect only the first N bytes, reject, or allow directly).</description></item>
            /// </list>
            /// <remarks>
            /// <para>The specific value range and default value are subject to the WAF server-side configuration.</para>
            /// </remarks>
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
