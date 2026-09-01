// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterParametersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to clear binlogs. This parameter takes effect only when binlog is disabled.</para>
        /// </summary>
        [NameInMap("ClearBinlog")]
        [Validation(Required=false)]
        public bool? ClearBinlog { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query information about all clusters in the specified region, including cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately or schedule the parameter modification and cluster restart. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><para>false (default): Scheduled execution.</para>
        /// </description></item>
        /// <item><description><para>true: Immediate execution.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FromTimeService")]
        [Validation(Required=false)]
        public bool? FromTimeService { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The parameter template ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/207178.html">DescribeParameterGroups</a> operation to query the parameter template ID.</description></item>
        /// <item><description>You must specify either this parameter or the <c>Parameters</c> parameter.</description></item>
        /// <item><description>Only PolarDB for MySQL supports this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pcpg-**************</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>A JSON string that consists of parameters and their values. Parameter values are of the STRING type. Example: <c>{&quot;wait_timeout&quot;:&quot;86&quot;,&quot;innodb_old_blocks_time&quot;:&quot;10&quot;}</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/98122.html">DescribeDBClusterParameters</a> operation to query the parameters of a PolarDB cluster.</description></item>
        /// <item><description>If the cluster runs PolarDB for PostgreSQL or PolarDB for PostgreSQL (Compatible with Oracle), this parameter is required.</description></item>
        /// <item><description>If the cluster runs PolarDB for MySQL, you must specify either this parameter or the <c>ParameterGroupId</c> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;wait_timeout&quot;:&quot;86&quot;,&quot;innodb_old_blocks_time&quot;:&quot;10&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The latest time to start running the scheduled task. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The latest time must be at least 30 minutes later than the start time.</description></item>
        /// <item><description>If you specify <c>PlannedStartTime</c> but do not specify this parameter, the latest time defaults to <c>start time + 30 minutes</c>. For example, if <c>PlannedStartTime</c> is set to <c>2021-01-14T09:00:00Z</c> and this parameter is left empty, the task starts no later than <c>2021-01-14T09:30:00Z</c>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-28T14:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>The earliest time to start running the scheduled task within the specified time range. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The start time must be within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, the start time can range from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</description></item>
        /// <item><description>If this parameter is left empty, the task is immediately executed.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-28T14:00:00Z</para>
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
