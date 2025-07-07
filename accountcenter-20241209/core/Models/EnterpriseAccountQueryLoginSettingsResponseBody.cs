// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseAccountQueryLoginSettingsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EnterpriseAccountQueryLoginSettingsResponseBodyData Data { get; set; }
        public class EnterpriseAccountQueryLoginSettingsResponseBodyData : TeaModel {
            [NameInMap("IpMaskDto")]
            [Validation(Required=false)]
            public EnterpriseAccountQueryLoginSettingsResponseBodyDataIpMaskDto IpMaskDto { get; set; }
            public class EnterpriseAccountQueryLoginSettingsResponseBodyDataIpMaskDto : TeaModel {
                [NameInMap("IpMaskEnabledStatus")]
                [Validation(Required=false)]
                public string IpMaskEnabledStatus { get; set; }

                [NameInMap("IpMasks")]
                [Validation(Required=false)]
                public List<string> IpMasks { get; set; }

            }

            [NameInMap("MfaBindStatus")]
            [Validation(Required=false)]
            public string MfaBindStatus { get; set; }

            [NameInMap("RiskControlDto")]
            [Validation(Required=false)]
            public EnterpriseAccountQueryLoginSettingsResponseBodyDataRiskControlDto RiskControlDto { get; set; }
            public class EnterpriseAccountQueryLoginSettingsResponseBodyDataRiskControlDto : TeaModel {
                [NameInMap("ProtectLevel")]
                [Validation(Required=false)]
                public string ProtectLevel { get; set; }

                [NameInMap("RiskControlEnabled")]
                [Validation(Required=false)]
                public bool? RiskControlEnabled { get; set; }

                [NameInMap("VerifyDetail")]
                [Validation(Required=false)]
                public string VerifyDetail { get; set; }

                [NameInMap("VerifyType")]
                [Validation(Required=false)]
                public string VerifyType { get; set; }

            }

            [NameInMap("SecurityMobileLoginStatus")]
            [Validation(Required=false)]
            public string SecurityMobileLoginStatus { get; set; }

            [NameInMap("SessionExpireTime")]
            [Validation(Required=false)]
            public int? SessionExpireTime { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
