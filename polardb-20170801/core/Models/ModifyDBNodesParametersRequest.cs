// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBNodesParametersRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes. To specify multiple node IDs, separate the IDs with a comma (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pi-<b><b><b><b><b><b><b><b>， pi-</b></b></b></b></b></b></b></b></para>
        /// </summary>
        [NameInMap("DBNodeIds")]
        [Validation(Required=false)]
        public string DBNodeIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to apply the parameter modifications and restart the node. Valid values: \<c>false\\</c> (default): Schedules the task. \<c>true\\</c>: Executes the task immediately.</para>
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
        /// <para>A JSON string that contains the parameters and their values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;wait_timeout&quot;:&quot;86&quot;,&quot;innodb_old_blocks_time&quot;:&quot;10&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The latest time to start the scheduled task. The time must be in the \<c>YYYY-MM-DDThh:mm:ssZ\\</c> format and in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-28T14:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>The earliest time to start the scheduled task. The time must be in the \<c>YYYY-MM-DDThh:mm:ssZ\\</c> format and in UTC.</para>
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
