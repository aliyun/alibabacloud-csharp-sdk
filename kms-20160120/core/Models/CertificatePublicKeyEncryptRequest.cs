// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CertificatePublicKeyEncryptRequest : TeaModel {
        /// <summary>
        /// <para>The encryption algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>RSAES_OAEP_SHA_1</para>
        /// </description></item>
        /// <item><description><para>RSAES_OAEP_SHA_256</para>
        /// </description></item>
        /// <item><description><para>SM2PKE</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The SM2PKE encryption algorithm is supported only in regions in mainland China. In these regions, managed hardware security modules (HSMs) are used. For more information, see <a href="https://help.aliyun.com/document_detail/125803.html">Managed HSM overview</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSAES_OAEP_SHA_256</para>
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
        /// <para>The data that you want to encrypt.</para>
        /// <para>The value is encoded in Base64. For example, if the hexadecimal data that you want to encrypt is <c>[0x31, 0x32, 0x33, 0x34]</c>, the Base64-encoded data is <c>MTIzNA==</c>.</para>
        /// <para>The size of data that can be encrypted varies based on the encryption algorithm that you use:</para>
        /// <list type="bullet">
        /// <item><description>RSAES_OAEP_SHA_1: 214 bytes</description></item>
        /// <item><description>RSAES_OAEP_SHA_256: 190 bytes</description></item>
        /// <item><description>SM2PKE: 6,047 bytes</description></item>
        /// </list>
        /// <para>If the size of data that you want to encrypt exceeds the preceding limits, you can call the <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a> operation to generate a data key to encrypt the data. Then, call the CertificatePublicKeyEncrypt operation to encrypt the data key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIHRoZSBsYXp5IGRvZy4=</para>
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

    }

}
