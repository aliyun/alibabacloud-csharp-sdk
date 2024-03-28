// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityPriceRequest : TeaModel {
        /// <summary>
        /// The commodity orders.
        /// </summary>
        [NameInMap("Orders")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceRequestOrders> Orders { get; set; }
        public class DescribeCommodityPriceRequestOrders : TeaModel {
            /// <summary>
            /// The billing method. Set the value to **PREPAY**, which specifies the subscription billing method.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The commodity code.
            /// 
            /// Valid values on the China site (aliyun.com):
            /// 
            /// *   **ga_gapluspre_public_cn**: GA instance.
            /// *   **ga_plusbwppre_public_cn**: basic bandwidth plan.
            /// 
            /// Valid values on the international site (alibabacloud.com):
            /// 
            /// *   **ga_pluspre_public_intl**: GA instance.
            /// *   **ga_bwppreintl_public_intl:** basic bandwidth plan.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The information about commodity modules.
            /// 
            /// The information varies based on the commodity module.
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<DescribeCommodityPriceRequestOrdersComponents> Components { get; set; }
            public class DescribeCommodityPriceRequestOrdersComponents : TeaModel {
                /// <summary>
                /// The code of the commodity module.
                /// 
                /// The information varies based on the commodity module. Examples: **instance** (GA instance) and **ord_time** (subscription duration).
                /// </summary>
                [NameInMap("ComponentCode")]
                [Validation(Required=false)]
                public string ComponentCode { get; set; }

                /// <summary>
                /// The attributes of commodity modules.
                /// 
                /// The information varies based on the commodity module.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<DescribeCommodityPriceRequestOrdersComponentsProperties> Properties { get; set; }
                public class DescribeCommodityPriceRequestOrdersComponentsProperties : TeaModel {
                    /// <summary>
                    /// The code of the attribute of the commodity module.
                    /// 
                    /// The information varies based on the commodity module. Examples: **instance** (GA instance) and **ord_time** (subscription duration).
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// The value of the attribute.
                    /// 
                    /// The information varies based on the commodity module. Examples: **instance_fee** (GA instance fee) and **1:Month** (one-month subscription).
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The subscription duration.
            /// 
            /// *   Valid values if you set **PricingCycle** to **Month**: **1** to **9**.
            /// *   Valid values if you set **PricingCycle** to **Year**: **1** to **3**.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// The type of the order. Valid values:
            /// 
            /// *   **BUY**: purchase order.
            /// *   **RENEW**: renewal order.
            /// *   **UPGRADE**: upgrade order.
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// The billing cycle. Valid values:
            /// 
            /// *   **Month**
            /// *   **Year**
            /// </summary>
            [NameInMap("PricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

            /// <summary>
            /// The number of instances that you want to purchase.
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

        }

        /// <summary>
        /// The coupon code.
        /// 
        /// >  This parameter is unavailable on the China site (aliyun.com).
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
