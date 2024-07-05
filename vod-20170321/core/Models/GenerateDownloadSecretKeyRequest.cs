// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GenerateDownloadSecretKeyRequest : TeaModel {
        /// <summary>
        /// A custom string of 16 to 32 characters in length. The string must contain uppercase letters, lowercase letters, and digits.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppDecryptKey")]
        [Validation(Required=false)]
        public string AppDecryptKey { get; set; }

        /// <summary>
        /// The unique identifier of the app.
        /// 
        /// *   Android: the SHA-1 fingerprint of the keystore. The value is a string that contains a colon (:).
        /// *   iOS: the bundle ID of the app.
        /// *   Windows: the serial number in the digital signature certificate.
        /// 
        /// For more information about how to obtain the unique identifier of an app, see [Obtain the unique app identifier](~~86107#section-wtj-9d7-lg2~~).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppIdentification")]
        [Validation(Required=false)]
        public string AppIdentification { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
