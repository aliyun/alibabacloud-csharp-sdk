// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetViberByRequestNoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetViberByRequestNoResponseBodyData Data { get; set; }
        public class GetViberByRequestNoResponseBodyData : TeaModel {
            [NameInMap("AuditRecord")]
            [Validation(Required=false)]
            public GetViberByRequestNoResponseBodyDataAuditRecord AuditRecord { get; set; }
            public class GetViberByRequestNoResponseBodyDataAuditRecord : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>eighteenUp</para>
                /// </summary>
                [NameInMap("AgeLimit")]
                [Validation(Required=false)]
                public string AgeLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aaaa</para>
                /// </summary>
                [NameInMap("BusinessAccountName")]
                [Validation(Required=false)]
                public string BusinessAccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>43645465465</para>
                /// </summary>
                [NameInMap("BusinessLicenseRegistrationNumber")]
                [Validation(Required=false)]
                public string BusinessLicenseRegistrationNumber { get; set; }

                [NameInMap("CompanyAddress")]
                [Validation(Required=false)]
                public List<GetViberByRequestNoResponseBodyDataAuditRecordCompanyAddress> CompanyAddress { get; set; }
                public class GetViberByRequestNoResponseBodyDataAuditRecordCompanyAddress : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>address</para>
                    /// </summary>
                    [NameInMap("CompanyAddress")]
                    [Validation(Required=false)]
                    public string CompanyAddress { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>111</para>
                    /// </summary>
                    [NameInMap("CompanyAddressTitle")]
                    [Validation(Required=false)]
                    public string CompanyAddressTitle { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>english</para>
                /// </summary>
                [NameInMap("CompanyEnglishName")]
                [Validation(Required=false)]
                public string CompanyEnglishName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxxcompany</para>
                /// </summary>
                [NameInMap("CompanyLegalName")]
                [Validation(Required=false)]
                public string CompanyLegalName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>jack</para>
                /// </summary>
                [NameInMap("CompanyLegalPerson")]
                [Validation(Required=false)]
                public string CompanyLegalPerson { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>new</para>
                /// </summary>
                [NameInMap("CompanyProfile")]
                [Validation(Required=false)]
                public string CompanyProfile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>beijing</para>
                /// </summary>
                [NameInMap("CompanyRegisteredCountry")]
                [Validation(Required=false)]
                public string CompanyRegisteredCountry { get; set; }

                [NameInMap("CompanyTel")]
                [Validation(Required=false)]
                public List<GetViberByRequestNoResponseBodyDataAuditRecordCompanyTel> CompanyTel { get; set; }
                public class GetViberByRequestNoResponseBodyDataAuditRecordCompanyTel : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>134213213</para>
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
                /// <para>address</para>
                /// </summary>
                [NameInMap("CompleteAddressOfHeadquarters")]
                [Validation(Required=false)]
                public string CompleteAddressOfHeadquarters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("ContactMail")]
                [Validation(Required=false)]
                public string ContactMail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>N</para>
                /// </summary>
                [NameInMap("EnableAutoReply")]
                [Validation(Required=false)]
                public string EnableAutoReply { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("IndustryDescription")]
                [Validation(Required=false)]
                public string IndustryDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cateringServices</para>
                /// </summary>
                [NameInMap("IndustryInvolved")]
                [Validation(Required=false)]
                public string IndustryInvolved { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxxxxxxxxx">https://xxxxxxxxxx</a></para>
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
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("MessageDialogueIntroduction")]
                [Validation(Required=false)]
                public string MessageDialogueIntroduction { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-08-05</para>
                /// </summary>
                [NameInMap("MessageEnableDate")]
                [Validation(Required=false)]
                public string MessageEnableDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("MessageSessionName")]
                [Validation(Required=false)]
                public string MessageSessionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NowRecovery</para>
                /// </summary>
                [NameInMap("NowRecovery")]
                [Validation(Required=false)]
                public string NowRecovery { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://wwwxxxx">https://wwwxxxx</a></para>
                /// </summary>
                [NameInMap("OtherLetterGuarantee")]
                [Validation(Required=false)]
                public string OtherLetterGuarantee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-11-11</para>
                /// </summary>
                [NameInMap("RecoveryDate")]
                [Validation(Required=false)]
                public string RecoveryDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("ReplyContent")]
                [Validation(Required=false)]
                public string ReplyContent { get; set; }

                /// <summary>
                /// <para>SuspensionDate</para>
                /// 
                /// <b>Example:</b>
                /// <para>SuspensionDate</para>
                /// </summary>
                [NameInMap("SuspensionDate")]
                [Validation(Required=false)]
                public string SuspensionDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxxxxx">https://xxxxxx</a></para>
                /// </summary>
                [NameInMap("WebAddress")]
                [Validation(Required=false)]
                public string WebAddress { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("AuditResult")]
            [Validation(Required=false)]
            public string AuditResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1785465</para>
            /// </summary>
            [NameInMap("AuditTime")]
            [Validation(Required=false)]
            public string AuditTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1753236426000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17833636</para>
            /// </summary>
            [NameInMap("GmtModifier")]
            [Validation(Required=false)]
            public string GmtModifier { get; set; }

            /// <summary>
            /// <para>ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>735221</para>
            /// </summary>
            [NameInMap("MaapServiceNo")]
            [Validation(Required=false)]
            public string MaapServiceNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aa</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5435435435</para>
            /// </summary>
            [NameInMap("RequestNo")]
            [Validation(Required=false)]
            public string RequestNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>viberOpen</para>
            /// </summary>
            [NameInMap("RequestType")]
            [Validation(Required=false)]
            public string RequestType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4534**</para>
            /// </summary>
            [NameInMap("SubscriberCode")]
            [Validation(Required=false)]
            public string SubscriberCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8**9-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
