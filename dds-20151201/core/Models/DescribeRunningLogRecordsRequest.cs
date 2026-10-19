// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeRunningLogRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>If you set this parameter to the ID of a sharded cluster instance, you must also specify the <b>NodeId</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bpxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mongodbtest</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>The end time must be within 24 hours from the start time. Otherwise, the call fails.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-01T13:10Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The logical operator for keyword-based search.
        /// Default value: and.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("LogicalOperator")]
        [Validation(Required=false)]
        public string LogicalOperator { get; set; }

        /// <summary>
        /// <para>Instance ID of the mongos or shard node in the sharded cluster instance.</para>
        /// <remarks>
        /// <para>This parameter is available only if you set the <b>DBInstanceId</b> parameter to instance ID of a sharded cluster instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bpxxxxxxxx</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The order in which the returned running logs are sorted by time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: ascending order.</description></item>
        /// <item><description>desc: descending order.</description></item>
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
        /// <para>The number of entries per page. Valid values: <b>30</b> to <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keywords for the query. Separate multiple keywords with spaces. You can specify up to 10 keywords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test test2</para>
        /// </summary>
        [NameInMap("QueryKeywords")]
        [Validation(Required=false)]
        public string QueryKeywords { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bpxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The role ID of the node. You can call <a href="https://help.aliyun.com/document_detail/62134.html">DescribeReplicaSetRole</a> to query the role ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>651xxxxx</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <para>The role of the node in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>primary</b>: primary node.</description></item>
        /// <item><description><b>secondary</b>: secondary node.</description></item>
        /// <item><description><b>search</b>: search node.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set the <b>NodeId</b> parameter to the ID of a mongos node, the value of <b>RoleType</b> can only be <b>primary</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>primary</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-01T12:10Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
