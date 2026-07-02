// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GenerateDataKeyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the DryRun mode.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the DryRun mode.</para>
        /// </description></item>
        /// <item><description><para>false (default): disables the DryRun mode.</para>
        /// </description></item>
        /// </list>
        /// <para>The DryRun mode is used to test the API call. It verifies whether you have the permissions to access the specified resources and whether the request parameters are valid. If you enable the DryRun mode, KMS always returns a failure response and a failure reason. The failure reasons include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>DryRunOperationError: The request succeeds if the DryRun parameter is not specified.</para>
        /// </description></item>
        /// <item><description><para>ValidationError: The parameters specified in the request are invalid.</para>
        /// </description></item>
        /// <item><description><para>AccessDeniedError: You are not authorized to perform this operation on the KMS resource.</para>
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
        /// <para>A JSON string that consists of key-value pairs.</para>
        /// <para>If you specify this parameter, you must also specify the same parameter when you call the <a href="https://help.aliyun.com/document_detail/28950.html">Decrypt</a> operation. For more information, see <a href="https://help.aliyun.com/document_detail/42975.html">EncryptionContext</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Example&quot;:&quot;Example&quot;}</para>
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> EncryptionContext { get; set; }

        /// <summary>
        /// <para>The ID of the key. You can also specify the alias or the key resource name (ARN) of the key. For more information about aliases, see <a href="https://help.aliyun.com/document_detail/480655.html">Manage aliases</a>.</para>
        /// <remarks>
        /// <para>When you access a key in another Alibaba Cloud account, you must enter the ARN of the key. The key ARN is in the format of <c>acs:kms:${region}:${account}:key/${keyid}</c>.</para>
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
        /// <para>The length of the data key to be generated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AES_256: a 256-bit symmetric key.</para>
        /// </description></item>
        /// <item><description><para>AES_128: a 128-bit symmetric key.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>We recommend that you use the KeySpec or NumberOfBytes parameter to specify the length of a data key. If you do not specify either of the parameters, KMS generates a 256-bit data key. If you specify both parameters, KMS ignores the KeySpec parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AES_256</para>
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// <para>The length of the data key that you want to generate. Unit: bytes.</para>
        /// <para>Valid values: 1 to 1024.</para>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set KeySpec to AES_256, the default value of NumberOfBytes is 32.</para>
        /// </description></item>
        /// <item><description><para>If you set KeySpec to AES_128, the default value of NumberOfBytes is 16.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("NumberOfBytes")]
        [Validation(Required=false)]
        public int? NumberOfBytes { get; set; }

        [NameInMap("Recipient")]
        [Validation(Required=false)]
        public string Recipient { get; set; }

    }

}
