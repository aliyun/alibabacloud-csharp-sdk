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
        /// <item><description>true (default): Uses the coupon.</description></item>
        /// <item><description>false: Does not use the coupon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and is case-sensitive. The value can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f54a343f1a4233c1e7d1c5c******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cloud service provider of the instance.</para>
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
        /// <para>The target specifications for all nodes. For more information, see <a href="https://help.aliyun.com/document_detail/102542.html">Compute node specifications</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar.mysql.x4.large</para>
        /// </summary>
        [NameInMap("DBNodeTargetClass")]
        [Validation(Required=false)]
        public string DBNodeTargetClass { get; set; }

        /// <summary>
        /// <para>The node type. Set the value to DLNode only when you modify the node specifications of an AI node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DLNode</para>
        /// </summary>
        [NameInMap("DBNodeType")]
        [Validation(Required=false)]
        public string DBNodeType { get; set; }

        /// <summary>
        /// <para>The modification type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Upgrade</b>: Upgrades the specifications.</description></item>
        /// <item><description><b>Downgrade</b>: Downgrades the specifications.</description></item>
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
        /// <para>The latest time to start the scheduled task. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The latest time must be at least 30 minutes later than the start time.</description></item>
        /// <item><description>If <c>PlannedStartTime</c> is specified but this parameter is left empty, the latest time to start the task defaults to 30 minutes after the start time. For example, if <c>PlannedStartTime</c> is set to <c>2021-01-14T09:00:00Z</c> and this parameter is left empty, the task starts at <c>2021-01-14T09:30:00Z</c> at the latest.</description></item>
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
        /// <para>The planned transient disconnection time.</para>
        /// <para>The time follows the ISO 8601 standard in the <c>YYYY-MM-DDTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-14T09:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedFlashingOffTime")]
        [Validation(Required=false)]
        public string PlannedFlashingOffTime { get; set; }

        /// <summary>
        /// <para>The earliest time to start the scheduled upgrade or downgrade task within the specified time window. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <c>ModifyType</c> is set to <c>Upgrade</c> or <c>Downgrade</c>.</description></item>
        /// <item><description>The start time must be within the next 24 hours. For example, if the current time is <c>2021-01-14T09:00:00Z</c>, the allowed start time ranges from <c>2021-01-14T09:00:00Z</c> to <c>2021-01-15T09:00:00Z</c>.</description></item>
        /// <item><description>If this parameter is left empty, the upgrade task is executed immediately by default.</description></item>
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
        /// <para>The coupon code. If this parameter is left empty, the default coupon is used.</para>
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
        /// <para>The sub-edition of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>normal_exclusive</b>: Dedicated.</para>
        /// </description></item>
        /// <item><description><para><b>normal_general</b>: General-purpose.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required when you change the specifications between Dedicated and General-purpose.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal_general</para>
        /// </summary>
        [NameInMap("SubCategory")]
        [Validation(Required=false)]
        public string SubCategory { get; set; }

    }

}
