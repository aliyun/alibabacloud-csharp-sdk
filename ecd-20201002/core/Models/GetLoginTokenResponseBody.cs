// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class GetLoginTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The email address of the user. The system returns the email address in the return value of the LoginToken parameter after the user logs on to the client.</para>
        /// <list type="bullet">
        /// <item><description>For a convenience user, the return value is the email address specified when the administrator creates the convenience user.</description></item>
        /// <item><description>For an AD user, the return value is in the following format: <c>Username@Name of the AD domain</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The account of the convenience user or the AD user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This is a parameter only for internal use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>edu</para>
        /// </summary>
        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// <para>The token used to keep the user logged on. After the user logs on to the client and select the Keep Logon option, <c>KeepAliveToken</c> is returned when you call the operation. If the user does not select the Keep Logon option, null is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>006YwvYMsesWWsDBZnVB+Wq9AvJDVIqOY3YCktvtb7+KxMb3ClnNlV8+l/knhZYrXUmeP06IzkjF+IgcZ3vZKOyMprDyFHjCy1r27FRE/U7+geWCl8iQ+yF8GaCRHfJEkC2+ROs93HkT4tfHxyY1J8W7O7ZQGUC/cdCvm+cCP6FIy73IUuPuVR6PcKYXIpEZPW</para>
        /// </summary>
        [NameInMap("KeepAliveToken")]
        [Validation(Required=false)]
        public string KeepAliveToken { get; set; }

        /// <summary>
        /// <para>The attribute of the convenience user. For an AD user, null is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test:sample</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The logon token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v18101ac6a9e69c66b04a163031680463660b4b216cd758f34b60b9ad6a7c7f7334b83dd8f75eef4209c68f9f1080b****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <para>The next stage that is expected to enter. For example, an administrator enables MFA in the EDS console. When an end user enters the password, that is, the end user completes the <c>ADPassword</c> stage, this parameter returns <c>MFAVerify</c>. This indicates that MFA is required.</para>
        /// <remarks>
        /// <para> For more information about the authentication stages, see the <c>CurrentStage</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MFAVerify</para>
        /// </summary>
        [NameInMap("NextStage")]
        [Validation(Required=false)]
        public string NextStage { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This is a parameter only for internal use.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("PasswordStrategy")]
        [Validation(Required=false)]
        public GetLoginTokenResponseBodyPasswordStrategy PasswordStrategy { get; set; }
        public class GetLoginTokenResponseBodyPasswordStrategy : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This is a parameter only for internal use.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TenantAlternativeChars")]
            [Validation(Required=false)]
            public List<string> TenantAlternativeChars { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This is a parameter only for internal use.</para>
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
        /// <para>Enter the mobile number of the convenience user. For an AD user, null is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1381111****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This is a parameter only for internal use.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Props")]
        [Validation(Required=false)]
        public Dictionary<string, string> Props { get; set; }

        /// <summary>
        /// <para>The QR code that is generated when the virtual MFA device is bound. The value is encoded in Base64. This parameter can be empty. This parameter is required only when the CurrentStage parameter is set to <c>MFABind</c>.</para>
        /// <remarks>
        /// <para>For more information about each authentication stage, see the parameter description of the request parameter <c>CurrentStage</c>.</para>
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
        /// <para>This is a parameter only for internal use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Risk identification information regarding the signin process.</para>
        /// </summary>
        [NameInMap("RiskVerifyInfo")]
        [Validation(Required=false)]
        public GetLoginTokenResponseBodyRiskVerifyInfo RiskVerifyInfo { get; set; }
        public class GetLoginTokenResponseBodyRiskVerifyInfo : TeaModel {
            /// <summary>
            /// <para>The email used for authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:user@example.com">user@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The duration of the lock.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1713749778</para>
            /// </summary>
            [NameInMap("LastLockDuration")]
            [Validation(Required=false)]
            public long? LastLockDuration { get; set; }

            /// <summary>
            /// <para>Whether the account is locked or not.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Locked")]
            [Validation(Required=false)]
            public string Locked { get; set; }

            /// <summary>
            /// <para>The mobile number used for authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1388888****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

        }

        /// <summary>
        /// <para>The key that is generated when you bind the virtual MFA device. This parameter is required when the CurrentStage parameter is set to <c>MFABind</c>.</para>
        /// <remarks>
        /// <para>For more information about each authentication stage, see the parameter description of the request parameter <c>CurrentStage</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5OCLLKKOJU5HPBX66H3QCTWYI7MH****</para>
        /// </summary>
        [NameInMap("Secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        /// <summary>
        /// <para>The ID of the session. The ID is returned the first time you call the <c>GetLoginToken</c> operation in the session. If MFA is required, you must specify this parameter in subsequent stages.</para>
        /// <remarks>
        /// <para>For more information about each authentication stage, see the parameter description of the request parameter <c>CurrentStage</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d6ec166d-ab93-4286-bf7f-a18bb929****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. The ID is used for hardware client authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>166353906220****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This is a parameter only for internal use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mode</para>
        /// </summary>
        [NameInMap("WindowDisplayMode")]
        [Validation(Required=false)]
        public string WindowDisplayMode { get; set; }

    }

}
