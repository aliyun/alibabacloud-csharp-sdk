// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateReplicationVaultRequest : TeaModel {
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
        /// <para>The encryption type of the replication target vault. This parameter is valid only when VaultType is set to STANDARD. The encryption type must be the same as that of the source backup repository. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HBR_PRIVATE</b>: fully managed by Cloud Backup. The built-in secret key encryption method of the backup service is used.</description></item>
        /// <item><description><b>KMS</b>: uses a custom key from Alibaba Cloud Key Management Service (KMS) for encryption.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HBR_PRIVATE</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>The custom key or alias from Alibaba Cloud KMS. This parameter is required only when EncryptType is set to KMS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alias/test</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The data redundancy storage method of the backup vault. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LRS: locally redundant storage (LRS). The data redundancy storage mechanism is used to store redundant copies of each object on multiple devices across multiple facilities within the same zone, ensuring data durability and availability in the event of hardware failure.</description></item>
        /// <item><description>ZRS: zone-redundant storage (ZRS). The multi-zone mechanism is used to distribute user data across three zones in the same region. If one zone becomes unavailable, the data can still be accessed normally.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LRS</para>
        /// </summary>
        [NameInMap("RedundancyType")]
        [Validation(Required=false)]
        public string RedundancyType { get; set; }

        /// <summary>
        /// <para>The region ID of the source vault.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ReplicationSourceRegionId")]
        [Validation(Required=false)]
        public string ReplicationSourceRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the source vault.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("ReplicationSourceVaultId")]
        [Validation(Required=false)]
        public string ReplicationSourceVaultId { get; set; }

        /// <summary>
        /// <para>The name of the backup vault. The name must be 1 to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mirrorvaultname</para>
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
        /// <para>The storage class of the backup vault. The value can only be <b>STANDARD</b>, which indicates standard storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("VaultStorageClass")]
        [Validation(Required=false)]
        public string VaultStorageClass { get; set; }

    }

}
