// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMessageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Meta ad account ID.</para>
        /// <remarks>
        /// <para>This parameter is a test parameter that is not fully available. Ignore this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123123********</para>
        /// </summary>
        [NameInMap("AdAccountId")]
        [Validation(Required=false)]
        public string AdAccountId { get; set; }

        /// <summary>
        /// <para>The message category (for WhatsApp direct send).</para>
        /// <remarks>
        /// <para>Warning: Do not specify this parameter unless you are a Meta-invited customer. Otherwise, message delivery will fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>UTILITY</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The channel type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><para><b>whatsapp</b> </para>
        /// </description></item>
        /// <item><description><para><b>messenger</b> </para>
        /// </description></item>
        /// <item><description><para><b>instagram</b></para>
        /// </description></item>
        /// <item><description><para><b>telegram</b></para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;- <b>viber</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>whatsapp</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The message content.</para>
        /// <para><b>WhatsApp message notes:</b></para>
        /// <list type="bullet">
        /// <item><description>If <b>messageType</b> is <b>text</b>, the <b>text</b> field is required and the <b>Caption</b> field must not be specified.</description></item>
        /// <item><description>If <b>messageType</b> is <b>image</b>, the <b>Link</b> field is required.</description></item>
        /// <item><description>If <b>messageType</b> is <b>video</b>, the <b>Link</b> field is required.</description></item>
        /// <item><description>If <b>messageType</b> is <b>audio</b>, the <b>Link</b> field is required and the <b>Caption</b> field is invalid.</description></item>
        /// <item><description>If <b>messageType</b> is <b>document</b>, the <b>Link</b> and <b>FileName</b> fields are required and the <b>Caption</b> field is invalid.</description></item>
        /// <item><description>If <b>messageType</b> is <b>interactive</b>, the <b>type</b> and <b>action</b> fields are required.</description></item>
        /// <item><description>If <b>messageType</b> is <b>contacts</b>, the <b>name</b> field is required.</description></item>
        /// <item><description>If <b>messageType</b> is <b>location</b>, the <b>longitude</b> and <b>latitude</b> fields are required.</description></item>
        /// <item><description>If <b>messageType</b> is <b>sticker</b>, the <b>Link</b> field is required and the <b>Caption</b> and <b>FileName</b> fields are invalid.</description></item>
        /// <item><description>If <b>messageType</b> is <b>reaction</b>, the <b>messageId</b> and <b>emoji</b> fields are required.</description></item>
        /// </list>
        /// <para><b>Messenger message notes:</b></para>
        /// <list type="bullet">
        /// <item><description>If <b>messageType</b> is <b>text</b>, the <b>text</b> field is required.</description></item>
        /// <item><description>If <b>messageType</b> is <b>image</b>, <b>video</b>, <b>audio</b>, or <b>document</b>, the <b>link</b> field is required.</description></item>
        /// </list>
        /// <para><b>Instagram message notes:</b></para>
        /// <list type="bullet">
        /// <item><description>If <b>messageType</b> is <b>text</b>, the <b>text</b> field is required.</description></item>
        /// <item><description>If <b>messageType</b> is <b>image</b>, <b>video</b>, or <b>audio</b>, the <b>link</b> field is required.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;<b>Viber message notes:</b>
        /// &lt;props=&quot;intl&quot;&gt;- If <b>messageType</b> is <b>text</b>, the <b>text</b> field is required.
        /// &lt;props=&quot;intl&quot;&gt;- If <b>messageType</b> is <b>image</b>, the <b>link</b> field is required.
        /// &lt;props=&quot;intl&quot;&gt;- If <b>messageType</b> is <b>video</b>, the <b>link</b>, <b>thumbnail</b>, <b>fileSize</b>, and <b>duration</b> fields are required.
        /// &lt;props=&quot;intl&quot;&gt;- If <b>messageType</b> is <b>document</b>, the <b>link</b>, <b>fileName</b>, and <b>fileType</b> fields are required.
        /// &lt;props=&quot;intl&quot;&gt;- If <b>messageType</b> is <b>text_button</b>, the <b>text</b>, <b>caption</b>, and <b>action</b> fields are required.
        /// &lt;props=&quot;intl&quot;&gt;- If <b>messageType</b> is <b>text_image_button</b>, the <b>text</b>, <b>link</b>, <b>caption</b>, and <b>action</b> fields are required.
        /// &lt;props=&quot;intl&quot;&gt;- If <b>messageType</b> is <b>text_video</b>, the <b>text</b>, <b>link</b>, <b>thumbnail</b>, <b>fileSize</b>, and <b>duration</b> fields are required.
        /// &lt;props=&quot;intl&quot;&gt;- If <b>messageType</b> is <b>text_video_button</b>, the <b>text</b>, <b>link</b>, <b>thumbnail</b>, <b>fileSize</b>, <b>duration</b>, and <b>caption</b> fields are required, and the <b>action</b> field must not be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;text&quot;: &quot;hello,whatsapp&quot;,
        ///   &quot;link&quot;: &quot;https://<em><b><b><b>&quot;,
        ///   &quot;caption&quot;: &quot;</b></b>&quot;,
        ///   &quot;fileName&quot;: &quot;</b></em>*&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the message to reply to. This is the ID of a previously sent or received message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61851ccb2f1365b16aee****</para>
        /// </summary>
        [NameInMap("ContextMessageId")]
        [Validation(Required=false)]
        public string ContextMessageId { get; set; }

        /// <summary>
        /// <para>The SpaceId of the ISV sub-customer, or the direct customer instance ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> page.</para>
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
        /// <para>The ISV customer WABA ID. This parameter is deprecated. Use CustSpaceId instead, which is the direct customer instance ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8c8*********</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The custom fallback content. This parameter is for the China site (Chinese mainland). China site users can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fallback SMS</para>
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        /// <summary>
        /// <para>The fallback trigger time. This parameter is for the international site. China site users can ignore this parameter. &lt;props=&quot;intl&quot;&gt;If the message does not return a delivered receipt within the specified time, fallback is triggered. If this parameter is not specified, fallback is not triggered based on time and occurs only when the message fails to send or a failure status report is received. Unit: seconds. Minimum value: 60. Maximum value: 43200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("FallBackDuration")]
        [Validation(Required=false)]
        public int? FallBackDuration { get; set; }

        /// <summary>
        /// <para>The fallback policy ID. This parameter is for the China site (Chinese mainland). China site users can ignore this parameter. &lt;props=&quot;intl&quot;&gt;You can view the policy ID on the <a href="https://chatapp.console.alibabacloud.com/FallbackStrategy"><b>Fallback Policy</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S0****</para>
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// <para>The fallback rule. This parameter is for the international site. China site users can ignore this parameter.
        /// &lt;props=&quot;intl&quot;&gt;Valid values:
        /// &lt;props=&quot;intl&quot;&gt;- <b>undelivered</b>: fallback is triggered when the message cannot be delivered to the device (template and parameter validation must pass at the sending stage; template bans or number bans are not validated). This rule is used by default if the parameter value is empty.
        /// &lt;props=&quot;intl&quot;&gt;- <b>sentFailed</b>: fallback is also triggered when template or template variable validation fails. Only the channelType, type, messageType, to, and from (existence check) parameters are strictly validated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>undelivered</para>
        /// </summary>
        [NameInMap("FallBackRule")]
        [Validation(Required=false)]
        public string FallBackRule { get; set; }

        /// <summary>
        /// <para>The Flow message object.</para>
        /// </summary>
        [NameInMap("FlowAction")]
        [Validation(Required=false)]
        public string FlowActionShrink { get; set; }

        /// <summary>
        /// <para>The sender number.</para>
        /// <list type="bullet">
        /// <item><description>If ChannelType is set to <b>whatsapp</b>, this is the phone number registered and bindded with WhatsApp. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>WABA Management</b> &gt; <b>Phone Number Management</b> page.</description></item>
        /// <item><description>If ChannelType is set to <b>messenger</b>, this is the Page ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Public Page</b> page.</description></item>
        /// <item><description>If ChannelType is set to <b>instagram</b>, this is the Instagram professional account ID (Account ID). You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Professional Account</b> page.
        /// &lt;props=&quot;intl&quot;&gt;- If ChannelType is set to <b>viber</b>, this is the Viber Service ID. You can view it on the <a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Service ID Management</b> page.</description></item>
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
        /// <para>The ISV verification code used to verify whether a RAM user is authorized by the ISV. This parameter is deprecated and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123******</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        [Obsolete]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The Viber message type. This parameter is for the international site. China site users can ignore this parameter.
        /// &lt;props=&quot;intl&quot;&gt;Valid values:
        /// &lt;props=&quot;intl&quot;&gt;- <b>pormotion</b>: marketing or promotional messages.
        /// &lt;props=&quot;intl&quot;&gt;- <b>transaction</b>: notification messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>promotion</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The language. For a list of language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The campaign message ID.</para>
        /// <remarks>
        /// <para>This parameter is a test parameter that is not fully available. Ignore this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123123********</para>
        /// </summary>
        [NameInMap("MessageCampaignId")]
        [Validation(Required=false)]
        public string MessageCampaignId { get; set; }

        /// <summary>
        /// <para>The detailed message type when Type is set to message. Valid values:</para>
        /// <details>
        /// <summary>WHATSAPP</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>text: text message.</para>
        /// </description></item>
        /// <item><description><para>image: image message.</para>
        /// </description></item>
        /// <item><description><para>video: video message.</para>
        /// </description></item>
        /// <item><description><para>audio: audio message.</para>
        /// </description></item>
        /// <item><description><para>document: document message.</para>
        /// </description></item>
        /// <item><description><para>interactive: interactive message.</para>
        /// </description></item>
        /// <item><description><para>location: location message.</para>
        /// </description></item>
        /// <item><description><para>contacts: contacts message.</para>
        /// </description></item>
        /// <item><description><para>reaction: reaction message.</para>
        /// </description></item>
        /// <item><description><para>sticker: sticker message.</para>
        /// </description></item>
        /// <item><description><para>typing_indicator: typing indicator message.</para>
        /// </description></item>
        /// <item><description><para>pin: pin or unpin message (available only for group messages).</para>
        /// </description></item>
        /// <item><description><para>carousel: carousel message.</para>
        /// </details></description></item>
        /// </list>
        /// <details>
        /// <summary>VIBER</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>text: text message.</para>
        /// </description></item>
        /// <item><description><para>image: image message.</para>
        /// </description></item>
        /// <item><description><para>text_image_button: text + image + button message.</para>
        /// </description></item>
        /// <item><description><para>text_button: text + button message.</para>
        /// </description></item>
        /// <item><description><para>document: document message.</para>
        /// </description></item>
        /// <item><description><para>video: video message.</para>
        /// </description></item>
        /// <item><description><para>text_video: text + video message.</para>
        /// </description></item>
        /// <item><description><para>text_video_button: text + video + button message.</para>
        /// </description></item>
        /// <item><description><para>text_image: text + image message.</para>
        /// </details></description></item>
        /// </list>
        /// <details>
        /// <summary>MESSENGER / INSTAGRAM</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>text: text message.</para>
        /// </description></item>
        /// <item><description><para>image: image message.</para>
        /// </description></item>
        /// <item><description><para>video: video message.</para>
        /// </description></item>
        /// <item><description><para>document: document message.</para>
        /// </description></item>
        /// <item><description><para>audio: audio message.</para>
        /// </description></item>
        /// <item><description><para>interactive: interactive message.</para>
        /// </description></item>
        /// <item><description><para>couponTemplate: coupon template message.</para>
        /// </description></item>
        /// <item><description><para>regularTemplate: regular template message.</para>
        /// </description></item>
        /// <item><description><para>quickReply: quick reply message.</para>
        /// </description></item>
        /// <item><description><para>buttonTemplate: button template message.</para>
        /// </details></description></item>
        /// </list>
        /// <details>
        /// <summary>TELEGRAM</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>text: text message.</para>
        /// </description></item>
        /// <item><description><para>image: image message.</para>
        /// </description></item>
        /// <item><description><para>video: video message.</para>
        /// </description></item>
        /// <item><description><para>audio: audio message.</para>
        /// </description></item>
        /// <item><description><para>document: document message.</para>
        /// </description></item>
        /// <item><description><para>location: location message.</para>
        /// </description></item>
        /// <item><description><para>gif: animated GIF message.</para>
        /// </description></item>
        /// <item><description><para>sticker: sticker message.</para>
        /// </description></item>
        /// </list>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The collection of button trigger messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>payloadtext1,payloadtext2,payloadtext3</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string PayloadShrink { get; set; }

        /// <summary>
        /// <para>The product information. This parameter applies only to the WhatsApp channel type and refers to the product information you uploaded on Meta.</para>
        /// </summary>
        [NameInMap("ProductAction")]
        [Validation(Required=false)]
        public string ProductActionShrink { get; set; }

        /// <summary>
        /// <para>The recipient type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>individual: an individual.</para>
        /// </description></item>
        /// <item><description><para>group: a group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>individual</para>
        /// </summary>
        [NameInMap("RecipientType")]
        [Validation(Required=false)]
        public string RecipientType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tag information. Custom tag information for Viber message delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag</para>
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
        /// <para>The template code. You can view the template code on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Template Design</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1119***************</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The template name. You can view the template name on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Template Design</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The collection of template parameters.</para>
        /// </summary>
        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public string TemplateParamsShrink { get; set; }

        /// <summary>
        /// <para>The recipient number.</para>
        /// <list type="bullet">
        /// <item><description>If ChannelType is set to <b>whatsapp</b>, this is the phone number of the message recipient.</description></item>
        /// <item><description>If ChannelType is set to <b>messenger</b>, this is the Page-Scoped User ID generated when the user interacts with the Facebook page.</description></item>
        /// <item><description>If ChannelType is set to <b>instagram</b>, this is the Instagram User ID generated when the user interacts with the Instagram business or creator account.
        /// &lt;props=&quot;intl&quot;&gt;- If ChannelType is set to <b>viber</b>, this is the phone number of the message recipient.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>861388988****</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// <para>The token type.</para>
        /// <remarks>
        /// <para>This parameter is a test parameter that is not fully available. Ignore this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bearer</para>
        /// </summary>
        [NameInMap("TokenType")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// <para>The custom tracking data passed in for Viber message types. This parameter is for the international site. China site users can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tracking Data</para>
        /// </summary>
        [NameInMap("TrackingData")]
        [Validation(Required=false)]
        public string TrackingData { get; set; }

        /// <summary>
        /// <para>The timeout period for Viber message delivery. This parameter is for the international site. China site users can ignore this parameter. &lt;props=&quot;intl&quot;&gt;Unit: seconds. Valid values: 30 to 1209600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The message type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>template: a message template that has been approved in the console. This type of message can be sent at any time.</para>
        /// </description></item>
        /// <item><description><para>message: a message in any format. This type of message can be sent only within 24 hours after the last message is received from the user.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: If Type is set to template, you must specify TemplateCode. If Type is set to message, you must specify MessageType.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
