// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class LogOffAllSessionsInAppInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The delivery group ID.</para>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description>The delivery group must meet the following status requirements:</description></item>
        /// </list>
        /// <ol>
        /// <item><description>ChargeType=PostPaid</description></item>
        /// <item><description>NodePool.StrategyType=NODE_SCALING_BY_SCHEDULE</description></item>
        /// <item><description>Status=PUBLISHED</description></item>
        /// <item><description>The current time is not within the NodePool.RecurrenceSchedules window.</description></item>
        /// </ol>
        /// <list type="bullet">
        /// <item><description>You can call the ListAppInstanceGroup or GetAppInstanceGroup operation to query the current status of the delivery group.</description></item>
        /// <item><description>You can call the CreateAppInstanceGroup operation to create a delivery group that meets the requirements.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aig-9ciijz60n4xsv****</para>
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
