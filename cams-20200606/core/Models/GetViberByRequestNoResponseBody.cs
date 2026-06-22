// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetViberByRequestNoResponseBody : TeaModel {
        /// <summary>
        /// <para>Access denial details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para><c>OK</c>: The request was successful.</para>
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
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetViberByRequestNoResponseBodyData Data { get; set; }
        public class GetViberByRequestNoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The audit record details.</para>
            /// </summary>
            [NameInMap("AuditRecord")]
            [Validation(Required=false)]
            public GetViberByRequestNoResponseBodyDataAuditRecord AuditRecord { get; set; }
            public class GetViberByRequestNoResponseBodyDataAuditRecord : TeaModel {
                /// <summary>
                /// <para>The age restriction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eighteenUp</para>
                /// </summary>
                [NameInMap("AgeLimit")]
                [Validation(Required=false)]
                public string AgeLimit { get; set; }

                /// <summary>
                /// <para>The reason for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                /// <summary>
                /// <para>The name of the business account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaaa</para>
                /// </summary>
                [NameInMap("BusinessAccountName")]
                [Validation(Required=false)]
                public string BusinessAccountName { get; set; }

                /// <summary>
                /// <para>The business license registration number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43645465465</para>
                /// </summary>
                [NameInMap("BusinessLicenseRegistrationNumber")]
                [Validation(Required=false)]
                public string BusinessLicenseRegistrationNumber { get; set; }

                /// <summary>
                /// <para>The company addresses.</para>
                /// </summary>
                [NameInMap("CompanyAddress")]
                [Validation(Required=false)]
                public List<GetViberByRequestNoResponseBodyDataAuditRecordCompanyAddress> CompanyAddress { get; set; }
                public class GetViberByRequestNoResponseBodyDataAuditRecordCompanyAddress : TeaModel {
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
                /// <para>english</para>
                /// </summary>
                [NameInMap("CompanyEnglishName")]
                [Validation(Required=false)]
                public string CompanyEnglishName { get; set; }

                /// <summary>
                /// <para>The legal name of the company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxxcompany</para>
                /// </summary>
                [NameInMap("CompanyLegalName")]
                [Validation(Required=false)]
                public string CompanyLegalName { get; set; }

                /// <summary>
                /// <para>The name of the company\&quot;s legal representative.</para>
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
                /// <para>new</para>
                /// </summary>
                [NameInMap("CompanyProfile")]
                [Validation(Required=false)]
                public string CompanyProfile { get; set; }

                /// <summary>
                /// <para>The country or region where the company is registered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>beijing</para>
                /// </summary>
                [NameInMap("CompanyRegisteredCountry")]
                [Validation(Required=false)]
                public string CompanyRegisteredCountry { get; set; }

                /// <summary>
                /// <para>The company telephone numbers.</para>
                /// </summary>
                [NameInMap("CompanyTel")]
                [Validation(Required=false)]
                public List<GetViberByRequestNoResponseBodyDataAuditRecordCompanyTel> CompanyTel { get; set; }
                public class GetViberByRequestNoResponseBodyDataAuditRecordCompanyTel : TeaModel {
                    /// <summary>
                    /// <para>The company telephone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>134213213</para>
                    /// </summary>
                    [NameInMap("CompanyTelNumber")]
                    [Validation(Required=false)]
                    public string CompanyTelNumber { get; set; }

                    /// <summary>
                    /// <para>The title for the telephone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("CompanyTelTitle")]
                    [Validation(Required=false)]
                    public string CompanyTelTitle { get; set; }

                }

                /// <summary>
                /// <para>The complete address of the company\&quot;s headquarters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>address</para>
                /// </summary>
                [NameInMap("CompleteAddressOfHeadquarters")]
                [Validation(Required=false)]
                public string CompleteAddressOfHeadquarters { get; set; }

                /// <summary>
                /// <para>The contact person\&quot;s email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6944**@gmail.com</para>
                /// </summary>
                [NameInMap("ContactEmail")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                /// <summary>
                /// <para>The contact email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("ContactMail")]
                [Validation(Required=false)]
                public string ContactMail { get; set; }

                /// <summary>
                /// <para>The contact person\&quot;s name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwq</para>
                /// </summary>
                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>The contact person\&quot;s phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>861151515***</para>
                /// </summary>
                [NameInMap("ContactPhone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                /// <summary>
                /// <para>The contact person\&quot;s position.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("ContactPosition")]
                [Validation(Required=false)]
                public string ContactPosition { get; set; }

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
                /// <para>A description of the industry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("IndustryDescription")]
                [Validation(Required=false)]
                public string IndustryDescription { get; set; }

                /// <summary>
                /// <para>The company\&quot;s industry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cateringServices</para>
                /// </summary>
                [NameInMap("IndustryInvolved")]
                [Validation(Required=false)]
                public string IndustryInvolved { get; set; }

                /// <summary>
                /// <para>The URL of the letter of guarantee.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxxxxxxxx">https://xxxxxxxxxx</a></para>
                /// </summary>
                [NameInMap("LetterGuarantee")]
                [Validation(Required=false)]
                public string LetterGuarantee { get; set; }

                /// <summary>
                /// <para>The logo URLs.</para>
                /// </summary>
                [NameInMap("Logo")]
                [Validation(Required=false)]
                public List<string> Logo { get; set; }

                /// <summary>
                /// <para>The local destination countries or regions.</para>
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
                /// <para>A brief introduction to the business messaging conversation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("MessageDialogueIntroduction")]
                [Validation(Required=false)]
                public string MessageDialogueIntroduction { get; set; }

                /// <summary>
                /// <para>The date business messaging is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-08-05</para>
                /// </summary>
                [NameInMap("MessageEnableDate")]
                [Validation(Required=false)]
                public string MessageEnableDate { get; set; }

                /// <summary>
                /// <para>The name of the business messaging conversation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("MessageSessionName")]
                [Validation(Required=false)]
                public string MessageSessionName { get; set; }

                /// <summary>
                /// <para>The recovery status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NowRecovery</para>
                /// </summary>
                [NameInMap("NowRecovery")]
                [Validation(Required=false)]
                public string NowRecovery { get; set; }

                /// <summary>
                /// <para>The URL for supplementary information.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://wwwxxxx">https://wwwxxxx</a></para>
                /// </summary>
                [NameInMap("OtherLetterGuarantee")]
                [Validation(Required=false)]
                public string OtherLetterGuarantee { get; set; }

                /// <summary>
                /// <para>The date of recovery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-11-11</para>
                /// </summary>
                [NameInMap("RecoveryDate")]
                [Validation(Required=false)]
                public string RecoveryDate { get; set; }

                /// <summary>
                /// <para>The content of the auto-reply message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("ReplyContent")]
                [Validation(Required=false)]
                public string ReplyContent { get; set; }

                /// <summary>
                /// <para>The suspension date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SuspensionDate</para>
                /// </summary>
                [NameInMap("SuspensionDate")]
                [Validation(Required=false)]
                public string SuspensionDate { get; set; }

                /// <summary>
                /// <para>The company website.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://xxxxxx">https://xxxxxx</a></para>
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
            /// <para>1785465</para>
            /// </summary>
            [NameInMap("AuditTime")]
            [Validation(Required=false)]
            public string AuditTime { get; set; }

            /// <summary>
            /// <para>The creator of the resource.</para>
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
            /// <para>1753236426000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17833636</para>
            /// </summary>
            [NameInMap("GmtModifier")]
            [Validation(Required=false)]
            public string GmtModifier { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The Viber service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>735221</para>
            /// </summary>
            [NameInMap("MaapServiceNo")]
            [Validation(Required=false)]
            public string MaapServiceNo { get; set; }

            /// <summary>
            /// <para>The user who last modified the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <para>The audit comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aa</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The unique number for the application request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5435435435</para>
            /// </summary>
            [NameInMap("RequestNo")]
            [Validation(Required=false)]
            public string RequestNo { get; set; }

            /// <summary>
            /// <para>The type of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>viberOpen</para>
            /// </summary>
            [NameInMap("RequestType")]
            [Validation(Required=false)]
            public string RequestType { get; set; }

            /// <summary>
            /// <para>The status of the request.</para>
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
            /// <para>4534**</para>
            /// </summary>
            [NameInMap("SubscriberCode")]
            [Validation(Required=false)]
            public string SubscriberCode { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID for the request. You can use this Aliyun-generated ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8**9-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
