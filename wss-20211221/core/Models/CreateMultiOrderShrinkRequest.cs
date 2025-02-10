// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class CreateMultiOrderShrinkRequest : TeaModel {
        [NameInMap("OrderItems")]
        [Validation(Required=false)]
        public List<CreateMultiOrderShrinkRequestOrderItems> OrderItems { get; set; }
        public class CreateMultiOrderShrinkRequestOrderItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<CreateMultiOrderShrinkRequestOrderItemsComponents> Components { get; set; }
            public class CreateMultiOrderShrinkRequestOrderItemsComponents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>RegionId</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Year</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>youhuiquan_promotion_option_id_for_blank</para>
            /// </summary>
            [NameInMap("PromotionId")]
            [Validation(Required=false)]
            public string PromotionId { get; set; }

            [NameInMap("ResourceIds")]
            [Validation(Required=false)]
            public List<string> ResourceIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DurationPackage</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>create</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string PropertiesShrink { get; set; }

    }

}
