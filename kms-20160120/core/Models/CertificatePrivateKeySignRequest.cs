// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CertificatePrivateKeySignRequest : TeaModel {
        /// <summary>
        /// <para>The signature algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>RSA_PKCS1_SHA_256</para>
        /// </description></item>
        /// <item><description><para>RSA_PSS_SHA_256</para>
        /// </description></item>
        /// <item><description><para>ECDSA_SHA_256</para>
        /// </description></item>
        /// <item><description><para>SM2DSA</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The SM2DSA signature algorithm is supported only in regions where managed hardware security modules (HSMs) are used in mainland China. For more information, see <a href="https://help.aliyun.com/document_detail/125803.html">Managed HSM overview</a>.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECDSA_SHA_256</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The ID of the certificate. The ID must be globally unique in Certificates Manager.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-12345678****</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// <para>The data to be signed.</para>
        /// <para>The value is encoded in Base64. For example, if the hexadecimal data that you want to sign is <c>[0x31, 0x32, 0x33, 0x34]</c>, the Base64-encoded data is <c>MTIzNA==</c>.</para>
        /// <para>If the MessageType parameter is set to RAW, the size of the data must be less than or equal to 4 KB.</para>
        /// <para>If the size of the data is greater than 4 KB, you can set the MessageType parameter to DIGEST and set the Message parameter to the digest of the data. The digest is also called hash value. You can compute the digest of the data on an on-premises machine. Certificates Manager uses the digest that you compute in your own certificate application system. The message digest algorithm that you use must match the specified signature algorithm. Comply with the following mapping between signature algorithms and message digest algorithms:</para>
        /// <list type="bullet">
        /// <item><description>If the signature algorithm is RSA_PKCS1_SHA_256, RSA_PSS_SHA_256, or ECDSA_SHA_256, the message digest algorithm must be SHA-256.</description></item>
        /// <item><description>If the signature algorithm is SM2DSA, the message digest algorithm must be SM3.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the key type of the certificate is EC_SM2 and the MessageType parameter is set to DIGEST, the value of the Message parameter is <c>e</c> that is described in GB/T 32918.2-2016 6.1.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The type of the message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RAW: the raw data. This is the default value.</description></item>
        /// <item><description>DIGEST: the message digest (hash value) of the raw data.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAW</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

    }

}
