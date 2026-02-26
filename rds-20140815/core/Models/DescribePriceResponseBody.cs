// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The order parameters.</para>
        /// <remarks>
        /// <para> If the <b>OrderParamOut</b> parameter is set to <b>true</b>, the value of the OrderParams parameter is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;autoPay\&quot;:false}&quot;</para>
        /// </summary>
        [NameInMap("OrderParams")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        /// <summary>
        /// <para>The price information.</para>
        /// </summary>
        [NameInMap("PriceInfo")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPriceInfo PriceInfo { get; set; }
        public class DescribePriceResponseBodyPriceInfo : TeaModel {
            /// <summary>
            /// <para>The information about the promotion.</para>
            /// </summary>
            [NameInMap("ActivityInfo")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoActivityInfo ActivityInfo { get; set; }
            public class DescribePriceResponseBodyPriceInfoActivityInfo : TeaModel {
                /// <summary>
                /// <para>The returned message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Error description</para>
                /// </summary>
                [NameInMap("CheckErrMsg")]
                [Validation(Required=false)]
                public string CheckErrMsg { get; set; }

                /// <summary>
                /// <para>The error code that is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the request was successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public string Success { get; set; }

            }

            [NameInMap("Coupons")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoCoupons Coupons { get; set; }
            public class DescribePriceResponseBodyPriceInfoCoupons : TeaModel {
                [NameInMap("Coupon")]
                [Validation(Required=false)]
                public List<DescribePriceResponseBodyPriceInfoCouponsCoupon> Coupon { get; set; }
                public class DescribePriceResponseBodyPriceInfoCouponsCoupon : TeaModel {
                    [NameInMap("CouponNo")]
                    [Validation(Required=false)]
                    public string CouponNo { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("IsSelected")]
                    [Validation(Required=false)]
                    public string IsSelected { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The currency unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DiscountPrice")]
            [Validation(Required=false)]
            public float? DiscountPrice { get; set; }

            /// <summary>
            /// <para>The order information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Order Information</para>
            /// </summary>
            [NameInMap("OrderLines")]
            [Validation(Required=false)]
            public object OrderLines { get; set; }

            /// <summary>
            /// <para>The original price.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2504</para>
            /// </summary>
            [NameInMap("OriginalPrice")]
            [Validation(Required=false)]
            public float? OriginalPrice { get; set; }

            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public DescribePriceResponseBodyPriceInfoRuleIds RuleIds { get; set; }
            public class DescribePriceResponseBodyPriceInfoRuleIds : TeaModel {
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public List<string> RuleId { get; set; }

            }

            /// <summary>
            /// <para>The estimated hourly cost that is calculated based on the maximum number of RCUs you specify.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**</para>
            /// </summary>
            [NameInMap("TradeMaxRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMaxRCUAmount { get; set; }

            /// <summary>
            /// <para>The estimated hourly cost that is calculated based on the minimum number of RCUs you specify.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2**</para>
            /// </summary>
            [NameInMap("TradeMinRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMinRCUAmount { get; set; }

            /// <summary>
            /// <para>The transaction price, which is equal to the original price minus the discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2504</para>
            /// </summary>
            [NameInMap("TradePrice")]
            [Validation(Required=false)]
            public float? TradePrice { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA0ADDDC-0BEB-4381-A3ED-73B4C79B8CC6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyRules Rules { get; set; }
        public class DescribePriceResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyRulesRule> Rule { get; set; }
            public class DescribePriceResponseBodyRulesRule : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

            }

        }

        /// <summary>
        /// <para>The pricing information about a serverless RDS instance.</para>
        /// </summary>
        [NameInMap("ServerlessPrice")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyServerlessPrice ServerlessPrice { get; set; }
        public class DescribePriceResponseBodyServerlessPrice : TeaModel {
            /// <summary>
            /// <para>The discount amount of the maximum number of RCUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**.*</para>
            /// </summary>
            [NameInMap("RCUDiscountMaxAmount")]
            [Validation(Required=false)]
            public float? RCUDiscountMaxAmount { get; set; }

            /// <summary>
            /// <para>The discount amount of the minimum number of RCUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1*.*</para>
            /// </summary>
            [NameInMap("RCUDiscountMinAmount")]
            [Validation(Required=false)]
            public float? RCUDiscountMinAmount { get; set; }

            /// <summary>
            /// <para>The price of the maximum number of RCUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2**.*</para>
            /// </summary>
            [NameInMap("RCUOriginalMaxAmount")]
            [Validation(Required=false)]
            public float? RCUOriginalMaxAmount { get; set; }

            /// <summary>
            /// <para>The price of the minimum number of RCUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3*.*</para>
            /// </summary>
            [NameInMap("RCUOriginalMinAmount")]
            [Validation(Required=false)]
            public float? RCUOriginalMinAmount { get; set; }

            /// <summary>
            /// <para>The original price of the disk capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1*</para>
            /// </summary>
            [NameInMap("StorageOriginalAmount")]
            [Validation(Required=false)]
            public float? StorageOriginalAmount { get; set; }

            /// <summary>
            /// <para>The maximum total price before the discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2**.*</para>
            /// </summary>
            [NameInMap("TotalOriginalMaxAmount")]
            [Validation(Required=false)]
            public float? TotalOriginalMaxAmount { get; set; }

            /// <summary>
            /// <para>The minimum total price before the discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2*.*</para>
            /// </summary>
            [NameInMap("TotalOriginalMinAmount")]
            [Validation(Required=false)]
            public float? TotalOriginalMinAmount { get; set; }

            /// <summary>
            /// <para>The transaction price of the maximum number of RCUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**.*</para>
            /// </summary>
            [NameInMap("TradeMaxRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMaxRCUAmount { get; set; }

            /// <summary>
            /// <para>The transaction price of the minimum number of RCUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2*.*</para>
            /// </summary>
            [NameInMap("TradeMinRCUAmount")]
            [Validation(Required=false)]
            public float? TradeMinRCUAmount { get; set; }

            /// <summary>
            /// <para>The discounted price of the disk capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.*</para>
            /// </summary>
            [NameInMap("storageDiscountAmount")]
            [Validation(Required=false)]
            public float? StorageDiscountAmount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether discounts can be used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("ShowDiscount")]
        [Validation(Required=false)]
        public bool? ShowDiscount { get; set; }

        /// <summary>
        /// <para>The estimated hourly fee that is calculated based on the maximum number of RCUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2**</para>
        /// </summary>
        [NameInMap("TradeMaxRCUAmount")]
        [Validation(Required=false)]
        public float? TradeMaxRCUAmount { get; set; }

        /// <summary>
        /// <para>The estimated hourly fee that is calculated based on the minimum number of RCUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1**</para>
        /// </summary>
        [NameInMap("TradeMinRCUAmount")]
        [Validation(Required=false)]
        public float? TradeMinRCUAmount { get; set; }

    }

}
