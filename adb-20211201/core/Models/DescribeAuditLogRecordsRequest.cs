// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAuditLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The cluster ID of an Enterprise Edition, Basic Edition, or Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The cluster ID of a Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the IDs of all clusters in a specified region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-t4nj8619bz2w3****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database on which the target SQL statement is executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is displayed in UTC and in the yyyy-MM-ddTHH:mmZ format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The end time must be later than the start time.</description></item>
        /// <item><description>The interval between the start time and the end time cannot exceed 24 hours.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-12T17:08Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>XIHE: audit logs of the default compute engine.</description></item>
        /// <item><description>AGENT_SERVERLESS: audit logs of the Serverless analytics feature.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, the default value is XIHE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XIHE</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The IP address and port number of the client that executes the target SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.104.XX.XX:43908</para>
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// <para>The sort configuration in JSON format. The value is an ordered JSON array that specifies composite sorting based on the input array order. Each element contains the <c>Field</c> and <c>Type</c> parameters. Example: <c>[{&quot;Field&quot;:&quot;ExecutionStartTime&quot;,&quot;Type&quot;:&quot;Desc&quot;},{&quot;Field&quot;:&quot;ScanRows&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>. Details:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c> specifies the field name for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HostAddress</b>: the client address used to connect to the database.</description></item>
        /// <item><description><b>UserName</b>: the username.</description></item>
        /// <item><description><b>ExecutionStartTime</b>: the start time of the target SQL statement execution.</description></item>
        /// <item><description><b>QueryTime</b>: the execution duration of the target SQL statement.</description></item>
        /// <item><description><b>PeakMemoryUsage</b>: the peak memory usage during the execution of the target SQL statement.</description></item>
        /// <item><description><b>ScanRows</b>: the number of scanned rows for tasks with a data source.</description></item>
        /// <item><description><b>ScanSize</b>: the volume of scanned data.</description></item>
        /// <item><description><b>ScanTime</b>: the total time consumed by data scanning.</description></item>
        /// <item><description><b>PlanningTime</b>: the time consumed by execution plan generation.</description></item>
        /// <item><description><b>WallTime</b>: the cumulative CPU time of all operators in the query across all nodes.</description></item>
        /// <item><description><b>ProcessID</b>: the process ID.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c> specifies the sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Desc</b>: descending order.</description></item>
        /// <item><description><b>Asc</b>: ascending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;ExecuteTime&quot;,&quot;Type&quot;:&quot;Desc&quot;},{&quot;Field&quot;:&quot;HostAddress&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The sort order of SQL statements by execution time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: ascending order.</description></item>
        /// <item><description><b>desc</b>: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
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
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the INTEGER data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>10</b> (default)</description></item>
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The process ID of the SQL query, used to filter audit logs of a specified process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20210608175202172016166249034536****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ProxyUser")]
        [Validation(Required=false)]
        public string ProxyUser { get; set; }

        /// <summary>
        /// <para>A string value that is used as a keyword to filter the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb</para>
        /// </summary>
        [NameInMap("QueryKeyword")]
        [Validation(Required=false)]
        public string QueryKeyword { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the region ID of the cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The SQL statement type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DELETE</b></description></item>
        /// <item><description><b>SELECT</b></description></item>
        /// <item><description><b>UPDATE</b></description></item>
        /// <item><description><b>INSERT INTO SELECT</b></description></item>
        /// <item><description><b>ALTER</b></description></item>
        /// <item><description><b>DROP</b></description></item>
        /// <item><description><b>CREATE</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>Only one type can be specified at a time. If this parameter is left empty, all types are queried by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is displayed in UTC and in the yyyy-MM-ddTHH:mmZ format.</para>
        /// <remarks>
        /// <para>SQL audit logs can be queried only when SQL Audit is enabled. Only SQL audit logs within the last 30 days can be queried. If SQL Audit is disabled and then re-enabled, only SQL audit logs generated after the re-enablement can be queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-12T04:17Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the target SQL statement is executed successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The SQL statement is executed successfully.</description></item>
        /// <item><description><b>false</b>: The SQL statement fails to be executed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Succeed")]
        [Validation(Required=false)]
        public string Succeed { get; set; }

        /// <summary>
        /// <para>The username that executes the target SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
