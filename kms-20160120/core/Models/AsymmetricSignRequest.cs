// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class AsymmetricSignRequest : TeaModel {
        /// <summary>
        /// <para>The signature algorithm.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_PSS_SHA_256</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The digest of the original message. The digest is generated using the hash algorithm that corresponds to the value of the Algorithm parameter.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value is Base64-encoded.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For information about how to calculate a message digest, see the &quot;Pre-signing: calculate a message digest&quot; section of the <a href="https://help.aliyun.com/document_detail/148146.html">Asymmetric digital signature</a> topic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiu****=</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the dry-run feature.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the feature.</para>
        /// </description></item>
        /// <item><description><para>false (default): disables the feature.</para>
        /// </description></item>
        /// </list>
        /// <para>The dry-run feature is used to test API calls and verify the permissions on the resources that you have and the validity of the request parameters. If you enable the dry-run feature, KMS always returns a failure response and a failure reason. The failure reasons include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>DryRunOperationError: The request would have succeeded if the DryRun parameter is not configured.</para>
        /// </description></item>
        /// <item><description><para>ValidationError: The specified parameters in the request are invalid.</para>
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
        /// <para>The globally unique identifier (GUID) of the customer master key (CMK).</para>
        /// <remarks>
        /// <para>You can also specify the alias that is bound to the CMK. For more information, see <a href="https://help.aliyun.com/document_detail/68522.html">Overview of aliases</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c438b18-05be-40ad-b6c2-3be6752c****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The ID of the key version. The ID must be the GUID of the key version.</para>
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
