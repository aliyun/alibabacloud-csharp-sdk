// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210220.Models
{
    public class GetLoginTokenRequest : TeaModel {
        [NameInMap("AuthenticationCode")]
        [Validation(Required=false)]
        public string AuthenticationCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientOS")]
        [Validation(Required=false)]
        public string ClientOS { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("CurrentStage")]
        [Validation(Required=false)]
        public string CurrentStage { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("EncryptedFingerPrintData")]
        [Validation(Required=false)]
        public string EncryptedFingerPrintData { get; set; }

        [NameInMap("EncryptedKey")]
        [Validation(Required=false)]
        public string EncryptedKey { get; set; }

        [NameInMap("EncryptedPassword")]
        [Validation(Required=false)]
        public string EncryptedPassword { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("FingerPrintData")]
        [Validation(Required=false)]
        public string FingerPrintData { get; set; }

        [NameInMap("IdpId")]
        [Validation(Required=false)]
        public string IdpId { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("KeepAlive")]
        [Validation(Required=false)]
        public bool? KeepAlive { get; set; }

        [NameInMap("KeepAliveToken")]
        [Validation(Required=false)]
        public string KeepAliveToken { get; set; }

        [NameInMap("LoginIdentifier")]
        [Validation(Required=false)]
        public string LoginIdentifier { get; set; }

        [NameInMap("LoginName")]
        [Validation(Required=false)]
        public string LoginName { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("NewPassword")]
        [Validation(Required=false)]
        public string NewPassword { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("OldPassword")]
        [Validation(Required=false)]
        public string OldPassword { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("PhoneVerifyCode")]
        [Validation(Required=false)]
        public string PhoneVerifyCode { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("SsoExtendsCookies")]
        [Validation(Required=false)]
        public string SsoExtendsCookies { get; set; }

        [NameInMap("SsoSessionToken")]
        [Validation(Required=false)]
        public string SsoSessionToken { get; set; }

        [NameInMap("TokenCode")]
        [Validation(Required=false)]
        public string TokenCode { get; set; }

        [NameInMap("UmidToken")]
        [Validation(Required=false)]
        public string UmidToken { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
