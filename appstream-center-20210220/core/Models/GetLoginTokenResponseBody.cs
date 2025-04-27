// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210220.Models
{
    public class GetLoginTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ad</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>easthp***.com</para>
        /// </summary>
        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alice***@aliyun.com</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>idp-7ttvs4ove8bo5***</para>
        /// </summary>
        [NameInMap("IdpId")]
        [Validation(Required=false)]
        public string IdpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>edu</para>
        /// </summary>
        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>006YwvYMsesWWsDBZnVB+Wq9AvJDVIqOY3YCktvtb7+KxMb3ClnNlV8+l/knhZYrXUmeP06IzkjF+IgcZ3vZKOyMprDyFHjCy1r27FRE/U7+geWCl8iQ+yF8GaCRHfJEkC2+ROs93HkT4tfHxyY1J8W7O7ZQGUC/cdCvm+cCP6FIy73IUuPuVR6PcKYXIp***</para>
        /// </summary>
        [NameInMap("KeepAliveToken")]
        [Validation(Required=false)]
        public string KeepAliveToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test:wuying</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v185fdd7f6d39fa7861981639366085772e150a390a5bb7b43c4e62440d94fc392b945770e1596cebe90085ce0af4d****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        [NameInMap("MfaTypeList")]
        [Validation(Required=false)]
        public List<GetLoginTokenResponseBodyMfaTypeList> MfaTypeList { get; set; }
        public class GetLoginTokenResponseBodyMfaTypeList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MFABind</para>
        /// </summary>
        [NameInMap("NextStage")]
        [Validation(Required=false)]
        public string NextStage { get; set; }

        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TenantPasswordLength")]
            [Validation(Required=false)]
            public int? TenantPasswordLength { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1826717****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("Props")]
        [Validation(Required=false)]
        public Dictionary<string, string> Props { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5OCLLKKOJU5HPBX66H3QCTWY******</para>
        /// </summary>
        [NameInMap("QrCodePng")]
        [Validation(Required=false)]
        public string QrCodePng { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PasswordExpired</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EEA72491-B731-53D6-83ED-209769D6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskVerifyInfo")]
        [Validation(Required=false)]
        public GetLoginTokenResponseBodyRiskVerifyInfo RiskVerifyInfo { get; set; }
        public class GetLoginTokenResponseBodyRiskVerifyInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ppas***@aliyun.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12000</para>
            /// </summary>
            [NameInMap("LastLockDuration")]
            [Validation(Required=false)]
            public long? LastLockDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Locked")]
            [Validation(Required=false)]
            public bool? Locked { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1826717****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4JZNSDHDM3T6AZ4G2O5OWXBLLE4P****</para>
        /// </summary>
        [NameInMap("Secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cc15c91c-821b-4edd-9af2-6df66cc****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Rq201***</para>
        /// </summary>
        [NameInMap("TenantAlias")]
        [Validation(Required=false)]
        public string TenantAlias { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13747924304****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("TenantInfos")]
        [Validation(Required=false)]
        public List<GetLoginTokenResponseBodyTenantInfos> TenantInfos { get; set; }
        public class GetLoginTokenResponseBodyTenantInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>INTERNET</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Up830***</para>
            /// </summary>
            [NameInMap("TenantAlias")]
            [Validation(Required=false)]
            public string TenantAlias { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Windowed</para>
        /// </summary>
        [NameInMap("WindowDisplayMode")]
        [Validation(Required=false)]
        public string WindowDisplayMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0aba1403b337a***</para>
        /// </summary>
        [NameInMap("WyId")]
        [Validation(Required=false)]
        public string WyId { get; set; }

    }

}
