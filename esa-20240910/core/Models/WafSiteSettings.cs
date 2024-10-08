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
