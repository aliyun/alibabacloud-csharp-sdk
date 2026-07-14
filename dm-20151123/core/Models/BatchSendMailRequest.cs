// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class BatchSendMailRequest : TeaModel {
        /// <summary>
        /// <para>The sender address configured in the management console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.com">test@example.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: random account</description></item>
        /// <item><description>1: sender address.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public int? AddressType { get; set; }

        /// <summary>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Enables data tracking.</description></item>
        /// <item><description>0 (default): Disables data tracking.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ClickTrace")]
        [Validation(Required=false)]
        public string ClickTrace { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable domain-level authentication.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Use this parameter only for domain-level authentication. Ignore it for sender address-level authentication.</para>
        /// <ol>
        /// <item><description><para>Create the address <a href="mailto:domain-auth-created-by-system@example.com">domain-auth-created-by-system@example.com</a> in the console. Keep the prefix before @ unchanged and replace the suffix with your own domain name.</para>
        /// </description></item>
        /// <item><description></description></item>
        /// </ol>
        /// <para><b>API scenario</b></para>
        /// <para>Set AccountName to the domain name. The recipient sees <a href="mailto:domain-auth-created-by-system@example.com">domain-auth-created-by-system@example.com</a> as the sender.</para>
        /// <para><b>SMTP scenario</b></para>
        /// <para>a. Call the ModifyPWByDomain operation to set the domain password.</para>
        /// <para>b. Authenticate with the domain name and the configured password. Pass a custom address such as <a href="mailto:user@example.com">user@example.com</a> as the actual sender (mailfrom). The recipient sees <a href="mailto:user@example.com">user@example.com</a> as the sender.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DomainAuth")]
        [Validation(Required=false)]
        public bool? DomainAuth { get; set; }

        /// <summary>
        /// <para>The email header settings.</para>
        /// <para>Both standard and non-standard fields must comply with the syntax requirements for headers defined in the standard. A maximum of 10 headers can be passed through the headers field when sending emails via API. Headers that exceed this limit are ignored. SMTP has no such limit.</para>
        /// <ol>
        /// <item><description>Standard fields</description></item>
        /// </ol>
        /// <para>Message-ID, List-Unsubscribe, List-Unsubscribe-Post</para>
        /// <para>Standard fields overwrite the original values in the email header.</para>
        /// <ol start="2">
        /// <item><description>Non-standard fields</description></item>
        /// </ol>
        /// <para>Case-insensitive.</para>
        /// <para>a. Fields prefixed with X-User- (not pushed to EventBridge or Message Service (MNS). This restriction applies only to API. SMTP allows any custom fields.)</para>
        /// <para>b. Fields prefixed with X-User-Notify- (pushed to EventBridge and Message Service (MNS). Both API and SMTP are supported.)</para>
        /// <para>When pushed to EventBridge or MNS, these fields are included under the header field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Message-ID&quot;: &quot;<a href="mailto:d52ce63e-a0d5-4f95-b6a9-e1256a44f5fb@example.net">d52ce63e-a0d5-4f95-b6a9-e1256a44f5fb@example.net</a>&quot;,
        ///       &quot;X-User-UID1&quot;: &quot;UID-1-000001&quot;,
        ///       &quot;X-User-UID2&quot;: &quot;UID-2-000001&quot;,
        ///       &quot;X-User-Notify-UID1&quot;: &quot;UID-3-000001&quot;,
        ///       &quot;X-User-Notify-UID2&quot;: &quot;UID-4-000001&quot;</para>
        /// <para>}</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string Headers { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated IP address pool. Users who have purchased dedicated IP addresses can use this parameter to specify the outbound IP address for this email sending task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e4xxxxxe-4xx0-4xx3-8xxa-74cxxxxx1cef</para>
        /// </summary>
        [NameInMap("IpPoolId")]
        [Validation(Required=false)]
        public string IpPoolId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The recipient list. The number of recipients cannot exceed 100. Specify this parameter or ReceiversName. If both Receivers and ReceiversName are specified, ReceiversName takes precedence.</para>
        /// <para>Example: [{&quot;To&quot;:[&quot;<a href="mailto:Jackie@example.com">Jackie@example.com</a>&quot;],&quot;TemplateData&quot;:{&quot;UserName&quot;:&quot;Jackie&quot;}},{&quot;To&quot;:[&quot;<a href="mailto:Tom@example.com">Tom@example.com</a>&quot;],&quot;TemplateData&quot;:{&quot;UserName&quot;:&quot;Tom&quot;}}].</para>
        /// </summary>
        [NameInMap("Receivers")]
        [Validation(Required=false)]
        public List<BatchSendMailRequestReceivers> Receivers { get; set; }
        public class BatchSendMailRequestReceivers : TeaModel {
            /// <summary>
            /// <para>The email template parameters. This parameter is of the JSON map type.</para>
            /// </summary>
            [NameInMap("TemplateData")]
            [Validation(Required=false)]
            public Dictionary<string, string> TemplateData { get; set; }

            /// <summary>
            /// <para>The recipient list. This parameter is of the array type.</para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public List<string> To { get; set; }

        }

        /// <summary>
        /// <para>The name of a pre-created recipient list that has recipients uploaded.</para>
        /// <para>Note:</para>
        /// <para>The number of recipients in the list must not exceed the remaining daily quota. Otherwise, the email sending fails.</para>
        /// <para>Do not delete the recipient list until at least 10 minutes after the task is triggered. Otherwise, the email sending may fail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2</para>
        /// </summary>
        [NameInMap("ReceiversName")]
        [Validation(Required=false)]
        public string ReceiversName { get; set; }

        /// <summary>
        /// <para>The reply-to address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2***@example.net</para>
        /// </summary>
        [NameInMap("ReplyAddress")]
        [Validation(Required=false)]
        public string ReplyAddress { get; set; }

        /// <summary>
        /// <para>The alias of the reply-to address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>小红</para>
        /// </summary>
        [NameInMap("ReplyAddressAlias")]
        [Validation(Required=false)]
        public string ReplyAddressAlias { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tag name of the email.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test3</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The custom email content. You can directly specify the content without creating a template in advance. Specify this parameter or TemplateName. If both TemplateContent and TemplateName are specified, TemplateName takes precedence.</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public BatchSendMailRequestTemplateContent TemplateContent { get; set; }
        public class BatchSendMailRequestTemplateContent : TeaModel {
            /// <summary>
            /// <para>The display name of the sender.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jackie</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The HTML body of the email.</para>
            /// <para>Note: HtmlBody and TextBody are used for different types of email content. You must specify one of them.</para>
            /// <para>The new SDK uses Body for parameter passing with a size limit of approximately 8 MB (Java 1.4.0 and later, Python3 1.4.0 and later, PHP 1.4.0 and later).</para>
            /// 
            /// <b>Example:</b>
            /// <h1>全场九折，仅限今日</h1>
            /// </summary>
            [NameInMap("HtmlBody")]
            [Validation(Required=false)]
            public string HtmlBody { get; set; }

            /// <summary>
            /// <para>The subject of the email.</para>
            /// 
            /// <b>Example:</b>
            /// <para>黑色星期五，专属折扣来袭</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The plain text body of the email.</para>
            /// <para>Note: HtmlBody and TextBody are used for different types of email content. You must specify one of them.</para>
            /// <para>The new SDK uses Body for parameter passing with a size limit of approximately 8 MB (Java 1.4.0 and later, Python3 1.4.0 and later, PHP 1.4.0 and later).</para>
            /// 
            /// <b>Example:</b>
            /// <para>全场九折，仅限今日</para>
            /// </summary>
            [NameInMap("TextBody")]
            [Validation(Required=false)]
            public string TextBody { get; set; }

        }

        /// <summary>
        /// <para>The name of a pre-created and approved template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The filtering level. For more information, see <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe link generation and filtering mechanism</a>.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disabled: No filtering is applied.</description></item>
        /// <item><description>default: The default policy is used. Batch addresses are filtered at the sender address level.</description></item>
        /// <item><description>mailfrom: Filtering at the sender address level.</description></item>
        /// <item><description>mailfrom_domain: Filtering at the sender domain level.</description></item>
        /// <item><description>edm_id: Filtering at the account level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mailfrom_domain</para>
        /// </summary>
        [NameInMap("UnSubscribeFilterLevel")]
        [Validation(Required=false)]
        public string UnSubscribeFilterLevel { get; set; }

        /// <summary>
        /// <para>The type of the generated unsubscribe link. For more information, see <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe link generation and filtering mechanism</a>.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disabled: No unsubscribe link is generated.</description></item>
        /// <item><description>default: The default policy is used. An unsubscribe link is generated when emails are sent from a batch-type sender address to specific domains that contain keywords such as &quot;gmail&quot;, &quot;yahoo&quot;, &quot;google&quot;, &quot;aol.com&quot;, &quot;hotmail&quot;, &quot;outlook&quot;, or &quot;ymail.com&quot;.</description></item>
        /// </list>
        /// <para>The display language is automatically determined based on the recipient\&quot;s browser settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("UnSubscribeLinkType")]
        [Validation(Required=false)]
        public string UnSubscribeLinkType { get; set; }

    }

}
