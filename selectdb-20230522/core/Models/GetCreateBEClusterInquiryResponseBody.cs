// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class GetCreateBEClusterInquiryResponseBody : TeaModel {
        /// <summary>
        /// <para>The information returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCreateBEClusterInquiryResponseBodyData Data { get; set; }
        public class GetCreateBEClusterInquiryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The currency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("OptionalPromotions")]
            [Validation(Required=false)]
            public List<GetCreateBEClusterInquiryResponseBodyDataOptionalPromotions> OptionalPromotions { get; set; }
            public class GetCreateBEClusterInquiryResponseBodyDataOptionalPromotions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CanPromFee")]
                [Validation(Required=false)]
                public string CanPromFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7afs9d</para>
                /// </summary>
                [NameInMap("OptionCode")]
                [Validation(Required=false)]
                public string OptionCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>通用优惠券可抵扣100</para>
                /// </summary>
                [NameInMap("PromotionDesc")]
                [Validation(Required=false)]
                public string PromotionDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>通用优惠券</para>
                /// </summary>
                [NameInMap("PromotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>775735400028</para>
                /// </summary>
                [NameInMap("PromotionOptionNo")]
                [Validation(Required=false)]
                public string PromotionOptionNo { get; set; }

            }

            [NameInMap("PricingRules")]
            [Validation(Required=false)]
            public Dictionary<string, string> PricingRules { get; set; }

            /// <summary>
            /// <para>The amount of money.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.76</para>
            /// </summary>
            [NameInMap("TradeAmount")]
            [Validation(Required=false)]
            public string TradeAmount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06758CAB-1204-5852-A471-29C87D5C1D0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
