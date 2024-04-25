// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class GetLoginTokenResponseBody : TeaModel {
        /// <summary>
        /// The email address of the user. The system returns the email address in the return value of the LoginToken parameter after the user logs on to the client.
        /// 
        /// *   For a convenience user, the return value is the email address specified when the administrator creates the convenience user.
        /// *   For an AD user, the return value is in the following format: `Username@Name of the AD domain`.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The account of the convenience user or the AD user.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// > This is a parameter only for internal use.
        /// </summary>
        [NameInMap("Industry")]
        [Validation(Required=false)]
        public string Industry { get; set; }

        /// <summary>
        /// The token used to keep the user logged on. After the user logs on to the client and select the Keep Logon option, `KeepAliveToken` is returned when you call the operation. If the user does not select the Keep Logon option, null is returned.
        /// </summary>
        [NameInMap("KeepAliveToken")]
        [Validation(Required=false)]
        public string KeepAliveToken { get; set; }

        /// <summary>
        /// The attribute of the convenience user. For an AD user, null is returned.
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// The logon token.
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// The next stage that is expected to enter. For example, if the administrator enables MFA authentication in the EDS console, `MFAVerify` is returned after the username and password pass the authentication (after you set CurrentStage to `ADPassword` stage). This indicates that the MFA authentication is required.
        /// 
        /// > For more information about each authentication stage, see the parameter description of the request parameter `CurrentStage`.
        /// </summary>
        [NameInMap("NextStage")]
        [Validation(Required=false)]
        public string NextStage { get; set; }

        /// <summary>
        /// Enter the mobile number of the convenience user. For an AD user, null is returned.
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// > This is a parameter only for internal use.
        /// </summary>
        [NameInMap("Props")]
        [Validation(Required=false)]
        public Dictionary<string, string> Props { get; set; }

        /// <summary>
        /// The QR code that is generated when the virtual MFA device is bound. The value is encoded in Base64. This parameter can be empty. This parameter is required only when the CurrentStage parameter is set to `MFABind`.
        /// 
        /// > For more information about each authentication stage, see the parameter description of the request parameter `CurrentStage`.
        /// </summary>
        [NameInMap("QrCodePng")]
        [Validation(Required=false)]
        public string QrCodePng { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
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
            public string Locked { get; set; }

            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

        }

        /// <summary>
        /// The key that is generated when you bind the virtual MFA device. This parameter is required when the CurrentStage parameter is set to `MFABind`.
        /// 
        /// > For more information about each authentication stage, see the parameter description of the request parameter `CurrentStage`.
        /// </summary>
        [NameInMap("Secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        /// <summary>
        /// The ID of the session. The ID is returned the first time you call the `GetLoginToken` operation in the session. If MFA is required, you must specify this parameter in subsequent stages.
        /// 
        /// > For more information about each authentication stage, see the parameter description of the request parameter `CurrentStage`.
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account. The ID is used for hardware client authentication.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// > This is a parameter only for internal use.
        /// </summary>
        [NameInMap("WindowDisplayMode")]
        [Validation(Required=false)]
        public string WindowDisplayMode { get; set; }

    }

}
