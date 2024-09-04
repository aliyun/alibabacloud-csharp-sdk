// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CreateCouponTemplateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicableProducts")]
        [Validation(Required=false)]
        public string ApplicableProducts { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CostBearer")]
        [Validation(Required=false)]
        public string CostBearer { get; set; }

        [NameInMap("CouponDescription")]
        [Validation(Required=false)]
        public string CouponDescription { get; set; }

        [NameInMap("Expireddate")]
        [Validation(Required=false)]
        public string Expireddate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LimitPerPerson")]
        [Validation(Required=false)]
        public string LimitPerPerson { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public List<string> ProductType { get; set; }

        [NameInMap("PurchaseType")]
        [Validation(Required=false)]
        public string PurchaseType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReasonForApplication")]
        [Validation(Required=false)]
        public string ReasonForApplication { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("Vailddate")]
        [Validation(Required=false)]
        public string Vailddate { get; set; }

        [NameInMap("Vaildperioddays")]
        [Validation(Required=false)]
        public string Vaildperioddays { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ValidUntil")]
        [Validation(Required=false)]
        public string ValidUntil { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
