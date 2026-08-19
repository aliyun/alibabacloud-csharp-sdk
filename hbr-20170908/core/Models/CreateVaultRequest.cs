// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateVaultRequest : TeaModel {
        /// <summary>
        /// <para>The description of the backup vault. The description can be 0 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The encryption type of the source data. This parameter is valid only if you set VaultType to STANDARD or OTS_BACKUP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HBR_PRIVATE</b>: The backup vault is encrypted using the built-in encryption method of Cloud Backup.</para>
        /// </description></item>
        /// <item><description><para><b>KMS</b>: The backup vault is encrypted using a customer master key (CMK) from Key Management Service (KMS).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KMS</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>The ID or alias of the KMS key. This parameter is required only if you set EncryptType to KMS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alias/yzs-hhht</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a replication vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Replication")]
        [Validation(Required=false)]
        public bool? Replication { get; set; }

        /// <summary>
        /// <para>The name of the backup vault. The name must be 1 to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>backupvaultname</para>
        /// </summary>
        [NameInMap("VaultName")]
        [Validation(Required=false)]
        public string VaultName { get; set; }

        /// <summary>
        /// <para>The region ID of the backup vault.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("VaultRegionId")]
        [Validation(Required=false)]
        public string VaultRegionId { get; set; }

        /// <summary>
        /// <para>The storage class of the backup vault.</para>
        /// <list type="bullet">
        /// <item><description><para><b>STANDARD</b>: Standard.</para>
        /// </description></item>
        /// <item><description><para><b>ARCHIVE</b>: This value is deprecated.</para>
        /// </description></item>
        /// <item><description><para><b>COLD_ARCHIVE</b>: This value is deprecated.</para>
        /// </description></item>
        /// <item><description><para><b>IA</b>: This value is deprecated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("VaultStorageClass")]
        [Validation(Required=false)]
        public string VaultStorageClass { get; set; }

        /// <summary>
        /// <para>The type of the backup vault. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>STANDARD</b>: a standard backup vault.</para>
        /// </description></item>
        /// <item><description><para><b>OTS_BACKUP</b>: a Tablestore backup vault.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("VaultType")]
        [Validation(Required=false)]
        public string VaultType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable backup locking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WormEnabled")]
        [Validation(Required=false)]
        public bool? WormEnabled { get; set; }

    }

}
