// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetResourcePackagePriceRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the resource plan. The value must be the same as the duration of the resource plan specified in the specifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The time when the resource plan takes effect. If you do not specify this parameter, the resource plan immediately takes effect by default. 
        /// When the <b>OrderType</b> is <b>BUY</b>, resource packs with the <b>EffectiveDate longer than the current time of 6 months</b> are not supported. 
        /// If the <b>OrderType</b> is <b>UPGRADE</b>, the <b>EffectiveDate</b> <b>must be less than or equal to</b> the actual expiration time of the upgraded instance.
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-10T12:00:00Z</para>
        /// </summary>
        [NameInMap("EffectiveDate")]
        [Validation(Required=false)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// <para>The ID of the instance. <b>This parameter is required when the order type is renewal or upgrade.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>OSSBAG-cn-0xl0002</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUY: You place the order to purchase an instance.</description></item>
        /// <item><description>UPGRADE: You place the order to upgrade an instance.</description></item>
        /// <item><description>RENEW: You place the order to renew an instance.</description></item>
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
        /// <para>The type of the resource plan. The value must be the same as the value of the <b>ProductCode</b> parameter that is returned when you call the <b>DescribeResourcePackageProduct</b> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FPT_ossbag_periodMonthlyAcc_NetworkOut_finance_common</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The unit of validity period of the resource plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The code of service. You can query the service code by calling the <b>QueryProductList</b> operation or viewing <b>Codes of Alibaba Cloud Services</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ossbag</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The specifications of the resource plan.</para>
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
