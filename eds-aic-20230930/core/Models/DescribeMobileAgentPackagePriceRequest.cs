// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeMobileAgentPackagePriceRequest : TeaModel {
        /// <summary>
        /// <para>The number of MobileAgent packages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>The region ID for the purchase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

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
        /// <para>The specifications of the MobileAgent package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>advanced</para>
        /// </summary>
        [NameInMap("MobileAgentPackageSpec")]
        [Validation(Required=false)]
        public string MobileAgentPackageSpec { get; set; }

        /// <summary>
        /// <para>The subscription duration of the purchased resource. The unit is specified by PeriodUnit. Valid value: 1 month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The duration unit of the subscription billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: Year.</description></item>
        /// <item><description><b>Month</b> (default): Month.</description></item>
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
