// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class IncreaseNodesRequest : TeaModel {
        /// <summary>
        /// <para>The application configurations. The number of array elements can range from 1 to 1,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("ApplicationConfigs")]
        [Validation(Required=false)]
        public List<ApplicationConfig> ApplicationConfigs { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically pay for the order. This parameter is effective only when the PaymentType of the node group is Subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Automatically pays for the order.</para>
        /// </description></item>
        /// <item><description><para>false: Does not automatically pay for the order.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPayOrder")]
        [Validation(Required=false)]
        public bool? AutoPayOrder { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the added nodes. The default value is false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para>false: Disables auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The number of nodes to add. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("IncreaseNodeCount")]
        [Validation(Required=false)]
        public int? IncreaseNodeCount { get; set; }

        /// <summary>
        /// <para>The minimum number of nodes to add in this scale-out operation. The value must be between 1 and 500.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter and the available ECS inventory is less than IncreaseNodeCount, the system attempts to create at least the number of nodes specified by MinIncreaseNodeCount. The scale-out flow is then marked as <c>PARTIAL_COMPLETED</c>.</para>
        /// </description></item>
        /// <item><description><para>If you do not set this parameter and the available ECS inventory is less than IncreaseNodeCount, the scale-out flow fails and is marked as <c>FAILED</c>.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("MinIncreaseNodeCount")]
        [Validation(Required=false)]
        public int? MinIncreaseNodeCount { get; set; }

        /// <summary>
        /// <para>The ID of the node group to scale out.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The subscription duration. If PaymentDurationUnit is set to Month, valid values are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public int? PaymentDuration { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month: The unit is month.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PaymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        [NameInMap("Promotions")]
        [Validation(Required=false)]
        public List<Promotion> Promotions { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
