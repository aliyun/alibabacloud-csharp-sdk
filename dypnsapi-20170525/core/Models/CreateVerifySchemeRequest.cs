// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class CreateVerifySchemeRequest : TeaModel {
        /// <summary>
        /// The app name.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The verification type. You can select multiple types only when the phone number verification is supported. Separate multiple types with commas (,).
        /// 
        /// *   **1**: phone number verification
        /// *   **2**: SMS verification
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// The bundle ID. This parameter is required when OsType is set to iOS. The bundle ID must be 1 to 128 characters in length and can contain digits, letters, hyphens (-), underscores (\_), and periods (.).
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// The channel code of China Mobile.
        /// </summary>
        [NameInMap("CmApiCode")]
        [Validation(Required=false)]
        public long? CmApiCode { get; set; }

        /// <summary>
        /// The channel code of China Telecom.
        /// </summary>
        [NameInMap("CtApiCode")]
        [Validation(Required=false)]
        public long? CtApiCode { get; set; }

        /// <summary>
        /// The channel code of China Unicom.
        /// </summary>
        [NameInMap("CuApiCode")]
        [Validation(Required=false)]
        public long? CuApiCode { get; set; }

        /// <summary>
        /// The email address that receives the key.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The IP address whitelist.
        /// </summary>
        [NameInMap("IpWhiteList")]
        [Validation(Required=false)]
        public string IpWhiteList { get; set; }

        /// <summary>
        /// The source URL of the HTML5 app page. We recommend that you specify this parameter as a domain name.
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// The type of the operating system for the terminal. Valid values: iOS and Android.
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The package name. This parameter is required when OsType is set to Android. The name must be 1 to 128 characters in length and can contain digits, letters, hyphens (-), underscores (\_), and periods (.).
        /// </summary>
        [NameInMap("PackName")]
        [Validation(Required=false)]
        public string PackName { get; set; }

        /// <summary>
        /// The package signature. This parameter is required when OsType is set to Android. The signature must be 32 characters in length and can contain digits and letters.
        /// </summary>
        [NameInMap("PackSign")]
        [Validation(Required=false)]
        public string PackSign { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The service type.
        /// </summary>
        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

        /// <summary>
        /// The service name.
        /// </summary>
        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

        /// <summary>
        /// The bound SMS signature. This parameter is valid only when AuthType is set to 2. The signature must be approved.
        /// </summary>
        [NameInMap("SmsSignName")]
        [Validation(Required=false)]
        public string SmsSignName { get; set; }

        /// <summary>
        /// The URL of the HTML5 app page.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
