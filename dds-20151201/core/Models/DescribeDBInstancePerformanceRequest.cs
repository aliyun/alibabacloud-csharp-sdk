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
        /// <para><b>NodeId</b> is required when specifying a sharded cluster instance ID</para>
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
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-13T11:58Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The data granularity of the performance metrics in seconds. Valid values: 5, 30, 60, 600, 1800, 3600, and 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The performance metrics. For more information, see <a href="https://help.aliyun.com/document_detail/216973.html">Metrics</a>.</para>
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
        /// <para>The ID of a mongos or shard node in the sharded cluster instance. This parameter lets you query the performance of a single node.</para>
        /// <remarks>
        /// <para>Available only when <b>DBInstanceId</b> is set to the ID of a sharded cluster instance.</para>
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
        /// <para>The role of a node in a standalone or replica set instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Primary</b>: The primary node.</para>
        /// </description></item>
        /// <item><description><para><b>Secondary</b>: A secondary node.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Available only when <b>DBInstanceId</b> is set to the ID of a standalone or replica set instance.</para>
        /// </description></item>
        /// <item><description><para>If <b>DBInstanceId</b> is set to the ID of a standalone instance, this parameter only supports the value <b>Primary</b>.</para>
        /// </description></item>
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
        /// <para>The role ID of a node in a standalone or replica set instance. To query the role ID, call the <a href="https://help.aliyun.com/document_detail/62134.html">DescribeReplicaSetRole</a> operation.</para>
        /// <remarks>
        /// <para>Available only when <b>DBInstanceId</b> is set to the ID of a standalone or replica set instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6025****</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <para>The Search node ID.</para>
        /// <remarks>
        /// <para>Available only after the Search feature is enabled for the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dds-2zec12675c9e****-search</para>
        /// </summary>
        [NameInMap("SearchId")]
        [Validation(Required=false)]
        public string SearchId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time must be in UTC.</para>
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
