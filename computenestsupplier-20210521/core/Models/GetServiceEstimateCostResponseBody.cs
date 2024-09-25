// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceEstimateCostResponseBody : TeaModel {
        /// <summary>
        /// <para>The subscription duration information about the purchase order of Alibaba Cloud Marketplace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;PayPeriodUnit\&quot;:Month,\&quot;PayPeriod\&quot;:1}</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public Dictionary<string, object> Commodity { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E73F09DC-6C13-5CB1-A10F-7A4E125ABD2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;ECSInstances&quot;:{
        ///         &quot;Type&quot;:&quot;ALIYUN::ECS::InstanceGroup&quot;,
        ///         &quot;Success&quot;:true,
        ///         &quot;Result&quot;:{
        ///           &quot;Order&quot;:{
        ///             &quot;Currency&quot;:&quot;CNY&quot;,
        ///             &quot;RuleIds&quot;:[
        ///               1752723
        ///             ],
        ///             &quot;DetailInfos&quot;:{
        ///               &quot;ResourcePriceModel&quot;:[
        ///                 {
        ///                   &quot;Resource&quot;:&quot;bandwidth&quot;,
        ///                   &quot;TradeAmount&quot;:0.0,
        ///                   &quot;SubRuleIds&quot;:[],
        ///                   &quot;OriginalAmount&quot;:0.0,
        ///                   &quot;DiscountAmount&quot;:0.0
        ///                 },
        ///                 {
        ///                   &quot;Resource&quot;:&quot;image&quot;,
        ///                   &quot;TradeAmount&quot;:0.0,
        ///                   &quot;SubRuleIds&quot;:[],
        ///                   &quot;OriginalAmount&quot;:0.0,
        ///                   &quot;DiscountAmount&quot;:0.0
        ///                 },
        ///                 {
        ///                   &quot;Resource&quot;:&quot;instanceType&quot;,
        ///                   &quot;TradeAmount&quot;:0.006966,
        ///                   &quot;SubRuleIds&quot;:[],
        ///                   &quot;OriginalAmount&quot;:0.45,
        ///                   &quot;DiscountAmount&quot;:0.443034
        ///                 },
        ///                 {
        ///                   &quot;Resource&quot;:&quot;systemDisk&quot;,
        ///                   &quot;TradeAmount&quot;:0.000867,
        ///                   &quot;SubRuleIds&quot;:[],
        ///                   &quot;OriginalAmount&quot;:0.056,
        ///                   &quot;DiscountAmount&quot;:0.055133
        ///                 },
        ///                 {
        ///                   &quot;Resource&quot;:&quot;dataDisk&quot;,
        ///                   &quot;TradeAmount&quot;:0.002167,
        ///                   &quot;SubRuleIds&quot;:[],
        ///                   &quot;OriginalAmount&quot;:0.14,
        ///                   &quot;DiscountAmount&quot;:0.137833
        ///                 }
        ///               ]
        ///             }</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public Dictionary<string, object> Resources { get; set; }

    }

}
