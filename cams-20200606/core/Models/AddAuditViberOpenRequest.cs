// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class AddAuditViberOpenRequest : TeaModel {
        /// <summary>
        /// <para>The audit record.</para>
        /// </summary>
        [NameInMap("AuditRecord")]
        [Validation(Required=false)]
        public AddAuditViberOpenRequestAuditRecord AuditRecord { get; set; }
        public class AddAuditViberOpenRequestAuditRecord : TeaModel {
            /// <summary>
            /// <para>The age limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("AgeLimit")]
            [Validation(Required=false)]
            public string AgeLimit { get; set; }

            /// <summary>
            /// <para>The name of the business account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("BusinessAccountName")]
            [Validation(Required=false)]
            public string BusinessAccountName { get; set; }

            /// <summary>
            /// <para>The registration number of the business license.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("BusinessLicenseRegistrationNumber")]
            [Validation(Required=false)]
            public string BusinessLicenseRegistrationNumber { get; set; }

            /// <summary>
            /// <para>A list of company addresses.</para>
            /// </summary>
            [NameInMap("CompanyAddress")]
            [Validation(Required=false)]
            public List<AddAuditViberOpenRequestAuditRecordCompanyAddress> CompanyAddress { get; set; }
            public class AddAuditViberOpenRequestAuditRecordCompanyAddress : TeaModel {
                /// <summary>
                /// <para>The company address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>address</para>
                /// </summary>
                [NameInMap("CompanyAddress")]
                [Validation(Required=false)]
                public string CompanyAddress { get; set; }

                /// <summary>
                /// <para>The title of the company address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("CompanyAddressTitle")]
                [Validation(Required=false)]
                public string CompanyAddressTitle { get; set; }

            }

            /// <summary>
            /// <para>The English name of the company.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7Pj6</para>
            /// </summary>
            [NameInMap("CompanyEnglishName")]
            [Validation(Required=false)]
            public string CompanyEnglishName { get; set; }

            /// <summary>
            /// <para>The legal name of the company.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("CompanyLegalName")]
            [Validation(Required=false)]
            public string CompanyLegalName { get; set; }

            /// <summary>
            /// <para>The legal representative of the company.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jerry</para>
            /// </summary>
            [NameInMap("CompanyLegalPerson")]
            [Validation(Required=false)]
            public string CompanyLegalPerson { get; set; }

            /// <summary>
            /// <para>The company profile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CompanyProfile</para>
            /// </summary>
            [NameInMap("CompanyProfile")]
            [Validation(Required=false)]
            public string CompanyProfile { get; set; }

            /// <summary>
            /// <para>The country where the company is registered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("CompanyRegisteredCountry")]
            [Validation(Required=false)]
            public string CompanyRegisteredCountry { get; set; }

            /// <summary>
            /// <para>A list of company phone number objects.</para>
            /// </summary>
            [NameInMap("CompanyTel")]
            [Validation(Required=false)]
            public List<AddAuditViberOpenRequestAuditRecordCompanyTel> CompanyTel { get; set; }
            public class AddAuditViberOpenRequestAuditRecordCompanyTel : TeaModel {
                /// <summary>
                /// <para>The company phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>156********</para>
                /// </summary>
                [NameInMap("CompanyTelNumber")]
                [Validation(Required=false)]
                public string CompanyTelNumber { get; set; }

                /// <summary>
                /// <para>The title of the company phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("CompanyTelTitle")]
                [Validation(Required=false)]
                public string CompanyTelTitle { get; set; }

            }

            /// <summary>
            /// <para>The complete address of the headquarters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("CompleteAddressOfHeadquarters")]
            [Validation(Required=false)]
            public string CompleteAddressOfHeadquarters { get; set; }

            /// <summary>
            /// <para>The email address of the contact person.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7151***<a href="mailto:5@qq.com">5@qq.com</a></para>
            /// </summary>
            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:123@123.com">123@123.com</a></para>
            /// </summary>
            [NameInMap("ContactMail")]
            [Validation(Required=false)]
            public string ContactMail { get; set; }

            /// <summary>
            /// <para>The name of the contact person.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mary</para>
            /// </summary>
            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The phone number of the contact person.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8615115**777</para>
            /// </summary>
            [NameInMap("ContactPhone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            /// <summary>
            /// <para>The position of the contact person.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("ContactPosition")]
            [Validation(Required=false)]
            public string ContactPosition { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-reply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("EnableAutoReply")]
            [Validation(Required=false)]
            public string EnableAutoReply { get; set; }

            /// <summary>
            /// <para>A description of the industry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("IndustryDescription")]
            [Validation(Required=false)]
            public string IndustryDescription { get; set; }

            /// <summary>
            /// <para>The industry involved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NFUwytiBnm11</para>
            /// </summary>
            [NameInMap("IndustryInvolved")]
            [Validation(Required=false)]
            public string IndustryInvolved { get; set; }

            /// <summary>
            /// <para>The letter of guarantee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tiCaYNHR8ttt</para>
            /// </summary>
            [NameInMap("LetterGuarantee")]
            [Validation(Required=false)]
            public string LetterGuarantee { get; set; }

            /// <summary>
            /// <para>A list of logos.</para>
            /// </summary>
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public List<string> Logo { get; set; }

            /// <summary>
            /// <para>A list of destination countries/regions for messages.</para>
            /// </summary>
            [NameInMap("MessageDestinationCountry")]
            [Validation(Required=false)]
            public List<string> MessageDestinationCountry { get; set; }

            /// <summary>
            /// <para>A list of destination countries/regions for international messages.</para>
            /// </summary>
            [NameInMap("MessageDestinationInternationalCountry")]
            [Validation(Required=false)]
            public List<string> MessageDestinationInternationalCountry { get; set; }

            /// <summary>
            /// <para>The introduction in the message dialog box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("MessageDialogueIntroduction")]
            [Validation(Required=false)]
            public string MessageDialogueIntroduction { get; set; }

            /// <summary>
            /// <para>The date when messaging is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("MessageEnableDate")]
            [Validation(Required=false)]
            public string MessageEnableDate { get; set; }

            /// <summary>
            /// <para>The name of the message session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nPHK8uaRo</para>
            /// </summary>
            [NameInMap("MessageSessionName")]
            [Validation(Required=false)]
            public string MessageSessionName { get; set; }

            /// <summary>
            /// <para>Other letters of guarantee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("OtherLetterGuarantee")]
            [Validation(Required=false)]
            public string OtherLetterGuarantee { get; set; }

            /// <summary>
            /// <para>The content of the reply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("ReplyContent")]
            [Validation(Required=false)]
            public string ReplyContent { get; set; }

            /// <summary>
            /// <para>The website address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("WebAddress")]
            [Validation(Required=false)]
            public string WebAddress { get; set; }

        }

        /// <summary>
        /// <para>The audit result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("AuditResult")]
        [Validation(Required=false)]
        public string AuditResult { get; set; }

        /// <summary>
        /// <para>The Space ID of the ISV sub-customer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1651322271196729</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:testuser@testdomain.co">testuser@testdomain.co</a></para>
        /// </summary>
        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1754580903499898</para>
        /// </summary>
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
