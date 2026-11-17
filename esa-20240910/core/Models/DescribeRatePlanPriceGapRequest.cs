// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeRatePlanPriceGapRequest : TeaModel {
        /// <summary>
        /// <para>The name of the target plan. You can obtain it by calling the <a href="~~DescribeRatePlanPrice~~">DescribeRatePlanPrice</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entranceplan</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DOWNGRADE: Downgrade.</description></item>
        /// <item><description>UPGRADE: Upgrade.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The code of the target plan for the specification change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standardplan</para>
        /// </summary>
        [NameInMap("TargetPlanCode")]
        [Validation(Required=false)]
        public string TargetPlanCode { get; set; }

        /// <summary>
        /// <para>The name of the target plan for the specification change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entranceplan</para>
        /// </summary>
        [NameInMap("TargetPlanName")]
        [Validation(Required=false)]
        public string TargetPlanName { get; set; }

    }

}
