// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeRatePlanPriceGapRequest : TeaModel {
        /// <summary>
        /// <para>The target plan name. You can obtain this value from the <a href="~~DescribeRatePlanPrice~~">DescribeRatePlanPrice</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>entranceplan</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The specification change type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DOWNGRADE: downgrade.</description></item>
        /// <item><description>UPGRADE: upgrade.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The specification change type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DOWNGRADE: downgrade.</description></item>
        /// <item><description>UPGRADE: upgrade.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
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
