// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// <para>Serialized commodity information based on the specified OrderType. The CommodityType corresponding to each OrderType is as follows:</para>
        /// <para>INSTANCE_BUY: InstanceBuyCommodity
        /// INSTANCE_RENEW: InstanceRenewCommodity
        /// INSTANCE_UPGRADE: InstanceUpgradeCommodity
        /// The parameters in the example are described as follows:</para>
        /// <para>productCode: The product code.
        /// skuCode: The product specification code. For non-image products: prepay for subscription, postpay for pay-as-you-go. For image products: ECS for pay-as-you-go, Package for subscription.
        /// components: Specification modules. The version package_version is required, and other modules depend on the product settings.
        /// duration: Number of cycles, such as 1, 2, 3...
        /// pricingCycle: Cycle unit. Day, Month, or Year.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;components&quot;:{&quot;package_version&quot;:&quot;yuncode12928000016&quot;},&quot;duration&quot;:1,&quot;pricingCycle&quot;:&quot;YEAR&quot;,&quot;productCode&quot;:&quot;cmgj01**28&quot;,&quot;quantity&quot;:1,&quot;skuCode&quot;:&quot;prepay&quot;}</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public string Commodity { get; set; }

        /// <summary>
        /// <para>Order type. Valid values:</para>
        /// <para>INSTANCE_BUY: Product purchase
        /// INSTANCE_RENEW: Instance renewal
        /// INSTANCE_UPGRADE: Instance upgrade
        /// Note: For renewal-type price inquiries, you must pass InstanceId in the Commodity parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE_BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

    }

}
