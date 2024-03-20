// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainSpecialBizDetailResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether retries are allowed.
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// The name of the application for which the error code is returned.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The dynamic error code.
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic error message.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The array of error parameters that are returned.
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// The HTTP status code that is directly returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryDomainSpecialBizDetailResponseBodyModule Module { get; set; }
        public class QueryDomainSpecialBizDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// The review information.
            /// </summary>
            [NameInMap("AuditMsg")]
            [Validation(Required=false)]
            public string AuditMsg { get; set; }

            /// <summary>
            /// The business name.
            /// </summary>
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            /// <summary>
            /// The business ID.
            /// </summary>
            [NameInMap("BizNo")]
            [Validation(Required=false)]
            public string BizNo { get; set; }

            /// <summary>
            /// The business status.
            /// </summary>
            [NameInMap("BizStatus")]
            [Validation(Required=false)]
            public string BizStatus { get; set; }

            /// <summary>
            /// The business type.
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// The time when the business was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The contact information.
            /// </summary>
            [NameInMap("DomainSpecialBizContact")]
            [Validation(Required=false)]
            public QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialBizContact DomainSpecialBizContact { get; set; }
            public class QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialBizContact : TeaModel {
                /// <summary>
                /// The business ID.
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// The city.
                /// </summary>
                [NameInMap("CCity")]
                [Validation(Required=false)]
                public string CCity { get; set; }

                /// <summary>
                /// The organization name.
                /// </summary>
                [NameInMap("CCompany")]
                [Validation(Required=false)]
                public string CCompany { get; set; }

                /// <summary>
                /// The country code.
                /// </summary>
                [NameInMap("CCountry")]
                [Validation(Required=false)]
                public string CCountry { get; set; }

                /// <summary>
                /// The contact name.
                /// </summary>
                [NameInMap("CName")]
                [Validation(Required=false)]
                public string CName { get; set; }

                /// <summary>
                /// The province.
                /// </summary>
                [NameInMap("CProvince")]
                [Validation(Required=false)]
                public string CProvince { get; set; }

                /// <summary>
                /// The address.
                /// </summary>
                [NameInMap("CVenu")]
                [Validation(Required=false)]
                public string CVenu { get; set; }

                /// <summary>
                /// The city in English.
                /// </summary>
                [NameInMap("ECity")]
                [Validation(Required=false)]
                public string ECity { get; set; }

                /// <summary>
                /// The organization name in English.
                /// </summary>
                [NameInMap("ECompany")]
                [Validation(Required=false)]
                public string ECompany { get; set; }

                /// <summary>
                /// The contact name in English.
                /// </summary>
                [NameInMap("EName")]
                [Validation(Required=false)]
                public string EName { get; set; }

                /// <summary>
                /// The province in English.
                /// </summary>
                [NameInMap("EProvince")]
                [Validation(Required=false)]
                public string EProvince { get; set; }

                /// <summary>
                /// The address in English.
                /// </summary>
                [NameInMap("EVenu")]
                [Validation(Required=false)]
                public string EVenu { get; set; }

                /// <summary>
                /// The email address.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The extended information.
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                /// <summary>
                /// The fax country code.
                /// </summary>
                [NameInMap("FaxArea")]
                [Validation(Required=false)]
                public string FaxArea { get; set; }

                /// <summary>
                /// The fax extension number.
                /// </summary>
                [NameInMap("FaxExt")]
                [Validation(Required=false)]
                public string FaxExt { get; set; }

                /// <summary>
                /// The fax number with an area code or mobile number.
                /// </summary>
                [NameInMap("FaxMain")]
                [Validation(Required=false)]
                public string FaxMain { get; set; }

                /// <summary>
                /// The mobile number.
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// The zip code.
                /// </summary>
                [NameInMap("Postalcode")]
                [Validation(Required=false)]
                public string Postalcode { get; set; }

                /// <summary>
                /// The contact type. Valid values: 1: individual. 2: enterprise.
                /// </summary>
                [NameInMap("RegType")]
                [Validation(Required=false)]
                public int? RegType { get; set; }

                /// <summary>
                /// The registrant ID.
                /// </summary>
                [NameInMap("RegistrantId")]
                [Validation(Required=false)]
                public string RegistrantId { get; set; }

                /// <summary>
                /// The calling code of the country or region where the domain name contact is located.
                /// </summary>
                [NameInMap("TelArea")]
                [Validation(Required=false)]
                public string TelArea { get; set; }

                /// <summary>
                /// The telephone extension number.
                /// </summary>
                [NameInMap("TelExt")]
                [Validation(Required=false)]
                public string TelExt { get; set; }

                /// <summary>
                /// The landline number with an area code or mobile number.
                /// </summary>
                [NameInMap("TelMain")]
                [Validation(Required=false)]
                public string TelMain { get; set; }

                /// <summary>
                /// The VSP contact ID.
                /// </summary>
                [NameInMap("VspContactId")]
                [Validation(Required=false)]
                public string VspContactId { get; set; }

            }

            /// <summary>
            /// The certificate information.
            /// </summary>
            [NameInMap("DomainSpecialBizCredentials")]
            [Validation(Required=false)]
            public List<QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialBizCredentials> DomainSpecialBizCredentials { get; set; }
            public class QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialBizCredentials : TeaModel {
                /// <summary>
                /// The ID of the associated workflow.
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// The certificate number.
                /// </summary>
                [NameInMap("CredentialNo")]
                [Validation(Required=false)]
                public string CredentialNo { get; set; }

                /// <summary>
                /// The certificate type.
                /// </summary>
                [NameInMap("CredentialType")]
                [Validation(Required=false)]
                public string CredentialType { get; set; }

                /// <summary>
                /// The certificate URL.
                /// </summary>
                [NameInMap("CredentialUrl")]
                [Validation(Required=false)]
                public string CredentialUrl { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// Indicates whether the certificate belongs to the registrant.
                /// </summary>
                [NameInMap("HolderCert")]
                [Validation(Required=false)]
                public int? HolderCert { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

            }

            /// <summary>
            /// The information about the order.
            /// </summary>
            [NameInMap("DomainSpecialOrderResult")]
            [Validation(Required=false)]
            public QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialOrderResult DomainSpecialOrderResult { get; set; }
            public class QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialOrderResult : TeaModel {
                /// <summary>
                /// The cost type.
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// The amount of the order.
                /// </summary>
                [NameInMap("OrderAmount")]
                [Validation(Required=false)]
                public double? OrderAmount { get; set; }

                /// <summary>
                /// The currency.
                /// </summary>
                [NameInMap("OrderCurrency")]
                [Validation(Required=false)]
                public string OrderCurrency { get; set; }

                /// <summary>
                /// The order ID.
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// The order status.
                /// </summary>
                [NameInMap("OrderStatus")]
                [Validation(Required=false)]
                public string OrderStatus { get; set; }

                /// <summary>
                /// The time when the order was placed.
                /// </summary>
                [NameInMap("OrderTime")]
                [Validation(Required=false)]
                public string OrderTime { get; set; }

                /// <summary>
                /// The validity period.
                /// </summary>
                [NameInMap("OrderYear")]
                [Validation(Required=false)]
                public int? OrderYear { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

                /// <summary>
                /// The suborder ID.
                /// </summary>
                [NameInMap("SubOrderId")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

            }

            /// <summary>
            /// The time when the business was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the business was modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The primary key.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The order ID.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// The service ID.
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("SaleId")]
            [Validation(Required=false)]
            public string SaleId { get; set; }

            /// <summary>
            /// The business status.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The description of business status.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// The time when the business was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Indicates whether to perform synchronous processing.
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
