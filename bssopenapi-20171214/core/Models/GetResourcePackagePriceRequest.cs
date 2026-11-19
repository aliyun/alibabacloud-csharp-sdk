// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetResourcePackagePriceRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the resource plan. The value must match the available validity period of the specification size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The effective period of the resource plan. If you do not specify this parameter, the default is immediate.
        /// When the order type is <b>BUY</b>, you cannot query the price of a resource plan whose effective period is more than six months later than the current time.
        /// When the order type is <b>UPGRADE</b>, the effective period must be earlier than or equal to the actual expiration time of the resource plan to be upgraded.
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-10T12:00:00Z</para>
        /// </summary>
        [NameInMap("EffectiveDate")]
        [Validation(Required=false)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// <para>The instance ID. <b>This parameter is required when the order type is renewal or upgrade.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>OSSBAG-cn-0xl0002</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUY: new purchase.</description></item>
        /// <item><description>UPGRADE: upgrade.</description></item>
        /// <item><description>RENEW: renewal.</description></item>
        /// </list>
        /// <para>Default value: BUY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The resource plan type. The value must be the same as the Code value of <b>ResourcePackage</b> returned by the operation that describes resource plans.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FPT_ossbag_periodMonthlyAcc_NetworkOut_finance_common</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The unit of the validity period for the resource plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month: months.</description></item>
        /// <item><description>Year: years.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The product code. You can obtain the product code by calling the <b>QueryProductList</b> operation or referring to the <b>Alibaba Cloud product code quick reference guide</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ossbag</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The specification size of the resource plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

    }

}
