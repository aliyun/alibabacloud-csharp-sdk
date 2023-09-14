// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RestoreDdrTableRequest : TeaModel {
        /// <summary>
        /// The ID of the backup set.
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
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
        /// The point in time to which you want to restore data. The point in time that you specify must be earlier than the current time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// > If **RestoreType** is set to **BackupTime**, you must specify this parameter.
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// The method that is used to restore data. Valid values:
        /// 
        /// *   **0**: restores data from a backup set. If you set this parameter to 0, you must also specify the **BackupSetId** parameter.
        /// *   **1**: restores data to a point in time. If you set this parameter to 1, you must also specify the **RestoreTime**, **SourceRegion**, and **SourceDBInstanceName** parameters.
        /// 
        /// Default value: **0**.
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// The ID of the source instance if you want to restore data to a point in time.
        /// 
        /// > : If you set **RestoreType** to **1**, you must also specify this parameter.
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// The region ID of the source instance if you want to restore data to a point in time.
        /// 
        /// > : If you set **RestoreType** to **1**, you must also specify this parameter.
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// The names of the databases and tables that you want to restore. The value is in the following format: `[{"type":"db","name":"<The name of Database 1 on the source instance>","newname":"<The name of Database 1 on the destination instance>","tables":[{"type":"table","name":"<The name of Table 1 in Database 1 on the source instance>","newname":"<The name of Table 1 in Database 1 on the destination instance>"},{"type":"table","name":"<The name of Table 2 in Database 1 on the source instance>","newname":"<The name of Table 2 in Database 1 on the destination instance>"}]},{"type":"db","name":"<The name of Database 2 on the source instance>","newname":"<The name of Database 2 on the destination instance>","tables":[{"type":"table","name":"<The name of Table 3 in Database 2 on the source instance>","newname":"<The name of Table 3 in Database 2 on the destination instance>"},{"type":"table","name":"<The name of Table 4 in Database 2 on the source instance>","newname":"<The name of Table 4 in Database 2 on the destination instance>"}]}]`
        /// </summary>
        [NameInMap("TableMeta")]
        [Validation(Required=false)]
        public string TableMeta { get; set; }

    }

}
