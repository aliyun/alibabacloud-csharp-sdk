// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateClientKeyRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **CreateClientKey**.
        /// </summary>
        [NameInMap("AapName")]
        [Validation(Required=false)]
        public string AapName { get; set; }

        /// <summary>
        /// The encryption password of the client key.
        /// 
        /// The password must be 8 to 64 characters in length and must contain at least two of the following types: digits, letters, and special characters. Special characters include `~ ! @ # $ % ^ & * ? _ -`.
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        /// <summary>
        /// The end of the validity period of the client key.
        /// 
        /// Specify the time in the ISO 8601 standard. The time must be in UTC. The time must be in the yyyy-MM-ddTHH:mm:ssZ format.
        /// 
        /// > 
        /// 
        /// *   If you do not configure NotAfter, the default value is the time when the client key was created plus five years.
        /// *   If you configure NotAfter, you must configure NotBefore.
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        /// <summary>
        /// The name of the AAP.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
