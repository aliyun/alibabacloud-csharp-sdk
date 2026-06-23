// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateKMSEncryptionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable the Secret encryption at rest feature.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Disables the encryption at rest feature.</description></item>
        /// <item><description><c>false</c>: Enables the encryption at rest feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_encryption")]
        [Validation(Required=false)]
        public bool? DisableEncryption { get; set; }

        /// <summary>
        /// <para>The key ID of the KMS key used by the Secret encryption at rest feature.</para>
        /// <remarks>
        /// <para>Notice: You cannot use a service key. Use only a master key or a customer master key (CMK). The key type must be <c>Aliyun_AES_256</c>, and the key usage must be <c>ENCRYPT/DECRYPT</c>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: During the procedure of enabling or shutdown of encryption at rest and after the feature is enabled, do not disable or delete the KMS key in the KMS console or through OpenAPI. Otherwise, the cluster API Server becomes not active, which prevents normal retrieval of objects such as Secrets and ServiceAccounts and affects the normal operation of business applications.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>key-abc***</para>
        /// </summary>
        [NameInMap("kms_key_id")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

    }

}
