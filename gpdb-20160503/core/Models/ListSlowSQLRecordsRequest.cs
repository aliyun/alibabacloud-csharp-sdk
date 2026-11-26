// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSlowSQLRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb01</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The end time of the query. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format. The time must be in UTC.</para>
        /// <para>Default value: The current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-04T17:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The query keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum execution duration. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("MaxDuration")]
        [Validation(Required=false)]
        public string MaxDuration { get; set; }

        /// <summary>
        /// <para>The minimum execution duration. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinDuration")]
        [Validation(Required=false)]
        public string MinDuration { get; set; }

        /// <summary>
        /// <para>The sorting conditions in JSON format. Example: {&quot;Field&quot;:&quot;QueryStartTime&quot;,&quot;Type&quot;:&quot;Desc&quot;}.</para>
        /// <para>Field: the field to sort by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>QueryID: the query ID.</para>
        /// </description></item>
        /// <item><description><para>UserName: the username.</para>
        /// </description></item>
        /// <item><description><para>DBName: the database name.</para>
        /// </description></item>
        /// <item><description><para>QueryStartTime: the start time.</para>
        /// </description></item>
        /// <item><description><para>QueryEndTime: the end time.</para>
        /// </description></item>
        /// <item><description><para>DurationTime: the execution duration.</para>
        /// </description></item>
        /// <item><description><para>Optimizer: the optimizer.</para>
        /// </description></item>
        /// <item><description><para>LockWaitTime: the lock wait time.</para>
        /// </description></item>
        /// <item><description><para>QueueWaitTime: the queue wait time.</para>
        /// </description></item>
        /// <item><description><para>CpuTimeMs: the CPU time.</para>
        /// </description></item>
        /// <item><description><para>MemBytes: the memory usage.</para>
        /// </description></item>
        /// <item><description><para>SpillBytes: the size of spilled files.</para>
        /// </description></item>
        /// </list>
        /// <para>Type: the sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Desc: descending order.</para>
        /// </description></item>
        /// <item><description><para>Asc: ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Field&quot;:&quot;QueryStartTime&quot;,&quot;Type&quot;:&quot;Desc&quot;}</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0 and less than or equal to 100.</para>
        /// <para>Default value: 1.</para>
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
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <para>Default value: 5 minutes before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-04T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The database username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_user</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
