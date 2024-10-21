// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryDomainSpecialBizDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether retries are allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The name of the application for which the error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-com</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The array of error parameters that are returned.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110001</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code that is directly returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryDomainSpecialBizDetailResponseBodyModule Module { get; set; }
        public class QueryDomainSpecialBizDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The review information.</para>
            /// </summary>
            [NameInMap("AuditMsg")]
            [Validation(Required=false)]
            public string AuditMsg { get; set; }

            /// <summary>
            /// <para>The business name.</para>
            /// </summary>
            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            /// <summary>
            /// <para>The business ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A83E1D74-E46B-505C-947A-8C6B7E41C012</para>
            /// </summary>
            [NameInMap("BizNo")]
            [Validation(Required=false)]
            public string BizNo { get; set; }

            /// <summary>
            /// <para>The business status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REGISTRANT_VSP_AUDIT_SUCCESS</para>
            /// </summary>
            [NameInMap("BizStatus")]
            [Validation(Required=false)]
            public string BizStatus { get; set; }

            /// <summary>
            /// <para>The business type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>govRegister</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>The time when the business was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-17 11:31:10</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test003.cn</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The contact information.</para>
            /// </summary>
            [NameInMap("DomainSpecialBizContact")]
            [Validation(Required=false)]
            public QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialBizContact DomainSpecialBizContact { get; set; }
            public class QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialBizContact : TeaModel {
                /// <summary>
                /// <para>The business ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>258</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// <para>The city.</para>
                /// </summary>
                [NameInMap("CCity")]
                [Validation(Required=false)]
                public string CCity { get; set; }

                /// <summary>
                /// <para>The organization name.</para>
                /// </summary>
                [NameInMap("CCompany")]
                [Validation(Required=false)]
                public string CCompany { get; set; }

                /// <summary>
                /// <para>The country code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("CCountry")]
                [Validation(Required=false)]
                public string CCountry { get; set; }

                /// <summary>
                /// <para>The contact name.</para>
                /// </summary>
                [NameInMap("CName")]
                [Validation(Required=false)]
                public string CName { get; set; }

                /// <summary>
                /// <para>The province.</para>
                /// </summary>
                [NameInMap("CProvince")]
                [Validation(Required=false)]
                public string CProvince { get; set; }

                /// <summary>
                /// <para>The address.</para>
                /// </summary>
                [NameInMap("CVenu")]
                [Validation(Required=false)]
                public string CVenu { get; set; }

                /// <summary>
                /// <para>The city in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>an shan Shi</para>
                /// </summary>
                [NameInMap("ECity")]
                [Validation(Required=false)]
                public string ECity { get; set; }

                /// <summary>
                /// <para>The organization name in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hebeihuiheguandaozhizaoyouxiangongsi</para>
                /// </summary>
                [NameInMap("ECompany")]
                [Validation(Required=false)]
                public string ECompany { get; set; }

                /// <summary>
                /// <para>The contact name in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tong da wei</para>
                /// </summary>
                [NameInMap("EName")]
                [Validation(Required=false)]
                public string EName { get; set; }

                /// <summary>
                /// <para>The province in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liao ning</para>
                /// </summary>
                [NameInMap("EProvince")]
                [Validation(Required=false)]
                public string EProvince { get; set; }

                /// <summary>
                /// <para>The address in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tie xi qu xin kai jie 59-4 hao</para>
                /// </summary>
                [NameInMap("EVenu")]
                [Validation(Required=false)]
                public string EVenu { get; set; }

                /// <summary>
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The extended information.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                /// <summary>
                /// <para>The fax country code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("FaxArea")]
                [Validation(Required=false)]
                public string FaxArea { get; set; }

                /// <summary>
                /// <para>The fax extension number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61284565</para>
                /// </summary>
                [NameInMap("FaxExt")]
                [Validation(Required=false)]
                public string FaxExt { get; set; }

                /// <summary>
                /// <para>The fax number with an area code or mobile number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16604121234</para>
                /// </summary>
                [NameInMap("FaxMain")]
                [Validation(Required=false)]
                public string FaxMain { get; set; }

                /// <summary>
                /// <para>The mobile number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>156********</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>The zip code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("Postalcode")]
                [Validation(Required=false)]
                public string Postalcode { get; set; }

                /// <summary>
                /// <para>The contact type. Valid values: 1: individual. 2: enterprise.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RegType")]
                [Validation(Required=false)]
                public int? RegType { get; set; }

                /// <summary>
                /// <para>The registrant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>121000002****</para>
                /// </summary>
                [NameInMap("RegistrantId")]
                [Validation(Required=false)]
                public string RegistrantId { get; set; }

                /// <summary>
                /// <para>The calling code of the country or region where the domain name contact is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("TelArea")]
                [Validation(Required=false)]
                public string TelArea { get; set; }

                /// <summary>
                /// <para>The telephone extension number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61284565</para>
                /// </summary>
                [NameInMap("TelExt")]
                [Validation(Required=false)]
                public string TelExt { get; set; }

                /// <summary>
                /// <para>The landline number with an area code or mobile number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16604121234</para>
                /// </summary>
                [NameInMap("TelMain")]
                [Validation(Required=false)]
                public string TelMain { get; set; }

                /// <summary>
                /// <para>The VSP contact ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>121000001****</para>
                /// </summary>
                [NameInMap("VspContactId")]
                [Validation(Required=false)]
                public string VspContactId { get; set; }

            }

            /// <summary>
            /// <para>The certificate information.</para>
            /// </summary>
            [NameInMap("DomainSpecialBizCredentials")]
            [Validation(Required=false)]
            public List<QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialBizCredentials> DomainSpecialBizCredentials { get; set; }
            public class QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialBizCredentials : TeaModel {
                /// <summary>
                /// <para>The ID of the associated workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T20220831150014000001</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// <para>The certificate number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4111111111111110**</para>
                /// </summary>
                [NameInMap("CredentialNo")]
                [Validation(Required=false)]
                public string CredentialNo { get; set; }

                /// <summary>
                /// <para>The certificate type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SFZ</para>
                /// </summary>
                [NameInMap("CredentialType")]
                [Validation(Required=false)]
                public string CredentialType { get; set; }

                /// <summary>
                /// <para>The certificate URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://test.oss-cn-hangzhou.aliyuncs.com/20170522/1219541161213057_070445190.jpg">http://test.oss-cn-hangzhou.aliyuncs.com/20170522/1219541161213057_070445190.jpg</a></para>
                /// </summary>
                [NameInMap("CredentialUrl")]
                [Validation(Required=false)]
                public string CredentialUrl { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test003.cn</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>Indicates whether the certificate belongs to the registrant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HolderCert")]
                [Validation(Required=false)]
                public int? HolderCert { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S20172315BJ37809</para>
                /// </summary>
                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

            }

            /// <summary>
            /// <para>The information about the order.</para>
            /// </summary>
            [NameInMap("DomainSpecialOrderResult")]
            [Validation(Required=false)]
            public QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialOrderResult DomainSpecialOrderResult { get; set; }
            public class QueryDomainSpecialBizDetailResponseBodyModuleDomainSpecialOrderResult : TeaModel {
                /// <summary>
                /// <para>The cost type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>activate</para>
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// <para>The amount of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("OrderAmount")]
                [Validation(Required=false)]
                public double? OrderAmount { get; set; }

                /// <summary>
                /// <para>The currency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("OrderCurrency")]
                [Validation(Required=false)]
                public string OrderCurrency { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S201601060123456</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The order status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ORDER_WAIT_PAY</para>
                /// </summary>
                [NameInMap("OrderStatus")]
                [Validation(Required=false)]
                public string OrderStatus { get; set; }

                /// <summary>
                /// <para>The time when the order was placed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-19T14:28Z</para>
                /// </summary>
                [NameInMap("OrderTime")]
                [Validation(Required=false)]
                public string OrderTime { get; set; }

                /// <summary>
                /// <para>The validity period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("OrderYear")]
                [Validation(Required=false)]
                public int? OrderYear { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S201601063418719</para>
                /// </summary>
                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

                /// <summary>
                /// <para>The suborder ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S201601061234567</para>
                /// </summary>
                [NameInMap("SubOrderId")]
                [Validation(Required=false)]
                public string SubOrderId { get; set; }

            }

            /// <summary>
            /// <para>The time when the business was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-21 15:10:04.0</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the business was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-21 15:10:04.0</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The primary key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34083</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S20172315BJ37809</para>
            /// </summary>
            [NameInMap("SaleId")]
            [Validation(Required=false)]
            public string SaleId { get; set; }

            /// <summary>
            /// <para>The business status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The description of business status.</para>
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The time when the business was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-17 18:11:15</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121000000****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A83E1D74-E46B-505C-947A-8C6B7E41C011</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Indicates whether to perform synchronous processing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
