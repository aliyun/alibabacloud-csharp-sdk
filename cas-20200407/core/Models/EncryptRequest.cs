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
        /// <item><description><para><b>RSAES_OAEP_SHA_1</b></para>
        /// </description></item>
        /// <item><description><para><b>RSAES_OAEP_SHA_256</b></para>
        /// </description></item>
        /// <item><description><para><b>SM2PKE</b></para>
        /// </description></item>
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
        /// <para>The unique identifier of the certificate. To obtain this parameter, call the <a href="https://help.aliyun.com/document_detail/455806.html">ListCert</a> operation.</para>
        /// <list type="bullet">
        /// <item><description><para>The identifier of an SSL certificate is usually in the {Certificate ID}-cn-hangzhou format.</para>
        /// </description></item>
        /// <item><description><para>For a private certificate authority (PCA) certificate, this is the value of the Identifier field of the private certificate.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1ef1da5f-38ed-69b3-****-037781890265</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The custom identifier, which serves as a unique key.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>6bb538d538c70c01f81dg3</b></b></para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The message type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>RAW (default): Directly encrypts the value of Plaintext.</para>
        /// </description></item>
        /// <item><description><para>Base64: Decodes the Base64-encoded value of Plaintext and then encrypts the decoded data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RAW</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>The data to encrypt. The data can be plaintext or Base64-encoded plaintext. For more information, see the MessageType parameter. If you use Base64 encoding, for example, if the hexadecimal content of the data to be encrypted is <c>[0x31, 0x32, 0x33, 0x34]</c>, the corresponding Base64-encoded string is MTIzNA==. The maximum size of Plaintext depends on the Algorithm:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RSAES_OAEP_SHA_1</b>: 214 bytes.</para>
        /// </description></item>
        /// <item><description><para><b>RSAES_OAEP_SHA_256</b>: 190 bytes.</para>
        /// </description></item>
        /// <item><description><para><b>SM2PKE</b>: 6047 bytes.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234***</para>
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

        /// <summary>
        /// <para>The repository ID.</para>
        /// <remarks>
        /// <para>To obtain this ID, call the <a href="https://help.aliyun.com/document_detail/455805.html">ListCertWarehouse</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("WarehouseId")]
        [Validation(Required=false)]
        public long? WarehouseId { get; set; }

    }

}
