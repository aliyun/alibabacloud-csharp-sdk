// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class EncryptShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the dry run feature.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the dry run feature.</para>
        /// </description></item>
        /// <item><description><para>false (default): disables the dry run feature.</para>
        /// </description></item>
        /// </list>
        /// <para>The dry run feature is used to test API calls and verify the permissions on the resources that you have and the validity of the request parameters. You can view the check results in the response.</para>
        /// <list type="bullet">
        /// <item><description><para>DryRunOperationError: The permissions and parameters are valid. If you do not specify the DryRun parameter, the request is successful.</para>
        /// </description></item>
        /// <item><description><para>ValidationError: The parameters in the request are invalid.</para>
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
        /// <para>A JSON string that consists of key-value pairs. If you specify this parameter, you must specify the same parameter when you call the Decrypt operation. For more information, see <a href="https://help.aliyun.com/document_detail/42975.html">EncryptionContext</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Example&quot;:&quot;Example&quot;}</para>
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public string EncryptionContextShrink { get; set; }

        /// <summary>
        /// <para>The ID of the key. You can also specify the alias or Amazon Resource Name (ARN) of the key. For more information about aliases, see <a href="https://help.aliyun.com/document_detail/480655.html">Manage aliases</a>.</para>
        /// <remarks>
        /// <para>When you access a key in another Alibaba Cloud account, you must specify the ARN of the key. The ARN of a key is in the <c>acs:kms:${region}:${account}:key/${keyid}</c> format.</para>
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
        /// <para>The plaintext to be encrypted. The plaintext must be Base64-encoded.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SGVsbG8gd29y****</para>
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

    }

}
