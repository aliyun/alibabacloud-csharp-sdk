// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCertificatePrivateKeyRequest : TeaModel {
        /// <summary>
        /// <para>The password that is used to encrypt the private key. The password can contain letters, digits, and special characters, such as <c>, + - _ #</c>. The password can be up to 32 bytes in length.</para>
        /// <para><b>Warning</b> You must remember the password that you specify. The password is required to decrypt the encrypted private key. If you forget the password, the encrypted private key that is returned cannot be decrypted. You must call this operation again.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>!QA@WS3ed</para>
        /// </summary>
        [NameInMap("EncryptedCode")]
        [Validation(Required=false)]
        public string EncryptedCode { get; set; }

        /// <summary>
        /// <para>The unique identifier of the client certificate or server certificate that you want to query.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/330884.html">ListClientCertificate</a> operation to query the unique identifiers of all client certificates and server certificates.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bc37133bb7ed68c7938d928fd26d****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
