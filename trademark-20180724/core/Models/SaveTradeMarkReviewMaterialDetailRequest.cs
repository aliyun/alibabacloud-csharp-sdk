// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class SaveTradeMarkReviewMaterialDetailRequest : TeaModel {
        [NameInMap("AdditionalOssKeyList")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdditionalOssKeyList { get; set; }

        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("ApplicationOssKey")]
        [Validation(Required=false)]
        public string ApplicationOssKey { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BusinessLicenceOssKey")]
        [Validation(Required=false)]
        public string BusinessLicenceOssKey { get; set; }

        [NameInMap("CardNumber")]
        [Validation(Required=false)]
        public string CardNumber { get; set; }

        [NameInMap("ChangeName")]
        [Validation(Required=false)]
        public bool? ChangeName { get; set; }

        [NameInMap("ContactAddress")]
        [Validation(Required=false)]
        public string ContactAddress { get; set; }

        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("ContactNumber")]
        [Validation(Required=false)]
        public string ContactNumber { get; set; }

        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("EngAddress")]
        [Validation(Required=false)]
        public string EngAddress { get; set; }

        [NameInMap("EngName")]
        [Validation(Required=false)]
        public string EngName { get; set; }

        [NameInMap("IdCardOssKey")]
        [Validation(Required=false)]
        public string IdCardOssKey { get; set; }

        [NameInMap("LegalNoticeOssKey")]
        [Validation(Required=false)]
        public string LegalNoticeOssKey { get; set; }

        [NameInMap("LoaOssKey")]
        [Validation(Required=false)]
        public string LoaOssKey { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PassportOssKey")]
        [Validation(Required=false)]
        public string PassportOssKey { get; set; }

        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public int? Region { get; set; }

        [NameInMap("ReviewMaterialAdditionalJson")]
        [Validation(Required=false)]
        public string ReviewMaterialAdditionalJson { get; set; }

        [NameInMap("Separate")]
        [Validation(Required=false)]
        public bool? Separate { get; set; }

        [NameInMap("SubmitOnline")]
        [Validation(Required=false)]
        public bool? SubmitOnline { get; set; }

        [NameInMap("SubmitType")]
        [Validation(Required=false)]
        public int? SubmitType { get; set; }

        [NameInMap("SupplementFlag")]
        [Validation(Required=false)]
        public bool? SupplementFlag { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
