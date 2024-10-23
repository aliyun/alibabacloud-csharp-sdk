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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the cluster IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a specific region.</para>
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
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The end time must be later than the start time. The specified time range must be less than seven days.</para>
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
        /// <para>The order in which to sort the retrieved entries by field. Specify this parameter in the JSON format. The value is an ordered array that uses the order of the input array and contains <c>Field</c> and <c>Type</c>. Example: <c>[{&quot;Field&quot;:&quot;ExecutionStartTime&quot;,&quot;Type&quot;:&quot;Desc&quot;},{&quot;Field&quot;:&quot;ScanRows&quot;,&quot;Type&quot;:&quot;Asc&quot;}]</c>.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c>: the field that is used to sort the retrieved entries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HostAddress</b>: the IP address of the client that is used to connect to the database.</description></item>
        /// <item><description><b>UserName</b>: the username.</description></item>
        /// <item><description><b>ExecutionStartTime</b>: the start time of the query execution.</description></item>
        /// <item><description><b>QueryTime</b>: the amount of time consumed to execute the SQL statement.</description></item>
        /// <item><description><b>PeakMemoryUsage</b>: the maximum memory usage when the SQL statement is executed.</description></item>
        /// <item><description><b>ScanRows</b>: the number of rows to be scanned from a data source in the task.</description></item>
        /// <item><description><b>ScanSize</b>: the amount of data to be scanned.</description></item>
        /// <item><description><b>ScanTime</b>: the total amount of time consumed to scan data.</description></item>
        /// <item><description><b>PlanningTime</b>: the amount of time consumed to generate execution plans.</description></item>
        /// <item><description><b>WallTime</b>: the accumulated CPU Time values of all operators in the query on each node.</description></item>
        /// <item><description><b>ProcessID</b>: the ID of the process.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c>: the sorting type of the retrieved entries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Desc</b>: descending order</description></item>
        /// <item><description><b>Asc</b>: ascending order</description></item>
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
        /// <para>The number of the page to return. The value must be an integer that is greater than 0. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021052716044317201616624903453******</para>
        /// </summary>
        [NameInMap("ProcessID")]
        [Validation(Required=false)]
        public string ProcessID { get; set; }

        /// <summary>
        /// <para>The range conditions used to filter specified fields, including <c>Max</c> and <c>Min</c>. Specify this parameter in the JSON format. Example: <c>[{&quot;Field&quot;:&quot;ScanSize&quot;,&quot;Min&quot;:&quot;1000000&quot;,&quot;Max&quot;:&quot;10000000&quot;},{&quot;Field&quot;:&quot;QueryTime&quot;,&quot;Min&quot;:&quot;1000&quot;,&quot;Max&quot;:&quot;10000&quot;}]</c>.</para>
        /// <para><c>Field</c>: the field to be filtered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ScanSize</b>: the amount of data to be scanned. Unit: KB.</description></item>
        /// <item><description><b>QueryTime</b>: the amount of time consumed to execute the statement. Unit: milliseconds.</description></item>
        /// <item><description><b>PeakMemoryUsage</b>: the maximum memory usage when the SQL statement is executed. Unit: KB.</description></item>
        /// </list>
        /// <remarks>
        /// <para> <c>Min</c> indicates the minimum value of the query range (left operand). <c>Max</c> indicates the maximum value of the query range (right operand). Max and Min are both of the String type.</para>
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
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-20T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The state of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Successed</b>: successful</description></item>
        /// <item><description><b>Failed</b>: failed</description></item>
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
