// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210220.Models
{
    public class GetLoginTokenResponseBody : TeaModel {
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("IdpId")]
        [Validation(Required=false)]
        public string IdpId { get; set; }

        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        [NameInMap("KeepAliveToken")]
        [Validation(Required=false)]
        public string KeepAliveToken { get; set; }

        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        [NameInMap("NextStage")]
        [Validation(Required=false)]
        public string NextStage { get; set; }

        [NameInMap("OfficeSites")]
        [Validation(Required=false)]
        public List<string> OfficeSites { get; set; }

        [NameInMap("PasswordStrategy")]
        [Validation(Required=false)]
        public GetLoginTokenResponseBodyPasswordStrategy PasswordStrategy { get; set; }
        public class GetLoginTokenResponseBodyPasswordStrategy : TeaModel {
            [NameInMap("TenantAlternativeChars")]
            [Validation(Required=false)]
            public List<string> TenantAlternativeChars { get; set; }

            [NameInMap("TenantPasswordLength")]
            [Validation(Required=false)]
            public int? TenantPasswordLength { get; set; }

        }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("Props")]
        [Validation(Required=false)]
        public Dictionary<string, string> Props { get; set; }

        [NameInMap("QrCodePng")]
        [Validation(Required=false)]
        public string QrCodePng { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskVerifyInfo")]
        [Validation(Required=false)]
        public GetLoginTokenResponseBodyRiskVerifyInfo RiskVerifyInfo { get; set; }
        public class GetLoginTokenResponseBodyRiskVerifyInfo : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("LastLockDuration")]
            [Validation(Required=false)]
            public long? LastLockDuration { get; set; }

            [NameInMap("Locked")]
            [Validation(Required=false)]
            public bool? Locked { get; set; }

            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

        }

        [NameInMap("Secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("TenantAlias")]
        [Validation(Required=false)]
        public string TenantAlias { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("TenantInfos")]
        [Validation(Required=false)]
        public List<GetLoginTokenResponseBodyTenantInfos> TenantInfos { get; set; }
        public class GetLoginTokenResponseBodyTenantInfos : TeaModel {
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            [NameInMap("TenantAlias")]
            [Validation(Required=false)]
            public string TenantAlias { get; set; }

        }

        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

        [NameInMap("WindowDisplayMode")]
        [Validation(Required=false)]
        public string WindowDisplayMode { get; set; }

        [NameInMap("WyId")]
        [Validation(Required=false)]
        public string WyId { get; set; }

    }

}
