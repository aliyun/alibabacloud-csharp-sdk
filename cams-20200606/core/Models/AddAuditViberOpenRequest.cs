// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class AddAuditViberOpenRequest : TeaModel {
        [NameInMap("AuditRecord")]
        [Validation(Required=false)]
        public AddAuditViberOpenRequestAuditRecord AuditRecord { get; set; }
        public class AddAuditViberOpenRequestAuditRecord : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AgeLimit")]
            [Validation(Required=false)]
            public string AgeLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("BusinessAccountName")]
            [Validation(Required=false)]
            public string BusinessAccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("BusinessLicenseRegistrationNumber")]
            [Validation(Required=false)]
            public string BusinessLicenseRegistrationNumber { get; set; }

            [NameInMap("CompanyAddress")]
            [Validation(Required=false)]
            public List<AddAuditViberOpenRequestAuditRecordCompanyAddress> CompanyAddress { get; set; }
            public class AddAuditViberOpenRequestAuditRecordCompanyAddress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>address</para>
                /// </summary>
                [NameInMap("CompanyAddress")]
                [Validation(Required=false)]
                public string CompanyAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("CompanyAddressTitle")]
                [Validation(Required=false)]
                public string CompanyAddressTitle { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7Pj6</para>
            /// </summary>
            [NameInMap("CompanyEnglishName")]
            [Validation(Required=false)]
            public string CompanyEnglishName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("CompanyLegalName")]
            [Validation(Required=false)]
            public string CompanyLegalName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jerry</para>
            /// </summary>
            [NameInMap("CompanyLegalPerson")]
            [Validation(Required=false)]
            public string CompanyLegalPerson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CompanyProfile</para>
            /// </summary>
            [NameInMap("CompanyProfile")]
            [Validation(Required=false)]
            public string CompanyProfile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("CompanyRegisteredCountry")]
            [Validation(Required=false)]
            public string CompanyRegisteredCountry { get; set; }

            [NameInMap("CompanyTel")]
            [Validation(Required=false)]
            public List<AddAuditViberOpenRequestAuditRecordCompanyTel> CompanyTel { get; set; }
            public class AddAuditViberOpenRequestAuditRecordCompanyTel : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>156********</para>
                /// </summary>
                [NameInMap("CompanyTelNumber")]
                [Validation(Required=false)]
                public string CompanyTelNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("CompanyTelTitle")]
                [Validation(Required=false)]
                public string CompanyTelTitle { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("CompleteAddressOfHeadquarters")]
            [Validation(Required=false)]
            public string CompleteAddressOfHeadquarters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:123@123.com">123@123.com</a></para>
            /// </summary>
            [NameInMap("ContactMail")]
            [Validation(Required=false)]
            public string ContactMail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("EnableAutoReply")]
            [Validation(Required=false)]
            public string EnableAutoReply { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("IndustryDescription")]
            [Validation(Required=false)]
            public string IndustryDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NFUwytiBnm11</para>
            /// </summary>
            [NameInMap("IndustryInvolved")]
            [Validation(Required=false)]
            public string IndustryInvolved { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tiCaYNHR8ttt</para>
            /// </summary>
            [NameInMap("LetterGuarantee")]
            [Validation(Required=false)]
            public string LetterGuarantee { get; set; }

            [NameInMap("Logo")]
            [Validation(Required=false)]
            public List<string> Logo { get; set; }

            [NameInMap("MessageDestinationCountry")]
            [Validation(Required=false)]
            public List<string> MessageDestinationCountry { get; set; }

            [NameInMap("MessageDestinationInternationalCountry")]
            [Validation(Required=false)]
            public List<string> MessageDestinationInternationalCountry { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("MessageDialogueIntroduction")]
            [Validation(Required=false)]
            public string MessageDialogueIntroduction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("MessageEnableDate")]
            [Validation(Required=false)]
            public string MessageEnableDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nPHK8uaRo</para>
            /// </summary>
            [NameInMap("MessageSessionName")]
            [Validation(Required=false)]
            public string MessageSessionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("OtherLetterGuarantee")]
            [Validation(Required=false)]
            public string OtherLetterGuarantee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("ReplyContent")]
            [Validation(Required=false)]
            public string ReplyContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("WebAddress")]
            [Validation(Required=false)]
            public string WebAddress { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("AuditResult")]
        [Validation(Required=false)]
        public string AuditResult { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
