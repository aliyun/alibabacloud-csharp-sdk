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
        /// <para>You can specify multiple database accounts. Separate multiple accounts with a space. For example: <c>user1 user2 user3</c>.</para>
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
        /// <para>This parameter is required if the database instance is a PolarDB for MySQL cluster.</para>
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
        /// <para>You can specify multiple database names. Separate multiple names with a space. For example: <c>DB1 DB2 DB3</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value must be a Unix timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. The time range cannot exceed one day.</para>
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
        /// <para>The SQL execution error code. You can call the <a href="https://help.aliyun.com/document_detail/409804.html">GetAsyncErrorRequestStatByCode</a> operation to obtain the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1064</para>
        /// </summary>
        [NameInMap("Fail")]
        [Validation(Required=false)]
        public string Fail { get; set; }

        /// <summary>
        /// <para>The client IP address.</para>
        /// <remarks>
        /// <para>You can specify multiple client IP addresses. Separate multiple IP addresses with a space. For example: <c>IP1 IP2 IP3</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX</para>
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// <para>The ID of the database instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The logical operator to use with multiple keywords. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>or</b></para>
        /// </description></item>
        /// <item><description><para><b>and</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("LogicalOperator")]
        [Validation(Required=false)]
        public string LogicalOperator { get; set; }

        /// <summary>
        /// <para>The maximum execution time in microseconds. Returns SQL statements that have an execution time less than this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxLatancy")]
        [Validation(Required=false)]
        public long? MaxLatancy { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 5 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public long? MaxRecordsPerPage { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MaxRows")]
        [Validation(Required=false)]
        public long? MaxRows { get; set; }

        /// <summary>
        /// <para>The maximum number of scanned rows. Returns SQL statements that scanned fewer than this number of rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxScanRows")]
        [Validation(Required=false)]
        public long? MaxScanRows { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MaxSpillCnt")]
        [Validation(Required=false)]
        public long? MaxSpillCnt { get; set; }

        /// <summary>
        /// <para>The minimum execution time in microseconds. Returns SQL statements with an execution time greater than or equal to this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinLatancy")]
        [Validation(Required=false)]
        public long? MinLatancy { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MinRows")]
        [Validation(Required=false)]
        public long? MinRows { get; set; }

        /// <summary>
        /// <para>The minimum number of scanned rows. Returns SQL statements that scanned at least this number of rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinScanRows")]
        [Validation(Required=false)]
        public long? MinScanRows { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MinSpillCnt")]
        [Validation(Required=false)]
        public long? MinSpillCnt { get; set; }

        /// <summary>
        /// <para>The page number to return. Pages start from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public long? PageNumbers { get; set; }

        /// <summary>
        /// <para>The query keyword.</para>
        /// <remarks>
        /// <para>Fuzzy search is supported. You can specify up to 10 keywords. Separate multiple keywords with a space. For example: a1 b2 c3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a1 b2</para>
        /// </summary>
        [NameInMap("QueryKeyword")]
        [Validation(Required=false)]
        public string QueryKeyword { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
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
        /// <item><description><para><b>ScanRows</b>: scanned rows.</para>
        /// </description></item>
        /// <item><description><para><b>UpdateRows</b>: updated rows.</para>
        /// </description></item>
        /// <item><description><para><b>Consume</b>: execution time.</para>
        /// </description></item>
        /// <item><description><para><b>OriginTime</b>: The execution start time.</para>
        /// </description></item>
        /// <item><description><para><b>ReturnRows</b>: returned rows.</para>
        /// </description></item>
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
        /// <item><description><para><b>ASC</b>: ascending</para>
        /// </description></item>
        /// <item><description><para><b>DESC</b>: descending</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("SortMethod")]
        [Validation(Required=false)]
        public string SortMethod { get; set; }

        /// <summary>
        /// <para>The SQL type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This value must be a Unix timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>You can query only data that is generated after you enable DAS Enterprise Edition. The start time cannot be earlier than seven days before the current time.</para>
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
        /// <para>The execution state. Set this parameter to <b>0</b> to query for successfully executed SQL statements. You can also specify an error code to query for the corresponding SQL statements.</para>
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
        /// <para>You can specify multiple thread IDs. Separate multiple IDs with a space. For example: <c>657 658 659</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>657</para>
        /// </summary>
        [NameInMap("ThreadID")]
        [Validation(Required=false)]
        public string ThreadID { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
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
