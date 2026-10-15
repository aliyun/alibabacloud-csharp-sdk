// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class PriceInfo : TeaModel {
        /// <summary>
        /// <para>The pricing currency.</para>
        /// </summary>
        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The discount amount.</para>
        /// </summary>
        [NameInMap("discountAmount")]
        [Validation(Required=false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// <para>The list of optional promotions.</para>
        /// </summary>
        [NameInMap("optionalPromotions")]
        [Validation(Required=false)]
        public List<PromotionInfo> OptionalPromotions { get; set; }

        /// <summary>
        /// <para>The original amount.</para>
        /// </summary>
        [NameInMap("originalAmount")]
        [Validation(Required=false)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// <para>The pricing details by module.</para>
        /// </summary>
        [NameInMap("priceModules")]
        [Validation(Required=false)]
        public List<PriceInfoPriceModules> PriceModules { get; set; }
        public class PriceInfoPriceModules : TeaModel {
            /// <summary>
            /// <para>The original amount of the module.</para>
            /// </summary>
            [NameInMap("originalAmount")]
            [Validation(Required=false)]
            public string OriginalAmount { get; set; }

            /// <summary>
            /// <para>The type of the pricing module.</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The list of discount rules.</para>
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<PriceInfoRules> Rules { get; set; }
        public class PriceInfoRules : TeaModel {
            /// <summary>
            /// <para>The discount amount of the rule.</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <para>The name of the discount rule.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the discount rule.</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

        /// <summary>
        /// <para>The tax amount.</para>
        /// </summary>
        [NameInMap("taxAmount")]
        [Validation(Required=false)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// <para>The final transaction amount.</para>
        /// </summary>
        [NameInMap("tradeAmount")]
        [Validation(Required=false)]
        public string TradeAmount { get; set; }

    }

}
