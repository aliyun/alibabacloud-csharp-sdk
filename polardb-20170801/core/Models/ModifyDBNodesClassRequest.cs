// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBNodesClassRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically apply a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (Default): A coupon is automatically applied.</para>
        /// </description></item>
        /// <item><description><para>false: A coupon is not applied.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. This token must be unique for each request and must be a case-sensitive string of up to 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cloud provider of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENS</para>
        /// </summary>
        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

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
        /// <para>The list of cluster nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<ModifyDBNodesClassRequestDBNode> DBNode { get; set; }
        public class ModifyDBNodesClassRequestDBNode : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster node.</para>
            /// <remarks>
            /// <para>If you specify this parameter, you must also specify DBNode.N.TargetClass. N represents the index of the node in the request, starting from 1.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pi-*************</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <para>The target specifications of the node. For more information about node specifications, see <a href="https://help.aliyun.com/document_detail/102542.html">compute node specifications</a>.</para>
            /// <remarks>
            /// <para>If you specify this parameter, you must also specify DBNode.N.DBNodeId. N represents the index of the node in the request, starting from 1.</para>
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
        /// <para>The modification type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Upgrade</b>: Upgrades the specifications.</para>
        /// </description></item>
        /// <item><description><para><b>Downgrade</b>: Downgrades the specifications.</para>
        /// </description></item>
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
        /// <para>The latest time to begin the scheduled task. Specify the time in UTC using the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The latest start time must be at least 30 minutes later than the earliest start time.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>PlannedStartTime</c> but not this parameter, the task starts within 30 minutes of the <c>PlannedStartTime</c>. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and leave this parameter empty, the task will start by <c>2021-01-14T09:30:00Z</c>.</para>
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
        /// <para>The planned time for the transient disconnection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedFlashingOffTime")]
        [Validation(Required=false)]
        public string PlannedFlashingOffTime { get; set; }

        /// <summary>
        /// <para>The earliest time to begin the scheduled upgrade of the node specifications. Specify the time in UTC using the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when <c>ModifyType</c> is set to <c>Upgrade</c>.</para>
        /// </description></item>
        /// <item><description><para>The specified time must be within the next 24 hours.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not specified, the upgrade task runs immediately.</para>
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

        /// <summary>
        /// <para>The coupon code. If you do not specify this parameter, a default coupon is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The sub-category of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>normal_exclusive</b>: dedicated specifications</para>
        /// </description></item>
        /// <item><description><para><b>normal_general</b>: general-purpose specifications</para>
        /// </description></item>
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
