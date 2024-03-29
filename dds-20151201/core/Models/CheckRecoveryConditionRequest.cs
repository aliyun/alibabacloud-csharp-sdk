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
        /// > *   You can call the [DescribeBackups](~~62172~~) operation to query the backup ID.
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
        /// The ID of the source instance.
        /// </summary>
        [NameInMap("SourceDBInstance")]
        [Validation(Required=false)]
        public string SourceDBInstance { get; set; }

    }

}
