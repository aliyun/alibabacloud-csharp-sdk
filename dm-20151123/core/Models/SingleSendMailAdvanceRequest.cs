// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SingleSendMailAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The sending address configured in the management console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test***@example.net</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>Address type. Values:</para>
        /// <para>0: Random account</para>
        /// <para>1: Sending address</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public int? AddressType { get; set; }

        /// <summary>
        /// <para>Only supported for use with the new version of the SDK; not currently supported by openapi and signature mechanisms.</para>
        /// </summary>
        [NameInMap("Attachments")]
        [Validation(Required=false)]
        public List<SingleSendMailAdvanceRequestAttachments> Attachments { get; set; }
        public class SingleSendMailAdvanceRequestAttachments : TeaModel {
            /// <summary>
            /// <para>Only supported for use with the new version of the SDK; not currently supported by openapi and signature mechanisms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.txt</para>
            /// </summary>
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }

            /// <summary>
            /// <para>Only supported for use with the new version of the SDK; not currently supported by openapi and signature mechanisms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>C:\Users\Downloads\test.txt</para>
            /// </summary>
            [NameInMap("AttachmentUrl")]
            [Validation(Required=false)]
            public Stream AttachmentUrlObject { get; set; }

        }

        /// <summary>
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
        /// <para>1: Enable data tracking function</para>
        /// <para>0 (default): Disable data tracking function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ClickTrace")]
        [Validation(Required=false)]
        public string ClickTrace { get; set; }

        [NameInMap("DomainAuth")]
        [Validation(Required=false)]
        public bool? DomainAuth { get; set; }

        /// <summary>
        /// <para>Sender alias, with a maximum length of 15 characters.</para>
        /// <para>For example, if the sender alias is set to &quot;Xiaohong&quot; and the sending address is test***@example.net, the recipient will see the sending address as &quot;Xiaohong&quot; <a href="mailto:test***@example.net">test***@example.net</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Xiaohong</para>
        /// </summary>
        [NameInMap("FromAlias")]
        [Validation(Required=false)]
        public string FromAlias { get; set; }

        /// <summary>
        /// <para>Currently, the standard fields that can be added to the email header are Message-ID, List-Unsubscribe, and List-Unsubscribe-Post. Standard fields will overwrite the existing values in the email header, while non-standard fields need to start with X-User- and will be appended to the email header.
        /// Currently, up to 10 headers can be passed in JSON format, and both standard and non-standard fields must comply with the syntax requirements for headers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Message-ID&quot;: &quot;<a href="mailto:msg0001@example.com">msg0001@example.com</a>&quot;,
        ///   &quot;X-User-UID1&quot;: &quot;UID-1-000001&quot;,
        ///   &quot;X-User-UID2&quot;: &quot;UID-2-000001&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public string Headers { get; set; }

        /// <summary>
        /// <para>Email HTML body, limited to 80K by the SDK. Note: HtmlBody and TextBody are for different types of email content, and one of them must be provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>body</para>
        /// </summary>
        [NameInMap("HtmlBody")]
        [Validation(Required=false)]
        public string HtmlBody { get; set; }

        /// <summary>
        /// <para>dedicated IP pool ID. Users who have purchased an dedicated IP can use this parameter to specify the outgoing IP for this email.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("IpPoolId")]
        [Validation(Required=false)]
        public string IpPoolId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Reply-to address</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2***@example.net</para>
        /// </summary>
        [NameInMap("ReplyAddress")]
        [Validation(Required=false)]
        public string ReplyAddress { get; set; }

        /// <summary>
        /// <para>Reply-to address alias</para>
        /// 
        /// <b>Example:</b>
        /// <para>Xiaohong</para>
        /// </summary>
        [NameInMap("ReplyAddressAlias")]
        [Validation(Required=false)]
        public string ReplyAddressAlias { get; set; }

        /// <summary>
        /// <para>Whether to enable the reply-to address configured in the management console (the status must be verified). The value range is the string <c>true</c> or <c>false</c> (not a boolean value).</para>
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
        /// <para>Email subject, with a maximum length of 100 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subject</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <para>A tag created in the email push console, used to categorize batches of sent emails. You can use tags to query the sending status of each batch. Additionally, if the email tracking feature is enabled, you must use an email tag when sending emails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public SingleSendMailAdvanceRequestTemplate Template { get; set; }
        public class SingleSendMailAdvanceRequestTemplate : TeaModel {
            [NameInMap("TemplateData")]
            [Validation(Required=false)]
            public Dictionary<string, string> TemplateData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>Email text body, limited to 80K by the SDK. Note: HtmlBody and TextBody are for different types of email content, and one of them must be provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>body</para>
        /// </summary>
        [NameInMap("TextBody")]
        [Validation(Required=false)]
        public string TextBody { get; set; }

        /// <summary>
        /// <para>Recipient addresses. Multiple email addresses can be separated by commas, with a maximum of 100 addresses (supports mailing lists).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1***@example.net</para>
        /// </summary>
        [NameInMap("ToAddress")]
        [Validation(Required=false)]
        public string ToAddress { get; set; }

        /// <summary>
        /// <para>Filtering level. Refer to the <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe Function Link Generation and Filtering Mechanism</a> document.</para>
        /// <para>disabled: Do not filter</para>
        /// <para>default: Use the default strategy, bulk addresses use the sending address level filtering</para>
        /// <para>mailfrom: Sending address level filtering</para>
        /// <para>mailfrom_domain: Sending domain level filtering</para>
        /// <para>edm_id: Account level filtering</para>
        /// 
        /// <b>Example:</b>
        /// <para>mailfrom_domain</para>
        /// </summary>
        [NameInMap("UnSubscribeFilterLevel")]
        [Validation(Required=false)]
        public string UnSubscribeFilterLevel { get; set; }

        /// <summary>
        /// <para>Type of generated unsubscribe link. Refer to the <a href="https://help.aliyun.com/document_detail/2689048.html">Unsubscribe Function Link Generation and Filtering Mechanism</a> document.</para>
        /// <para>disabled: Do not generate</para>
        /// <para>default: Use the default strategy: Generate unsubscribe links for bulk-type sending addresses to specific domains, such as those containing the keywords &quot;gmail&quot;, &quot;yahoo&quot;,</para>
        /// <para>&quot;google&quot;, &quot;aol.com&quot;, &quot;hotmail&quot;,</para>
        /// <para>&quot;outlook&quot;, &quot;ymail.com&quot;, etc.</para>
        /// <para>zh-cn: Generate, for future content preparation</para>
        /// <para>en-us: Generate, for future content preparation</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("UnSubscribeLinkType")]
        [Validation(Required=false)]
        public string UnSubscribeLinkType { get; set; }

    }

}
