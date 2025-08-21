// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafSiteSettings : TeaModel {
        [NameInMap("AddBotProtectionHeaders")]
        [Validation(Required=false)]
        public WafSiteSettingsAddBotProtectionHeaders AddBotProtectionHeaders { get; set; }
        public class WafSiteSettingsAddBotProtectionHeaders : TeaModel {
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        [NameInMap("AddSecurityHeaders")]
        [Validation(Required=false)]
        public WafSiteSettingsAddSecurityHeaders AddSecurityHeaders { get; set; }
        public class WafSiteSettingsAddSecurityHeaders : TeaModel {
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

        [NameInMap("BotManagement")]
        [Validation(Required=false)]
        public WafSiteSettingsBotManagement BotManagement { get; set; }
        public class WafSiteSettingsBotManagement : TeaModel {
            [NameInMap("DefiniteBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementDefiniteBots DefiniteBots { get; set; }
            public class WafSiteSettingsBotManagementDefiniteBots : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("EffectOnStatic")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementEffectOnStatic EffectOnStatic { get; set; }
            public class WafSiteSettingsBotManagementEffectOnStatic : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            [NameInMap("JSDetection")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementJSDetection JSDetection { get; set; }
            public class WafSiteSettingsBotManagementJSDetection : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            [NameInMap("LikelyBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementLikelyBots LikelyBots { get; set; }
            public class WafSiteSettingsBotManagementLikelyBots : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("VerifiedBots")]
            [Validation(Required=false)]
            public WafSiteSettingsBotManagementVerifiedBots VerifiedBots { get; set; }
            public class WafSiteSettingsBotManagementVerifiedBots : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        [NameInMap("ClientIpIdentifier")]
        [Validation(Required=false)]
        public WafSiteSettingsClientIpIdentifier ClientIpIdentifier { get; set; }
        public class WafSiteSettingsClientIpIdentifier : TeaModel {
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public List<string> Headers { get; set; }

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

        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public WafSiteSettingsSecurityLevel SecurityLevel { get; set; }
        public class WafSiteSettingsSecurityLevel : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
