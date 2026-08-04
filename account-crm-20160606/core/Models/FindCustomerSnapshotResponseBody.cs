// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class FindCustomerSnapshotResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CustomerSnapshot")]
        [Validation(Required=false)]
        public FindCustomerSnapshotResponseBodyCustomerSnapshot CustomerSnapshot { get; set; }
        public class FindCustomerSnapshotResponseBodyCustomerSnapshot : TeaModel {
            [NameInMap("AccountInfoSnapshotModel")]
            [Validation(Required=false)]
            public FindCustomerSnapshotResponseBodyCustomerSnapshotAccountInfoSnapshotModel AccountInfoSnapshotModel { get; set; }
            public class FindCustomerSnapshotResponseBodyCustomerSnapshotAccountInfoSnapshotModel : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Address2")]
                [Validation(Required=false)]
                public string Address2 { get; set; }

                [NameInMap("Address3")]
                [Validation(Required=false)]
                public string Address3 { get; set; }

                [NameInMap("Address4")]
                [Validation(Required=false)]
                public string Address4 { get; set; }

                [NameInMap("Address5")]
                [Validation(Required=false)]
                public string Address5 { get; set; }

                [NameInMap("Address6")]
                [Validation(Required=false)]
                public string Address6 { get; set; }

                [NameInMap("CityId")]
                [Validation(Required=false)]
                public string CityId { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("PostCode")]
                [Validation(Required=false)]
                public string PostCode { get; set; }

                [NameInMap("ProvinceId")]
                [Validation(Required=false)]
                public string ProvinceId { get; set; }

                [NameInMap("ProvinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                [NameInMap("TrueName")]
                [Validation(Required=false)]
                public string TrueName { get; set; }

            }

            [NameInMap("AccountTaxSnapshotModel")]
            [Validation(Required=false)]
            public FindCustomerSnapshotResponseBodyCustomerSnapshotAccountTaxSnapshotModel AccountTaxSnapshotModel { get; set; }
            public class FindCustomerSnapshotResponseBodyCustomerSnapshotAccountTaxSnapshotModel : TeaModel {
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

            }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InfoType")]
            [Validation(Required=false)]
            public string InfoType { get; set; }

            [NameInMap("KpId")]
            [Validation(Required=false)]
            public long? KpId { get; set; }

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
