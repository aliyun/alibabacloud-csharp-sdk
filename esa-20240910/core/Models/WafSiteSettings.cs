// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafSiteSettings : TeaModel {
        /// <summary>
        /// <para>Adds a bot protection header.</para>
        /// </summary>
        [NameInMap("AddBotProtectionHeaders")]
        [Validation(Required=false)]
        public WafSiteSettingsAddBotProtectionHeaders AddBotProtectionHeaders { get; set; }
        public class WafSiteSettingsAddBotProtectionHeaders : TeaModel {
            /// <summary>
            /// <para>Indicates whether the parameter is enabled.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>Adds security request header.</para>
        /// </summary>
        [NameInMap("AddSecurityHeaders")]
        [Validation(Required=false)]
        public WafSiteSettingsAddSecurityHeaders AddSecurityHeaders { get; set; }
        public class WafSiteSettingsAddSecurityHeaders : TeaModel {
            /// <summary>
            /// <para>Indicates whether the parameter is enabled.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        [NameInMap("BandwidthAbuseProtection")]
        [Validation(Required=false)]
        public WafSiteSettingsBandwidthAbuseProtection BandwidthAbuseProtection { get; set; }
        public class WafSiteSettingsBandwidthAbuseProtection : TeaModel {
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

        /// <summary>
        /// <para>Bot management.</para>
        /// </summary>
        [NameInMap("BotManagement")]
        [Validation(Required=false)]
        public WafSiteSettingsBotManagement BotManagement { get; set; }
        public class WafSiteSettingsBotManagement : TeaModel {
            /// <summary>
            /// <para>Definite Bots</para>
            /// </summary>
            [NameInMap("DefiniteBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementDefiniteBots DefiniteBots { get; set; }
            public class WafSiteSettingsBotManagementDefiniteBots : TeaModel {
                /// <summary>
                /// <para>The action that you want to perform on requests that match the rule.</para>
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
            /// <para>Takes effect on static resource requests.</para>
            /// </summary>
            [NameInMap("EffectOnStatic")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementEffectOnStatic EffectOnStatic { get; set; }
            public class WafSiteSettingsBotManagementEffectOnStatic : TeaModel {
                /// <summary>
                /// <para>Indicates whether the parameter is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// <para>JavaScript detection.</para>
            /// </summary>
            [NameInMap("JSDetection")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementJSDetection JSDetection { get; set; }
            public class WafSiteSettingsBotManagementJSDetection : TeaModel {
                /// <summary>
                /// <para>Indicates whether the parameter is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// <para>Likely Bots</para>
            /// </summary>
            [NameInMap("LikelyBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementLikelyBots LikelyBots { get; set; }
            public class WafSiteSettingsBotManagementLikelyBots : TeaModel {
                /// <summary>
                /// <para>The action that you want to perform on requests that match the rule.</para>
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
            /// <para>Verified Bots</para>
            /// </summary>
            [NameInMap("VerifiedBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementVerifiedBots VerifiedBots { get; set; }
            public class WafSiteSettingsBotManagementVerifiedBots : TeaModel {
                /// <summary>
                /// <para>The action that you want to perform on requests that match the rule.</para>
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
        /// <para>Identifies the IP address of the client.</para>
        /// </summary>
        [NameInMap("ClientIpIdentifier")]
        [Validation(Required=false)]
        public WafSiteSettingsClientIpIdentifier ClientIpIdentifier { get; set; }
        public class WafSiteSettingsClientIpIdentifier : TeaModel {
            /// <summary>
            /// <para>Specify headers.</para>
            /// </summary>
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<string> Headers { get; set; }

            /// <summary>
            /// <para>Identifies the mode.</para>
            /// <para>Enumerated values:</para>
            /// <list type="bullet">
            /// <item><description>headers: specifies the headers.</description></item>
            /// <item><description>connection_ip: the IP address for establishing a connection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>headers</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

        [NameInMap("DisableSecurityModule")]
        [Validation(Required=false)]
        public WafSiteSettingsDisableSecurityModule DisableSecurityModule { get; set; }
        public class WafSiteSettingsDisableSecurityModule : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestBodyInspection")]
        [Validation(Required=false)]
        public WafSiteSettingsRequestBodyInspection RequestBodyInspection { get; set; }
        public class WafSiteSettingsRequestBodyInspection : TeaModel {
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

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
            /// <para>The security level value.</para>
            /// <para>Enumerated values:</para>
            /// <list type="bullet">
            /// <item><description>high: high.</description></item>
            /// <item><description>low: low.</description></item>
            /// <item><description>under_attack: I am under attack.</description></item>
            /// <item><description>medium: medium.</description></item>
            /// <item><description>essentially_off: essentially off.</description></item>
            /// <item><description>off: completely off.</description></item>
            /// </list>
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
