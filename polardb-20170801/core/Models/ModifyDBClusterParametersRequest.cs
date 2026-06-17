// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterParametersRequest : TeaModel {
        [NameInMap("ClearBinlog")]
        [Validation(Required=false)]
        public bool? ClearBinlog { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to view information about all clusters in the destination region, including cluster IDs.</para>
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
        /// <para>Specifies whether to immediately modify the parameters and restart the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): The modification is scheduled.</para>
        /// </description></item>
        /// <item><description><para>true: The modification is performed immediately.</para>
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
        /// <para>The ID of the parameter template.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Call the <a href="https://help.aliyun.com/document_detail/207178.html">DescribeParameterGroups</a> operation to view the ID of the parameter template.</para>
        /// </description></item>
        /// <item><description><para>You must specify this parameter or the <c>Parameters</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>This parameter is supported only by PolarDB for MySQL.</para>
        /// </description></item>
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
        /// <para>A JSON string that consists of parameters and their values. The parameter values must be strings. For example: <c>{&quot;wait_timeout&quot;:&quot;86&quot;,&quot;innodb_old_blocks_time&quot;:&quot;10&quot;}</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Call the <a href="https://help.aliyun.com/document_detail/98122.html">DescribeDBClusterParameters</a> operation to view the parameters of a PolarDB cluster.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required if the destination cluster is a PolarDB for PostgreSQL or PolarDB for PostgreSQL (Oracle compatible) cluster.</para>
        /// </description></item>
        /// <item><description><para>If the destination cluster is a PolarDB for MySQL cluster, you must specify this parameter or the <c>ParameterGroupId</c> parameter.</para>
        /// </description></item>
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
        /// <para>The latest time to start the scheduled task. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The latest start time must be at least 30 minutes later than the earliest start time.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>PlannedStartTime</c> but not this parameter, the latest time to start the task is <c>PlannedStartTime + 30 minutes</c> by default. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and leave this parameter empty, the task starts no later than <c>2021-01-14T09:30:00Z</c>.</para>
        /// </description></item>
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
        /// <para>The earliest time to start the scheduled task. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The start time can be any point in time within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can set the start time to a value in the range of <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty, the task is executed immediately.</para>
        /// </description></item>
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
