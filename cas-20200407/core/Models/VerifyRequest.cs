// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class VerifyRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the certificate. To get this parameter, call the <a href="https://help.aliyun.com/document_detail/455806.html">ListCert</a> operation.</para>
        /// <list type="bullet">
        /// <item><description><para>The identifier for an SSL certificate is typically in the format \<c>{Certificate ID}-cn-hangzhou\\</c>.</para>
        /// </description></item>
        /// <item><description><para>For a PCA certificate, this is the value of the \<c>Identifier\\</c> field.</para>
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
        /// <para>The custom identifier. This key must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>6bb538d538c70c01f81jh2</b></b></para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The data to verify. The data must be Base64-encoded. For example, if the hexadecimal content of the data to sign is \<c>[0x31, 0x32, 0x33, 0x34]\\</c>, the Base64-encoded value is \<c>MTIzNA==\\</c>. If you set \<c>MessageType\\</c> to \<c>RAW\\</c>, the data size must be less than 4 KB. If the data to sign is larger than 4 KB, set \<c>MessageType\\</c> to \<c>DIGEST\\</c>. Then, set \<c>Message\\</c> to the message digest, or hash, that you calculate locally. The hashing algorithm for the digest must be compatible with the signature algorithm:<br></para>
        /// <list type="bullet">
        /// <item><description><para>The hashing algorithm for \<c>SHA256withRSA\\</c>, \<c>SHA256withRSA/PSS\\</c>, and \<c>SHA256withECDSA\\</c> is SHA-256.</para>
        /// </description></item>
        /// <item><description><para>The hashing algorithm for \<c>SM3withSM2\\</c> is SM3.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNA==</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The message type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RAW</b> (default): The raw data.</para>
        /// </description></item>
        /// <item><description><para><b>DIGEST</b>: The message digest of the raw data.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAW</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>The signature value. The value must be Base64-encoded.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyaC0w3ROK5b3QcHmUtAhMY/sQjKu2t3uBfnf6J/gn7JfZtyxwcCUjzXbw5jmqJQRbj1te670Bshg9kUdanKhtHFhJjU5jX+ZMMBr6pH0gqQDJxR0K0yHXRc0Q5OQoUZ6BfpbI4Wt4jJvJSdCstz1vSg12CfEHS8Kd5qfhItK7Y=</para>
        /// </summary>
        [NameInMap("SignatureValue")]
        [Validation(Required=false)]
        public string SignatureValue { get; set; }

        /// <summary>
        /// <para>The signature algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SHA256withRSA</b></para>
        /// </description></item>
        /// <item><description><para><b>SHA256withRSA/PSS</b></para>
        /// </description></item>
        /// <item><description><para><b>SHA256withECDSA</b></para>
        /// </description></item>
        /// <item><description><para><b>SM3withSM2</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHA256withRSA</para>
        /// </summary>
        [NameInMap("SigningAlgorithm")]
        [Validation(Required=false)]
        public string SigningAlgorithm { get; set; }

        /// <summary>
        /// <para>The ID of the repository. To get this parameter, call the <a href="https://help.aliyun.com/document_detail/453246.html">ListCertWarehouse</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WarehouseId")]
        [Validation(Required=false)]
        public string WarehouseId { get; set; }

    }

}
