// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterAndNodesParametersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The IDs of nodes. You can specify this parameter, or leave this parameter empty. Separate multiple node IDs with commas (,).</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, only the cluster parameters are modified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-****************,pi-**********,</para>
        /// </summary>
        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public string DBNodeIds { get; set; }

        /// <summary>
        /// <para>Specifies an immediate or scheduled task to modify parameters and restart the cluster. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: runs the kernel upgrade task in a scheduled manner.</description></item>
        /// <item><description><b>true</b>: immediately runs the kernel upgrade task.</description></item>
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
        /// <para>pcpg-**************</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The JSON string for the parameter and its value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;wait_timeout&quot;:&quot;86&quot;,&quot;innodb_old_blocks_time&quot;:&quot;10&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The latest start time to run the task. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The value of this parameter must be at least 30 minutes later than the value of the PlannedStartTime parameter.</para>
        /// </description></item>
        /// <item><description><para>By default, if you specify the <c>PlannedStartTime</c> parameter but do not specify the PlannedEndTime parameter, the latest start time of the task is set to a value that is calculated by using the following formula: <c>Value of the PlannedEndTime parameter + 30 minutes</c>. For example, if you set the <c>PlannedStartTime</c> parameter to <c>2021-01-14T09:00:00Z</c> and you do not specify the PlannedEndTime parameter, the latest start time of the task is set to <c>2021-01-14T09:30:00Z</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>The earliest time to upgrade the specifications within the scheduled time period. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The earliest start time of the task can be a point in time within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can specify a point in the time range from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is empty, the upgrade task is immediately performed.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The secondary clusters in the GDN to which the parameter settings are synchronized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-<b><b><b><b><b>,gdn-</b></b></b></b></b></para>
        /// </summary>
        [NameInMap("StandbyClusterIdListNeedToSync")]
        [Validation(Required=false)]
        public string StandbyClusterIdListNeedToSync { get; set; }

    }

}
