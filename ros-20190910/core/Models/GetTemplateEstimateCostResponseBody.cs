// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateEstimateCostResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6DEA36EF-C97D-5658-A4AC-4F5DB08D1A89</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;NewEip&quot;: {
        ///     &quot;Type&quot;: &quot;ALIYUN::VPC::EIP&quot;,
        ///     &quot;Success&quot;: true,
        ///     &quot;Result&quot;: {
        ///       &quot;Order&quot;: {
        ///         &quot;TaxAmount&quot;: 0.0,
        ///         &quot;Currency&quot;: &quot;CNY&quot;,
        ///         &quot;RuleIds&quot;: [
        ///           &quot;102204102264****&quot;
        ///         ],
        ///         &quot;TradeAmount&quot;: 87.5,
        ///         &quot;OriginalAmount&quot;: 125.0,
        ///         &quot;DiscountAmount&quot;: 37.5
        ///       },
        ///       &quot;OrderSupplement&quot;: {
        ///         &quot;ChargeType&quot;: &quot;PrePaid&quot;,
        ///         &quot;Period&quot;: 1,
        ///         &quot;Quantity&quot;: 1,
        ///         &quot;PriceType&quot;: &quot;Total&quot;,
        ///         &quot;PeriodUnit&quot;: &quot;Month&quot;
        ///       },
        ///       &quot;InquiryType&quot;: &quot;Buy&quot;,
        ///       &quot;Rules&quot;: {
        ///         &quot;Rule&quot;: [
        ///           {
        ///             &quot;RuleDescId&quot;: &quot;102204102264****&quot;,
        ///             &quot;Name&quot;: &quot;Contract_Discount_Full_Order_30%_Off&quot;
        ///           }
        ///         ]
        ///       }
        ///     }
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public Dictionary<string, object> Resources { get; set; }

    }

}
