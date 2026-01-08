// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateAuditRequestRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AuditRecord")]
        [Validation(Required=false)]
        public UpdateAuditRequestRequestAuditRecord AuditRecord { get; set; }
        public class UpdateAuditRequestRequestAuditRecord : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>unlimited</para>
            /// </summary>
            [NameInMap("AgeLimit")]
            [Validation(Required=false)]
            public string AgeLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>reason</para>
            /// </summary>
            [NameInMap("ApplyReason")]
            [Validation(Required=false)]
            public string ApplyReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testaccount</para>
            /// </summary>
            [NameInMap("BusinessAccountName")]
            [Validation(Required=false)]
            public string BusinessAccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9211515**345</para>
            /// </summary>
            [NameInMap("BusinessLicenseRegistrationNumber")]
            [Validation(Required=false)]
            public string BusinessLicenseRegistrationNumber { get; set; }

            [NameInMap("CompanyAddress")]
            [Validation(Required=false)]
            public List<UpdateAuditRequestRequestAuditRecordCompanyAddress> CompanyAddress { get; set; }
            public class UpdateAuditRequestRequestAuditRecordCompanyAddress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123 Sunshine Street, City, Country</para>
                /// </summary>
                [NameInMap("CompanyAddress")]
                [Validation(Required=false)]
                public string CompanyAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx company</para>
                /// </summary>
                [NameInMap("CompanyAddressTitle")]
                [Validation(Required=false)]
                public string CompanyAddressTitle { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>baidu</para>
            /// </summary>
            [NameInMap("CompanyEnglishName")]
            [Validation(Required=false)]
            public string CompanyEnglishName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("CompanyLegalName")]
            [Validation(Required=false)]
            public string CompanyLegalName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("CompanyLegalPerson")]
            [Validation(Required=false)]
            public string CompanyLegalPerson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CompanyProfile")]
            [Validation(Required=false)]
            public string CompanyProfile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("CompanyRegisteredCountry")]
            [Validation(Required=false)]
            public string CompanyRegisteredCountry { get; set; }

            [NameInMap("CompanyTel")]
            [Validation(Required=false)]
            public List<UpdateAuditRequestRequestAuditRecordCompanyTel> CompanyTel { get; set; }
            public class UpdateAuditRequestRequestAuditRecordCompanyTel : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>07364245xxxx</para>
                /// </summary>
                [NameInMap("CompanyTelNumber")]
                [Validation(Required=false)]
                public string CompanyTelNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CompanyTelTitle")]
                [Validation(Required=false)]
                public string CompanyTelTitle { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxstreet</para>
            /// </summary>
            [NameInMap("CompleteAddressOfHeadquarters")]
            [Validation(Required=false)]
            public string CompleteAddressOfHeadquarters { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxx@gamil.com">xxxx@gamil.com</a></para>
            /// </summary>
            [NameInMap("ContactMail")]
            [Validation(Required=false)]
            public string ContactMail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N/A‌</para>
            /// </summary>
            [NameInMap("EnableAutoReply")]
            [Validation(Required=false)]
            public string EnableAutoReply { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("IndustryDescription")]
            [Validation(Required=false)]
            public string IndustryDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>telecommunicationsAndIT</para>
            /// </summary>
            [NameInMap("IndustryInvolved")]
            [Validation(Required=false)]
            public string IndustryInvolved { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("LetterGuarantee")]
            [Validation(Required=false)]
            public string LetterGuarantee { get; set; }

            /// <summary>
            /// <para>logo</para>
            /// </summary>
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
            /// <para>hello!</para>
            /// </summary>
            [NameInMap("MessageDialogueIntroduction")]
            [Validation(Required=false)]
            public string MessageDialogueIntroduction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-11-07</para>
            /// </summary>
            [NameInMap("MessageEnableDate")]
            [Validation(Required=false)]
            public string MessageEnableDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MessageSessionName")]
            [Validation(Required=false)]
            public string MessageSessionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx.xxx.com">https://xxx.xxx.com</a></para>
            /// </summary>
            [NameInMap("OtherLetterGuarantee")]
            [Validation(Required=false)]
            public string OtherLetterGuarantee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-11-07</para>
            /// </summary>
            [NameInMap("RecoveryDate")]
            [Validation(Required=false)]
            public string RecoveryDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("ReplyContent")]
            [Validation(Required=false)]
            public string ReplyContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("SuspensionDate")]
            [Validation(Required=false)]
            public string SuspensionDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.xxx.xxx.com">https://www.xxx.xxx.com</a></para>
            /// </summary>
            [NameInMap("WebAddress")]
            [Validation(Required=false)]
            public string WebAddress { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>unAudit</para>
        /// </summary>
        [NameInMap("AuditResult")]
        [Validation(Required=false)]
        public string AuditResult { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8pi**urn5s</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114624518**5956096</para>
        /// </summary>
        [NameInMap("RequestNo")]
        [Validation(Required=false)]
        public string RequestNo { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
