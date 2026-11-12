// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterAndNodesParametersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to clear binlogs. This parameter takes effect only when binlogs are disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ClearBinlog")]
        [Validation(Required=false)]
        public bool? ClearBinlog { get; set; }

        /// <summary>
        /// <para>The cluster ID. The DBClusterStatus of the target cluster must be Running. You can call the DescribeDBClusters operation to check the current status. Usage notes: The DBClusterStatus of the cluster must be Running. You can call the DescribeDBClusters operation to verify the status.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**********</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The node IDs. You can set this parameter to modify the parameters of the cluster and the specified nodes. Separate multiple node IDs with commas (,).</para>
        /// <remarks>
        /// <para>If this parameter is left empty, only the cluster parameters are modified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-<b><b><b><b><b>,pi-</b></b></b></b></b></para>
        /// </summary>
        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public string DBNodeIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to execute the parameter modification and cluster restart immediately or at a scheduled time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: The task is executed at a scheduled time. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: The task is executed immediately.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>pcpg-**********</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The JSON string of parameters and their values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;wait_timeout&quot;:&quot;86&quot;,&quot;innodb_old_blocks_time&quot;:&quot;10&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The latest time to start the scheduled task. The time must be in the <c>YYYY-MM-DDThh:mm:ssZ</c> format and in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The latest time must be at least 30 minutes later than the start time.</description></item>
        /// <item><description>If <c>PlannedStartTime</c> is specified but this parameter is not, the latest start time defaults to 30 minutes after the start time. For example, if <c>PlannedStartTime</c> is set to <c>2021-01-14T09:00:00Z</c> and this parameter is left empty, the task will start no later than <c>2021-01-14T09:30:00Z</c>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>The earliest time to start the scheduled task. The time must be in the <c>YYYY-MM-DDThh:mm:ssZ</c> format and in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The start time must be within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, the allowed start time ranges from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</description></item>
        /// <item><description>If this parameter is left empty, the task is executed immediately by default.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:00:00Z</para>
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

        /// <summary>
        /// <para>The list of secondary clusters in the Global Database Network (GDN) that require parameter settings synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-<b><b><b><b><b>,gdn-</b></b></b></b></b></para>
        /// </summary>
        [NameInMap("StandbyClusterIdListNeedToSync")]
        [Validation(Required=false)]
        public string StandbyClusterIdListNeedToSync { get; set; }

    }

}
