// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetAuditRequestByTypeUnAuditResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>OK indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAuditRequestByTypeUnAuditResponseBodyData Data { get; set; }
        public class GetAuditRequestByTypeUnAuditResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21432</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The audit data.</para>
            /// </summary>
            [NameInMap("AuditRecord")]
            [Validation(Required=false)]
            public GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecord AuditRecord { get; set; }
            public class GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecord : TeaModel {
                /// <summary>
                /// <para>The age limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eighteenUp</para>
                /// </summary>
                [NameInMap("AgeLimit")]
                [Validation(Required=false)]
                public string AgeLimit { get; set; }

                /// <summary>
                /// <para>The application reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bnv</para>
                /// </summary>
                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                /// <summary>
                /// <para>The business account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("BusinessAccountName")]
                [Validation(Required=false)]
                public string BusinessAccountName { get; set; }

                /// <summary>
                /// <para>The company addresses.</para>
                /// </summary>
                [NameInMap("CompanyAddress")]
                [Validation(Required=false)]
                public List<GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecordCompanyAddress> CompanyAddress { get; set; }
                public class GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecordCompanyAddress : TeaModel {
                    /// <summary>
                    /// <para>The company addresses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxxxcompany</para>
                    /// </summary>
                    [NameInMap("CompanyAddress")]
                    [Validation(Required=false)]
                    public string CompanyAddress { get; set; }

                    /// <summary>
                    /// <para>The address title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>111</para>
                    /// </summary>
                    [NameInMap("CompanyAddressTitle")]
                    [Validation(Required=false)]
                    public string CompanyAddressTitle { get; set; }

                }

                /// <summary>
                /// <para>The English name of the company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Company English Name</para>
                /// </summary>
                [NameInMap("CompanyEnglishName")]
                [Validation(Required=false)]
                public string CompanyEnglishName { get; set; }

                /// <summary>
                /// <para>The legal name of the company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxcompany</para>
                /// </summary>
                [NameInMap("CompanyLegalName")]
                [Validation(Required=false)]
                public string CompanyLegalName { get; set; }

                /// <summary>
                /// <para>The name of the legal representative of the company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jack</para>
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
                /// </summary>
                [NameInMap("CompanyRegisteredCountry")]
                [Validation(Required=false)]
                public List<string> CompanyRegisteredCountry { get; set; }

                /// <summary>
                /// <para>The company phone numbers.</para>
                /// </summary>
                [NameInMap("CompanyTel")]
                [Validation(Required=false)]
                public List<GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecordCompanyTel> CompanyTel { get; set; }
                public class GetAuditRequestByTypeUnAuditResponseBodyDataAuditRecordCompanyTel : TeaModel {
                    /// <summary>
                    /// <para>The company phone numbers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>143243**</para>
                    /// </summary>
                    [NameInMap("CompanyTelNumber")]
                    [Validation(Required=false)]
                    public string CompanyTelNumber { get; set; }

                    /// <summary>
                    /// <para>The company phone title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example</para>
                    /// </summary>
                    [NameInMap("CompanyTelTitle")]
                    [Validation(Required=false)]
                    public string CompanyTelTitle { get; set; }

                }

                /// <summary>
                /// <para>The company email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:qqemail@gmail.com">qqemail@gmail.com</a></para>
                /// </summary>
                [NameInMap("ContactMail")]
                [Validation(Required=false)]
                public string ContactMail { get; set; }

                /// <summary>
                /// <para>Indicates whether auto-reply is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>N</para>
                /// </summary>
                [NameInMap("EnableAutoReply")]
                [Validation(Required=false)]
                public string EnableAutoReply { get; set; }

                /// <summary>
                /// <para>The industry description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("IndustryDescription")]
                [Validation(Required=false)]
                public string IndustryDescription { get; set; }

                /// <summary>
                /// <para>The industry involved.</para>
                /// 
                /// <b>Example:</b>
                /// <para>it</para>
                /// </summary>
                [NameInMap("IndustryInvolved")]
                [Validation(Required=false)]
                public string IndustryInvolved { get; set; }

                /// <summary>
                /// <para>The URL of the letter of guarantee.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.xxxxxxx">https://www.xxxxxxx</a></para>
                /// </summary>
                [NameInMap("LetterGuarantee")]
                [Validation(Required=false)]
                public string LetterGuarantee { get; set; }

                /// <summary>
                /// <para>The collection of logo URLs.</para>
                /// </summary>
                [NameInMap("Logo")]
                [Validation(Required=false)]
                public List<string> Logo { get; set; }

                /// <summary>
                /// <para>The local destination country or region.</para>
                /// </summary>
                [NameInMap("MessageDestinationCountry")]
                [Validation(Required=false)]
                public List<string> MessageDestinationCountry { get; set; }

                /// <summary>
                /// <para>The international destination countries or regions.</para>
                /// </summary>
                [NameInMap("MessageDestinationInternationalCountry")]
                [Validation(Required=false)]
                public List<string> MessageDestinationInternationalCountry { get; set; }

                /// <summary>
                /// <para>The business message introduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MessageDialogueIntroduction</para>
                /// </summary>
                [NameInMap("MessageDialogueIntroduction")]
                [Validation(Required=false)]
                public string MessageDialogueIntroduction { get; set; }

                /// <summary>
                /// <para>The date when business messaging is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-11-01</para>
                /// </summary>
                [NameInMap("MessageEnableDate")]
                [Validation(Required=false)]
                public string MessageEnableDate { get; set; }

                /// <summary>
                /// <para>The business message session name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Message Session Name</para>
                /// </summary>
                [NameInMap("MessageSessionName")]
                [Validation(Required=false)]
                public string MessageSessionName { get; set; }

                /// <summary>
                /// <para>The suspension status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n</para>
                /// </summary>
                [NameInMap("NowRecovery")]
                [Validation(Required=false)]
                public string NowRecovery { get; set; }

                /// <summary>
                /// <para>The recovery date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-111-06</para>
                /// </summary>
                [NameInMap("RecoveryDate")]
                [Validation(Required=false)]
                public string RecoveryDate { get; set; }

                /// <summary>
                /// <para>The reply content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaaqq</para>
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
                /// <para>The company website URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.xxxxx">www.xxxxx</a></para>
                /// </summary>
                [NameInMap("WebAddress")]
                [Validation(Required=false)]
                public string WebAddress { get; set; }

            }

            /// <summary>
            /// <para>The audit result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("AuditResult")]
            [Validation(Required=false)]
            public string AuditResult { get; set; }

            /// <summary>
            /// <para>The audit time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250106</para>
            /// </summary>
            [NameInMap("AuditTime")]
            [Validation(Required=false)]
            public string AuditTime { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1789200</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20251624</para>
            /// </summary>
            [NameInMap("GmtModifier")]
            [Validation(Required=false)]
            public string GmtModifier { get; set; }

            /// <summary>
            /// <para>ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The Viber service number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>475646</para>
            /// </summary>
            [NameInMap("MaapServiceNo")]
            [Validation(Required=false)]
            public string MaapServiceNo { get; set; }

            /// <summary>
            /// <para>The modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The request number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45345435435</para>
            /// </summary>
            [NameInMap("RequestNo")]
            [Validation(Required=false)]
            public string RequestNo { get; set; }

            /// <summary>
            /// <para>The request type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>viber_open</para>
            /// </summary>
            [NameInMap("RequestType")]
            [Validation(Required=false)]
            public string RequestType { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The subscriber code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>345436456546</para>
            /// </summary>
            [NameInMap("SubscriberCode")]
            [Validation(Required=false)]
            public string SubscriberCode { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID generated by Alibaba Cloud for this request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A9486***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Successful.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
