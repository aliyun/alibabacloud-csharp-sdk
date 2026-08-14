// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAuditLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Data Warehouse Edition cluster.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to view the IDs of all Data Warehouse Edition clusters in the destination region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-t4nj8619bz2w3****</para>
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
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The end time must be later than the start time.</para>
        /// </description></item>
        /// <item><description><para>The time range to query cannot exceed 24 hours.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-23T22:18Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The IP address and port number of the client that was used to execute the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.104.XX.XX:43908</para>
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// <para>The sorting order of the query results. Specify the value as an ordered JSON array. The results are sorted based on the order of fields in the array. Each object in the array contains the \<c>Field\\</c> and \<c>Type\\</c> fields.</para>
        /// <list type="bullet">
        /// <item><description><para>Field specifies the field by which to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>HostAddress: the IP address of the client that connects to the database.</para>
        /// </description></item>
        /// <item><description><para>Succeed: specifies whether the SQL statement was successfully executed.</para>
        /// </description></item>
        /// <item><description><para>TotalTime: the total amount of time that is consumed to execute the SQL statement.</para>
        /// </description></item>
        /// <item><description><para>DBName: the name of the database on which the SQL statement was executed.</para>
        /// </description></item>
        /// <item><description><para>SQLType: the type of the SQL statement.</para>
        /// </description></item>
        /// <item><description><para>User: the username that was used to execute the SQL statement.</para>
        /// </description></item>
        /// <item><description><para>ExecuteTime: the start time of the SQL statement execution.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Type specifies the sorting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Desc: descending.</para>
        /// </description></item>
        /// <item><description><para>Asc: ascending.</para>
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
        /// <para>The order by which to sort the query results based on the execution time of the SQL statement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>asc</b>: ascending.</para>
        /// </description></item>
        /// <item><description><para><b>desc</b>: descending.</para>
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
        /// <para>The page number. The value must be an integer that is greater than 0 and does not exceed the maximum value of the integer data type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>10</b></para>
        /// </description></item>
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value is 10.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>The keyword for the query. This keyword is used to filter SQL statements.</para>
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
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to view the regions and zones, including the region IDs, that are supported by AnalyticDB for MySQL.</para>
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
        /// <item><description><para><b>INSERT_INTO_SELECT</b></para>
        /// </description></item>
        /// <item><description><para><b>ALTER</b></para>
        /// </description></item>
        /// <item><description><para><b>DROP</b></para>
        /// </description></item>
        /// <item><description><para><b>CREATE</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can query for only one type of SQL statement at a time. If you leave this parameter empty, all types of SQL statements are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>You can query SQL audit logs only when SQL Audit is enabled. You can query only the SQL audit logs from the last 30 days. If you disable and then re-enable SQL Audit, you can query only the logs generated after it was re-enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-23T02:18Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the SQL statement was successfully executed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The SQL statement was successfully executed.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The SQL statement failed to be executed.</para>
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
        /// <para>The username that was used to execute the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
