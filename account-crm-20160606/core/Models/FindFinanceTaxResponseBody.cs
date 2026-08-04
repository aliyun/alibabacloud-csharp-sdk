// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class FindFinanceTaxResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FinanceVersion")]
        [Validation(Required=false)]
        public FindFinanceTaxResponseBodyFinanceVersion FinanceVersion { get; set; }
        public class FindFinanceTaxResponseBodyFinanceVersion : TeaModel {
            [NameInMap("FinanceTaxCertificateImgName")]
            [Validation(Required=false)]
            public string FinanceTaxCertificateImgName { get; set; }

            [NameInMap("FinanceTaxCertificateImgUrl")]
            [Validation(Required=false)]
            public string FinanceTaxCertificateImgUrl { get; set; }

            [NameInMap("SecondFinanceTax")]
            [Validation(Required=false)]
            public string SecondFinanceTax { get; set; }

            [NameInMap("SecondFinanceTaxCertificateImgName")]
            [Validation(Required=false)]
            public string SecondFinanceTaxCertificateImgName { get; set; }

            [NameInMap("SecondFinanceTaxCertificateImgUrl")]
            [Validation(Required=false)]
            public string SecondFinanceTaxCertificateImgUrl { get; set; }

            [NameInMap("Tax")]
            [Validation(Required=false)]
            public string Tax { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
