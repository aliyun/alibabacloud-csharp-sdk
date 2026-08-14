// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSlowLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters in the destination region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1rqvm70uh2****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. The time range between the start time and the end time cannot exceed 7 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-27T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The sorting order of the results. The value is an ordered JSON array. The results are sorted in the order of the objects in the array. Each object contains the <c>Field</c> and <c>Type</c> parameters. Example: <c>[{&quot;Field&quot;:&quot;ExecutionStartTime&quot;,&quot;Type&quot;:&quot;Desc&quot;},{&quot;Field&quot;:&quot;ScanRows&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: the field to sort by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HostAddress</b>: the IP address of the client that is used to connect to the database.</para>
        /// </description></item>
        /// <item><description><para><b>UserName</b>: the username.</para>
        /// </description></item>
        /// <item><description><para><b>ExecutionStartTime</b>: the start time of the SQL statement execution.</para>
        /// </description></item>
        /// <item><description><para><b>QueryTime</b>: the execution duration of the SQL statement.</para>
        /// </description></item>
        /// <item><description><para><b>PeakMemoryUsage</b>: the peak memory usage for executing the SQL statement.</para>
        /// </description></item>
        /// <item><description><para><b>ScanRows</b>: the number of rows scanned from the data source.</para>
        /// </description></item>
        /// <item><description><para><b>ScanSize</b>: the amount of scanned data.</para>
        /// </description></item>
        /// <item><description><para><b>ScanTime</b>: the total time consumed to scan data.</para>
        /// </description></item>
        /// <item><description><para><b>PlanningTime</b>: the time consumed to generate the execution plan.</para>
        /// </description></item>
        /// <item><description><para><b>WallTime</b>: the total CPU time consumed by all operators in the query on each node.</para>
        /// </description></item>
        /// <item><description><para><b>ProcessID</b>: the process ID.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: the sorting type. Valid values:</para>
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
        /// <para>[{&quot;Field&quot;:&quot;ExecutionStartTime&quot;,&quot;Type&quot;:&quot;Desc&quot;},{&quot;Field&quot;:&quot;ScanRows&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

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
        /// <para>The number of entries to return on each page. Valid values: <b>30</b> (default), <b>50</b>, and <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The process ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021052716044317201616624903453******</para>
        /// </summary>
        [NameInMap("ProcessID")]
        [Validation(Required=false)]
        public string ProcessID { get; set; }

        /// <summary>
        /// <para>Filters the results by a specified range based on the maximum (<c>Max</c>) and minimum (<c>Min</c>) values of a field. The value is a JSON array. Example: <c>[{&quot;Field&quot;:&quot;ScanSize&quot;,&quot;Min&quot;:&quot;1000000&quot;,&quot;Max&quot;:&quot;10000000&quot;},{&quot;Field&quot;:&quot;QueryTime&quot;,&quot;Min&quot;:&quot;1000&quot;,&quot;Max&quot;:&quot;10000&quot;}]</c>.</para>
        /// <para>The <c>Field</c> parameter specifies the field to filter by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ScanSize</b>: the amount of scanned data. Unit: KB.</para>
        /// </description></item>
        /// <item><description><para><b>QueryTime</b>: the execution duration. Unit: milliseconds (ms).</para>
        /// </description></item>
        /// <item><description><para><b>PeakMemoryUsage</b>: the peak memory usage for executing the SQL statement. Unit: KB.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para><c>Min</c> specifies the minimum value of the query range (left operand). <c>Max</c> specifies the maximum value of the query range (right operand). The data type of both parameters is String.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;ScanSize&quot;,&quot;Min&quot;:&quot;1000000&quot;,&quot;Max&quot;:&quot;10000000&quot;},{&quot;Field&quot;:&quot;QueryTime&quot;,&quot;Min&quot;:&quot;1000&quot;,&quot;Max&quot;:&quot;10000&quot;}]</para>
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-20T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The query state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Successed</b>: The query was successful.</para>
        /// </description></item>
        /// <item><description><para><b>Failed</b>: The query failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Successed</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
