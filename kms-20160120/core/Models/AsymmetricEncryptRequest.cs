// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricEncryptRequest : TeaModel {
        /// <summary>
        /// <para>The encryption algorithm.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSAES_OAEP_SHA_1</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the dry run feature.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the feature.</para>
        /// </description></item>
        /// <item><description><para>false (default): disables the feature.</para>
        /// </description></item>
        /// </list>
        /// <para>The dry run feature is used to test the API call and verify the permissions on the specified resources and the validity of the request parameters. If you enable the dry run feature, KMS always returns a failed result and a failure reason. The failure reasons include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>DryRunOperationError: The request would have succeeded if the DryRun parameter was not specified.</para>
        /// </description></item>
        /// <item><description><para>ValidationError: The specified parameters in the request are invalid.</para>
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
        /// <para>The ID of the key. You can also specify the alias or the Amazon Resource Name (ARN) of the key. For more information about aliases, see <a href="https://help.aliyun.com/document_detail/480655.html">Manage aliases</a>.</para>
        /// <remarks>
        /// <para>To access a key of another Alibaba Cloud account, you must specify the ARN of the key. The key ARN is in the format of <c>acs:kms:${region}:${account}:key/${keyid}</c>.</para>
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
        /// <para>The ID of the key version. The ID must be a globally unique identifier.</para>
        /// <remarks>
        /// <para>To obtain the key version ID, call the <a href="https://help.aliyun.com/document_detail/133966.html">ListKeyVersions</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ab1a983-7072-4bbc-a582-584b5bd8****</para>
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        /// <summary>
        /// <para>The plaintext to be encrypted. The value must be Base64-encoded.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SGVsbG8gd29ybGQ=</para>
        /// </summary>
        [NameInMap("Plaintext")]
        [Validation(Required=false)]
        public string Plaintext { get; set; }

    }

}
