// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class EncryptRequest : TeaModel {
        /// <summary>
        /// <para>The encryption algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RSAES_OAEP_SHA_1</b></description></item>
        /// <item><description><b>RSAES_OAEP_SHA_256</b></description></item>
        /// <item><description><b>SM2PKE</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSAESOAEPSHA_1</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The unique identifier of the certificate. You can call the <a href="https://help.aliyun.com/document_detail/455806.html">ListCert</a> operation to obtain the identifier.</para>
        /// <list type="bullet">
        /// <item><description>If the certificate is an SSL certificate, the value of this parameter must be in the {Certificate ID}-cn-hangzhou format.</description></item>
        /// <item><description>If the certificate is a private certificate, the value of this parameter must be the value of the Identifier field for the private certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-12345678****</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The value type of the Message parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RAW: The value of the Plaintext parameter is directly encrypted. This is the default value.</description></item>
        /// <item><description>Base64: The value of the Plaintext parameter is Base64-encoded data. The data is decoded and then encrypted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RAW</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>The data that you want to encrypt. The value of this parameter can be raw data or Base64-encoded data. For more information, see the description of the MessageType parameter. For example, if the hexadecimal data that you want to encrypt is <c>[0x31, 0x32, 0x33, 0x34]</c>, the Base64-encoded data is MTIzNA==. The size of data that can be encrypted varies based on the encryption algorithm that you use. The following list describes the relationship between the encryption algorithms and data sizes:</para>
        /// <list type="bullet">
        /// <item><description><b>RSAES_OAEP_SHA_1</b>: 214 bytes</description></item>
        /// <item><description><b>RSAES_OAEP_SHA_256</b>: 190 bytes</description></item>
        /// <item><description><b>SM2PKE</b>: 6,047 bytes</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234***</para>
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

    }

}
