// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCreditPackagePriceRequest : TeaModel {
        /// <summary>
        /// <para>The number of credits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("CreditAmount")]
        [Validation(Required=false)]
        public int? CreditAmount { get; set; }

        /// <summary>
        /// <para>The number of credit boost packages to purchase. Valid values: 1 to 99.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PackageAmount")]
        [Validation(Required=false)]
        public string PackageAmount { get; set; }

        /// <summary>
        /// <para>The subscription period of the resource. The unit is specified by PeriodUnit. Valid values: 3 months, 6 months, and 1 year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The billing time unit of the subscription Billable methods. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: year</description></item>
        /// <item><description><b>Month</b> (default): month</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the promotion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003308011****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

    }

}
