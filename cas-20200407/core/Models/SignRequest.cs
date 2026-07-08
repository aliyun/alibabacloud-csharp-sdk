// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class SignRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the certificate. You can get this value by calling the <a href="https://help.aliyun.com/document_detail/455806.html">ListCert</a> operation.</para>
        /// <list type="bullet">
        /// <item><description><para>The identifier of an SSL certificate is typically in the format \&quot;{Certificate ID}-cn-hangzhou\&quot;.</para>
        /// </description></item>
        /// <item><description><para>For a PCA certificate, this is the Identifier from the corresponding private certificate.</para>
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
        /// <para>A unique, user-defined identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b>e6bb538d538c70c01f81fg3</b></em>*</para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The data to sign. The MessageType parameter determines the format of this data. If MessageType is set to RAW, Message is the raw data. If MessageType is set to BASE64, Message is the Base64-encoded raw data. If MessageType is set to DIGEST, Message is the message digest (hash value). If MessageType is set to BLIND, Message is the Base64-encoded blinded message.</para>
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
        /// <item><description><para><c>RAW</c> (default): The raw data.</para>
        /// </description></item>
        /// <item><description><para><c>DIGEST</c>: The message digest (hash value) of the raw data.</para>
        /// </description></item>
        /// <item><description><para><c>BASE64</c>: The Base64-encoded raw data.</para>
        /// </description></item>
        /// <item><description><para><c>BLIND</c>: Enables blind signing. This is supported only for certificates that use an RSA algorithm.</para>
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
        /// <para>The signature algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>SHA256withRSA</c></para>
        /// </description></item>
        /// <item><description><para><c>SHA256withRSA/PSS</c></para>
        /// </description></item>
        /// <item><description><para><c>SHA256withECDSA</c></para>
        /// </description></item>
        /// <item><description><para><c>SM3withSM2</c></para>
        /// </description></item>
        /// <item><description><para><c>SHA256withRSA/P7</c></para>
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
        /// <para>The repository ID.</para>
        /// <remarks>
        /// <para>You can get this ID by calling the <a href="https://help.aliyun.com/document_detail/455805.html">ListCertWarehouse</a> operation.</para>
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
