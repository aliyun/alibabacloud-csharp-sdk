// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyRDSToClickhouseDbRequest : TeaModel {
        /// <summary>
        /// The password of the account that is used to log on to the database in the ApsaraDB for ClickHouse cluster.
        /// </summary>
        [NameInMap("CkPassword")]
        [Validation(Required=false)]
        public string CkPassword { get; set; }

        /// <summary>
        /// The account that is used to log on to the database in the ApsaraDB for ClickHouse cluster.
        /// </summary>
        [NameInMap("CkUserName")]
        [Validation(Required=false)]
        public string CkUserName { get; set; }

        /// <summary>
        /// The port number of the ApsaraDB for ClickHouse cluster.
        /// </summary>
        [NameInMap("ClickhousePort")]
        [Validation(Required=false)]
        public long? ClickhousePort { get; set; }

        /// <summary>
        /// The ID of the ApsaraDB for ClickHouse cluster.
        /// </summary>
        [NameInMap("DbClusterId")]
        [Validation(Required=false)]
        public string DbClusterId { get; set; }

        /// <summary>
        /// The maximum number of rows that can be synchronized per second.
        /// </summary>
        [NameInMap("LimitUpper")]
        [Validation(Required=false)]
        public long? LimitUpper { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the ApsaraDB RDS for MySQL instance.
        /// </summary>
        [NameInMap("RdsId")]
        [Validation(Required=false)]
        public string RdsId { get; set; }

        /// <summary>
        /// The password of the account that is used to log on to the database in the ApsaraDB RDS for MySQL instance.
        /// </summary>
        [NameInMap("RdsPassword")]
        [Validation(Required=false)]
        public string RdsPassword { get; set; }

        /// <summary>
        /// The port number of the ApsaraDB RDS for MySQL instance.
        /// </summary>
        [NameInMap("RdsPort")]
        [Validation(Required=false)]
        public long? RdsPort { get; set; }

        /// <summary>
        /// The database in the ApsaraDB RDS for MySQL instance.
        /// </summary>
        [NameInMap("RdsSynDb")]
        [Validation(Required=false)]
        public string RdsSynDb { get; set; }

        /// <summary>
        /// The table in the ApsaraDB RDS for MySQL instance.
        /// </summary>
        [NameInMap("RdsSynTables")]
        [Validation(Required=false)]
        public string RdsSynTables { get; set; }

        /// <summary>
        /// The account that is used to log on to the database in the ApsaraDB RDS for MySQL instance.
        /// </summary>
        [NameInMap("RdsUserName")]
        [Validation(Required=false)]
        public string RdsUserName { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the ApsaraDB RDS for MySQL instance belongs.
        /// </summary>
        [NameInMap("RdsVpcId")]
        [Validation(Required=false)]
        public string RdsVpcId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to ignore databases that do not support synchronization. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("SkipUnsupported")]
        [Validation(Required=false)]
        public bool? SkipUnsupported { get; set; }

    }

}
