// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainSpecialBizInfoByDomainResponseBody : TeaModel {
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryDomainSpecialBizInfoByDomainResponseBodyModule Module { get; set; }
        public class QueryDomainSpecialBizInfoByDomainResponseBodyModule : TeaModel {
            [NameInMap("AuditMsg")]
            [Validation(Required=false)]
            public string AuditMsg { get; set; }

            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            [NameInMap("BizNo")]
            [Validation(Required=false)]
            public string BizNo { get; set; }

            [NameInMap("BizStatus")]
            [Validation(Required=false)]
            public string BizStatus { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("DomainSpecialBizContact")]
            [Validation(Required=false)]
            public QueryDomainSpecialBizInfoByDomainResponseBodyModuleDomainSpecialBizContact DomainSpecialBizContact { get; set; }
            public class QueryDomainSpecialBizInfoByDomainResponseBodyModuleDomainSpecialBizContact : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                [NameInMap("CCity")]
                [Validation(Required=false)]
                public string CCity { get; set; }

                [NameInMap("CCompany")]
                [Validation(Required=false)]
                public string CCompany { get; set; }

                [NameInMap("CCountry")]
                [Validation(Required=false)]
                public string CCountry { get; set; }

                [NameInMap("CName")]
                [Validation(Required=false)]
                public string CName { get; set; }

                [NameInMap("CProvince")]
                [Validation(Required=false)]
                public string CProvince { get; set; }

                [NameInMap("CVenu")]
                [Validation(Required=false)]
                public string CVenu { get; set; }

                [NameInMap("ECity")]
                [Validation(Required=false)]
                public string ECity { get; set; }

                [NameInMap("ECompany")]
                [Validation(Required=false)]
                public string ECompany { get; set; }

                [NameInMap("EName")]
                [Validation(Required=false)]
                public string EName { get; set; }

                [NameInMap("EProvince")]
                [Validation(Required=false)]
                public string EProvince { get; set; }

                [NameInMap("EVenu")]
                [Validation(Required=false)]
                public string EVenu { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                [NameInMap("FaxArea")]
                [Validation(Required=false)]
                public string FaxArea { get; set; }

                [NameInMap("FaxExt")]
                [Validation(Required=false)]
                public string FaxExt { get; set; }

                [NameInMap("FaxMain")]
                [Validation(Required=false)]
                public string FaxMain { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("Postalcode")]
                [Validation(Required=false)]
                public string Postalcode { get; set; }

                [NameInMap("RegType")]
                [Validation(Required=false)]
                public int? RegType { get; set; }

                [NameInMap("RegistrantId")]
                [Validation(Required=false)]
                public string RegistrantId { get; set; }

                [NameInMap("TelArea")]
                [Validation(Required=false)]
                public string TelArea { get; set; }

                [NameInMap("TelExt")]
                [Validation(Required=false)]
                public string TelExt { get; set; }

                [NameInMap("TelMain")]
                [Validation(Required=false)]
                public string TelMain { get; set; }

                [NameInMap("VspContactId")]
                [Validation(Required=false)]
                public string VspContactId { get; set; }

            }

            [NameInMap("DomainSpecialBizCredentials")]
            [Validation(Required=false)]
            public List<QueryDomainSpecialBizInfoByDomainResponseBodyModuleDomainSpecialBizCredentials> DomainSpecialBizCredentials { get; set; }
            public class QueryDomainSpecialBizInfoByDomainResponseBodyModuleDomainSpecialBizCredentials : TeaModel {
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                [NameInMap("CredentialNo")]
                [Validation(Required=false)]
                public string CredentialNo { get; set; }

                [NameInMap("CredentialType")]
                [Validation(Required=false)]
                public string CredentialType { get; set; }

                [NameInMap("CredentialUrl")]
                [Validation(Required=false)]
                public string CredentialUrl { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("HolderCert")]
                [Validation(Required=false)]
                public int? HolderCert { get; set; }

                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

            }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("SaleId")]
            [Validation(Required=false)]
            public string SaleId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
