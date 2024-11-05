// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CreateCouponTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All Products</para>
        /// </summary>
        [NameInMap("ApplicableProducts")]
        [Validation(Required=false)]
        public string ApplicableProducts { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Partner</para>
        /// </summary>
        [NameInMap("CostBearer")]
        [Validation(Required=false)]
        public string CostBearer { get; set; }

        [NameInMap("CouponDescription")]
        [Validation(Required=false)]
        public string CouponDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-08-26</para>
        /// </summary>
        [NameInMap("Expireddate")]
        [Validation(Required=false)]
        public string Expireddate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unlimited</para>
        /// </summary>
        [NameInMap("LimitPerPerson")]
        [Validation(Required=false)]
        public string LimitPerPerson { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductTypeShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("PurchaseType")]
        [Validation(Required=false)]
        public string PurchaseType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReasonForApplication")]
        [Validation(Required=false)]
        public string ReasonForApplication { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-08-26</para>
        /// </summary>
        [NameInMap("Vailddate")]
        [Validation(Required=false)]
        public string Vailddate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Vaildperioddays")]
        [Validation(Required=false)]
        public string Vaildperioddays { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Validity Duration</para>
        /// </summary>
        [NameInMap("ValidUntil")]
        [Validation(Required=false)]
        public string ValidUntil { get; set; }

        /// <summary>
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
