// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateKMSEncryptionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to disable the encryption at rest feature for Secrets.</para>
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
        /// <para>The KMS key ID used for the encryption at rest feature for Secrets.</para>
        /// <remarks>
        /// <para>Notice: You cannot use a service key. You can only use a master key or a customer master key (CMK). The key type must be <c>Aliyun_AES_256</c>, and the key usage must be <c>ENCRYPT/DECRYPT</c>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: Do not disable or delete the KMS key in the KMS console or by calling API operations during the start or shutdown procedure of the encryption at rest feature, or after the feature is started. Otherwise, the cluster API server becomes inactive. As a result, objects such as Secrets and ServiceAccounts cannot be retrieved, which affects the normal operation of your applications.</para>
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
