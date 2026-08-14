// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeLoadTasksRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the details of all Data Warehouse Edition clusters in a specified region, including cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp2590j****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database involved in the import or export task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adb_demo</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-ddTHH:mm:ssZ</i> format (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-18T06:30:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Sorts tasks in ascending or descending order based on a specified field. The value must be a JSON string. Example: <c>[{&quot;Field&quot;:&quot;CreateTime&quot;, &quot;Type&quot;:&quot;desc&quot;}]</c></para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><c>Field</c> specifies the field by which to sort. Valid fields: <c>State</c>, <c>CreateTime</c>, <c>DBName</c>, <c>ProcessID</c>, <c>UpdateTime</c>, <c>JobName</c>, and <c>ProcessRows</c>.</description></item>
        /// <item><description><c>Type</c> specifies the sort order. Valid values: <c>Desc</c> (descending) and <c>Asc</c> (ascending). The values are case-insensitive.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Field&quot;:&quot;CreateTime&quot;, &quot;Type&quot;:&quot;desc&quot;}]</para>
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
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default).</description></item>
        /// <item><description><b>50</b>.</description></item>
        /// <item><description><b>100</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the region IDs supported by a specified Data Warehouse Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
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
        /// <para>The beginning of the time range to query. Specify the time in the <i>yyyy-MM-ddTHH:mm:ssZ</i> format (UTC).</para>
        /// <remarks>
        /// <para>Set the query start time to a point in time within the last 30 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-18T06:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the asynchronous import or export task to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INIT</b>: The task is being initialized.</description></item>
        /// <item><description><b>RUNNING</b>: The task is running.</description></item>
        /// <item><description><b>FINISH</b>: The task is successful.</description></item>
        /// <item><description><b>FAILED</b>: The task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FINISH</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
