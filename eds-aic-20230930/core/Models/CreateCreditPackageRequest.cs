// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateCreditPackageRequest : TeaModel {
        /// <summary>
        /// <para>Whether to enable auto-payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables auto-payment. Make sure that your account has a sufficient balance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (Default): Creates an unpaid order.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If your account has an insufficient balance, you can set this parameter to false. This generates an unpaid order. You can then pay for the order in the Wuying Cloud Phone management console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The number of credits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("CreditAmount")]
        [Validation(Required=false)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// <para>The subscription duration. The PeriodUnit parameter specifies the unit for the duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b>: The period is measured in months.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: The period is measured in years.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003308011****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

    }

}
