// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CreateCouponTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The accepted language.
        /// Default value: None.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Chinese.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// <item><description>ja: Japanese.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The applicable products.</para>
        /// <list type="bullet">
        /// <item><description>All Products: All products.</description></item>
        /// <item><description>Custom: Custom products.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All Products</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Partner</para>
        /// </summary>
        [NameInMap("CostBearer")]
        [Validation(Required=false)]
        public string CostBearer { get; set; }

        /// <summary>
        /// <para>The remark for the coupon.
        /// The field length is limited to 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Coupon remark</para>
        /// </summary>
        [NameInMap("CouponDescription")]
        [Validation(Required=false)]
        public string CouponDescription { get; set; }

        /// <summary>
        /// <para>The end time of the effective period.
        /// Format: yyyy-MM-dd.
        /// Example: 2024-08-26.<br>This parameter is required when the validity period is set to Custom Timeframe.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-26</para>
        /// </summary>
        [NameInMap("Expireddate")]
        [Validation(Required=false)]
        public string Expireddate { get; set; }

        /// <summary>
        /// <para>The maximum number of coupons that each person can claim.</para>
        /// <list type="bullet">
        /// <item><description>Limited to 1: Limited to one coupon.</description></item>
        /// <item><description>Unlimited: Unlimited.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unlimited</para>
        /// </summary>
        [NameInMap("LimitPerPerson")]
        [Validation(Required=false)]
        public string LimitPerPerson { get; set; }

        /// <summary>
        /// <para>The list of product codes.</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public List<string> ProductType { get; set; }

        /// <summary>
        /// <para>The order type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("PurchaseType")]
        [Validation(Required=false)]
        public string PurchaseType { get; set; }

        /// <summary>
        /// <para>The reason for the template application.
        /// The field length is limited to 100 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reason for template application</para>
        /// </summary>
        [NameInMap("ReasonForApplication")]
        [Validation(Required=false)]
        public string ReasonForApplication { get; set; }

        /// <summary>
        /// <para>The template name.
        /// The field length is limited to 30 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The start time of the effective period.
        /// Format: yyyy-MM-dd.
        /// Example: 2024-08-26.<br>This parameter is required when the validity period is set to Custom Timeframe.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-26</para>
        /// </summary>
        [NameInMap("Vailddate")]
        [Validation(Required=false)]
        public string Vailddate { get; set; }

        /// <summary>
        /// <para>The duration of the relative time in days.
        /// The value must be a positive integer.
        /// This parameter is required when the validity period is set to Validity Duration.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Validity Duration</para>
        /// </summary>
        [NameInMap("ValidUntil")]
        [Validation(Required=false)]
        public string ValidUntil { get; set; }

        /// <summary>
        /// <para>The denomination of the coupon.
        /// The value must be an integer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
