// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBNodesClassRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. The token is case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The details of the nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<ModifyDBNodesClassRequestDBNode> DBNode { get; set; }
        public class ModifyDBNodesClassRequestDBNode : TeaModel {
            /// <summary>
            /// <para>The ID of the node.</para>
            /// <remarks>
            /// <para> If you specify this parameter, DBNode.N.TargetClass is required. N is an integer that starts from 1. The maximum value of N is calculated by using the following formula:16 - The number of current nodes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pi-*************</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <para>The specifications of the node that you want to change. For more information, see <a href="https://help.aliyun.com/document_detail/102542.html">Specifications of compute nodes</a>.</para>
            /// <remarks>
            /// <para> If you specify this parameter, DBNode.N.DBNodeId is required. N is an integer that starts from 1. The maximum value of N is calculated by using the following formula:16 - The number of current nodes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.x4.medium</para>
            /// </summary>
            [NameInMap("TargetClass")]
            [Validation(Required=false)]
            public string TargetClass { get; set; }

        }

        /// <summary>
        /// <para>The type of the configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Upgrade</b></description></item>
        /// <item><description><b>Downgrade</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The latest start time to upgrade the specifications within the scheduled time period. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value of this parameter must be at least 30 minutes later than the value of PlannedStartTime.</description></item>
        /// <item><description>By default, if you specify <c>PlannedStartTime</c> but do not specify PlannedEndTime, the latest start time of the task is set to <c>Value of PlannedEndTime + 30 minutes</c>. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and you do not specify PlannedEndTime, the latest start time of the task is <c>2021-01-14T09:30:00Z</c>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        [NameInMap("PlannedFlashingOffTime")]
        [Validation(Required=false)]
        public string PlannedFlashingOffTime { get; set; }

        /// <summary>
        /// <para>The earliest start time to upgrade the specifications within the scheduled time period. Specify the time in the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <c>ModifyType</c> is set to <c>Upgrade</c>.</description></item>
        /// <item><description>The earliest start time of the task can be a point in time within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can specify a point in the time that ranges from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</description></item>
        /// <item><description>If this parameter is left empty, the upgrade task is immediately performed.</description></item>
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
        /// <para>The category of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal_exclusive</b>: dedicated</description></item>
        /// <item><description><b>normal_general</b>: genera-purpose</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal_general</para>
        /// </summary>
        [NameInMap("SubCategory")]
        [Validation(Required=false)]
        public string SubCategory { get; set; }

    }

}
