// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class PaymentInfo : TeaModel {
        /// <summary>
        /// <para>The auto-renewal cycle. Unit: month. This parameter is required when <b>isAutoRenew</b> is set to <b>true</b>. The valid values are the same as those on the buy page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("autoRenewDuration")]
        [Validation(Required=false)]
        public long? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>The subscription duration. This parameter is required. You can specify the duration in months or years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false (default): disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isAutoRenew")]
        [Validation(Required=false)]
        public bool? IsAutoRenew { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Year: year</description></item>
        /// <item><description>Month: month.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("pricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

    }

}
