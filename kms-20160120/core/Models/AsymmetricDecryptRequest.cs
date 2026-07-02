// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricDecryptRequest : TeaModel {
        /// <summary>
        /// <para>The decryption algorithm.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSAES_OAEP_SHA_1</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The ciphertext to be decrypted. The ciphertext is encoded in Base64.</para>
        /// <remarks>
        /// <para>You can generate a ciphertext by calling the <a href="https://help.aliyun.com/document_detail/148131.html">AsymmetricEncrypt</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BQKP+1zK6+ZEMxTP5qaVzcsgXtWplYBKm0NXdSnB5FzliFxE1bSiu4dnEIlca2JpeH7yz1/S6fed630H+hIH6DoM25fTLNcKj+mFB0Xnh9m2+HN59Mn4qyTfcUeadnfCXSWcGBouhXFwcdd2rJ3n337bzTf4jm659gZu3L0i6PLuxM9p7mqdwO0cKJPfGVfhnfMz+f4alMg79WB/NNyE2lyX7/qxvV49ObNrrJbKSFiz8Djocaf0IESNLMbfYI5bXjWkJlX92DQbKhibtQW8ZOJ//ZC6t0AWcUoKL6QDm/dg5koQalcleRinpB+QadFm894sLbVZ9+N4GVsv1W****==</para>
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the dry run feature.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the dry run feature.</para>
        /// </description></item>
        /// <item><description><para>false: disables the dry run feature. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// <para>The dry run feature is used to test API calls, verify the permissions on the specified resources, and check the validity of the request parameters. If you enable the dry run feature, KMS always returns a failure response and the cause of the failure. The causes of the failure include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>DryRunOperationError: The request would have succeeded if the DryRun parameter is not specified.</para>
        /// </description></item>
        /// <item><description><para>ValidationError: The specified parameter in the request is invalid.</para>
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
        /// <para>The ID of the key version. The globally unique identifier of the key version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ab1a983-7072-4bbc-a582-584b5bd8****</para>
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

    }

}
