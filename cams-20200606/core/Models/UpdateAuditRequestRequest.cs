// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateAuditRequestRequest : TeaModel {
        /// <summary>
        /// <para>Viber audit items.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AuditRecord")]
        [Validation(Required=false)]
        public UpdateAuditRequestRequestAuditRecord AuditRecord { get; set; }
        public class UpdateAuditRequestRequestAuditRecord : TeaModel {
            /// <summary>
            /// <para>Age limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>unlimited</para>
            /// </summary>
            [NameInMap("AgeLimit")]
            [Validation(Required=false)]
            public string AgeLimit { get; set; }

            /// <summary>
            /// <para>Application reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reason</para>
            /// </summary>
            [NameInMap("ApplyReason")]
            [Validation(Required=false)]
            public string ApplyReason { get; set; }

            /// <summary>
            /// <para>Business account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testaccount</para>
            /// </summary>
            [NameInMap("BusinessAccountName")]
            [Validation(Required=false)]
            public string BusinessAccountName { get; set; }

            /// <summary>
            /// <para>Business license registration number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9211515**345</para>
            /// </summary>
            [NameInMap("BusinessLicenseRegistrationNumber")]
            [Validation(Required=false)]
            public string BusinessLicenseRegistrationNumber { get; set; }

            /// <summary>
            /// <para>Company addresses.</para>
            /// </summary>
            [NameInMap("CompanyAddress")]
            [Validation(Required=false)]
            public List<UpdateAuditRequestRequestAuditRecordCompanyAddress> CompanyAddress { get; set; }
            public class UpdateAuditRequestRequestAuditRecordCompanyAddress : TeaModel {
                /// <summary>
                /// <para>Company address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123 Sunshine Street, City, Country</para>
                /// </summary>
                [NameInMap("CompanyAddress")]
                [Validation(Required=false)]
                public string CompanyAddress { get; set; }

                /// <summary>
                /// <para>Company address title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx company</para>
                /// </summary>
                [NameInMap("CompanyAddressTitle")]
                [Validation(Required=false)]
                public string CompanyAddressTitle { get; set; }

            }

            /// <summary>
            /// <para>Company English name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>baidu</para>
            /// </summary>
            [NameInMap("CompanyEnglishName")]
            [Validation(Required=false)]
            public string CompanyEnglishName { get; set; }

            /// <summary>
            /// <para>Company legal name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("CompanyLegalName")]
            [Validation(Required=false)]
            public string CompanyLegalName { get; set; }

            /// <summary>
            /// <para>Company legal person name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("CompanyLegalPerson")]
            [Validation(Required=false)]
            public string CompanyLegalPerson { get; set; }

            /// <summary>
            /// <para>Company profile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CompanyProfile")]
            [Validation(Required=false)]
            public string CompanyProfile { get; set; }

            /// <summary>
            /// <para>Company registered country or region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("CompanyRegisteredCountry")]
            [Validation(Required=false)]
            public string CompanyRegisteredCountry { get; set; }

            /// <summary>
            /// <para>Company phone numbers.</para>
            /// </summary>
            [NameInMap("CompanyTel")]
            [Validation(Required=false)]
            public List<UpdateAuditRequestRequestAuditRecordCompanyTel> CompanyTel { get; set; }
            public class UpdateAuditRequestRequestAuditRecordCompanyTel : TeaModel {
                /// <summary>
                /// <para>Company phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>07364245xxxx</para>
                /// </summary>
                [NameInMap("CompanyTelNumber")]
                [Validation(Required=false)]
                public string CompanyTelNumber { get; set; }

                /// <summary>
                /// <para>Phone number title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("CompanyTelTitle")]
                [Validation(Required=false)]
                public string CompanyTelTitle { get; set; }

            }

            /// <summary>
            /// <para>Complete address of headquarters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxstreet</para>
            /// </summary>
            [NameInMap("CompleteAddressOfHeadquarters")]
            [Validation(Required=false)]
            public string CompleteAddressOfHeadquarters { get; set; }

            /// <summary>
            /// <para>Contact mailbox.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5**<a href="mailto:8585@gmail.com">8585@gmail.com</a></para>
            /// </summary>
            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <para>Contact mailbox.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxx@gamil.com">xxxx@gamil.com</a></para>
            /// </summary>
            [NameInMap("ContactMail")]
            [Validation(Required=false)]
            public string ContactMail { get; set; }

            /// <summary>
            /// <para>Contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mary</para>
            /// </summary>
            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>Contact phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>861515115***</para>
            /// </summary>
            [NameInMap("ContactPhone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            /// <summary>
            /// <para>Contact position.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job</para>
            /// </summary>
            [NameInMap("ContactPosition")]
            [Validation(Required=false)]
            public string ContactPosition { get; set; }

            /// <summary>
            /// <para>Enable auto-reply (this field is deprecated).</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A‌</para>
            /// </summary>
            [NameInMap("EnableAutoReply")]
            [Validation(Required=false)]
            public string EnableAutoReply { get; set; }

            /// <summary>
            /// <para>Industry description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("IndustryDescription")]
            [Validation(Required=false)]
            public string IndustryDescription { get; set; }

            /// <summary>
            /// <para>Industry involved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>telecommunicationsAndIT</para>
            /// </summary>
            [NameInMap("IndustryInvolved")]
            [Validation(Required=false)]
            public string IndustryInvolved { get; set; }

            /// <summary>
            /// <para>Letter of guarantee (download address).</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.xxx.xxx">https://xxx.xxx.xxx</a></para>
            /// </summary>
            [NameInMap("LetterGuarantee")]
            [Validation(Required=false)]
            public string LetterGuarantee { get; set; }

            /// <summary>
            /// <para>Logo</para>
            /// </summary>
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public List<string> Logo { get; set; }

            /// <summary>
            /// <para>Local destination countries or regions.</para>
            /// </summary>
            [NameInMap("MessageDestinationCountry")]
            [Validation(Required=false)]
            public List<string> MessageDestinationCountry { get; set; }

            /// <summary>
            /// <para>International destination countries and regions.</para>
            /// </summary>
            [NameInMap("MessageDestinationInternationalCountry")]
            [Validation(Required=false)]
            public List<string> MessageDestinationInternationalCountry { get; set; }

            /// <summary>
            /// <para>Commercial message dialogue introduction.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello!</para>
            /// </summary>
            [NameInMap("MessageDialogueIntroduction")]
            [Validation(Required=false)]
            public string MessageDialogueIntroduction { get; set; }

            /// <summary>
            /// <para>Commercial message enable date (GMT).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-07</para>
            /// </summary>
            [NameInMap("MessageEnableDate")]
            [Validation(Required=false)]
            public string MessageEnableDate { get; set; }

            /// <summary>
            /// <para>Commercial message dialogue name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MessageSessionName")]
            [Validation(Required=false)]
            public string MessageSessionName { get; set; }

            /// <summary>
            /// <para>Supplementary material address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.xxx.com">https://xxx.xxx.com</a></para>
            /// </summary>
            [NameInMap("OtherLetterGuarantee")]
            [Validation(Required=false)]
            public string OtherLetterGuarantee { get; set; }

            /// <summary>
            /// <para>Recovery date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-07</para>
            /// </summary>
            [NameInMap("RecoveryDate")]
            [Validation(Required=false)]
            public string RecoveryDate { get; set; }

            /// <summary>
            /// <para>Reply content (deprecated).</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("ReplyContent")]
            [Validation(Required=false)]
            public string ReplyContent { get; set; }

            /// <summary>
            /// <para>Deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("SuspensionDate")]
            [Validation(Required=false)]
            public string SuspensionDate { get; set; }

            /// <summary>
            /// <para>Company website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.xxx.xxx.com">https://www.xxx.xxx.com</a></para>
            /// </summary>
            [NameInMap("WebAddress")]
            [Validation(Required=false)]
            public string WebAddress { get; set; }

        }

        /// <summary>
        /// <para>The audit result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unAudit</para>
        /// </summary>
        [NameInMap("AuditResult")]
        [Validation(Required=false)]
        public string AuditResult { get; set; }

        /// <summary>
        /// <para>The Space ID of the ISV sub-customer or the instance ID. View it on the <a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8pi**urn5s</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1500111740532860</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The request number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114624518**5956096</para>
        /// </summary>
        [NameInMap("RequestNo")]
        [Validation(Required=false)]
        public string RequestNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:user1@example.com">user1@example.com</a>&quot;</para>
        /// </summary>
        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1577495724967111</para>
        /// </summary>
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
