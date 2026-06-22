// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetAuditRequestByTypeUnAuditResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAuditRequestByTypeUnAuditResponseBodyData Data { get; set; }
        public class GetAuditRequestByTypeUnAuditResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("AuditRecord")]
            [Validation(Required=false)]
            public GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecord AuditRecord { get; set; }
            public class GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecord : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("AgeLimit")]
                [Validation(Required=false)]
                public string AgeLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("BusinessAccountName")]
                [Validation(Required=false)]
                public string BusinessAccountName { get; set; }

                [NameInMap("CompanyAddress")]
                [Validation(Required=false)]
                public List<GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecordCompanyAddress> CompanyAddress { get; set; }
                public class GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecordCompanyAddress : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值示例值</para>
                    /// </summary>
                    [NameInMap("CompanyAddress")]
                    [Validation(Required=false)]
                    public string CompanyAddress { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值示例值</para>
                    /// </summary>
                    [NameInMap("CompanyAddressTitle")]
                    [Validation(Required=false)]
                    public string CompanyAddressTitle { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
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
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("CompanyProfile")]
                [Validation(Required=false)]
                public string CompanyProfile { get; set; }

                [NameInMap("CompanyRegisteredCountry")]
                [Validation(Required=false)]
                public List<string> CompanyRegisteredCountry { get; set; }

                [NameInMap("CompanyTel")]
                [Validation(Required=false)]
                public List<GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecordCompanyTel> CompanyTel { get; set; }
                public class GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecordCompanyTel : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值</para>
                    /// </summary>
                    [NameInMap("CompanyTelNumber")]
                    [Validation(Required=false)]
                    public string CompanyTelNumber { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值</para>
                    /// </summary>
                    [NameInMap("CompanyTelTitle")]
                    [Validation(Required=false)]
                    public string CompanyTelTitle { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("ContactMail")]
                [Validation(Required=false)]
                public string ContactMail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("EnableAutoReply")]
                [Validation(Required=false)]
                public string EnableAutoReply { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("IndustryDescription")]
                [Validation(Required=false)]
                public string IndustryDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("IndustryInvolved")]
                [Validation(Required=false)]
                public string IndustryInvolved { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
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
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("MessageSessionName")]
                [Validation(Required=false)]
                public string MessageSessionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("NowRecovery")]
                [Validation(Required=false)]
                public string NowRecovery { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("RecoveryDate")]
                [Validation(Required=false)]
                public string RecoveryDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("ReplyContent")]
                [Validation(Required=false)]
                public string ReplyContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("SuspensionDate")]
                [Validation(Required=false)]
                public string SuspensionDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("WebAddress")]
                [Validation(Required=false)]
                public string WebAddress { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AuditResult")]
            [Validation(Required=false)]
            public string AuditResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("AuditTime")]
            [Validation(Required=false)]
            public string AuditTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("GmtModifier")]
            [Validation(Required=false)]
            public string GmtModifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("MaapServiceNo")]
            [Validation(Required=false)]
            public string MaapServiceNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("RequestNo")]
            [Validation(Required=false)]
            public string RequestNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("RequestType")]
            [Validation(Required=false)]
            public string RequestType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("SubscriberCode")]
            [Validation(Required=false)]
            public string SubscriberCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
