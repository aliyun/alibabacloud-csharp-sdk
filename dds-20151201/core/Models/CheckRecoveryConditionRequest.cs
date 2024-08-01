// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CheckRecoveryConditionRequest : TeaModel {
        /// <summary>
        /// The backup ID.
        /// 
        /// > *   You can call the [DescribeBackups](https://help.aliyun.com/document_detail/62172.html) operation to query the backup ID.
        /// > *   You must specify one of the **RestoreTime** and BackupId parameters.
        /// > *   This parameter is not applicable to sharded cluster instances.
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The name of the source database. The value is a JSON array.
        /// 
        /// >  If you do not specify this parameter, all databases are restored by default.
        /// </summary>
        [NameInMap("DatabaseNames")]
        [Validation(Required=false)]
        public string DatabaseNames { get; set; }

        /// <summary>
        /// The region of the backup set used for the cross-region backup and restoration.
        /// 
        /// >  This parameter is required when you set the RestoreType parameter to 3.
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        /// <summary>
        /// The instance architecture. Valid values:
        /// 
        /// *   replicate
        /// *   sharding
        /// 
        /// > * This parameter is required when you set the RestoreType parameter to 2.
        /// > * This parameter is required when you set the RestoreType parameter to 3.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The point in time to which the instance is restored. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > *   The time can be a point in time within the past seven days. The time must be earlier than the current time, but later than the time when the instance was created.
        /// > *   You must specify one of the RestoreTime and **BackupId** parameters.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The restoration type.
        /// 
        /// > * 0: The data of the source instance is restored to a new instance in the same region.
        /// > * 1: The data of the source instance is restored to an earlier point in time.
        /// > * 2: The data of a deleted instance is restored to a new instance from the backup set.
        /// > * 3: The data of a deleted instance is restored to a new instance in another region from the backup set.
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// The ID of the source instance.
        /// </summary>
        [NameInMap("SourceDBInstance")]
        [Validation(Required=false)]
        public string SourceDBInstance { get; set; }

        /// <summary>
        /// The region where the source instance resides.
        /// 
        /// > * This parameter is required when you set the RestoreType parameter to 2.
        /// > * This parameter is required when you set the RestoreType parameter to 3.
        /// </summary>
        [NameInMap("SrcRegion")]
        [Validation(Required=false)]
        public string SrcRegion { get; set; }

    }

}
