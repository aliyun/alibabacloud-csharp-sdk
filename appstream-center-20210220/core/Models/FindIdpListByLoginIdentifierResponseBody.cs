// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210220.Models
{
    public class FindIdpListByLoginIdentifierResponseBody : TeaModel {
        [NameInMap("IdpInfos")]
        [Validation(Required=false)]
        public List<FindIdpListByLoginIdentifierResponseBodyIdpInfos> IdpInfos { get; set; }
        public class FindIdpListByLoginIdentifierResponseBodyIdpInfos : TeaModel {
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("Cookies")]
            [Validation(Required=false)]
            public string Cookies { get; set; }

            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public string IdpId { get; set; }

            [NameInMap("IdpName")]
            [Validation(Required=false)]
            public string IdpName { get; set; }

            [NameInMap("IdpProvider")]
            [Validation(Required=false)]
            public string IdpProvider { get; set; }

            [NameInMap("JumpSwitch")]
            [Validation(Required=false)]
            public string JumpSwitch { get; set; }

            [NameInMap("SsoProtocol")]
            [Validation(Required=false)]
            public string SsoProtocol { get; set; }

            [NameInMap("SsoServiceUrl")]
            [Validation(Required=false)]
            public string SsoServiceUrl { get; set; }

        }

        [NameInMap("OfficeSiteInfo")]
        [Validation(Required=false)]
        public FindIdpListByLoginIdentifierResponseBodyOfficeSiteInfo OfficeSiteInfo { get; set; }
        public class FindIdpListByLoginIdentifierResponseBodyOfficeSiteInfo : TeaModel {
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("ProviderId")]
            [Validation(Required=false)]
            public string ProviderId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SsoServiceUrl")]
            [Validation(Required=false)]
            public string SsoServiceUrl { get; set; }

        }

        [NameInMap("PopRegionConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> PopRegionConfig { get; set; }

        [NameInMap("ProfileRegion")]
        [Validation(Required=false)]
        public string ProfileRegion { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TenantAliasInfo")]
        [Validation(Required=false)]
        public FindIdpListByLoginIdentifierResponseBodyTenantAliasInfo TenantAliasInfo { get; set; }
        public class FindIdpListByLoginIdentifierResponseBodyTenantAliasInfo : TeaModel {
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            [NameInMap("TenantAlias")]
            [Validation(Required=false)]
            public string TenantAlias { get; set; }

        }

    }

}
