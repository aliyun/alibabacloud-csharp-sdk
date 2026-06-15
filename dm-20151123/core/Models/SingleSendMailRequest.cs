// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SingleSendMailRequest : TeaModel {
        /// <summary>
        /// <para>The sender address configured in the Direct Mail console.</para>
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
        /// <para><c>0</c>: A random account.</para>
        /// <para><c>1</c>: A sender address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public int? AddressType { get; set; }

        /// <summary>
        /// <para>This feature is available only through the latest SDKs. It is not supported for OpenAPI calls or signature-based authentication. For more information, see <a href="https://help.aliyun.com/document_detail/2937843.html">How do I send an email with an attachment by using an SDK?</a>.</para>
        /// </summary>
        [NameInMap("Attachments")]
        [Validation(Required=false)]
        public List<SingleSendMailRequestAttachments> Attachments { get; set; }
        public class SingleSendMailRequestAttachments : TeaModel {
            /// <summary>
            /// <para>The filename of the attachment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.txt</para>
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// <para>The local file path of the attachment that the SDK will use.</para>
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
        /// <item><description><para>A comma-separated list of BCC recipients.</para>
        /// </description></item>
        /// <item><description><para>The system sends a copy of the email to each BCC recipient. The BCC information is hidden from all recipients, including those specified in <c>ToAddress</c> and <c>BccAddress</c>.</para>
        /// </description></item>
        /// <item><description><para>To protect privacy, email tracking features (such as open and click tracking) are disabled for emails sent to BCC recipients. However, billing and sending status are still tracked.</para>
        /// </description></item>
        /// <item><description><para>A maximum of two BCC recipients are allowed per request.</para>
        /// </description></item>
        /// </list>
        /// <para>Note: The <c>SingleSendMail</c> API operation does not support a CC field. To send carbon copies, use SMTP.</para>
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
        /// <para>Specifies whether to enable click tracking. Valid values: <c>&quot;1&quot;</c> enables click tracking, and <c>&quot;0&quot;</c> disables it (default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ClickTrace")]
        [Validation(Required=false)]
        public string ClickTrace { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable domain-level authentication.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c></para>
        /// </description></item>
        /// <item><description><para><c>false</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is used only for domain-level authentication. Ignore it for sender address-level authentication.</para>
        /// <para>1\. Create the address <c>domain-auth-created-by-system@example.com</c> in the console. The prefix must be fixed, and the suffix must be your domain.</para>
        /// <para>2\.</para>
        /// <para><b>API scenario</b></para>
        /// <para>Set <c>AccountName</c> to your domain. Recipients will see the sender as <c>domain-auth-created-by-system@example.com</c>.</para>
        /// <para><b>SMTP scenario</b></para>
        /// <para>a. Call the <c>ModifyPWByDomain</c> API operation to set a password for the domain.</para>
        /// <para>b. Authenticate with the domain and the configured password. Pass a custom address, such as <c>user@example.com</c>, as the actual sender in the <c>MAIL FROM</c> command. Recipients will see <c>user@example.com</c> as the sender.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DomainAuth")]
        [Validation(Required=false)]
        public bool? DomainAuth { get; set; }

        /// <summary>
        /// <para>The sender name. It must be 15 characters or shorter.</para>
        /// <para>For example, if you set the sender name to &quot;Xiaohong&quot; and the sender address is <c>test***@example.net</c>, the recipient sees the sender as &quot;Xiaohong&quot; \&lt;test\*\*\*@example.net&gt;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("FromAlias")]
        [Validation(Required=false)]
        public string FromAlias { get; set; }

        /// <summary>
        /// <para>Custom email header settings.</para>
        /// <para>Both standard and non-standard fields must comply with standard header syntax. You can specify up to 10 headers for an API call. Excess headers are ignored. This limit does not apply to SMTP.</para>
        /// <para>1\. Standard fields</para>
        /// <para><c>Message-ID</c>, <c>List-Unsubscribe</c>, <c>List-Unsubscribe-Post</c></para>
        /// <para>Standard fields overwrite existing values in the email header.</para>
        /// <para>2\. Non-standard fields</para>
        /// <para>Case-insensitive.</para>
        /// <para>a. Fields starting with <c>X-User-</c>: These are not pushed to EventBridge or Message Service (MNS). This prefix is required only for API calls, not for SMTP.</para>
        /// <para>b. Fields starting with <c>X-User-Notify-</c>: These are pushed to EventBridge and MNS. This is supported for both API and SMTP calls.</para>
        /// <para>When pushed to EventBridge or MNS, the header object will contain these fields.</para>
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
        /// <para>Note: You must specify either <c>HtmlBody</c> or <c>TextBody</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>The size of the body is limited to approximately 80 KB when passed as a URL parameter.</para>
        /// </description></item>
        /// <item><description><para>For recent SDKs (Java 1.4.0+, Python 3 1.4.0+, and PHP 1.4.0+), the request body is limited to approximately 8 MB.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>body</para>
        /// </summary>
        [NameInMap("HtmlBody")]
        [Validation(Required=false)]
        public string HtmlBody { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated IP pool. If you have purchased dedicated IPs, you can use this parameter to select which dedicated IP pool to use for sending the email. For more information, see <a href="https://help.aliyun.com/document_detail/2932088.html">Dedicated IP</a>.</para>
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
        /// <para>The name displayed for the reply-to address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jane</para>
        /// </summary>
        [NameInMap("ReplyAddressAlias")]
        [Validation(Required=false)]
        public string ReplyAddressAlias { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the default reply-to address configured in the console. This address must be verified. Valid values: true, false.</para>
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
        /// <para>The subject of the email, with a maximum length of 256 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subject</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <para>A tag for categorizing email batches, which you can create in the Direct Mail console. Tags allow you to query the sending status of each batch and are required if you enable email tracking. The tag must be 1 to 128 characters long and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The template information for sending a templated email.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public SingleSendMailRequestTemplate Template { get; set; }
        public class SingleSendMailRequestTemplate : TeaModel {
            /// <summary>
            /// <para>The variables and their values for the template.</para>
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
        /// <para>Note: You must specify either <c>HtmlBody</c> or <c>TextBody</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>The size of the body is limited to approximately 80 KB when passed as a URL parameter.</para>
        /// </description></item>
        /// <item><description><para>For recent SDKs (Java 1.4.0+, Python 3 1.4.0+, and PHP 1.4.0+), the request body is limited to approximately 8 MB.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>body</para>
        /// </summary>
        [NameInMap("TextBody")]
        [Validation(Required=false)]
        public string TextBody { get; set; }

        /// <summary>
        /// <para>The destination email address(es). To specify multiple addresses, separate them with commas (up to 100).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1***@example.net</para>
        /// </summary>
        [NameInMap("ToAddress")]
        [Validation(Required=false)]
        public string ToAddress { get; set; }

        /// <summary>
        /// <para>The filtering level. For more information, see <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe link generation and filtering mechanism</a>.</para>
        /// <para><c>disabled</c>: No filtering.</para>
        /// <para><c>default</c>: Uses the default policy. For batch addresses, filtering is applied at the sender address level.</para>
        /// <para><c>mailfrom</c>: Filters at the sender address level.</para>
        /// <para><c>mailfrom_domain</c>: Filters at the sender domain level.</para>
        /// <para><c>edm_id</c>: Filters at the account level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mailfrom_domain</para>
        /// </summary>
        [NameInMap("UnSubscribeFilterLevel")]
        [Validation(Required=false)]
        public string UnSubscribeFilterLevel { get; set; }

        /// <summary>
        /// <para><c>disabled</c>: Does not generate an unsubscribe link.</para>
        /// <para><c>default</c>: Uses the default policy. For batch sender addresses, an unsubscribe link is generated when sending to specific domains containing keywords such as &quot;gmail&quot;, &quot;yahoo&quot;,</para>
        /// <para>&quot;google&quot;, &quot;aol.com&quot;, &quot;hotmail&quot;,</para>
        /// <para>&quot;outlook&quot;, and &quot;ymail.com&quot;. For more information, see <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe link generation and filtering mechanism</a>.</para>
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
