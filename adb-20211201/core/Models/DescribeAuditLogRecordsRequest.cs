// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAuditLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query the IDs of all clusters in a region.</para>
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
        /// <para>The end of the time range to query. The time must be in UTC and in the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The end time must be later than the start time.</para>
        /// </description></item>
        /// <item><description><para>The time range cannot exceed 24 hours.</para>
        /// </description></item>
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
        /// <para>The client IP address and port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.104.XX.XX:43908</para>
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// <para>Specifies the fields for sorting the results. The value is a JSON string that is an array of objects. The order of objects in the array defines the sort priority. Each object contains the<c>Field</c> and<c>Type</c> parameters. Example: <c>[{&quot;Field&quot;:&quot;ExecutionStartTime&quot;,&quot;Type&quot;:&quot;Desc&quot;},{&quot;Field&quot;:&quot;ScanRows&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: the field by which to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HostAddress</b>: the client IP address.</para>
        /// </description></item>
        /// <item><description><para><b>UserName</b>: the username.</para>
        /// </description></item>
        /// <item><description><para><b>ExecutionStartTime</b>: the execution start time of the SQL statement.</para>
        /// </description></item>
        /// <item><description><para><b>QueryTime</b>: the execution duration.</para>
        /// </description></item>
        /// <item><description><para><b>PeakMemoryUsage</b>: the peak memory usage of the SQL statement.</para>
        /// </description></item>
        /// <item><description><para><b>ScanRows</b>: the number of rows scanned by a task that involves a data source.</para>
        /// </description></item>
        /// <item><description><para><b>ScanSize</b>: the amount of data scanned.</para>
        /// </description></item>
        /// <item><description><para><b>ScanTime</b>: the time taken for the data scan.</para>
        /// </description></item>
        /// <item><description><para><b>PlanningTime</b>: the time taken to generate the execution plan.</para>
        /// </description></item>
        /// <item><description><para><b>WallTime</b>: the total CPU time of all operators on all nodes.</para>
        /// </description></item>
        /// <item><description><para><b>ProcessID</b>: the process ID.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: the sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Desc</b>: descending order.</para>
        /// </description></item>
        /// <item><description><para><b>Asc</b>: ascending order.</para>
        /// </description></item>
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
        /// <para>The sort order for the results based on execution time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>asc</b>: ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>desc</b>: descending order.</para>
        /// </description></item>
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
        /// <para>The page number. The value must be an integer that is greater than 0. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>10</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
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
        /// <para>无</para>
        /// </summary>
        [NameInMap("ProxyUser")]
        [Validation(Required=false)]
        public string ProxyUser { get; set; }

        /// <summary>
        /// <para>A keyword used to perform a fuzzy search on the returned results.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query available regions.</para>
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
        /// <item><description><para><b>DELETE</b></para>
        /// </description></item>
        /// <item><description><para><b>SELECT</b></para>
        /// </description></item>
        /// <item><description><para><b>UPDATE</b></para>
        /// </description></item>
        /// <item><description><para><b>INSERT INTO SELECT</b></para>
        /// </description></item>
        /// <item><description><para><b>ALTER</b></para>
        /// </description></item>
        /// <item><description><para><b>DROP</b></para>
        /// </description></item>
        /// <item><description><para><b>CREATE</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify only one type per request. If this parameter is not specified, all types are queried by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The time must be in UTC and in the <c>yyyy-MM-ddTHH:mmZ</c> format.</para>
        /// <remarks>
        /// <para>You can query SQL audit logs only when this feature is enabled. Logs are available for the last 30 days. If you disable and then re-enable SQL audit, only logs generated after the feature was re-enabled are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-12T04:17Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the SQL statement was successfully executed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The SQL statement succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The SQL statement failed.</para>
        /// </description></item>
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
