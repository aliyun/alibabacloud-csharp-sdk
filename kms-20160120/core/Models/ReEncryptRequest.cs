// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ReEncryptRequest : TeaModel {
        /// <summary>
        /// <para>The ciphertext that you want to re-encrypt.<br> This parameter can be the ciphertext that is returned after symmetric or asymmetric key encryption.<br><br></para>
        /// <list type="bullet">
        /// <item><description><para>Symmetric encryption: the ciphertext that is returned after you call the <a href="https://help.aliyun.com/document_detail/28949.html">Encrypt</a>, <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a>, <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a>, or <a href="https://help.aliyun.com/document_detail/176804.html">GenerateAndExportDataKey</a> operation.</para>
        /// </description></item>
        /// <item><description><para>Asymmetric key encryption: the data that is encrypted using a public key after you call the <a href="https://help.aliyun.com/document_detail/176804.html">GenerateAndExportDataKey</a> operation, or the data that is encrypted using an asymmetric public key in an external system.</para>
        /// </description></item>
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
        /// <para>A JSON string that consists of key-value pairs. This parameter specifies the encryption context for the destination master key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Example&quot;:&quot;Example&quot;}</para>
        /// </summary>
        [NameInMap("DestinationEncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> DestinationEncryptionContext { get; set; }

        /// <summary>
        /// <para>The ID of the symmetric master key that is used to re-encrypt the data after the ciphertext is decrypted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234abcd-12ab-34cd-56ef-12345678****</para>
        /// </summary>
        [NameInMap("DestinationKeyId")]
        [Validation(Required=false)]
        public string DestinationKeyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the DryRun mode.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the DryRun mode.</para>
        /// </description></item>
        /// <item><description><para>false (default): disables the DryRun mode.</para>
        /// </description></item>
        /// </list>
        /// <para>The DryRun mode is used to test API calls, verify whether you have the permissions to perform operations on the required resources, and check whether the request parameters are valid. If you enable the DryRun mode, KMS always returns a failure and a reason for the failure. The reasons for the failure include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>DryRunOperationError: The request would have succeeded if the DryRun parameter was not configured.</para>
        /// </description></item>
        /// <item><description><para>ValidationError: The parameters specified in the request are invalid.</para>
        /// </description></item>
        /// <item><description><para>AccessDeniedError: You are not authorized to perform the operation on the KMS resource.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>If CiphertextBlob is the result of public key encryption, specify the public key encryption algorithm. For more information about the algorithms, see <a href="https://help.aliyun.com/document_detail/148130.html">AsymmetricDecrypt</a>.<br> Valid values:<br><br></para>
        /// <list type="bullet">
        /// <item><description><para>RSAES_OAEP_SHA_256</para>
        /// </description></item>
        /// <item><description><para>RSAES_OAEP_SHA_1</para>
        /// </description></item>
        /// <item><description><para>SM2PKE</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify this parameter when CiphertextBlob is the data that is encrypted using a public key after asymmetric key encryption.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RSAES_OAEP_SHA_256</para>
        /// </summary>
        [NameInMap("SourceEncryptionAlgorithm")]
        [Validation(Required=false)]
        public string SourceEncryptionAlgorithm { get; set; }

        /// <summary>
        /// <para>A JSON string that consists of key-value pairs. If you specify this parameter when you call the <a href="https://help.aliyun.com/document_detail/28949.html">Encrypt</a>, <a href="https://help.aliyun.com/document_detail/28948.html">GenerateDataKey</a>, <a href="https://help.aliyun.com/document_detail/134043.html">GenerateDataKeyWithoutPlaintext</a>, or <a href="https://help.aliyun.com/document_detail/176804.html">GenerateAndExportDataKey</a> operation, you must specify the same parameter to decrypt the data. For more information, see <a href="https://help.aliyun.com/document_detail/42975.html">EncryptionContext</a>.</para>
        /// <remarks>
        /// <para>You must specify this parameter when CiphertextBlob is the ciphertext that is returned after symmetric encryption.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Example&quot;:&quot;Example&quot;}</para>
        /// </summary>
        [NameInMap("SourceEncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> SourceEncryptionContext { get; set; }

        /// <summary>
        /// <para>The ID of the master key that is used to decrypt the ciphertext.<br> The globally unique identifier of the master key.<br><br></para>
        /// <remarks>
        /// <para>You must specify this parameter when CiphertextBlob is the data that is encrypted using a public key after asymmetric key encryption.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5c438b18-05be-40ad-b6c2-3be6752c****</para>
        /// </summary>
        [NameInMap("SourceKeyId")]
        [Validation(Required=false)]
        public string SourceKeyId { get; set; }

        /// <summary>
        /// <para>The ID of the key version that is used to decrypt the ciphertext.</para>
        /// <remarks>
        /// <para>You must specify this parameter when CiphertextBlob is the data that is encrypted using a public key after asymmetric key encryption.</para>
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
