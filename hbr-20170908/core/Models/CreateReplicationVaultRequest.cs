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
        /// <b>Example:</b>
        /// <para>HBR_PRIVATE</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alias/test</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The data redundancy type of the backup vault. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LRS: standard locally redundant storage (LRS). Cloud Backup stores the copies of each object on multiple devices of different facilities in the same zone. This way, Cloud Backup ensures data durability and availability even if hardware failures occur.</description></item>
        /// <item><description>ZRS: standard zone-redundant storage (ZRS). Cloud Backup uses the multi-zone mechanism to distribute data across three zones within the same region. If a zone fails, the data that is stored in the other two zones is still accessible.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LRS</para>
        /// </summary>
        [NameInMap("RedundancyType")]
        [Validation(Required=false)]
        public string RedundancyType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the source vault resides.</para>
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

    }

}
