// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class BatchSendMailRequest : TeaModel {
        /// <summary>
        /// <para>The sender address configured in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.com">test@example.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>0: Random account</para>
        /// </description></item>
        /// <item><description><para>1: Sender address</para>
        /// </description></item>
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
        /// <list type="bullet">
        /// <item><description><para>1: Enables the data tracking feature.</para>
        /// </description></item>
        /// <item><description><para>0 (default): Disables the data tracking feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ClickTrace")]
        [Validation(Required=false)]
        public string ClickTrace { get; set; }

        /// <summary>
        /// <para>Enables domain-level authentication.</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <para>Use this parameter only for domain-level authentication. Ignore it for sender address-level authentication.</para>
        /// <para>1\. The console creates the address \<c>domain-auth-created-by-system\\@example.com\\</c>. Do not change the prefix before the at sign (@). Replace the domain suffix with your own domain.</para>
        /// <para>2\.</para>
        /// <para><b>API scenario</b></para>
        /// <para>Set \<c>AccountName\\</c> to your domain. Recipients see \<c>domain-auth-created-by-system\\@example.com\\</c> as the sender.</para>
        /// <para><b>SMTP scenario</b></para>
        /// <para>a. Use the \<c>ModifyPWByDomain\\</c> API to set a password for your domain.</para>
        /// <para>b. Authenticate using your domain and the password. Set the actual sender address (\<c>mailfrom\\</c>) to a custom address, such as \<c>user\\@example.com\\</c>. Recipients see \<c>user\\@example.com\\</c> as the sender.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DomainAuth")]
        [Validation(Required=false)]
        public bool? DomainAuth { get; set; }

        /// <summary>
        /// <para>Message header settings.</para>
        /// <para>All fields, standard or non-standard, must follow standard header syntax. For API calls, the \<c>headers\\</c> field supports up to 10 headers. Any headers beyond this limit are ignored. SMTP does not have a header limit.</para>
        /// <para>1\. Standard fields</para>
        /// <para>\<c>Message-ID\\</c>, \<c>List-Unsubscribe\\</c>, \<c>List-Unsubscribe-Post\\</c></para>
        /// <para>Standard fields overwrite existing values in the message header.</para>
        /// <para>2\. Non-standard fields</para>
        /// <para>Case-insensitive</para>
        /// <para>a. Start with \<c>X-User-\\</c>. These fields are not pushed to EventBridge or Message Service. They are required only for API calls. SMTP supports any custom header.</para>
        /// <para>b. Start with \<c>X-User-Notify-\\</c>. These fields are pushed to EventBridge and Message Service. They are supported by both API and SMTP.</para>
        /// <para>When pushed to EventBridge or Message Service, these fields appear under the \<c>headers\\</c> object.</para>
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
        /// <para>The ID of the dedicated IP address pool. If you purchased dedicated IP addresses, use this parameter to specify the egress IP address for sending the email.</para>
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
        /// <para>The name of a pre-created recipient list to which recipients have been uploaded.</para>
        /// <para>Note:</para>
        /// <para>The number of recipients in the list must not exceed your remaining daily quota. Otherwise, email sending fails.</para>
        /// <para>Do not delete the recipient list for at least 10 minutes after triggering the task. Otherwise, email sending may fail.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The alias for the reply-to address.</para>
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
        /// <para>The name of the email tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test3</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>The name of a pre-created and approved template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The filtering level. For more information, see <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe link generation and filtering mechanism</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>disabled: No filtering.</para>
        /// </description></item>
        /// <item><description><para>default: Uses the default policy. Batch emails are filtered at the sender address level.</para>
        /// </description></item>
        /// <item><description><para>mailfrom: Filters at the sender address level.</para>
        /// </description></item>
        /// <item><description><para>mailfrom_domain: Filters at the email domain level.</para>
        /// </description></item>
        /// <item><description><para>edm_id: Filters at the account level.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mailfrom_domain</para>
        /// </summary>
        [NameInMap("UnSubscribeFilterLevel")]
        [Validation(Required=false)]
        public string UnSubscribeFilterLevel { get; set; }

        /// <summary>
        /// <para>The type of unsubscribe link to generate. For more information, see <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe link generation and filtering mechanism</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>disabled: Does not generate a link.</para>
        /// </description></item>
        /// <item><description><para>default: Uses the default policy. An unsubscribe link is generated when batch emails are sent from a sender address to specific domains, such as those containing the keywords &quot;gmail&quot;, &quot;yahoo&quot;, &quot;google&quot;, &quot;aol.com&quot;, &quot;hotmail&quot;, &quot;outlook&quot;, or &quot;ymail.com&quot;.</para>
        /// </description></item>
        /// </list>
        /// <para>The language of the unsubscribe link matches the recipient\&quot;s browser language setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("UnSubscribeLinkType")]
        [Validation(Required=false)]
        public string UnSubscribeLinkType { get; set; }

    }

}
