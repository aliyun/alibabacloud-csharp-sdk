// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DecryptRequest : TeaModel {
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
        /// <para>The unique identifier of the certificate. Call <a href="https://help.aliyun.com/document_detail/455806.html">ListCert</a> to obtain this parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>The identifier of an SSL certificate is typically in the format {Certificate ID}-cn-hangzhou.</para>
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
        /// <para>The Base64-encoded data to decrypt.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</para>
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// <para>A custom identifier that serves as a unique key.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>6bb538d538c70c01f81jh2</b></b></para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The message type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>RAW: The response returns the plaintext in UTF-8 encoding.</para>
        /// </description></item>
        /// <item><description><para>Base64 (default): The response returns the Base64-encoded plaintext.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>The ID of the repository.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/455805.html">ListCertWarehouse</a> to obtain this ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WarehouseId")]
        [Validation(Required=false)]
        public long? WarehouseId { get; set; }

    }

}
