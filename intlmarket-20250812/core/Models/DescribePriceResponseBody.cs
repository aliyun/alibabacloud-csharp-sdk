// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntlMarket20250812.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Coupons")]
        [Validation(Required=false)]
        public List<DescribePriceResponseBodyCoupons> Coupons { get; set; }
        public class DescribePriceResponseBodyCoupons : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CanPromFee</para>
            /// </summary>
            [NameInMap("CanPromFee")]
            [Validation(Required=false)]
            public long? CanPromFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CouponName</para>
            /// </summary>
            [NameInMap("CouponName")]
            [Validation(Required=false)]
            public string CouponName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CouponOptionCode</para>
            /// </summary>
            [NameInMap("CouponOptionCode")]
            [Validation(Required=false)]
            public string CouponOptionCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CouponOptionNo</para>
            /// </summary>
            [NameInMap("CouponOptionNo")]
            [Validation(Required=false)]
            public string CouponOptionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IsSelected</para>
            /// </summary>
            [NameInMap("IsSelected")]
            [Validation(Required=false)]
            public bool? IsSelected { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PromotionDesc</para>
            /// </summary>
            [NameInMap("PromotionDesc")]
            [Validation(Required=false)]
            public string PromotionDesc { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("Cuxiao")]
        [Validation(Required=false)]
        public bool? Cuxiao { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>once</para>
        /// </summary>
        [NameInMap("Cycle")]
        [Validation(Required=false)]
        public string Cycle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("DiscountPrice")]
        [Validation(Required=false)]
        public float? DiscountPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NO_AVAILABLE_PAYMENT_METHOD</para>
        /// </summary>
        [NameInMap("ExpressionCode")]
        [Validation(Required=false)]
        public string ExpressionCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ExpressionMessage</para>
        /// </summary>
        [NameInMap("ExpressionMessage")]
        [Validation(Required=false)]
        public string ExpressionMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>139.41</para>
        /// </summary>
        [NameInMap("InfoTitle")]
        [Validation(Required=false)]
        public string InfoTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2099.0</para>
        /// </summary>
        [NameInMap("OriginalPrice")]
        [Validation(Required=false)]
        public float? OriginalPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>csas</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("PromotionRules")]
        [Validation(Required=false)]
        public List<DescribePriceResponseBodyPromotionRules> PromotionRules { get; set; }
        public class DescribePriceResponseBodyPromotionRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>alb-xdnghlhvm9vvo1sk54_Accelerator</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1827975</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>054AF571-C86F-533F-8A7B-F62206FA4367</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1320.0</para>
        /// </summary>
        [NameInMap("TradePrice")]
        [Validation(Required=false)]
        public float? TradePrice { get; set; }

    }

}
