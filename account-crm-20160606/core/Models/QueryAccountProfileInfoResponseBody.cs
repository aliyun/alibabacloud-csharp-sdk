// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryAccountProfileInfoResponseBody : TeaModel {
        [NameInMap("ProfileInfo")]
        [Validation(Required=false)]
        public QueryAccountProfileInfoResponseBodyProfileInfo ProfileInfo { get; set; }
        public class QueryAccountProfileInfoResponseBodyProfileInfo : TeaModel {
            [NameInMap("AccountAttr")]
            [Validation(Required=false)]
            public string AccountAttr { get; set; }

            [NameInMap("AccountCertifyType")]
            [Validation(Required=false)]
            public string AccountCertifyType { get; set; }

            [NameInMap("ActiveNotSetMobile")]
            [Validation(Required=false)]
            public string ActiveNotSetMobile { get; set; }

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

            [NameInMap("AlipayAccount")]
            [Validation(Required=false)]
            public string AlipayAccount { get; set; }

            [NameInMap("AlipayUid")]
            [Validation(Required=false)]
            public string AlipayUid { get; set; }

            [NameInMap("AliyunID")]
            [Validation(Required=false)]
            public string AliyunID { get; set; }

            [NameInMap("AliyunPK")]
            [Validation(Required=false)]
            public string AliyunPK { get; set; }

            [NameInMap("AuthAlipay")]
            [Validation(Required=false)]
            public string AuthAlipay { get; set; }

            [NameInMap("AuthDomainUserId")]
            [Validation(Required=false)]
            public string AuthDomainUserId { get; set; }

            [NameInMap("B2bhid")]
            [Validation(Required=false)]
            public string B2bhid { get; set; }

            [NameInMap("BankId")]
            [Validation(Required=false)]
            public string BankId { get; set; }

            [NameInMap("BankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

            [NameInMap("BeiAnAuthCId")]
            [Validation(Required=false)]
            public string BeiAnAuthCId { get; set; }

            [NameInMap("BeiAnIcpNumber")]
            [Validation(Required=false)]
            public string BeiAnIcpNumber { get; set; }

            [NameInMap("BeiAnMobile")]
            [Validation(Required=false)]
            public string BeiAnMobile { get; set; }

            [NameInMap("BindAlipayNo")]
            [Validation(Required=false)]
            public string BindAlipayNo { get; set; }

            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            [NameInMap("CertifiedFrom")]
            [Validation(Required=false)]
            public string CertifiedFrom { get; set; }

            [NameInMap("CertifiedTime")]
            [Validation(Required=false)]
            public string CertifiedTime { get; set; }

            [NameInMap("City")]
            [Validation(Required=false)]
            public QueryAccountProfileInfoResponseBodyProfileInfoCity City { get; set; }
            public class QueryAccountProfileInfoResponseBodyProfileInfoCity : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("ContactMethod")]
            [Validation(Required=false)]
            public string ContactMethod { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("District")]
            [Validation(Required=false)]
            public QueryAccountProfileInfoResponseBodyProfileInfoDistrict District { get; set; }
            public class QueryAccountProfileInfoResponseBodyProfileInfoDistrict : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Eid")]
            [Validation(Required=false)]
            public string Eid { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Fax")]
            [Validation(Required=false)]
            public string Fax { get; set; }

            [NameInMap("FirstName")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            [NameInMap("Fyl")]
            [Validation(Required=false)]
            public string Fyl { get; set; }

            [NameInMap("HavanaId")]
            [Validation(Required=false)]
            public string HavanaId { get; set; }

            [NameInMap("Head")]
            [Validation(Required=false)]
            public string Head { get; set; }

            [NameInMap("HeadUrl")]
            [Validation(Required=false)]
            public string HeadUrl { get; set; }

            [NameInMap("IDNumber")]
            [Validation(Required=false)]
            public string IDNumber { get; set; }

            [NameInMap("IsBankIDAuth")]
            [Validation(Required=false)]
            public string IsBankIDAuth { get; set; }

            [NameInMap("IsCertified")]
            [Validation(Required=false)]
            public string IsCertified { get; set; }

            [NameInMap("LastName")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("NationalityCode")]
            [Validation(Required=false)]
            public string NationalityCode { get; set; }

            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("Own")]
            [Validation(Required=false)]
            public string Own { get; set; }

            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("PostCode")]
            [Validation(Required=false)]
            public string PostCode { get; set; }

            [NameInMap("PreferredLanguage")]
            [Validation(Required=false)]
            public string PreferredLanguage { get; set; }

            [NameInMap("ProcessingEnterpriseCertify")]
            [Validation(Required=false)]
            public bool? ProcessingEnterpriseCertify { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public QueryAccountProfileInfoResponseBodyProfileInfoProvince Province { get; set; }
            public class QueryAccountProfileInfoResponseBodyProfileInfoProvince : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("RegisterIP")]
            [Validation(Required=false)]
            public string RegisterIP { get; set; }

            [NameInMap("SecurityMobile")]
            [Validation(Required=false)]
            public string SecurityMobile { get; set; }

            [NameInMap("SecurityQuestionExists")]
            [Validation(Required=false)]
            public bool? SecurityQuestionExists { get; set; }

            [NameInMap("SelfServicingBusinessRegNum")]
            [Validation(Required=false)]
            public string SelfServicingBusinessRegNum { get; set; }

            [NameInMap("SelfServicingIdentificationNum")]
            [Validation(Required=false)]
            public string SelfServicingIdentificationNum { get; set; }

            [NameInMap("ShowNickName")]
            [Validation(Required=false)]
            public string ShowNickName { get; set; }

            [NameInMap("Src")]
            [Validation(Required=false)]
            public string Src { get; set; }

            [NameInMap("TaobaoAccount")]
            [Validation(Required=false)]
            public string TaobaoAccount { get; set; }

            [NameInMap("TaobaoNickFromHavana")]
            [Validation(Required=false)]
            public string TaobaoNickFromHavana { get; set; }

            [NameInMap("Tbhid")]
            [Validation(Required=false)]
            public string Tbhid { get; set; }

            [NameInMap("TrueName")]
            [Validation(Required=false)]
            public string TrueName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("YahooEmail")]
            [Validation(Required=false)]
            public string YahooEmail { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
