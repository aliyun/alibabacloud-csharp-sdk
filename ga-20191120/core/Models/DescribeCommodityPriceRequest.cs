// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityPriceRequest : TeaModel {
        /// <summary>
        /// <para>The commodity orders.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Orders")]
        [Validation(Required=false)]
        public List<DescribeCommodityPriceRequestOrders> Orders { get; set; }
        public class DescribeCommodityPriceRequestOrders : TeaModel {
            /// <summary>
            /// <para>The billing method. Set the value to <b>PREPAY</b>, which specifies the subscription billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// <para>Valid values on the China site (aliyun.com):</para>
            /// <list type="bullet">
            /// <item><description><b>ga_gapluspre_public_cn</b>: GA instance.</description></item>
            /// <item><description><b>ga_plusbwppre_public_cn</b>: basic bandwidth plan.</description></item>
            /// </list>
            /// <para>Valid values on the international site (alibabacloud.com):</para>
            /// <list type="bullet">
            /// <item><description><b>ga_pluspre_public_intl</b>: GA instance.</description></item>
            /// <item><description><b>ga_bwppreintl_public_intl:</b> basic bandwidth plan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ga_gapluspre_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The information about commodity modules.</para>
            /// <para>The information varies based on the commodity module.</para>
            /// </summary>
            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<DescribeCommodityPriceRequestOrdersComponents> Components { get; set; }
            public class DescribeCommodityPriceRequestOrdersComponents : TeaModel {
                /// <summary>
                /// <para>The code of the commodity module.</para>
                /// <para>The information varies based on the commodity module. Examples: <b>instance</b> (GA instance) and <b>ord_time</b> (subscription duration).</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
                [NameInMap("ComponentCode")]
                [Validation(Required=false)]
                public string ComponentCode { get; set; }

                /// <summary>
                /// <para>The attributes of commodity modules.</para>
                /// <para>The information varies based on the commodity module.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<DescribeCommodityPriceRequestOrdersComponentsProperties> Properties { get; set; }
                public class DescribeCommodityPriceRequestOrdersComponentsProperties : TeaModel {
                    /// <summary>
                    /// <para>The code of the attribute of the commodity module.</para>
                    /// <para>The information varies based on the commodity module. Examples: <b>instance</b> (GA instance) and <b>ord_time</b> (subscription duration).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>instance</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The value of the attribute.</para>
                    /// <para>The information varies based on the commodity module. Examples: <b>instance_fee</b> (GA instance fee) and <b>1:Month</b> (one-month subscription).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>instance_fee</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The subscription duration.</para>
            /// <list type="bullet">
            /// <item><description>Valid values if you set <b>PricingCycle</b> to <b>Month</b>: <b>1</b> to <b>9</b>.</description></item>
            /// <item><description>Valid values if you set <b>PricingCycle</b> to <b>Year</b>: <b>1</b> to <b>3</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The type of the order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BUY</b>: purchase order.</description></item>
            /// <item><description><b>RENEW</b>: renewal order.</description></item>
            /// <item><description><b>UPGRADE</b>: upgrade order.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The billing cycle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Month</b></description></item>
            /// <item><description><b>Year</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

            /// <summary>
            /// <para>The number of instances that you want to purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

        }

        /// <summary>
        /// <para>The coupon code.</para>
        /// <remarks>
        /// <para> This parameter is unavailable on the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50003298014****</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
