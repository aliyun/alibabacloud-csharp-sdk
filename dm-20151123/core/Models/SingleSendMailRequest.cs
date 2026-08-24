// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SingleSendMailRequest : TeaModel {
        /// <summary>
        /// <para>The sender address configured in the management console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test***@example.net</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The address type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: random account</description></item>
        /// <item><description>1: sender address</description></item>
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
        /// <para>Supported only when using the new SDK. Not supported through OpenAPI or signature mechanism methods. For more information, refer to <a href="https://help.aliyun.com/document_detail/2937843.html">How do I send emails with attachments through the SDK?</a>.</para>
        /// </summary>
        [NameInMap("Attachments")]
        [Validation(Required=false)]
        public List<SingleSendMailRequestAttachments> Attachments { get; set; }
        public class SingleSendMailRequestAttachments : TeaModel {
            /// <summary>
            /// <para>Supported only when using the new SDK. Not supported through OpenAPI or signature mechanism methods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.txt</para>
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// <para>Supported only when using the new SDK. Not supported through OpenAPI or signature mechanism methods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Users\Downloads\test.txt</para>
            /// </summary>
            [NameInMap("AttachmentUrl")]
            [Validation(Required=false)]
            public string AttachmentUrl { get; set; }

        }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Specifies the BCC (blind carbon copy) recipient list for the email.</description></item>
        /// <item><description>The system sends a copy identical to the main email content to each BCC address. The BCC information is not visible to any recipients (including ToAddress and BccAddress).</description></item>
        /// <item><description>To protect the privacy of BCC recipients, email tracking features are disabled by default for BCC emails. This means the system does not record behavioral data such as open rates or click-through rates for BCC emails. However, billing for sending volume, sending details, and sending status statistics remain consistent with regular emails.</description></item>
        /// <item><description>A maximum of 2 BCC recipients can be specified per send.</description></item>
        /// </list>
        /// <para>Note: The SingleSendMail operation does not support the Cc (carbon copy) field. Use SMTP if you need this feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:1@example.com">1@example.com</a>,<a href="mailto:2@example.com">2@example.com</a></para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("BccAddress")]
        [Validation(Required=false)]
        public string BccAddress { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable data tracking. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Enable data tracking.</description></item>
        /// <item><description>0 (default): Disable data tracking.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ClickTrace")]
        [Validation(Required=false)]
        public string ClickTrace { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable domain-level authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Use this parameter only for domain-level authentication. Ignore it for sender address-level authentication.</para>
        /// <ol>
        /// <item><description><para>Create the address <a href="mailto:domain-auth-created-by-system@example.com">domain-auth-created-by-system@example.com</a> in the console. Keep the prefix before @ unchanged and use your own domain name as the suffix.</para>
        /// </description></item>
        /// <item><description></description></item>
        /// </ol>
        /// <para><b>API scenario</b></para>
        /// <para>Set AccountName to a custom sender address for the domain. The recipient sees the custom sender address as the sender.</para>
        /// <para><b>SMTP scenario</b></para>
        /// <para>a. Set the domain password through the ModifyPWByDomain operation.</para>
        /// <para>b. Authenticate using the domain name and the configured password. Pass a custom address such as <a href="mailto:user@example.com">user@example.com</a> as the actual sender (mailfrom). The recipient sees <a href="mailto:user@example.com">user@example.com</a> as the sender.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DomainAuth")]
        [Validation(Required=false)]
        public bool? DomainAuth { get; set; }

        /// <summary>
        /// <para>The sender nickname. The value cannot exceed 15 characters in length.</para>
        /// <para>For example, if the sender nickname is set to &quot;Jane&quot; and the sender address is test***@example.net, the recipient sees the sender address as &quot;Jane&quot; test***@example.net.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("FromAlias")]
        [Validation(Required=false)]
        public string FromAlias { get; set; }

        /// <summary>
        /// <para>The email header settings.</para>
        /// <para>Both standard and non-standard fields must comply with the syntax requirements for headers defined in the standard. A maximum of 10 headers can be passed through the headers field when sending emails via API. Headers exceeding this limit are ignored. SMTP has no such limit.</para>
        /// <ol>
        /// <item><description>Standard fields</description></item>
        /// </ol>
        /// <para>Message-ID, List-Unsubscribe, List-Unsubscribe-Post</para>
        /// <para>Standard fields overwrite the original values in the email header.</para>
        /// <ol start="2">
        /// <item><description>Non-standard fields</description></item>
        /// </ol>
        /// <para>Case-insensitive.</para>
        /// <para>a. Fields prefixed with X-User- (not pushed to EventBridge or Message Service MNS. This is an API-only requirement. SMTP allows any custom fields.)</para>
        /// <para>b. Fields prefixed with X-User-Notify- (pushed to EventBridge and Message Service MNS. Both API and SMTP are supported.)</para>
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
        /// <para>The HTML body of the email.</para>
        /// <para>Note: HtmlBody and TextBody are used for different types of email content. You must specify one of them.</para>
        /// <list type="bullet">
        /// <item><description>The size limit for URL-based parameter passing is approximately 80 KB.</description></item>
        /// <item><description>The size limit for Body-based parameter passing with the new SDK is approximately 8 MB (Java 1.4.0 or later, Python3 1.4.0 or later, PHP 1.4.0 or later).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>body</para>
        /// </summary>
        [NameInMap("HtmlBody")]
        [Validation(Required=false)]
        public string HtmlBody { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated IP address pool. Users who have purchased dedicated IP addresses can use this parameter to specify the outbound IP address for this email. For more information, refer to <a href="https://help.aliyun.com/document_detail/2932088.html">Dedicated IP</a>.</para>
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
        /// <para>The reply-to address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2***@example.net</para>
        /// </summary>
        [NameInMap("ReplyAddress")]
        [Validation(Required=false)]
        public string ReplyAddress { get; set; }

        /// <summary>
        /// <para>The reply-to address nickname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("ReplyAddressAlias")]
        [Validation(Required=false)]
        public string ReplyAddressAlias { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the reply-to address configured in the management console (the address must be verified). Valid values: true or false.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReplyToAddress")]
        [Validation(Required=false)]
        public bool? ReplyToAddress { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The email subject. The value cannot exceed 256 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subject</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <para>The tag created in the DirectMail console. Tags are used to categorize email batches. You can query the sending status of each batch by tag. If the email tracking feature is enabled, you must use an email tag when sending emails.
        /// The value must be 1 to 128 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The template information for template-based sending.</para>
        /// <para>When sending with a template, the HtmlBody and TextBody values are ignored.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public SingleSendMailRequestTemplate Template { get; set; }
        public class SingleSendMailRequestTemplate : TeaModel {
            /// <summary>
            /// <para>The template variables and values.</para>
            /// </summary>
            [NameInMap("TemplateData")]
            [Validation(Required=false)]
            public Dictionary<string, string> TemplateData { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The text body of the email.</para>
        /// <para>Note: HtmlBody and TextBody are used for different types of email content. You must specify one of them.</para>
        /// <list type="bullet">
        /// <item><description>The size limit for URL-based parameter passing is approximately 80 KB.</description></item>
        /// <item><description>The size limit for Body-based parameter passing with the new SDK is approximately 8 MB (Java 1.4.0 or later, Python3 1.4.0 or later, PHP 1.4.0 or later).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>body</para>
        /// </summary>
        [NameInMap("TextBody")]
        [Validation(Required=false)]
        public string TextBody { get; set; }

        /// <summary>
        /// <para>The destination address. You can specify multiple email addresses separated by commas. A maximum of 100 addresses are supported (mailing lists are supported).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1***@example.net</para>
        /// </summary>
        [NameInMap("ToAddress")]
        [Validation(Required=false)]
        public string ToAddress { get; set; }

        /// <summary>
        /// <para>The filtering level. For more information, refer to <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe link generation and filtering mechanism</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disabled: No filtering is applied.</description></item>
        /// <item><description>default: The default policy is used. Batch addresses use sender address-level filtering.</description></item>
        /// <item><description>mailfrom: Sender address-level filtering.</description></item>
        /// <item><description>mailfrom_domain: Sender domain-level filtering.</description></item>
        /// <item><description>edm_id: Account-level filtering.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mailfrom_domain</para>
        /// </summary>
        [NameInMap("UnSubscribeFilterLevel")]
        [Validation(Required=false)]
        public string UnSubscribeFilterLevel { get; set; }

        /// <summary>
        /// <para>The type of unsubscribe link. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disabled: No unsubscribe link is generated.</description></item>
        /// <item><description>default: The default policy is used. An unsubscribe link is generated when emails are sent from batch-type sender addresses to specific domains, such as those containing keywords &quot;gmail&quot;, &quot;yahoo&quot;, &quot;google&quot;, &quot;aol.com&quot;, &quot;hotmail&quot;, &quot;outlook&quot;, or &quot;ymail.com&quot;. For more information, refer to <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe link generation and filtering mechanism</a>.</description></item>
        /// </list>
        /// <para>The display language is automatically detected based on the recipient\&quot;s browser settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("UnSubscribeLinkType")]
        [Validation(Required=false)]
        public string UnSubscribeLinkType { get; set; }

    }

}
