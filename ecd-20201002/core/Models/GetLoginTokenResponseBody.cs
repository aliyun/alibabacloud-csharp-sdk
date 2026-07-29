// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class GetLoginTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The email address of the user. This value is returned with the LoginToken after logon.    </para>
        /// <list type="bullet">
        /// <item><description>For a convenience user, the email address specified when the convenience user was created is returned.</description></item>
        /// <item><description>For an AD user, the value is returned in the format of <c>username@AD domain name</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The convenience account username or AD username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This is an internal field and is not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>edu</para>
        /// </summary>
        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>The token used to keep the logon session alive. After a successful logon with the keep-alive option enabled, the operation returns a <c>KeepAliveToken</c>. If the keep-alive option is not enabled, an empty value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>006YwvYMsesWWsDBZnVB+Wq9AvJDVIqOY3YCktvtb7+KxMb3ClnNlV8+l/knhZYrXUmeP06IzkjF+IgcZ3vZKOyMprDyFHjCy1r27FRE/U7+geWCl8iQ+yF8GaCRHfJEkC2+ROs93HkT4tfHxyY1J8W7O7ZQGUC/cdCvm+cCP6FIy73IUuPuVR6PcKYXIpEZPW</para>
        /// </summary>
        [NameInMap("KeepAliveToken")]
        [Validation(Required=false)]
        public string KeepAliveToken { get; set; }

        /// <summary>
        /// <para>The property of the convenience user. If the user is an AD user, an empty value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test:wuying</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The logon credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v18101ac6a9e69c66b04a163031680463660b4b216cd758f34b60b9ad6a7c7f7334b83dd8f75eef4209c68f9f1080b****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <para>The expected next stage. For example, if the administrator has enabled MFA authentication in the Elastic Desktop Service console, after the username and password authentication is passed (the <c>ADPassword</c> stage), this parameter returns <c>MFAVerify</c>, indicating that MFA authentication is required.</para>
        /// <remarks>
        /// <para>For more information about each authentication stage, see the parameter description of the <c>CurrentStage</c> request parameter of this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MFAVerify</para>
        /// </summary>
        [NameInMap("NextStage")]
        [Validation(Required=false)]
        public string NextStage { get; set; }

        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This is an internal field and is not available for public use.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("PasswordStrategy")]
        [Validation(Required=false)]
        public GetLoginTokenResponseBodyPasswordStrategy PasswordStrategy { get; set; }
        public class GetLoginTokenResponseBodyPasswordStrategy : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This is an internal field and is not available for public use.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TenantAlternativeChars")]
            [Validation(Required=false)]
            public List<string> TenantAlternativeChars { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This is an internal field and is not available for public use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("TenantPasswordLength")]
            [Validation(Required=false)]
            public string TenantPasswordLength { get; set; }

        }

        /// <summary>
        /// <para>The phone number of the convenience user. If the user is an AD user, an empty value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1381111****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This is an internal field and is not available for public use.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Props")]
        [Validation(Required=false)]
        public Dictionary<string, string> Props { get; set; }

        /// <summary>
        /// <para>The QR code of the secret key used when attaching a virtual MFA device. The value uses Base64 encoding. This value can be empty and is used in the <c>MFABind</c> stage.</para>
        /// <remarks>
        /// <para>For more information about each authentication stage, see the parameter description of the <c>CurrentStage</c> request parameter of this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5OCLLKKOJU5HPBX66H3QCTWY******</para>
        /// </summary>
        [NameInMap("QrCodePng")]
        [Validation(Required=false)]
        public string QrCodePng { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This is an internal field and is not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The logon risk identification information.</para>
        /// </summary>
        [NameInMap("RiskVerifyInfo")]
        [Validation(Required=false)]
        public GetLoginTokenResponseBodyRiskVerifyInfo RiskVerifyInfo { get; set; }
        public class GetLoginTokenResponseBodyRiskVerifyInfo : TeaModel {
            /// <summary>
            /// <para>The email address used for identity verification when risk verification is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:user@example.com">user@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The account lockout duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1713749778</para>
            /// </summary>
            [NameInMap("LastLockDuration")]
            [Validation(Required=false)]
            public long? LastLockDuration { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is locked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Locked")]
            [Validation(Required=false)]
            public string Locked { get; set; }

            /// <summary>
            /// <para>The phone number used for identity verification when risk verification is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

        }

        /// <summary>
        /// <para>The secret key used when attaching a virtual MFA device. This value is used in the <c>MFABind</c> stage.</para>
        /// <remarks>
        /// <para>For more information about each authentication stage, see the parameter description of the <c>CurrentStage</c> request parameter of this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5OCLLKKOJU5HPBX66H3QCTWYI7MH****</para>
        /// </summary>
        [NameInMap("Secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        /// <summary>
        /// <para>The session ID. This value is returned only when <c>GetLoginToken</c> is invoked for the first time within the same session. For subsequent stages that require multiple authentications, pass in this parameter.</para>
        /// <remarks>
        /// <para>For more information about each authentication stage, see the parameter description of the <c>CurrentStage</c> request parameter of this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d6ec166d-ab93-4286-bf7f-a18bb929****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID. This value is used for hardware terminal identification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>166353906220****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This is an internal field and is not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mode</para>
        /// </summary>
        [NameInMap("WindowDisplayMode")]
        [Validation(Required=false)]
        public string WindowDisplayMode { get; set; }

        [NameInMap("WyId")]
        [Validation(Required=false)]
        public string WyId { get; set; }

    }

}
