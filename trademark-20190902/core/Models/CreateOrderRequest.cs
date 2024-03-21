// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class CreateOrderRequest : TeaModel {
        [NameInMap("AgreementId")]
        [Validation(Required=false)]
        public string AgreementId { get; set; }

        [NameInMap("ApplicantId")]
        [Validation(Required=false)]
        public string ApplicantId { get; set; }

        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public int? ApplicationType { get; set; }

        [NameInMap("AuthorizationOssKey")]
        [Validation(Required=false)]
        public string AuthorizationOssKey { get; set; }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("BlackAndWhiteIcon")]
        [Validation(Required=false)]
        public string BlackAndWhiteIcon { get; set; }

        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("Classifications")]
        [Validation(Required=false)]
        public string Classifications { get; set; }

        [NameInMap("IdempotentId")]
        [Validation(Required=false)]
        public string IdempotentId { get; set; }

        [NameInMap("LegalNoticeKey")]
        [Validation(Required=false)]
        public string LegalNoticeKey { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("PaymentCallback")]
        [Validation(Required=false)]
        public string PaymentCallback { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public int? PrincipalName { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("TrademarkComment")]
        [Validation(Required=false)]
        public string TrademarkComment { get; set; }

        [NameInMap("TrademarkIcon")]
        [Validation(Required=false)]
        public string TrademarkIcon { get; set; }

        [NameInMap("TrademarkName")]
        [Validation(Required=false)]
        public string TrademarkName { get; set; }

        [NameInMap("TrademarkNameType")]
        [Validation(Required=false)]
        public string TrademarkNameType { get; set; }

    }

}
