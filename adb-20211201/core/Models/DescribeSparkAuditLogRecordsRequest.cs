// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkAuditLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/454250.html">DescribeDBClusters</a> operation to query cluster IDs.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1j7******78j8i</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Query end time. The end time must be later than the start time, and the interval between them must be less than 1 day. Format: yyyy-MM-ddTHH:mmZ (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-25T01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Sort the SQL statements based on specified fields. The format is a JSON array that preserves order, and composite sorting is performed according to the sequence of objects in the array. Each object contains two fields: <c>Field</c> and <c>Type</c>. For example:<c>[{&quot;Field&quot;:&quot;CreateTime&quot;, &quot;Type&quot;: &quot;desc&quot; }]</c>. Where:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Field</c> specifies the field that is used to sort the SQL statements. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ResourceGroupName</c>: The name of the resource group.</description></item>
        /// <item><description><c>Status</c> :SQL execution status.</description></item>
        /// <item><description><c>User</c>: The username that is used to execute the SQL statement.</description></item>
        /// <item><description><c>ExecuteTime</c>: The start time of SQL execution.</description></item>
        /// <item><description><c>TotalTime</c>: The amount of time consumed to execute the SQL statement.</description></item>
        /// <item><description><c>ProcessId</c>: Query ID.</description></item>
        /// <item><description><c>ClientIp</c>: The source IP address.</description></item>
        /// <item><description><c>StatementSource</c>: The source from which the query was initiated.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><c>Type</c> specifies the sorting order. Valid values (case-insensitive):</para>
        /// <list type="bullet">
        /// <item><description><c>Desc</c>: Descending order.</description></item>
        /// <item><description><c>Asc</c>: Ascending order.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Field\&quot;:\&quot;ExecuteTime\&quot;,\&quot;Type\&quot;:\&quot;Desc\&quot;}]</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>999f2439-6b10-xxxx-a5d3-daf3b35c****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("ProxyUser")]
        [Validation(Required=false)]
        public string ProxyUser { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612293.html">DescribeRegions</a> operation to query the available regions and zones, including region ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group name.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612410.html">DescribeDBResourceGroup</a> operation to query the resource group ID within a cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test_job</para>
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The keyword in the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table_name</para>
        /// </summary>
        [NameInMap("SQLText")]
        [Validation(Required=false)]
        public string SQLText { get; set; }

        /// <summary>
        /// <para>Query start time. Format: <em>yyyy-MM-ddTHH:mmZ</em> (UTC time).</para>
        /// <remarks>
        /// <para> We recommend that you set the query start time to any point in time within 30 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2025-09-25T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The ID of the statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fbd22066-1c03-xxxx-aa16-6ae28288****</para>
        /// </summary>
        [NameInMap("StatementId")]
        [Validation(Required=false)]
        public string StatementId { get; set; }

        /// <summary>
        /// <para>The source from which the query was initiated.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SQL_EDITOR: SQL_EDITOR.</description></item>
        /// <item><description>JDBC: JDBC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SQL_EDITOR</para>
        /// </summary>
        [NameInMap("StatementSource")]
        [Validation(Required=false)]
        public string StatementSource { get; set; }

        /// <summary>
        /// <para>The execution status of the SQL statement.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cancel: The task is canceled .</description></item>
        /// <item><description>finished: The execution succeeds .</description></item>
        /// <item><description>error:The execution fails .</description></item>
        /// <item><description>timeout: The execution timed out .</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>finish</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The duration of the SQL statement. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("TotalTime")]
        [Validation(Required=false)]
        public string TotalTime { get; set; }

        /// <summary>
        /// <para>The username that is used to execute SQL statements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
