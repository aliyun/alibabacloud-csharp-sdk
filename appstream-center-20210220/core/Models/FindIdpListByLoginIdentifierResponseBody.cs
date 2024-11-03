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
            /// <summary>
            /// <b>Example:</b>
            /// <para>simple</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Cookies")]
            [Validation(Required=false)]
            public string Cookies { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>idp-hlyexfvwert9m8****</para>
            /// </summary>
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public string IdpId { get; set; }

            [NameInMap("IdpName")]
            [Validation(Required=false)]
            public string IdpName { get; set; }

            [NameInMap("IdpNameEN")]
            [Validation(Required=false)]
            public string IdpNameEN { get; set; }

            [NameInMap("IdpProvider")]
            [Validation(Required=false)]
            public string IdpProvider { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("JumpSwitch")]
            [Validation(Required=false)]
            public string JumpSwitch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SAML</para>
            /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai+dir-448204****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("ProviderId")]
            [Validation(Required=false)]
            public string ProviderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn_hangzhou</para>
        /// </summary>
        [NameInMap("ProfileRegion")]
        [Validation(Required=false)]
        public string ProfileRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AD2D0761-1FE5-549D-B169-D3F8D19C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TenantAliasInfo")]
        [Validation(Required=false)]
        public FindIdpListByLoginIdentifierResponseBodyTenantAliasInfo TenantAliasInfo { get; set; }
        public class FindIdpListByLoginIdentifierResponseBodyTenantAliasInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Or09****</para>
            /// </summary>
            [NameInMap("TenantAlias")]
            [Validation(Required=false)]
            public string TenantAlias { get; set; }

        }

    }

}
