// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CommodityValue : TeaModel {
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CommodityValueResult Result { get; set; }
        public class CommodityValueResult : TeaModel {
            [NameInMap("Order")]
            [Validation(Required=false)]
            public CommodityValueResultOrder Order { get; set; }
            public class CommodityValueResultOrder : TeaModel {
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                [NameInMap("TradeAmount")]
                [Validation(Required=false)]
                public string TradeAmount { get; set; }

                [NameInMap("DiscountAmount")]
                [Validation(Required=false)]
                public string DiscountAmount { get; set; }

                [NameInMap("OriginalAmount")]
                [Validation(Required=false)]
                public string OriginalAmount { get; set; }

            }

            [NameInMap("InquiryType")]
            [Validation(Required=false)]
            public string InquiryType { get; set; }

            [NameInMap("SubOrders")]
            [Validation(Required=false)]
            public CommodityValueResultSubOrders SubOrders { get; set; }
            public class CommodityValueResultSubOrders : TeaModel {
                [NameInMap("SubOrder")]
                [Validation(Required=false)]
                public List<CommodityValueResultSubOrdersSubOrder> SubOrder { get; set; }
                public class CommodityValueResultSubOrdersSubOrder : TeaModel {
                    [NameInMap("ModuleInstance")]
                    [Validation(Required=false)]
                    public List<CommodityValueResultSubOrdersSubOrderModuleInstance> ModuleInstance { get; set; }
                    public class CommodityValueResultSubOrdersSubOrderModuleInstance : TeaModel {
                        [NameInMap("ModuleId")]
                        [Validation(Required=false)]
                        public long? ModuleId { get; set; }

                        [NameInMap("ModuleName")]
                        [Validation(Required=false)]
                        public string ModuleName { get; set; }

                        [NameInMap("ModuleCode")]
                        [Validation(Required=false)]
                        public string ModuleCode { get; set; }

                        [NameInMap("TotalProductFee")]
                        [Validation(Required=false)]
                        public double? TotalProductFee { get; set; }

                        [NameInMap("DiscountFee")]
                        [Validation(Required=false)]
                        public double? DiscountFee { get; set; }

                        [NameInMap("PayFee")]
                        [Validation(Required=false)]
                        public double? PayFee { get; set; }

                        [NameInMap("PriceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

                        [NameInMap("IsPricingModule")]
                        [Validation(Required=false)]
                        public bool? IsPricingModule { get; set; }

                        [NameInMap("NeedOrderPay")]
                        [Validation(Required=false)]
                        public bool? NeedOrderPay { get; set; }

                        [NameInMap("PriceType")]
                        [Validation(Required=false)]
                        public string PriceType { get; set; }

                        [NameInMap("ModuleAttrs")]
                        [Validation(Required=false)]
                        public List<CommodityValueResultSubOrdersSubOrderModuleInstanceModuleAttrs> ModuleAttrs { get; set; }
                        public class CommodityValueResultSubOrdersSubOrderModuleInstanceModuleAttrs : TeaModel {
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public long? Type { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public string Code { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                            [NameInMap("Unit")]
                            [Validation(Required=false)]
                            public string Unit { get; set; }

                        }

                    }

                }

            }

            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public List<CommodityValueResultCoupons> Coupons { get; set; }
            public class CommodityValueResultCoupons : TeaModel {
                [NameInMap("CanPromFee")]
                [Validation(Required=false)]
                public double? CanPromFee { get; set; }

                [NameInMap("CouponDesc")]
                [Validation(Required=false)]
                public string CouponDesc { get; set; }

                [NameInMap("CouponName")]
                [Validation(Required=false)]
                public string CouponName { get; set; }

                [NameInMap("CouponOptionNo")]
                [Validation(Required=false)]
                public string CouponOptionNo { get; set; }

                [NameInMap("Selected")]
                [Validation(Required=false)]
                public bool? Selected { get; set; }

            }

        }

    }

}
