// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateUniRestorePlanRequest : TeaModel {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// The UUID of the Hybrid Backup Recovery (HBR) agent that is used to restore the data of the database on your server.
        /// 
        /// >  You can call the [DescribeUniBackupDatabase](~~DescribeUniBackupDatabase~~) operation to query the UUID.
        /// </summary>
        [NameInMap("InstanceUuid")]
        [Validation(Required=false)]
        public string InstanceUuid { get; set; }

        /// <summary>
        /// The ID of the anti-ransomware policy.
        /// 
        /// >  You can call the [DescribeUniBackupPolicies](~~DescribeUniBackupPolicies~~) operation to query the ID.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// The identifier of the point in time for restoration in the backup version that you want to use. The database is an Oracle database.****
        /// 
        /// >  You can call the [DescribeUniRecoverableList](~~DescribeUniRecoverableList~~) operation to query the value.
        /// </summary>
        [NameInMap("ResetScn")]
        [Validation(Required=false)]
        public string ResetScn { get; set; }

        /// <summary>
        /// The point in time for restoration in the backup version that you want to use. The database is an Oracle database.****
        /// 
        /// >  You can call the [DescribeUniRecoverableList](~~DescribeUniRecoverableList~~) operation to query the value.
        /// </summary>
        [NameInMap("ResetTime")]
        [Validation(Required=false)]
        public string ResetTime { get; set; }

        /// <summary>
        /// The information about the database. This parameter is available when the database is a Microsoft SQL Server (MSSQL) database. The value is a JSON string. Valid values:
        /// 
        /// *   **name**: the name of the database
        /// *   **files**: the path to the database files
        /// 
        /// >  You can call the [DescribeUniRecoverableList](~~DescribeUniRecoverableList~~) operation to query the information.
        /// </summary>
        [NameInMap("RestoreInfo")]
        [Validation(Required=false)]
        public string RestoreInfo { get; set; }

        /// <summary>
        /// The point in time to which you want to restore data.
        /// 
        /// >  You can call the [DescribeRestorePlans](~~DescribeRestorePlans~~) operation to query the point in time.
        /// </summary>
        [NameInMap("TimePoint")]
        [Validation(Required=false)]
        public long? TimePoint { get; set; }

    }

}
