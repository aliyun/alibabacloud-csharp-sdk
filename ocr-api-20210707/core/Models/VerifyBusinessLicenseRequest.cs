// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class VerifyBusinessLicenseRequest : TeaModel {
        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        [NameInMap("CreditCode")]
        [Validation(Required=false)]
        public string CreditCode { get; set; }

        [NameInMap("LegalPerson")]
        [Validation(Required=false)]
        public string LegalPerson { get; set; }

    }

}
