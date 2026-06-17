// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterAndNodesParametersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to clear binlog. This parameter is valid only when binlog is disabled.</para>
        /// </summary>
        [NameInMap("ClearBinlog")]
        [Validation(Required=false)]
        public bool? ClearBinlog { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**********</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes. By setting this parameter, you can modify the parameters of the cluster and specified nodes. Separate multiple node IDs with commas (,).</para>
        /// <remarks>
        /// <para>If this parameter is not specified, only the cluster parameters are modified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-<b><b><b><b><b>,pi-</b></b></b></b></b></para>
        /// </summary>
        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public string DBNodeIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately or scheduledly modify parameters and restart the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): scheduled execution</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: immediate execution</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>pcpg-**********</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The JSON string that consists of parameters and their values.</para>
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
        /// <item><description><para>The latest start time must be 30 minutes or more later than the earliest start time.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>PlannedStartTime</c> but not this parameter, the latest start time of the task is <c>the earliest start time + 30 minutes</c> by default. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and leave this parameter empty, the task will start no later than <c>2021-01-14T09:30:00Z</c>.</para>
        /// </description></item>
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
        /// <para>The earliest time to start the scheduled task. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The start time can be any time within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can specify a time that ranges from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty, the task is immediately executed.</para>
        /// </description></item>
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
        /// <para>The list of GDN standby clusters to which you want to synchronize the parameter settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-<b><b><b><b><b>,gdn-</b></b></b></b></b></para>
        /// </summary>
        [NameInMap("StandbyClusterIdListNeedToSync")]
        [Validation(Required=false)]
        public string StandbyClusterIdListNeedToSync { get; set; }

    }

}
