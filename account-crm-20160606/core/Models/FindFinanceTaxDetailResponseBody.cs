// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class FindFinanceTaxDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Finance")]
        [Validation(Required=false)]
        public FindFinanceTaxDetailResponseBodyFinance Finance { get; set; }
        public class FindFinanceTaxDetailResponseBodyFinance : TeaModel {
            [NameInMap("FinanceTaxCertificateImgName")]
            [Validation(Required=false)]
            public string FinanceTaxCertificateImgName { get; set; }

            [NameInMap("Tax")]
            [Validation(Required=false)]
            public string Tax { get; set; }

            [NameInMap("financeTaxCertificateImgUrl")]
            [Validation(Required=false)]
            public string FinanceTaxCertificateImgUrl { get; set; }

            [NameInMap("secondFinanceTax")]
            [Validation(Required=false)]
            public string SecondFinanceTax { get; set; }

            [NameInMap("secondFinanceTaxCertificateImgName")]
            [Validation(Required=false)]
            public string SecondFinanceTaxCertificateImgName { get; set; }

            [NameInMap("secondFinanceTaxCertificateImgUrl")]
            [Validation(Required=false)]
            public string SecondFinanceTaxCertificateImgUrl { get; set; }

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
