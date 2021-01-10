// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class UnsignWithholdAgreementRequest : TeaModel {
        [NameInMap("OutRequestNo")]
        [Validation(Required=false)]
        public string OutRequestNo { get; set; }

        [NameInMap("ExternalAgreementNo")]
        [Validation(Required=false)]
        public string ExternalAgreementNo { get; set; }

        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("AgreementNo")]
        [Validation(Required=false)]
        public string AgreementNo { get; set; }

    }

}
