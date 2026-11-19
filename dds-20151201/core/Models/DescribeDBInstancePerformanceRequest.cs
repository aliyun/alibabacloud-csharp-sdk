// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancePerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>If you specify the ID of a sharded cluster instance for this parameter, you must also specify the <b>NodeId</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp2635****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-13T11:58Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The data granularity. Valid values: 5, 30, 60, 600, 1800, 3600, and 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The performance metrics. For more information, see <a href="https://help.aliyun.com/document_detail/216973.html">Monitoring metrics</a>.</para>
        /// <remarks>
        /// <para>To specify multiple metrics, separate them with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CpuUsage</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Instance ID of the mongos or shard node in a sharded cluster instance. You can use this parameter to query the performance of a single node.</para>
        /// <remarks>
        /// <para>This parameter is available only when you specify instance ID of a sharded cluster instance for the <b>DBInstanceId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp2287****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The role of the node in a standalone instance or replica set instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Primary</b>: The primary node.</description></item>
        /// <item><description><b>Secondary</b>: The secondary node.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only when you specify instance ID of a standalone instance or replica set instance for the <b>DBInstanceId</b> parameter.</description></item>
        /// <item><description>When you specify instance ID of a standalone instance for the <b>DBInstanceId</b> parameter, you can set this parameter only to <b>Primary</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Primary</para>
        /// </summary>
        [NameInMap("ReplicaSetRole")]
        [Validation(Required=false)]
        public string ReplicaSetRole { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The instance ID of the node in a standalone instance or replica set instance. You can call the <a href="https://help.aliyun.com/document_detail/62134.html">DescribeReplicaSetRole</a> operation to query the instance ID.</para>
        /// <remarks>
        /// <para>This parameter is available only when you specify the ID of a standalone instance or replica set instance for the <b>DBInstanceId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6025****</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <para>The ID of the search node.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is available only when the search feature is enabled for the instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds-2zec12675c9e****-search</para>
        /// </summary>
        [NameInMap("SearchId")]
        [Validation(Required=false)]
        public string SearchId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-13T10:58Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
