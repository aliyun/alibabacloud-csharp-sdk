// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateKMSEncryptionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable the Secret-at-rest encryption feature.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Disables the at-rest encryption feature.</description></item>
        /// <item><description><c>false</c>: Enables the at-rest encryption feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_encryption")]
        [Validation(Required=false)]
        public bool? DisableEncryption { get; set; }

        /// <summary>
        /// <para>The KMS key ID used by the Secret-at-rest encryption feature.</para>
        /// <remarks>
        /// <para>Notice: You cannot use a service key. You must use either a master key or a customer master key. The key type must be <c>Aliyun_AES_256</c>, and the key usage must be <c>ENCRYPT/DECRYPT</c>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: During the process of enabling or disabling the at-rest encryption feature and after the feature is successfully enabled, do not disable or delete the KMS key via the KMS console or OpenAPI. Otherwise, the cluster API Server will become unavailable, preventing normal retrieval of objects such as Secrets and ServiceAccounts, which impacts the normal operation of business applications.</para>
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
