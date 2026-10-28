// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CreateCouponTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCouponTemplateResponseBodyData Data { get; set; }
        public class CreateCouponTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The applicable products.</para>
            /// <list type="bullet">
            /// <item><description>All Products: All products.</description></item>
            /// <item><description>Custom: Custom products.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("ApplicableProducts")]
            [Validation(Required=false)]
            public string ApplicableProducts { get; set; }

            /// <summary>
            /// <para>The party that bears the coupon cost.</para>
            /// <list type="bullet">
            /// <item><description>Partner: Borne by the partner.</description></item>
            /// <item><description>Alibaba Cloud: Borne by Alibaba Cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Partner</para>
            /// </summary>
            [NameInMap("CostBearer")]
            [Validation(Required=false)]
            public string CostBearer { get; set; }

            /// <summary>
            /// <para>The ID of the coupon template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("CouponTemplateID")]
            [Validation(Required=false)]
            public long? CouponTemplateID { get; set; }

            /// <summary>
            /// <para>The creation time. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-02 16:15:31</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The end time of the effective period.
            /// Format: yyyy-MM-dd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01</para>
            /// </summary>
            [NameInMap("Expireddate")]
            [Validation(Required=false)]
            public string Expireddate { get; set; }

            /// <summary>
            /// <para>The list of product codes.</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public List<string> ProductType { get; set; }

            /// <summary>
            /// <para>The status of the coupon template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATED: Created.</description></item>
            /// <item><description>APPROVING: Under review.</description></item>
            /// <item><description>APPROVED: Approved.</description></item>
            /// <item><description>UNAPPROVED: Unapproved.</description></item>
            /// <item><description>ABANDONED: Abandoned.</description></item>
            /// <item><description>EXPIRED: Expired.</description></item>
            /// <item><description>EXHAUSTED: Exhausted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APPROVED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
            /// <para>The start time of the effective period.
            /// Format: yyyy-MM-dd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01</para>
            /// </summary>
            [NameInMap("Vailddate")]
            [Validation(Required=false)]
            public string Vailddate { get; set; }

            /// <summary>
            /// <para>The duration of the relative time in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vaildperioddays")]
            [Validation(Required=false)]
            public string Vaildperioddays { get; set; }

            /// <summary>
            /// <para>The validity period of the coupon.</para>
            /// <list type="bullet">
            /// <item><description>Validity Duration: From the date of issuance.</description></item>
            /// <item><description>Custom Timeframe: Custom time period.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Validity Duration</para>
            /// </summary>
            [NameInMap("ValidUntil")]
            [Validation(Required=false)]
            public string ValidUntil { get; set; }

            /// <summary>
            /// <para>The denomination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2103a30617045934095083027d88c5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
