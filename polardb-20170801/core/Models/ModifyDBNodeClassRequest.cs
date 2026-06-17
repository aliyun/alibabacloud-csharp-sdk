// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBNodeClassRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c> (default): A coupon is automatically applied.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: A coupon is not applied.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of the request. The token must be unique across requests. It is case-sensitive and can be up to 64 ASCII characters long.</para>
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
        /// <para>The target node specifications for all nodes in the cluster. For more information, see <a href="https://help.aliyun.com/document_detail/102542.html">compute node specifications</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar.mysql.x4.large</para>
        /// </summary>
        [NameInMap("DBNodeTargetClass")]
        [Validation(Required=false)]
        public string DBNodeTargetClass { get; set; }

        /// <summary>
        /// <para>To modify the specifications of an AI node, you must set this parameter to <c>DLNode</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DLNode</para>
        /// </summary>
        [NameInMap("DBNodeType")]
        [Validation(Required=false)]
        public string DBNodeType { get; set; }

        /// <summary>
        /// <para>The modification type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Upgrade</b>: Upgrades the node specifications.</para>
        /// </description></item>
        /// <item><description><para><b>Downgrade</b>: Downgrades the node specifications.</para>
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
        /// <para>The latest time to start the scheduled task. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The latest start time must be at least 30 minutes later than the earliest start time.</para>
        /// </description></item>
        /// <item><description><para>If you specify <c>PlannedStartTime</c> but omit this parameter, the latest start time defaults to <c>PlannedStartTime + 30 minutes</c>. For example, if you set <c>PlannedStartTime</c> to <c>2021-01-14T09:00:00Z</c> and leave this parameter empty, the task starts no later than <c>2021-01-14T09:30:00Z</c>.</para>
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
        /// <para>The planned time for a transient disconnection. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedFlashingOffTime")]
        [Validation(Required=false)]
        public string PlannedFlashingOffTime { get; set; }

        /// <summary>
        /// <para>The earliest time to start the scheduled upgrade or downgrade task. Specify the time in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is valid only when <c>ModifyType</c> is set to <c>Upgrade</c> or <c>Downgrade</c>.</para>
        /// </description></item>
        /// <item><description><para>The start time must be within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, you can set the start time to a value in the range from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</para>
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

        /// <summary>
        /// <para>The coupon code. If you omit this parameter, the system applies the default coupon.</para>
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
        /// <para>The subcategory of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>normal_exclusive</b>: dedicated specifications</para>
        /// </description></item>
        /// <item><description><para><b>normal_general</b>: general-purpose specifications</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required when switching between dedicated and general-purpose specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal_general</para>
        /// </summary>
        [NameInMap("SubCategory")]
        [Validation(Required=false)]
        public string SubCategory { get; set; }

    }

}
