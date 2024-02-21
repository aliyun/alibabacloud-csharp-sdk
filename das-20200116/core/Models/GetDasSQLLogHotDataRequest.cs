// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDasSQLLogHotDataRequest : TeaModel {
        /// <summary>
        /// The account of the database.
        /// 
        /// >  You can specify multiple database accounts that are separated by spaces. Example: `user1 user2 user3`.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The node ID.
        /// 
        /// >  This parameter must be specified if the database instance is a PolarDB for MySQL cluster.
        /// </summary>
        [NameInMap("ChildDBInstanceIDs")]
        [Validation(Required=false)]
        public string ChildDBInstanceIDs { get; set; }

        /// <summary>
        /// The name of the database.
        /// 
        /// >  You can specify multiple database names that are separated by spaces. Example: `DB1 DB2 DB3`.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// >  The end time must be later than the start time. The interval between the start time and the end time cannot exceed 24 hours.
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// The error code of SQL execution. You can call the [GetAsyncErrorRequestStatByCode](~~409804~~) operation to query MySQL error codes in SQL Explorer data.
        /// </summary>
        [NameInMap("Fail")]
        [Validation(Required=false)]
        public string Fail { get; set; }

        /// <summary>
        /// The IP address of the client.
        /// 
        /// >  You can specify multiple IP addresses that are separated by spaces. Example: `IP1 IP2 IP3`.
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// The ID of the database instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The logical relationship among multiple keywords.
        /// 
        /// *   **or**
        /// *   **and**
        /// </summary>
        [NameInMap("LogicalOperator")]
        [Validation(Required=false)]
        public string LogicalOperator { get; set; }

        /// <summary>
        /// The maximum execution duration. Unit: microseconds. You can specify this parameter to query the SQL statements whose execution duration is smaller than the value of this parameter.
        /// </summary>
        [NameInMap("MaxLatancy")]
        [Validation(Required=false)]
        public long? MaxLatancy { get; set; }

        /// <summary>
        /// The maximum number of entries per page. Valid values: 5 to 100.
        /// </summary>
        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public long? MaxRecordsPerPage { get; set; }

        /// <summary>
        /// The reserved parameter. This parameter is not supported.
        /// </summary>
        [NameInMap("MaxRows")]
        [Validation(Required=false)]
        public long? MaxRows { get; set; }

        /// <summary>
        /// The maximum number of scanned rows. You can specify this parameter to query the SQL statements that scan a smaller number of rows than the value of this parameter.
        /// </summary>
        [NameInMap("MaxScanRows")]
        [Validation(Required=false)]
        public long? MaxScanRows { get; set; }

        /// <summary>
        /// The reserved parameter. This parameter is not supported.
        /// </summary>
        [NameInMap("MaxSpillCnt")]
        [Validation(Required=false)]
        public long? MaxSpillCnt { get; set; }

        /// <summary>
        /// The minimum execution duration. Unit: microseconds. You can specify this parameter to query the SQL statements whose execution duration is greater than or equal to the value of this parameter.
        /// </summary>
        [NameInMap("MinLatancy")]
        [Validation(Required=false)]
        public long? MinLatancy { get; set; }

        /// <summary>
        /// The reserved parameter. This parameter is not supported.
        /// </summary>
        [NameInMap("MinRows")]
        [Validation(Required=false)]
        public long? MinRows { get; set; }

        /// <summary>
        /// The minimum number of scanned rows. You can specify this parameter to query the SQL statements that scan a larger or an equal number of rows than the value of this parameter.
        /// </summary>
        [NameInMap("MinScanRows")]
        [Validation(Required=false)]
        public long? MinScanRows { get; set; }

        /// <summary>
        /// The reserved parameter. This parameter is not supported.
        /// </summary>
        [NameInMap("MinSpillCnt")]
        [Validation(Required=false)]
        public long? MinSpillCnt { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public long? PageNumbers { get; set; }

        /// <summary>
        /// The keyword that is used for the query.
        /// 
        /// >  The keyword must be at least four characters in length. You can specify multiple keywords that are separated by spaces. Fuzzy queries are not supported.
        /// </summary>
        [NameInMap("QueryKeyword")]
        [Validation(Required=false)]
        public string QueryKeyword { get; set; }

        /// <summary>
        /// The reserved parameter. This parameter is not supported.
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The basis on which you want to sort the query results.
        /// 
        /// *   **SCAN_ROWS**: the number of scanned rows.
        /// *   **UPDATE_ROWS**: the number of updated rows.
        /// *   **CONSUME**: the time consumed.
        /// *   **ORIGIN_TIME**: the execution duration.
        /// </summary>
        [NameInMap("SortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

        /// <summary>
        /// The order in which you want to sort the query results.
        /// 
        /// *   **ase**: ascending order.
        /// *   **desc**: descending order.
        /// </summary>
        [NameInMap("SortMethod")]
        [Validation(Required=false)]
        public string SortMethod { get; set; }

        /// <summary>
        /// The type of the SQL statement. Valid values:
        /// 
        /// *   **SELECT**
        /// *   **UPDATE**
        /// *   **DELETE**
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// >  You can query only the data that is generated after the new SQL Explorer and Audit feature is enabled. The start time can be up to seven days earlier than the current time.
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// The execution results. You can specify **0** to query the SQL statements that are successfully executed. You can also specify an error code to query the corresponding SQL statements that fail to be executed.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The thread ID.
        /// 
        /// >  You can specify multiple thread IDs that are separated by spaces. Example: `Thread ID1 Thread ID2 Thread ID3`.
        /// </summary>
        [NameInMap("ThreadID")]
        [Validation(Required=false)]
        public string ThreadID { get; set; }

        /// <summary>
        /// The reserved parameter. This parameter is not supported.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

        /// <summary>
        /// The transaction ID.
        /// </summary>
        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
