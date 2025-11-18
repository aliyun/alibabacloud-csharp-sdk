// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210220.Models
{
    public class GetLoginTokenRequest : TeaModel {
        [NameInMap("AreaSite")]
        [Validation(Required=false)]
        public string AreaSite { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>182901</para>
        /// </summary>
        [NameInMap("AuthenticationCode")]
        [Validation(Required=false)]
        public string AuthenticationCode { get; set; }

        [NameInMap("AvailableFeatures")]
        [Validation(Required=false)]
        public Dictionary<string, string> AvailableFeatures { get; set; }

        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05967f80-6f51-46cb-a27c-****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>windows_\&quot;Windows 10 Pro\&quot; 10.0 (Build 22631)</para>
        /// </summary>
        [NameInMap("ClientOS")]
        [Validation(Required=false)]
        public string ClientOS { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7.3.0-20240619.143924</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SsoTokenLogin</para>
        /// </summary>
        [NameInMap("CurrentStage")]
        [Validation(Required=false)]
        public string CurrentStage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing+dir-j9dd****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("EncryptedFingerPrintData")]
        [Validation(Required=false)]
        public string EncryptedFingerPrintData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4d7****8e90bb0484fc</para>
        /// </summary>
        [NameInMap("EncryptedKey")]
        [Validation(Required=false)]
        public string EncryptedKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04d7****8e90bb0484fc;gJ1GLca1vQRRqQbRvByU0A==;5kOWZE7AtbQhki+4LAo69A==</para>
        /// </summary>
        [NameInMap("EncryptedPassword")]
        [Validation(Required=false)]
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("FingerPrintData")]
        [Validation(Required=false)]
        public string FingerPrintData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>idp-iwntrlbb98q7v****</para>
        /// </summary>
        [NameInMap("IdpId")]
        [Validation(Required=false)]
        public string IdpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("KeepAlive")]
        [Validation(Required=false)]
        public bool? KeepAlive { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00ugamMAoO1+u1MlhmgCeZJ75q094x3H/4kg7ZaTI3f/joVTVPIpJgfv9JFkPLNxnQjblrvsByNas08mc6FtVWvQPOE68fqmt6QMM4UbRtahm8luxEXvicF58qSPXW1hxOtV/Ev6d92VBz2Bck/N4CYyjD0iLocfN8jkBnt231****</para>
        /// </summary>
        [NameInMap("KeepAliveToken")]
        [Validation(Required=false)]
        public string KeepAliveToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Fe04****</para>
        /// </summary>
        [NameInMap("LoginIdentifier")]
        [Validation(Required=false)]
        public string LoginIdentifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("LoginName")]
        [Validation(Required=false)]
        public string LoginName { get; set; }

        [NameInMap("MfaType")]
        [Validation(Required=false)]
        public string MfaType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Admin@1234****</para>
        /// </summary>
        [NameInMap("NewPassword")]
        [Validation(Required=false)]
        public string NewPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing+dir-j9dd****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Admin@1234****</para>
        /// </summary>
        [NameInMap("OldPassword")]
        [Validation(Required=false)]
        public string OldPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Admin@1234****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1822727****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>321123</para>
        /// </summary>
        [NameInMap("PhoneVerifyCode")]
        [Validation(Required=false)]
        public string PhoneVerifyCode { get; set; }

        [NameInMap("ProfileRegion")]
        [Validation(Required=false)]
        public string ProfileRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c6f3cd91-65fc-4c7b-b189-2a73da0****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("SsoExtendsCookies")]
        [Validation(Required=false)]
        public string SsoExtendsCookies { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04d707a6-fb23-44a7-aae7-8e90****</para>
        /// </summary>
        [NameInMap("SsoSessionToken")]
        [Validation(Required=false)]
        public string SsoSessionToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234***</para>
        /// </summary>
        [NameInMap("TokenCode")]
        [Validation(Required=false)]
        public string TokenCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04d707a6-fb23-44a7-aae7-8e90bb04****</para>
        /// </summary>
        [NameInMap("UmidToken")]
        [Validation(Required=false)]
        public string UmidToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C50973691A6D2BE23F2CDD73B85B****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
