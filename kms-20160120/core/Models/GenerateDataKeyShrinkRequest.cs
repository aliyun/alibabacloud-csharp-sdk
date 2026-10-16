// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GenerateDataKeyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable DryRun mode.</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false (default): disabled.</description></item>
        /// </list>
        /// <para>DryRun mode is used to test API calls, verify that you have the required permissions on the relevant resources, and check whether request parameters are configured correctly. When DryRun mode is enabled, KMS always returns a failure with a reason. Possible failure reasons include:</para>
        /// <list type="bullet">
        /// <item><description>DryRunOperationError: The request would succeed if the DryRun parameter were not set.</description></item>
        /// <item><description>ValidationError: A parameter specified in the request is invalid.</description></item>
        /// <item><description>AccessDeniedError: You do not have permission to perform the operation on the KMS resource.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>A JSON string of key-value pairs.</para>
        /// <para>If you specify this parameter, you must provide the same parameter when you call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation. For more information, see <a href="https://help.aliyun.com/document_detail/42975.html">EncryptionContext</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Example&quot;:&quot;Example&quot;}</para>
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public string EncryptionContextShrink { get; set; }

        /// <summary>
        /// <para>The ID of the key. You can also specify a key alias or a key Amazon Resource Name (ARN). For more information about aliases, see <a href="https://help.aliyun.com/document_detail/480655.html">Manage key aliases</a>.</para>
        /// <remarks>
        /// <para>To access a key in another Alibaba Cloud account, you must specify the key ARN. The key ARN format is <c>acs:kms:${region}:${account}:key/${keyid}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-hzz630494463ejqjx****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The length of the data key (DK) to generate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AES_256: a 256-bit symmetric key.</para>
        /// </description></item>
        /// <item><description><para>AES_128: a 128-bit symmetric key.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Use KeySpec or NumberOfBytes to specify the DK length. If neither is specified, KMS generates a 256-bit DK. If both are specified, KMS ignores the KeySpec parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AES_256</para>
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// <para>The length of the data key (DK) to generate, in bytes.</para>
        /// <para>Valid values: 1 to 1024.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>When KeySpec is set to AES_256, the default value of NumberOfBytes is 32.</description></item>
        /// <item><description>When KeySpec is set to AES_128, the default value of NumberOfBytes is 16.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("NumberOfBytes")]
        [Validation(Required=false)]
        public int? NumberOfBytes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        /// &quot;AttestationDocument&quot;:&quot;base64-encoded-attestion-document&quot;, 
        /// &quot;KeyEncryptionAlgorithm&quot;:&quot;RSAES_OAEP_SHA_256&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Recipient")]
        [Validation(Required=false)]
        public string Recipient { get; set; }

    }

}
