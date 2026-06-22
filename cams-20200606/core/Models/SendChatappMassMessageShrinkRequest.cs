// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMassMessageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>whatsapp</b></para>
        /// </description></item>
        /// <item><description><para><b>messenger</b></para>
        /// </description></item>
        /// <item><description><para><b>instagram</b></para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>viber</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>whatsapp</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The Space ID of the ISV sub-customer, or the instance ID for a direct customer. View it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8c8*********</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The WhatsApp Business Account (WABA) ID of the Independent Software Vendor (ISV) customer. This is a deprecated parameter. Use CustSpaceId instead, which is the direct customer\&quot;s instance ID. View the ID on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8c8*********</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The custom fallback content. This parameter is for the international site (alibabacloud.com). You can ignore it for the China site (aliyun.com).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fallback SMS</para>
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        /// <summary>
        /// <para>The time to trigger a fallback. This parameter is for the international site (alibabacloud.com). You can ignore it for the China site (aliyun.com).&lt;props=&quot;intl&quot;&gt;If a delivery receipt is not returned within the specified time, a fallback is triggered. If you leave this parameter empty, the fallback is not determined by time. A fallback is triggered only when the message fails to be sent or a failed status report is received. Unit: seconds. Minimum value: 60. Maximum value: 43200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("FallBackDuration")]
        [Validation(Required=false)]
        public int? FallBackDuration { get; set; }

        /// <summary>
        /// <para>The fallback policy ID. This parameter is for the international site (alibabacloud.com). You can ignore it for the China site (aliyun.com).&lt;props=&quot;intl&quot;&gt;View the policy ID on the <a href="https://chatapp.console.alibabacloud.com/FallbackStrategy"><b>Fallback Policy</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S0****</para>
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// <para>The fallback rule. This parameter is for the international site (alibabacloud.com). You can ignore it for the China site (aliyun.com). &lt;props=&quot;intl&quot;&gt;Valid values:</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>undelivered</b>: A fallback is triggered if the message cannot be delivered to the recipient. This rule requires that the template and parameters pass verification before sending. The rule does not apply if the message is blocked from sending, for example, due to a blacklisted template or phone number. This is the default rule if this parameter is empty.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>sentFailed</b>: A fallback is triggered if the template, template variables, or other parameters fail verification. Only the channelType, type, messageType, to, and the existence of the from parameter are strictly verified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>undelivered</para>
        /// </summary>
        [NameInMap("FallBackRule")]
        [Validation(Required=false)]
        public string FallBackRule { get; set; }

        /// <summary>
        /// <para>The sender\&quot;s number.</para>
        /// <list type="bullet">
        /// <item><description><para>If ChannelType is <b>whatsapp</b>, this is the phone number registered and bound with WhatsApp. View the number on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>WABA Management</b> &gt; <b>Phone Number Management</b> page.</para>
        /// </description></item>
        /// <item><description><para>If ChannelType is <b>messenger</b>, this is the Page ID. View the ID on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Facebook Homepage</b> page.</para>
        /// </description></item>
        /// <item><description><para>If ChannelType is <b>instagram</b>, this is the Instagram professional account ID. View the ID on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Professional Account</b> page.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If ChannelType is <b>viber</b>, this is the Viber service ID. View the ID on the <a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Service Number Management&#x20;</b>&#x70;age.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>861387777****</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>ISV verification code, used to verify if the user is authorized by an ISV. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikd****</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        [Obsolete]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The Viber message type. This parameter is for the international site (alibabacloud.com). You can ignore it for the China site (aliyun.com). &lt;props=&quot;intl&quot;&gt;Valid values:</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>promotion</b>: marketing messages.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>transaction</b>: notification messages.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>promotion</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The language. For language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>A list of recipients.</para>
        /// </summary>
        [NameInMap("SenderList")]
        [Validation(Required=false)]
        public string SenderListShrink { get; set; }

        /// <summary>
        /// <para>A custom tag for a Viber message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tag</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The custom task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The template code. View the template code on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Template Design</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1119***************</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The template name. View the template name on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Template Design</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The timeout period for sending a Viber message. This parameter is for the international site (alibabacloud.com). You can ignore it for the China site (aliyun.com).&lt;props=&quot;intl&quot;&gt;Unit: seconds. Valid values: 30 to 1209600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public long? Ttl { get; set; }

    }

}
