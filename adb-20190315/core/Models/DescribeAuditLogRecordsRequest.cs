// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAuditLogRecordsRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the database on which you want to execute the SQL statement.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   The end time must be later than the start time.
        /// 
        /// *   The maximum time range that can be specified is 24 hours.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The IP address and port number of the client that is used to execute the SQL statement.
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// The order in which specified fields are sorted. Specify this parameter as an ordered JSON array that consists of the Field and Type fields.
        /// 
        /// *   Field specifies the field that is used to sort the retrieved entries. Valid values:
        /// 
        ///     *   HostAddress: the IP address of the client that is used to connect to the database.
        ///     *   Succeed: specifies whether the SQL statement is successfully executed.
        ///     *   TotalTime: the total amount of time that is consumed to execute the SQL statement.
        ///     *   DBName: the name of the database on which the SQL statement is executed.
        ///     *   SQLType: the type of the SQL statement.
        ///     *   User: the username that is used to execute the SQL statement.
        ///     *   ExecuteTime: the time to start executing the SQL statement.
        /// 
        /// *   Type specifies the sorting order. Valid values:
        /// 
        ///     *   Desc: descending order.
        ///     *   Asc: ascending order.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The sorting order of the retrieved entries. Valid values:
        /// 
        /// *   **asc**: sorts the retrieved entries by time in ascending order.
        /// *   **desc**: sorts the retrieved entries by time in descending order.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. The value is an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values:
        /// 
        /// *   **10**
        /// *   **30**
        /// *   **50**
        /// *   **100**
        /// 
        /// > If you do not specify this parameter, the value 10 is used.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The keywords that are included in the SQL statement to query.
        /// </summary>
        [NameInMap("QueryKeyword")]
        [Validation(Required=false)]
        public string QueryKeyword { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the SQL statement. Valid values:
        /// 
        /// *   **DELETE**
        /// *   **SELECT**
        /// *   **UPDATE**
        /// *   **INSERT_INTO_SELECT**
        /// *   **ALTER**
        /// *   **DROP**
        /// *   **INSERT**
        /// 
        /// > You can query only a single type of SQL statements at a time. If this parameter is left empty, the **SELECT** SQL statements are queried.
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.
        /// 
        /// > SQL audit logs can be queried only when SQL audit is enabled. Only SQL audit logs within the last 30 days can be queried. If SQL audit was disabled and re-enabled, only SQL audit logs from the time when SQL audit was re-enabled can be queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Specifies whether the execution of the SQL statement succeeds. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Succeed")]
        [Validation(Required=false)]
        public string Succeed { get; set; }

        /// <summary>
        /// The name of the user who executed the SQL statement.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
