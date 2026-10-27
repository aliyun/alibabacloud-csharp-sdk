// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDasSQLLogHotDataRequest : TeaModel {
        /// <summary>
        /// <para>The database account.</para>
        /// <remarks>
        /// <para>You can use multiple database accounts for a combined query. Separate multiple database accounts with spaces. Example: <c>user1 user2 user3</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testuser</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>For a PolarDB for MySQL instance, you must specify the node ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp179lg03445l****</para>
        /// </summary>
        [NameInMap("ChildDBInstanceIDs")]
        [Validation(Required=false)]
        public string ChildDBInstanceIDs { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// <remarks>
        /// <para>You can use multiple database names for a combined query. Separate multiple database names with spaces. Example: <c>DB1 DB2 DB3</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is in the UNIX timestamp format. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time, and the interval between the start time and the end time cannot exceed 1 day.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684820697000</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The error code returned when the SQL statement is executed. You can call the <a href="https://help.aliyun.com/document_detail/409804.html">GetAsyncErrorRequestStatByCode</a> operation to obtain the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1064</para>
        /// </summary>
        [NameInMap("Fail")]
        [Validation(Required=false)]
        public string Fail { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// <remarks>
        /// <para>You can use multiple client IP addresses for a combined query. Separate multiple client IP addresses with spaces. Example: <c>IP1 IP2 IP3</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX</para>
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// <para>The database instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The logical relationship between multiple keywords. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>or</b>: OR.</description></item>
        /// <item><description><b>and</b>: AND.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("LogicalOperator")]
        [Validation(Required=false)]
        public string LogicalOperator { get; set; }

        /// <summary>
        /// <para>The maximum execution duration. Unit: microseconds. This parameter is used to query SQL statements whose execution duration is less than the specified value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxLatancy")]
        [Validation(Required=false)]
        public long? MaxLatancy { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page for the paging query. Valid values: 5 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public long? MaxRecordsPerPage { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MaxRows")]
        [Validation(Required=false)]
        public long? MaxRows { get; set; }

        /// <summary>
        /// <para>The maximum number of scanned rows. This parameter is used to query SQL statements whose number of scanned rows is less than the specified value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxScanRows")]
        [Validation(Required=false)]
        public long? MaxScanRows { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MaxSpillCnt")]
        [Validation(Required=false)]
        public long? MaxSpillCnt { get; set; }

        /// <summary>
        /// <para>The minimum execution duration. Unit: microseconds. This parameter is used to query SQL statements whose execution duration is greater than or equal to the specified value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinLatancy")]
        [Validation(Required=false)]
        public long? MinLatancy { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MinRows")]
        [Validation(Required=false)]
        public long? MinRows { get; set; }

        /// <summary>
        /// <para>The minimum number of scanned rows. This parameter is used to query SQL statements whose number of scanned rows is greater than or equal to the specified value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinScanRows")]
        [Validation(Required=false)]
        public long? MinScanRows { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MinSpillCnt")]
        [Validation(Required=false)]
        public long? MinSpillCnt { get; set; }

        /// <summary>
        /// <para>The page number for the paging query. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public long? PageNumbers { get; set; }

        /// <summary>
        /// <para>The keyword.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported. You can use a maximum of 10 keywords for a combined query. Separate multiple keywords with spaces. Example: a1 b2 c3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a1 b2</para>
        /// </summary>
        [NameInMap("QueryKeyword")]
        [Validation(Required=false)]
        public string QueryKeyword { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The sort key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ScanRows</b>: the number of scanned rows.</description></item>
        /// <item><description><b>UpdateRows</b>: the number of updated rows.</description></item>
        /// <item><description><b>Consume</b>: the execution duration.</description></item>
        /// <item><description><b>OriginTime</b>: the execution time.</description></item>
        /// <item><description><b>ReturnRows</b>: the number of returned rows.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ScanRows</para>
        /// </summary>
        [NameInMap("SortKey")]
        [Validation(Required=false)]
        public string SortKey { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b>: ascending order.</description></item>
        /// <item><description><b>DESC</b>: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("SortMethod")]
        [Validation(Required=false)]
        public string SortMethod { get; set; }

        /// <summary>
        /// <para>The type of the SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>select</b></description></item>
        /// <item><description><b>update</b></description></item>
        /// <item><description><b>delete</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>select</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is in the UNIX timestamp format. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>You can only query data generated after DAS Enterprise Edition is enabled. The start time cannot be more than 7 days earlier than the current time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684734297000</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>The execution result. If you enter <b>0</b>, the system queries SQL statements that are successfully executed. You can also enter a specific error code to query the corresponding SQL statements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The thread ID.</para>
        /// <remarks>
        /// <para>You can use multiple thread IDs for a combined query. Separate multiple thread IDs with spaces. Example: <c>ThreadID1 ThreadID2 ThreadID3</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>657</para>
        /// </summary>
        [NameInMap("ThreadID")]
        [Validation(Required=false)]
        public string ThreadID { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

        /// <summary>
        /// <para>The transaction ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
