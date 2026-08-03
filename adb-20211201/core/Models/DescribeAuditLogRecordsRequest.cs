// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAuditLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The cluster ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the cluster IDs of all clusters in a region.</para>
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
        /// <para>The name of the database on which the SQL statement was executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in UTC in the yyyy-MM-ddTHH:mmZ format.</para>
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

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The IP address and port number of the client that executed the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.104.XX.XX:43908</para>
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// <para>The sorting order based on specified fields. The value is in JSON format and is an ordered JSON array. Compound sorting is performed in the order of the input array. The array contains the <c>Field</c> and <c>Type</c> fields. Example: <c>[{&quot;Field&quot;:&quot;ExecutionStartTime&quot;,&quot;Type&quot;:&quot;Desc&quot;},{&quot;Field&quot;:&quot;ScanRows&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c> specifies the field name for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HostAddress</b>: the address of the client that connects to the database.</description></item>
        /// <item><description><b>UserName</b>: the username.</description></item>
        /// <item><description><b>ExecutionStartTime</b>: the execution start time of the SQL statement.</description></item>
        /// <item><description><b>QueryTime</b>: the execution duration of the SQL statement.</description></item>
        /// <item><description><b>PeakMemoryUsage</b>: the peak memory usage during the execution of the SQL statement.</description></item>
        /// <item><description><b>ScanRows</b>: the number of rows scanned by the task with a data source.</description></item>
        /// <item><description><b>ScanSize</b>: the amount of scanned data.</description></item>
        /// <item><description><b>ScanTime</b>: the total time consumed for scanning data.</description></item>
        /// <item><description><b>PlanningTime</b>: the time consumed for generating the execution plan.</description></item>
        /// <item><description><b>WallTime</b>: the cumulative CPU time of all operators across all nodes in the query.</description></item>
        /// <item><description><b>ProcessID</b>: the process ID.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c> specifies the sorting type. Valid values:</para>
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
        /// <para>The order in which the results are sorted by SQL execution time. Valid values:</para>
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
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: <b>1</b>.</para>
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
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ProxyUser")]
        [Validation(Required=false)]
        public string ProxyUser { get; set; }

        /// <summary>
        /// <para>The keyword used to filter the returned results.</para>
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
        /// <para>The type of the SQL statement. Valid values:</para>
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
        /// <para>Only one type can be specified per request. If this parameter is left empty, all types are queried by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in UTC in the yyyy-MM-ddTHH:mmZ format.</para>
        /// <remarks>
        /// <para>SQL Audit Log entries can be queried only when SQL audit is enabled, and only entries from the last 30 days are supported. If SQL audit is disabled and then re-enabled, only entries recorded after re-enabling are available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-12T04:17Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the SQL statement was executed successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The SQL statement was executed successfully.</description></item>
        /// <item><description><b>false</b>: The SQL statement failed to be executed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Succeed")]
        [Validation(Required=false)]
        public string Succeed { get; set; }

        /// <summary>
        /// <para>The username that executed the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
