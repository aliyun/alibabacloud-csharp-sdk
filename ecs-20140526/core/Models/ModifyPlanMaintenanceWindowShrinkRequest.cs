// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyPlanMaintenanceWindowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the maintenance window. If this parameter is not specified, the enabled status remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("MinMaintenanceInterval")]
        [Validation(Required=false)]
        public int? MinMaintenanceInterval { get; set; }

        /// <summary>
        /// <para>The ID of the maintenance window to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pw-bp1au1w8v8a1yer65g5k</para>
        /// </summary>
        [NameInMap("PlanWindowId")]
        [Validation(Required=false)]
        public string PlanWindowId { get; set; }

        /// <summary>
        /// <para>The new name of the maintenance window. If this parameter is not specified, the name remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WIndowName</para>
        /// </summary>
        [NameInMap("PlanWindowName")]
        [Validation(Required=false)]
        public string PlanWindowName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located. You can call the DescribeRegions operation to query the most recent list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The maintenance action for the maintenance window. If this parameter is not specified, the action remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reboot</para>
        /// </summary>
        [NameInMap("SupportMaintenanceAction")]
        [Validation(Required=false)]
        public string SupportMaintenanceAction { get; set; }

        /// <summary>
        /// <para>The resources to which the maintenance window applies. If this parameter is not specified, the target resources remain unchanged.</para>
        /// </summary>
        [NameInMap("TargetResource")]
        [Validation(Required=false)]
        public string TargetResourceShrink { get; set; }

        /// <summary>
        /// <para>The recurrence schedule for the maintenance window. If this parameter is not specified, the schedule remains unchanged.</para>
        /// </summary>
        [NameInMap("TimePeriod")]
        [Validation(Required=false)]
        public string TimePeriodShrink { get; set; }

    }

}
