// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcTaxIllegalResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcTaxIllegalResponseBodyData> Data { get; set; }
        public class GetOcTaxIllegalResponseBodyData : TeaModel {
            [NameInMap("AgencyCardNum")]
            [Validation(Required=false)]
            public string AgencyCardNum { get; set; }

            [NameInMap("AgencyCardType")]
            [Validation(Required=false)]
            public string AgencyCardType { get; set; }

            [NameInMap("AgencyEnt")]
            [Validation(Required=false)]
            public string AgencyEnt { get; set; }

            [NameInMap("AgencyName")]
            [Validation(Required=false)]
            public string AgencyName { get; set; }

            [NameInMap("AgencySex")]
            [Validation(Required=false)]
            public string AgencySex { get; set; }

            [NameInMap("CaseType")]
            [Validation(Required=false)]
            public string CaseType { get; set; }

            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("EntAddress")]
            [Validation(Required=false)]
            public string EntAddress { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("FinancialCardNum")]
            [Validation(Required=false)]
            public string FinancialCardNum { get; set; }

            [NameInMap("FinancialCardType")]
            [Validation(Required=false)]
            public string FinancialCardType { get; set; }

            [NameInMap("FinancialName")]
            [Validation(Required=false)]
            public string FinancialName { get; set; }

            [NameInMap("FinancialSex")]
            [Validation(Required=false)]
            public string FinancialSex { get; set; }

            [NameInMap("IllegalTruth")]
            [Validation(Required=false)]
            public string IllegalTruth { get; set; }

            [NameInMap("LawBasis")]
            [Validation(Required=false)]
            public string LawBasis { get; set; }

            [NameInMap("LegalCardNum")]
            [Validation(Required=false)]
            public string LegalCardNum { get; set; }

            [NameInMap("LegalCardType")]
            [Validation(Required=false)]
            public string LegalCardType { get; set; }

            [NameInMap("LegalName")]
            [Validation(Required=false)]
            public string LegalName { get; set; }

            [NameInMap("LegalSex")]
            [Validation(Required=false)]
            public string LegalSex { get; set; }

            [NameInMap("OrgCode")]
            [Validation(Required=false)]
            public string OrgCode { get; set; }

            [NameInMap("PublishDate")]
            [Validation(Required=false)]
            public string PublishDate { get; set; }

            [NameInMap("TaxpayerNum")]
            [Validation(Required=false)]
            public string TaxpayerNum { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
