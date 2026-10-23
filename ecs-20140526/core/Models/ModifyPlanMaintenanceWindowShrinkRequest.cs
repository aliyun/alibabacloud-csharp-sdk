// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyPlanMaintenanceWindowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable or disable the window. Leave this parameter empty if no modification is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The minimum time interval between the publish time and the scheduled time to execute scheduled O&amp;M events for the same instance. Valid values: 1 to 48. Unit: hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("MinMaintenanceInterval")]
        [Validation(Required=false)]
        public int? MinMaintenanceInterval { get; set; }

        /// <summary>
        /// <para>The ID of the O&amp;M window to be modified. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pw-bp1au1w8v8a1yer65g5k</para>
        /// </summary>
        [NameInMap("PlanWindowId")]
        [Validation(Required=false)]
        public string PlanWindowId { get; set; }

        /// <summary>
        /// <para>The name of the O&amp;M window. Leave this parameter empty if no modification is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WIndowName</para>
        /// </summary>
        [NameInMap("PlanWindowName")]
        [Validation(Required=false)]
        public string PlanWindowName { get; set; }

        /// <summary>
        /// <para>The region ID. This parameter is required for Alibaba Cloud SDK routing. However, specifying any region ID for this operation makes no difference. The O&amp;M window applies to all ECS instances across the network that meet the resource filtering conditions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The supported O&amp;M actions. Leave this parameter empty if no modification is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reboot</para>
        /// </summary>
        [NameInMap("SupportMaintenanceAction")]
        [Validation(Required=false)]
        public string SupportMaintenanceAction { get; set; }

        /// <summary>
        /// <para>The resources to which the O&amp;M window applies. Leave this parameter empty if no modification is required.</para>
        /// </summary>
        [NameInMap("TargetResource")]
        [Validation(Required=false)]
        public string TargetResourceShrink { get; set; }

        /// <summary>
        /// <para>The recurrence cycle of the window. Leave this parameter empty if no modification is required.</para>
        /// </summary>
        [NameInMap("TimePeriod")]
        [Validation(Required=false)]
        public string TimePeriodShrink { get; set; }

    }

}
