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
            /// Examples for the China site (aliyun.com):
            /// 
            /// *   **ga_gapluspre_public_cn**: GA instance.
            /// *   **ga_plusbwppre_public_cn**: basic bandwidth plan.
            /// 
            /// Examples for the international site (alibabacloud.com):
            /// 
            /// *   **ga_pluspre_public_intl**: GA instance.
            /// *   **ga_bwppreintl_public_intl**: basic bandwidth plan.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The information about the commodity module.
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
                /// The attributes of the commodity module.
                /// 
                /// The information varies based on the commodity module.
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<DescribeCommodityPriceRequestOrdersComponentsProperties> Properties { get; set; }
                public class DescribeCommodityPriceRequestOrdersComponentsProperties : TeaModel {
                    /// <summary>
                    /// The code of the attribute.
                    /// 
                    /// The information varies based on the commodity module. Examples: **instance** (GA instance) and **ord_time** (subscription duration).
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// The value of the attribute.
                    /// 
                    /// The information varies based on the commodity module. Examples: **1:Month** (one-month subscription) and **instance_fee** (GA instance fee).
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The subscription duration of the instance.
            /// 
            /// *   If the **PricingCycle** parameter is set to **Month**, the valid values of the Duration parameter are **1** to **9**.
            /// *   If the **PricingCycle** parameter is set to **Year**, the valid values of the Duration parameter are **1** to **3**.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// The type of order. Valid values:
            /// 
            /// *   **BUY**: purchase order
            /// *   **RENEW**: renewal order
            /// *   **UPGRADE**: upgrade order
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// The billing cycle of the GA instance. Valid values:
            /// 
            /// *   **Month**: billed on a monthly basis.
            /// *   **Year**: billed on an annual basis.
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
