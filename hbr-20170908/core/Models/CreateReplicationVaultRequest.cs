// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateReplicationVaultRequest : TeaModel {
        /// <summary>
        /// The description of the backup vault. The description must be 0 to 255 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The data redundancy type of the backup vault. Valid values:
        /// 
        /// - LRS: Locally redundant storage (LRS) is enabled for the backup vault. HBR stores the copies of each object on multiple devices of different facilities in the same zone. This way, HBR ensures data durability and availability even if hardware failures occur.
        /// - ZRS: Zone-redundant storage (ZRS) is enabled for the backup vault. HBR uses the multi-zone mechanism to distribute data across three zones within the same region. If a zone becomes unavailable, the data can still be accessed.
        /// </summary>
        [NameInMap("RedundancyType")]
        [Validation(Required=false)]
        public string RedundancyType { get; set; }

        /// <summary>
        /// The ID of the region where the source vault resides.
        /// </summary>
        [NameInMap("ReplicationSourceRegionId")]
        [Validation(Required=false)]
        public string ReplicationSourceRegionId { get; set; }

        /// <summary>
        /// The ID of the source vault.
        /// </summary>
        [NameInMap("ReplicationSourceVaultId")]
        [Validation(Required=false)]
        public string ReplicationSourceVaultId { get; set; }

        /// <summary>
        /// The name of the backup vault. The name must be 1 to 64 characters in length.
        /// </summary>
        [NameInMap("VaultName")]
        [Validation(Required=false)]
        public string VaultName { get; set; }

        /// <summary>
        /// The ID of the region where the backup vault resides.
        /// </summary>
        [NameInMap("VaultRegionId")]
        [Validation(Required=false)]
        public string VaultRegionId { get; set; }

        /// <summary>
        /// The storage type of the backup vault. Valid value: **STANDARD**. The value indicates standard storage.
        /// </summary>
        [NameInMap("VaultStorageClass")]
        [Validation(Required=false)]
        public string VaultStorageClass { get; set; }

    }

}
