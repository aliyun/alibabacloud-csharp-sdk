// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ReEncryptRequest : TeaModel {
        /// <summary>
        /// <para>The ciphertext that you want to re-encrypt.</para>
        /// <para>You can set this parameter to the ciphertext that is returned after a symmetric or asymmetric encryption operation.</para>
        /// <list type="bullet">
        /// <item><description>Symmetric encryption: the ciphertext returned after you call the <a href="https://help.aliyun.com/document_detail/28949.html">Encrypt</a>, <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a>, <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a>, or <a href="https://help.aliyun.com/document_detail/176804.html">GenerateAndExportDataKey</a> operation</description></item>
        /// <item><description>Asymmetric encryption: the public key-encrypted ciphertext returned after you call the <a href="https://help.aliyun.com/document_detail/176804.html">GenerateAndExportDataKey</a> operation, or the ciphertext encrypted by using the public key of an asymmetric key pair outside KMS</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODZhOWVmZDktM2QxNi00ODk0LWJkNGYtMWZjNDNmM2YyYWJmS7FmDBBQ0BkKsQrtRnidtPwirmDcS0ZuJCU41xxAAWk4Z8qsADfbV0b+i6kQmlvj79dJdGOvtX69Uycs901q********</para>
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// <para>A JSON string that consists of key-value pairs. This parameter specifies the EncryptionContext that is used to re-encrypt the decrypted data or data key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Example&quot;:&quot;Example&quot;}</para>
        /// </summary>
        [NameInMap("DestinationEncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> DestinationEncryptionContext { get; set; }

        /// <summary>
        /// <para>The ID of the symmetric CMK that is used to re-encrypt the ciphertext after the ciphertext is decrypted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234abcd-12ab-34cd-56ef-12345678****</para>
        /// </summary>
        [NameInMap("DestinationKeyId")]
        [Validation(Required=false)]
        public string DestinationKeyId { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The encryption algorithm based on which the public key is used to encrypt the ciphertext specified by CiphertextBlob. For more information about encryption algorithms, see <a href="https://help.aliyun.com/document_detail/148130.html">AsymmetricDecrypt</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RSAES_OAEP_SHA_256</description></item>
        /// <item><description>RSAES_OAEP_SHA_1</description></item>
        /// <item><description>SM2PKE</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set CiphertextBlob to the public key-encrypted ciphertext that is returned after an asymmetric encryption operation, specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RSAES_OAEP_SHA_256</para>
        /// </summary>
        [NameInMap("SourceEncryptionAlgorithm")]
        [Validation(Required=false)]
        public string SourceEncryptionAlgorithm { get; set; }

        /// <summary>
        /// <para>A JSON string that consists of key-value pairs. If you specify EncryptionContext when you call the <a href="https://help.aliyun.com/document_detail/28949.html">Encrypt</a>, <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a>, <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a>, or <a href="https://help.aliyun.com/document_detail/176804.html">GenerateAndExportDataKey</a> operation to encrypt the data or data key, an equivalent value is required here. For more information, see <a href="https://help.aliyun.com/document_detail/42975.html">EncryptionContext</a>.</para>
        /// <remarks>
        /// <para> If you set CiphertextBlob to the ciphertext that is returned after a symmetric encryption operation, specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Example&quot;:&quot;Example&quot;}</para>
        /// </summary>
        [NameInMap("SourceEncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> SourceEncryptionContext { get; set; }

        /// <summary>
        /// <para>The ID of the CMK that is used to decrypt the ciphertext.</para>
        /// <para>This parameter is the globally unique ID of the CMK.</para>
        /// <remarks>
        /// <para> If you set CiphertextBlob to the public key-encrypted ciphertext that is returned after an asymmetric encryption operation, specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5c438b18-05be-40ad-b6c2-3be6752c****</para>
        /// </summary>
        [NameInMap("SourceKeyId")]
        [Validation(Required=false)]
        public string SourceKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the CMK version that is used to decrypt the ciphertext.</para>
        /// <remarks>
        /// <para> If you set CiphertextBlob to the public key-encrypted ciphertext that is returned after an asymmetric encryption operation, specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2ab1a983-7072-4bbc-a582-584b5bd8****</para>
        /// </summary>
        [NameInMap("SourceKeyVersionId")]
        [Validation(Required=false)]
        public string SourceKeyVersionId { get; set; }

    }

}
