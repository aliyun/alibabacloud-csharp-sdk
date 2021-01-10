// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class GetWithholdSignPageUrlRequest : TeaModel {
        [NameInMap("OutRequestNo")]
        [Validation(Required=false)]
        public string OutRequestNo { get; set; }

        [NameInMap("ExternalAgreementNo")]
        [Validation(Required=false)]
        public string ExternalAgreementNo { get; set; }

        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("MerchantServiceName")]
        [Validation(Required=false)]
        public string MerchantServiceName { get; set; }

        [NameInMap("MerchantServiceDescription")]
        [Validation(Required=false)]
        public string MerchantServiceDescription { get; set; }

        [NameInMap("IdentityParameters")]
        [Validation(Required=false)]
        public string IdentityParameters { get; set; }

        [NameInMap("ReturnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public string NotifyUrl { get; set; }

        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

    }

}
