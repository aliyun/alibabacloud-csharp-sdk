// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateVaultRequest : TeaModel {
        /// <summary>
        /// <para>The description of the backup vault. The description must be 0 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The method that is used to encrypt the source data. This parameter is valid only if you set the VaultType parameter to STANDARD or OTS_BACKUP. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HBR_PRIVATE</b>: The source data is encrypted by using the built-in encryption method of Hybrid Backup Recovery (HBR).</description></item>
        /// <item><description><b>KMS</b>: The source data is encrypted by using Key Management Service (KMS).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KMS</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>The customer master key (CMK) created in KMS or the alias of the key. This parameter is required only if you set the EncryptType parameter to KMS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alias/yzs-hhht</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

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
        /// <para>The ID of the region where the backup vault resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("VaultRegionId")]
        [Validation(Required=false)]
        public string VaultRegionId { get; set; }

        /// <summary>
        /// <para>The storage class of the backup vault. Valid value: <b>STANDARD</b>, which indicates standard storage.</para>
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
        /// <item><description><b>STANDARD</b>: standard backup vault</description></item>
        /// <item><description><b>OTS_BACKUP</b>: backup vault for Tablestore</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("VaultType")]
        [Validation(Required=false)]
        public string VaultType { get; set; }

    }

}
