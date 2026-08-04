// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryEnterpriseInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ProfileInfo")]
        [Validation(Required=false)]
        public QueryEnterpriseInfoResponseBodyProfileInfo ProfileInfo { get; set; }
        public class QueryEnterpriseInfoResponseBodyProfileInfo : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("AliyunPK")]
            [Validation(Required=false)]
            public string AliyunPK { get; set; }

            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            [NameInMap("BusinessLicenseImgSrc")]
            [Validation(Required=false)]
            public string BusinessLicenseImgSrc { get; set; }

            [NameInMap("BusinessLicenseNumber")]
            [Validation(Required=false)]
            public string BusinessLicenseNumber { get; set; }

            [NameInMap("BusinessLicenseType")]
            [Validation(Required=false)]
            public string BusinessLicenseType { get; set; }

            [NameInMap("CertifiedFrom")]
            [Validation(Required=false)]
            public string CertifiedFrom { get; set; }

            [NameInMap("CertifiedTime")]
            [Validation(Required=false)]
            public string CertifiedTime { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public QueryEnterpriseInfoResponseBodyProfileInfoCity City { get; set; }
            public class QueryEnterpriseInfoResponseBodyProfileInfoCity : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DetailAddress")]
            [Validation(Required=false)]
            public string DetailAddress { get; set; }

            [NameInMap("EInterpriseSize")]
            [Validation(Required=false)]
            public string EInterpriseSize { get; set; }

            [NameInMap("EnterpriseEntity")]
            [Validation(Required=false)]
            public string EnterpriseEntity { get; set; }

            [NameInMap("EntityIDNumber")]
            [Validation(Required=false)]
            public string EntityIDNumber { get; set; }

            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            [NameInMap("Fax")]
            [Validation(Required=false)]
            public string Fax { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("PostalCode")]
            [Validation(Required=false)]
            public string PostalCode { get; set; }

            [NameInMap("Profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public QueryEnterpriseInfoResponseBodyProfileInfoProvince Province { get; set; }
            public class QueryEnterpriseInfoResponseBodyProfileInfoProvince : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("Years")]
            [Validation(Required=false)]
            public string Years { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
