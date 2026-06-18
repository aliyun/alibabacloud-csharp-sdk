// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafSiteSettings : TeaModel {
        /// <summary>
        /// <para>Configuration for adding bot protection headers.</para>
        /// </summary>
        [NameInMap("AddBotProtectionHeaders")]
        [Validation(Required=false)]
        public WafSiteSettingsAddBotProtectionHeaders AddBotProtectionHeaders { get; set; }
        public class WafSiteSettingsAddBotProtectionHeaders : TeaModel {
            /// <summary>
            /// <para>Specifies whether to add bot protection headers.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>Configuration for adding security headers.</para>
        /// </summary>
        [NameInMap("AddSecurityHeaders")]
        [Validation(Required=false)]
        public WafSiteSettingsAddSecurityHeaders AddSecurityHeaders { get; set; }
        public class WafSiteSettingsAddSecurityHeaders : TeaModel {
            /// <summary>
            /// <para>Specifies whether to add security headers.</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The bandwidth abuse protection settings.</para>
        /// </summary>
        [NameInMap("BandwidthAbuseProtection")]
        [Validation(Required=false)]
        public WafSiteSettingsBandwidthAbuseProtection BandwidthAbuseProtection { get; set; }
        public class WafSiteSettingsBandwidthAbuseProtection : TeaModel {
            /// <summary>
            /// <para>The action to perform for the bandwidth abuse protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The rule ID for bandwidth abuse protection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The status of the bandwidth abuse protection rule. Valid values: <c>on</c> and <c>off</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The bot management settings.</para>
        /// </summary>
        [NameInMap("BotManagement")]
        [Validation(Required=false)]
        public WafSiteSettingsBotManagement BotManagement { get; set; }
        public class WafSiteSettingsBotManagement : TeaModel {
            /// <summary>
            /// <para>Configuration for traffic identified as a definite bot.</para>
            /// </summary>
            [NameInMap("DefiniteBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementDefiniteBots DefiniteBots { get; set; }
            public class WafSiteSettingsBotManagementDefiniteBots : TeaModel {
                /// <summary>
                /// <para>The action to perform.</para>
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
            /// <para>Configuration to apply bot management to static resource requests.</para>
            /// </summary>
            [NameInMap("EffectOnStatic")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementEffectOnStatic EffectOnStatic { get; set; }
            public class WafSiteSettingsBotManagementEffectOnStatic : TeaModel {
                /// <summary>
                /// <para>Specifies whether to apply bot management to static resource requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// <para>The JavaScript detection settings.</para>
            /// </summary>
            [NameInMap("JSDetection")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementJSDetection JSDetection { get; set; }
            public class WafSiteSettingsBotManagementJSDetection : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable JavaScript detection.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// <para>Configuration for traffic identified as a likely bot.</para>
            /// </summary>
            [NameInMap("LikelyBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementLikelyBots LikelyBots { get; set; }
            public class WafSiteSettingsBotManagementLikelyBots : TeaModel {
                /// <summary>
                /// <para>The action to perform.</para>
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
            /// <para>Configuration for traffic identified as a verified bot.</para>
            /// </summary>
            [NameInMap("VerifiedBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementVerifiedBots VerifiedBots { get; set; }
            public class WafSiteSettingsBotManagementVerifiedBots : TeaModel {
                /// <summary>
                /// <para>The action to perform.</para>
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
        /// <para>Configuration for client IP identification.</para>
        /// </summary>
        [NameInMap("ClientIpIdentifier")]
        [Validation(Required=false)]
        public WafSiteSettingsClientIpIdentifier ClientIpIdentifier { get; set; }
        public class WafSiteSettingsClientIpIdentifier : TeaModel {
            /// <summary>
            /// <para>An array of headers to check for the client IP address.</para>
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
        /// <para>Configuration for disabling the security module.</para>
        /// </summary>
        [NameInMap("DisableSecurityModule")]
        [Validation(Required=false)]
        public WafSiteSettingsDisableSecurityModule DisableSecurityModule { get; set; }
        public class WafSiteSettingsDisableSecurityModule : TeaModel {
            /// <summary>
            /// <para>Specifies whether to disable the security module. Set to <c>on</c> to disable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Configuration for request body inspection.</para>
        /// </summary>
        [NameInMap("RequestBodyInspection")]
        [Validation(Required=false)]
        public WafSiteSettingsRequestBodyInspection RequestBodyInspection { get; set; }
        public class WafSiteSettingsRequestBodyInspection : TeaModel {
            /// <summary>
            /// <para>The action to perform when the request body size exceeds the limit.</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The rule ID for request body inspection.</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The size limit, in bytes, for inspecting the request body.</para>
            /// </summary>
            [NameInMap("SizeLimit")]
            [Validation(Required=false)]
            public string SizeLimit { get; set; }

        }

        /// <summary>
        /// <para>The security level settings.</para>
        /// </summary>
        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public WafSiteSettingsSecurityLevel SecurityLevel { get; set; }
        public class WafSiteSettingsSecurityLevel : TeaModel {
            /// <summary>
            /// <para>The security level.</para>
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
