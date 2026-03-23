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
        /// <para>0: Random account</para>
        /// <para>1: Sender address</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public int? AddressType { get; set; }

        /// <summary>
        /// <para>This feature is available only in the latest software development kit (SDK). It is not supported by OpenAPI or signature mechanisms. For more information, see <a href="">How do I send an email with attachments using an SDK?</a>.</para>
        /// </summary>
        [NameInMap("Attachments")]
        [Validation(Required=false)]
        public List<SingleSendMailRequestAttachments> Attachments { get; set; }
        public class SingleSendMailRequestAttachments : TeaModel {
            /// <summary>
            /// <para>This feature is available only in the latest SDK. It is not supported by OpenAPI or signature mechanisms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.txt</para>
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// <para>This feature is available only in the latest SDK. It is not supported by OpenAPI or signature mechanisms.</para>
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
        /// <item><description><para>The list of blind carbon copy (BCC) recipients.</para>
        /// </description></item>
        /// <item><description><para>A copy of the email is sent to each BCC address. The BCC information is not visible to any recipient, including those in the ToAddress and BccAddress fields.</para>
        /// </description></item>
        /// <item><description><para>To protect the privacy of BCC recipients, email tracking is disabled by default for emails sent to BCC addresses. This means that behavioral data, such as open rates and click-through rates, is not recorded for BCC emails. However, billing, sending details, and sending status statistics are the same as for regular emails.</para>
        /// </description></item>
        /// <item><description><para>You can specify up to two BCC recipients for each email.</para>
        /// </description></item>
        /// </list>
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
        /// <para>1: Enables data tracking.</para>
        /// <para>0 (default): Disables data tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ClickTrace")]
        [Validation(Required=false)]
        public string ClickTrace { get; set; }

        /// <summary>
        /// <para>Enable domain-level authentication.</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <para>Use this only for domain-level authentication. Ignore it for sender address-level authentication.</para>
        /// <para>1\. Create the \<c>domain-auth-created-by-system\\@example.com\\</c> address in the console. Keep the prefix before the at sign (@) fixed and use your own domain as the suffix.</para>
        /// <para>2\.</para>
        /// <para><b>API scenario</b></para>
        /// <para>Set \<c>AccountName\\</c> to your domain. The recipient sees the sender as \<c>domain-auth-created-by-system\\@example.com\\</c>.</para>
        /// <para><b>SMTP scenario</b></para>
        /// <para>a. Set the domain password using the \<c>ModifyPWByDomain\\</c> API.</para>
        /// <para>b. Authenticate using the domain and the set password. For the actual sender, pass a custom address, such as \<c>user\\@example.com\\</c>, in the \<c>mailfrom\\</c> field. The recipient sees the sender as \<c>user\\@example.com\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DomainAuth")]
        [Validation(Required=false)]
        public bool? DomainAuth { get; set; }

        /// <summary>
        /// <para>The nickname of the sender. The nickname must be fewer than 15 characters.</para>
        /// <para>For example, if you set the nickname to &quot;Xiao Hong&quot; and the sender address is test\<em>\</em>\*@example.net, the recipient sees the sender as &quot;Xiao Hong&quot; \&lt;test\*\*\*@example.net&gt;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>小红</para>
        /// </summary>
        [NameInMap("FromAlias")]
        [Validation(Required=false)]
        public string FromAlias { get; set; }

        /// <summary>
        /// <para>Message header settings</para>
        /// <para>Both standard and non-standard fields must follow the syntax rules for message headers. The API supports a maximum of 10 headers in the headers field. Any headers exceeding this limit are ignored. SMTP, however, does not have this limit.</para>
        /// <para>1\. Standard fields</para>
        /// <para>Message-ID, List-Unsubscribe, List-Unsubscribe-Post</para>
        /// <para>Standard fields overwrite existing values in the message header.</para>
        /// <para>2\. Non-standard fields</para>
        /// <para>Case-insensitive</para>
        /// <para>a. Fields that start with X-User- (These are not pushed to the EventBridge event bus or Message Service MNS. They are required only for the API, whereas SMTP supports any custom header.)</para>
        /// <para>b. Fields that start with X-User-Notify- (These are pushed to the EventBridge event bus and Message Service MNS, and are supported by both the API and SMTP.)</para>
        /// <para>When pushed to EventBridge or MNS, these fields appear in the header field.</para>
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
        /// <para>Note: Specify HtmlBody or TextBody.</para>
        /// <list type="bullet">
        /// <item><description><para>The size of the parameter passed in a URL is limited to approximately 80 KB.</para>
        /// </description></item>
        /// <item><description><para>The new SDK limits the body parameter to approximately 8 MB (Java 1.4.0 and later, Python 3 1.4.0 and later, PHP 1.4.0 and later).</para>
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
        /// <para>The ID of the dedicated IP address pool. If you purchased dedicated IP addresses, use this parameter to specify the outbound IP address for the current email. For more information, see <a href="">Dedicated IPs</a>.</para>
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
        /// <para>The nickname of the reply-to address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>小红</para>
        /// </summary>
        [NameInMap("ReplyAddressAlias")]
        [Validation(Required=false)]
        public string ReplyAddressAlias { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the reply-to address configured in the console. The reply-to address must be verified. Valid values: true and false.</para>
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
        /// <para>The subject of the email. The subject cannot exceed 256 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subject</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <para>The email tag that you create in the Direct Mail console. Use tags to classify email batches and query the sending status of each batch. If email tracking is enabled, you must specify an email tag.
        /// The tag can be 1 to 128 characters in length and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The template information for sending template-based emails.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public SingleSendMailRequestTemplate Template { get; set; }
        public class SingleSendMailRequestTemplate : TeaModel {
            /// <summary>
            /// <para>The variables and their values in the template.</para>
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
        /// <para>Note: Specify HtmlBody or TextBody.</para>
        /// <list type="bullet">
        /// <item><description><para>The size of the parameter passed in a URL is limited to approximately 80 KB.</para>
        /// </description></item>
        /// <item><description><para>The new SDK limits the body parameter to approximately 8 MB (Java 1.4.0 and later, Python 3 1.4.0 and later, PHP 1.4.0 and later).</para>
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
        /// <para>The destination address. To specify multiple addresses, separate them with commas (,). You can specify a maximum of 100 addresses. Recipient groups are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1***@example.net</para>
        /// </summary>
        [NameInMap("ToAddress")]
        [Validation(Required=false)]
        public string ToAddress { get; set; }

        /// <summary>
        /// <para>The filtering level. For more information, see <a href="">Unsubscribe link generation and filtering mechanism</a>.</para>
        /// <para>disabled: No filtering.</para>
        /// <para>default: The default policy is used. Batch addresses are filtered at the sender address level.</para>
        /// <para>mailfrom: Filters at the sender address level.</para>
        /// <para>mailfrom_domain: Filters at the email domain level.</para>
        /// <para>edm_id: Filters at the account level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mailfrom_domain</para>
        /// </summary>
        [NameInMap("UnSubscribeFilterLevel")]
        [Validation(Required=false)]
        public string UnSubscribeFilterLevel { get; set; }

        /// <summary>
        /// <para>disabled: No link is generated.</para>
        /// <para>default: The default policy is used. An unsubscribe link is generated for batch emails sent to specific domains, such as domains that contain keywords like &quot;gmail&quot;, &quot;yahoo&quot;,
        /// &quot;google&quot;, &quot;aol.com&quot;, &quot;hotmail&quot;,
        /// &quot;outlook&quot;, or &quot;ymail.com&quot;. For more information, see <a href="">Unsubscribe link generation and filtering mechanism</a>.</para>
        /// <para>The display language is automatically detected based on the recipient\&quot;s browser settings.</para>
        /// <para>&quot;outlook&quot;, or &quot;ymail.com&quot;. For more information, see <a href="">Unsubscribe link generation and filtering mechanism</a>.</para>
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
