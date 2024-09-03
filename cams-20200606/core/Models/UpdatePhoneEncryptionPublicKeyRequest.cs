// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdatePhoneEncryptionPublicKeyRequest : TeaModel {
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EncryptionPublicKey")]
        [Validation(Required=false)]
        public string EncryptionPublicKey { get; set; }

        /// <summary>
        /// The phone number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

    }

}
