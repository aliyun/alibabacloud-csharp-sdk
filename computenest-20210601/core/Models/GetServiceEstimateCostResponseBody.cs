// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceEstimateCostResponseBody : TeaModel {
        /// <summary>
        /// <para>Alibaba Cloud Marketplace purchase order information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;cmgj00059839\&quot;: {\&quot;Result\&quot;: {\&quot;InquiryType\&quot;: \&quot;Buy\&quot;, \&quot;Order\&quot;: {\&quot;Currency\&quot;: \&quot;CNY\&quot;, \&quot;DiscountAmount\&quot;: \&quot;0.0\&quot;, \&quot;TradeAmount\&quot;: \&quot;0.01\&quot;, \&quot;OriginalAmount\&quot;: \&quot;0.01\&quot;}}}}</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public Dictionary<string, CommodityValue> Commodity { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08ABBB67-39C9-5EE7-98E5-80486F75CE8D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;EcsInstance&quot; : { &quot;Type&quot; : &quot;ALIYUN::ECS::Instance&quot;, &quot;Success&quot; : true, &quot;Result&quot; : { &quot;Order&quot; : { &quot;Currency&quot; : &quot;CNY&quot;, &quot;RuleIds&quot; : [ &quot;102111101338\<em>\</em>\<em>\</em>&quot; ], &quot;DetailInfos&quot; : { &quot;ResourcePriceModel&quot; : [ { &quot;OriginalPrice&quot; : 0, &quot;DiscountPrice&quot; : 0, &quot;SubRules&quot; : { &quot;Rule&quot; : [ ] }, &quot;Resource&quot; : &quot;bandwidth&quot;, &quot;TradePrice&quot; : 0 }, { &quot;OriginalPrice&quot; : 0, &quot;DiscountPrice&quot; : 0, &quot;SubRules&quot; : { &quot;Rule&quot; : [ ] }, &quot;Resource&quot; : &quot;image&quot;, &quot;TradePrice&quot; : 0 }, { &quot;OriginalPrice&quot; : 0.366666, &quot;DiscountPrice&quot; : 0.249012, &quot;SubRules&quot; : { &quot;Rule&quot; : [ ] }, &quot;Resource&quot; : &quot;instanceType&quot;, &quot;TradePrice&quot; : 0.117654 }, { &quot;OriginalPrice&quot; : 0.055555, &quot;DiscountPrice&quot; : 0.037729, &quot;SubRules&quot; : { &quot;Rule&quot; : [ ] }, &quot;Resource&quot; : &quot;systemDisk&quot;, &quot;TradePrice&quot; : 0.017826 } ] }, &quot;TradeAmount&quot; : 0.135, &quot;OriginalAmount&quot; : 0.422, &quot;Coupons&quot; : { &quot;Coupon&quot; : [ ] }, &quot;DiscountAmount&quot; : 0.287 }, &quot;OrderSupplement&quot; : { &quot;PriceUnit&quot; : &quot;/Hour&quot;, &quot;ChargeType&quot; : &quot;PostPaid&quot;, &quot;Quantity&quot; : 1, &quot;PriceType&quot; : &quot;Total&quot; }, &quot;Rules&quot; : { &quot;Rule&quot; : [ { &quot;RuleDescId&quot; : &quot;102111101338\<em>\</em>\<em>\</em>&quot;, &quot;Name&quot; : &quot;contract discount_multi-billing item discount_3.208750 discount&quot; } ] } } } }</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public Dictionary<string, object> Resources { get; set; }

    }

}
