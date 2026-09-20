// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the target instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp1u0639js2h7****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The renewal epoch for the target instance.</para>
        /// <list type="bullet">
        /// <item><description>If PricingCycle is set to <b>year</b>, valid values are 1 to 3.</description></item>
        /// <item><description>If PricingCycle is set to <b>month</b>, valid values are 1 to 9.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The unit of the renewal epoch for the target instance.</para>
        /// <list type="bullet">
        /// <item><description><b>year</b>: year.</description></item>
        /// <item><description><b>month</b>: month.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

    }

}
