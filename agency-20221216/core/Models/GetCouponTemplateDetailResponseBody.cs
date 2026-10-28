// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetCouponTemplateDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The operation result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCouponTemplateDetailResponseBodyData Data { get; set; }
        public class GetCouponTemplateDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The applicable products. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>UNIVERSAL: all products</para>
            /// </description></item>
            /// <item><description><para>a specific commodity code</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UNIVERSAL</para>
            /// </summary>
            [NameInMap("ApplicableProducts")]
            [Validation(Required=false)]
            public string ApplicableProducts { get; set; }

            /// <summary>
            /// <para>The party that bears the coupon cost. Valid values:
            /// ● cost_by_self: The cost is borne by the caller.
            /// ● aliyun_poc: The cost is borne by Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_poc</para>
            /// </summary>
            [NameInMap("CostBearer")]
            [Validation(Required=false)]
            public string CostBearer { get; set; }

            /// <summary>
            /// <para>The remarks of the coupon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>For testing</para>
            /// </summary>
            [NameInMap("CouponDescription")]
            [Validation(Required=false)]
            public string CouponDescription { get; set; }

            /// <summary>
            /// <para>The creation time. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-21 18:18:22</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The face value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Denomination")]
            [Validation(Required=false)]
            public double? Denomination { get; set; }

            /// <summary>
            /// <para>The maximum number of coupons that each person can claim. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: Each person can claim one coupon.</para>
            /// </description></item>
            /// <item><description><para>0: No limit applies.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LimitPerPerson")]
            [Validation(Required=false)]
            public int? LimitPerPerson { get; set; }

            /// <summary>
            /// <para>The order type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL: Alibaba Cloud upfront order</description></item>
            /// <item><description>BILLING: Alibaba Cloud pay-as-you-go bill</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL,BILLING</para>
            /// </summary>
            [NameInMap("PurchaseType")]
            [Validation(Required=false)]
            public string PurchaseType { get; set; }

            /// <summary>
            /// <para>The reason for the template application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>For testing</para>
            /// </summary>
            [NameInMap("ReasonForApplication")]
            [Validation(Required=false)]
            public string ReasonForApplication { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>APPROVED: approved</description></item>
            /// <item><description>ABANDONED: voided</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APPROVED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1576</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the coupon template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Template name</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The validity period. This parameter is used together with the validity period type.</para>
            /// <list type="bullet">
            /// <item><description><para>If the validity period type is relative time, the validity period is the number of valid days.</para>
            /// </description></item>
            /// <item><description><para>If the validity period type is absolute time, the validity period is a time period.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ValidUntil")]
            [Validation(Required=false)]
            public string ValidUntil { get; set; }

            /// <summary>
            /// <para>The type of the validity period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: relative time</description></item>
            /// <item><description>1: absolute time</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ValidUntilType")]
            [Validation(Required=false)]
            public string ValidUntilType { get; set; }

        }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
