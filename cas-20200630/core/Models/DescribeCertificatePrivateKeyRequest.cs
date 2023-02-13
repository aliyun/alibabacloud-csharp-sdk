// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCertificatePrivateKeyRequest : TeaModel {
        /// <summary>
        /// The password that is used to encrypt the private key. The password can contain letters, digits, and special characters, such as `, + - _ #`. The password can be up to 32 bytes in length.
        /// 
        /// **
        /// 
        /// **Warning** You must remember the password that you specify. The password is required to decrypt the encrypted private key. If you forget the password, the encrypted private key that is returned cannot be decrypted. You must call this operation again.
        /// </summary>
        [NameInMap("EncryptedCode")]
        [Validation(Required=false)]
        public string EncryptedCode { get; set; }

        /// <summary>
        /// The unique identifier of the client certificate or server certificate that you want to query.
        /// 
        /// >  You can call the [ListClientCertificate](~~330884~~) operation to query the unique identifiers of all client certificates and server certificates.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
