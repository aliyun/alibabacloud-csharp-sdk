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
        /// <para>This parameter is for internal testing, is not generally available, and can be ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123123********</para>
        /// </summary>
        [NameInMap("AdAccountId")]
        [Validation(Required=false)]
        public string AdAccountId { get; set; }

        /// <summary>
        /// <para>The message category for direct WhatsApp sending.</para>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>Specify this parameter only if you are a Meta-invited customer. Otherwise, the message may fail to send.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTILITY</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>whatsapp</b></para>
        /// </description></item>
        /// <item><description><para><b>messenger</b></para>
        /// </description></item>
        /// <item><description><para><b>instagram</b></para>
        /// </description></item>
        /// <item><description><para><b>telegram</b></para>
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
        /// <para>The message content, in a JSON-formatted string.</para>
        /// <para><b>Notes for WhatsApp messages:</b></para>
        /// <list type="bullet">
        /// <item><description><para>If <c>MessageType</c> is <c>text</c>, the <c>text</c> field is required, and the <c>Caption</c> field is not supported.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>image</c>, the <c>Link</c> field is required.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>video</c>, the <c>Link</c> field is required.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>audio</c>, the <c>Link</c> field is required. The <c>Caption</c> field is not supported.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>document</c>, the <c>Link</c> and <c>FileName</c> fields are required. The <c>Caption</c> field is not supported.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>interactive</c>, the <c>type</c> and <c>action</c> fields are required.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>contacts</c>, the <c>name</c> field is required.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>location</c>, the <c>longitude</c> and <c>latitude</c> fields are required.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>sticker</c>, the <c>Link</c> field is required. The <c>Caption</c> and <c>FileName</c> fields are not supported.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>reaction</c>, the <c>messageId</c> and <c>emoji</c> fields are required.</para>
        /// </description></item>
        /// </list>
        /// <para><b>Notes for Messenger messages:</b></para>
        /// <list type="bullet">
        /// <item><description><para>If <c>MessageType</c> is <c>text</c>, the <c>text</c> field is required.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>image</c>, <c>video</c>, <c>audio</c>, or <c>document</c>, the <c>link</c> field is required.</para>
        /// </description></item>
        /// </list>
        /// <para><b>Notes for Instagram messages:</b></para>
        /// <list type="bullet">
        /// <item><description><para>If <c>MessageType</c> is <c>text</c>, the <c>text</c> field is required.</para>
        /// </description></item>
        /// <item><description><para>If <c>MessageType</c> is <c>image</c>, <c>video</c>, or <c>audio</c>, the <c>link</c> field is required.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para><b>Notes for Viber messages:</b></para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>MessageType</c> is <c>text</c>, the <c>text</c> field is required.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>MessageType</c> is <c>image</c>, the <c>link</c> field is required.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>MessageType</c> is <c>video</c>, the <c>link</c>, <c>thumbnail</c>, <c>fileSize</c>, and <c>duration</c> fields are required.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>MessageType</c> is <c>document</c>, the <c>link</c>, <c>fileName</c>, and <c>fileType</c> fields are required.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>MessageType</c> is <c>text_button</c>, the <c>text</c>, <c>caption</c>, and <c>action</c> fields are required.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>MessageType</c> is <c>text_image_button</c>, the <c>text</c>, <c>link</c>, <c>caption</c>, and <c>action</c> fields are required.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>MessageType</c> is <c>text_video</c>, the <c>text</c>, <c>link</c>, <c>thumbnail</c>, <c>fileSize</c>, and <c>duration</c> fields are required.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>MessageType</c> is <c>text_video_button</c>, the <c>text</c>, <c>link</c>, <c>thumbnail</c>, <c>fileSize</c>, <c>duration</c>, and <c>caption</c> fields are required. The <c>action</c> field is not supported.</description></item>
        /// </list>
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
        /// <para>The ID of the message to which you are replying.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61851ccb2f1365b16aee****</para>
        /// </summary>
        [NameInMap("ContextMessageId")]
        [Validation(Required=false)]
        public string ContextMessageId { get; set; }

        /// <summary>
        /// <para>The Space ID of the ISV\&quot;s sub-account. For a direct customer, this is the Instance ID. You can find the ID on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> page.</para>
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
        /// <para><b>Deprecated.</b> Use <c>CustSpaceId</c> instead. The WABA ID of an ISV\&quot;s customer. For a direct customer, this is the Instance ID. You can find the ID on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8c8*********</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The custom content of the fallback message. This parameter is available only on the International Site and can be ignored if you are using the China site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fallback SMS</para>
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        /// <summary>
        /// <para>The duration after which a fallback is triggered. This parameter is available only on the International Site and can be ignored if you are using the China site.&lt;props=&quot;intl&quot;&gt; If a delivery receipt is not returned within the specified period, a fallback is triggered. If this parameter is omitted, a fallback is triggered only if the message fails to send or a failed delivery receipt is returned. Unit: seconds. The value must be between 60 and 43200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("FallBackDuration")]
        [Validation(Required=false)]
        public int? FallBackDuration { get; set; }

        /// <summary>
        /// <para>The ID of the fallback strategy. This parameter is available only on the International Site and can be ignored if you are using the China site.&lt;props=&quot;intl&quot;&gt; You can find the strategy ID on the <a href="https://chatapp.console.alibabacloud.com/FallbackStrategy"><b>Fallback Policy</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S0****</para>
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// <para>The fallback rule. This parameter is available only on the International Site and can be ignored if you are using the China site.
        /// &lt;props=&quot;intl&quot;&gt;Valid values:</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>undelivered</b>: A fallback is triggered if message delivery fails. The template and parameters must be valid at the time of sending. Blocked templates or phone numbers are not validated. This is the default rule if the parameter is empty.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>sentFailed</b>: A fallback is triggered if the message fails parameter validation, such as for the template or template parameters. Only the existence of <c>channelType</c>, <c>type</c>, <c>messageType</c>, <c>to</c>, and <c>from</c> is strictly validated.</description></item>
        /// </list>
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
        /// <para>The sender\&quot;s number or ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>ChannelType</c> is <b>whatsapp</b>, this is the phone number registered with WhatsApp. You can find the number on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>WABA Management</b> &gt; <b>Phone Number Management</b> page.</para>
        /// </description></item>
        /// <item><description><para>If <c>ChannelType</c> is <b>messenger</b>, this is the Facebook Page ID. You can find this ID on your &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Facebook Page</b> page.</para>
        /// </description></item>
        /// <item><description><para>If <c>ChannelType</c> is <b>instagram</b>, this is the Instagram professional account ID (Account ID). You can find the ID on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Professional Account</b> page.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>ChannelType</c> is <b>viber</b>, this is the Viber service ID (Service ID). You can find the ID on the <a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Service Number Management</b> page.</description></item>
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
        /// <para><b>Deprecated.</b> A verification code used to authorize an ISV\&quot;s sub-account. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123123******</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        [Obsolete]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The Viber message type. This parameter is available only on the International Site and can be ignored if you are using the China site.
        /// &lt;props=&quot;intl&quot;&gt;Valid values:</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>promotion</b>: A promotional or marketing message.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>transaction</b>: A notification message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>promotion</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The language of the message template. For a list of supported languages and their corresponding codes, see <a href="https://help.aliyun.com/document_detail/463420.html">language code</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The ID of the message campaign.</para>
        /// <remarks>
        /// <para>This parameter is for internal testing, is not generally available, and can be ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123123********</para>
        /// </summary>
        [NameInMap("MessageCampaignId")]
        [Validation(Required=false)]
        public string MessageCampaignId { get; set; }

        /// <summary>
        /// <para>The message type to use when <c>Type</c> is set to <c>message</c>. The valid values vary based on the channel type:</para>
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>WHATSAPP</para>
        /// </summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para><c>text</c>: A text message.</para>
        /// </description></item>
        /// <item><description><para><c>image</c>: An image message.</para>
        /// </description></item>
        /// <item><description><para><c>video</c>: A video message.</para>
        /// </description></item>
        /// <item><description><para><c>audio</c>: An audio message.</para>
        /// </description></item>
        /// <item><description><para><c>document</c>: A document message.</para>
        /// </description></item>
        /// <item><description><para><c>interactive</c>: An interactive message.</para>
        /// </description></item>
        /// <item><description><para><c>location</c>: A location message.</para>
        /// </description></item>
        /// <item><description><para><c>contacts</c>: A contacts message.</para>
        /// </description></item>
        /// <item><description><para><c>reaction</c>: A reaction message.</para>
        /// </description></item>
        /// <item><description><para><c>sticker</c>: A sticker message.</para>
        /// </description></item>
        /// <item><description><para><c>typing_indicator</c>: A typing indicator message.</para>
        /// </description></item>
        /// <item><description><para><c>pin</c>: A message to pin or unpin. This type is available only for group messages.</para>
        /// </description></item>
        /// <item><description><para><c>carousel</c>: A carousel message.</para>
        /// </description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>VIBER</para>
        /// </summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para><c>text</c>: A text message.</para>
        /// </description></item>
        /// <item><description><para><c>image</c>: An image message.</para>
        /// </description></item>
        /// <item><description><para><c>text_image_button</c>: A message with text, an image, and a button.</para>
        /// </description></item>
        /// <item><description><para><c>text_button</c>: A message with text and a button.</para>
        /// </description></item>
        /// <item><description><para><c>document</c>: A document message.</para>
        /// </description></item>
        /// <item><description><para><c>video</c>: A video message.</para>
        /// </description></item>
        /// <item><description><para><c>text_video</c>: A message with text and a video.</para>
        /// </description></item>
        /// <item><description><para><c>text_video_button</c>: A message with text, a video, and a button.</para>
        /// </description></item>
        /// <item><description><para><c>text_image</c>: A message with text and an image.</para>
        /// </description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>MESSENGER / INSTAGRAM</para>
        /// </summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para><c>text</c>: A text message.</para>
        /// </description></item>
        /// <item><description><para><c>image</c>: An image message.</para>
        /// </description></item>
        /// <item><description><para><c>video</c>: A video message.</para>
        /// </description></item>
        /// <item><description><para><c>document</c>: A document message.</para>
        /// </description></item>
        /// <item><description><para><c>audio</c>: An audio message.</para>
        /// </description></item>
        /// <item><description><para><c>interactive</c>: An interactive message.</para>
        /// </description></item>
        /// <item><description><para><c>couponTemplate</c>: A coupon template message.</para>
        /// </description></item>
        /// <item><description><para><c>regularTemplate</c>: A regular template message.</para>
        /// </description></item>
        /// <item><description><para><c>quickReply</c>: A quick reply message.</para>
        /// </description></item>
        /// <item><description><para><c>buttonTemplate</c>: A button template message.</para>
        /// </description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// 
        /// <summary>
        /// 
        /// <para>TELEGRAM</para>
        /// </summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para><c>text</c>: A text message.</para>
        /// </description></item>
        /// <item><description><para><c>image</c>: An image message.</para>
        /// </description></item>
        /// <item><description><para><c>video</c>: A video message.</para>
        /// </description></item>
        /// <item><description><para><c>audio</c>: An audio message.</para>
        /// </description></item>
        /// <item><description><para><c>document</c>: A document message.</para>
        /// </description></item>
        /// <item><description><para><c>location</c>: A location message.</para>
        /// </description></item>
        /// <item><description><para><c>gif</c>: An animated GIF message.</para>
        /// </description></item>
        /// <item><description><para><c>sticker</c>: A sticker message.</para>
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
        /// <para>An array of custom data strings that are sent to your webhook when a user clicks a corresponding button.</para>
        /// 
        /// <b>Example:</b>
        /// <para>payloadtext1,payloadtext2,payloadtext3</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string PayloadShrink { get; set; }

        /// <summary>
        /// <para>Product information that you have uploaded to Meta. This parameter applies to WhatsApp channels only.</para>
        /// </summary>
        [NameInMap("ProductAction")]
        [Validation(Required=false)]
        public string ProductActionShrink { get; set; }

        /// <summary>
        /// <para>The recipient type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>individual</c>: A single recipient.</para>
        /// </description></item>
        /// <item><description><para><c>group</c>: A group.</para>
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
        /// <para>A custom tag for the Viber message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>A custom task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The message template code. You can find the code on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Template Design</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1119***************</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The template name. You can find the template name on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>Template Design</b> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The parameters for the message template.</para>
        /// </summary>
        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public string TemplateParamsShrink { get; set; }

        /// <summary>
        /// <para>The recipient\&quot;s number or ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>ChannelType</c> is <b>whatsapp</b>, this is the recipient\&quot;s phone number.</para>
        /// </description></item>
        /// <item><description><para>If <c>ChannelType</c> is <b>messenger</b>, this is a Page-Scoped User ID (PSID) generated when a user interacts with your Facebook Page.</para>
        /// </description></item>
        /// <item><description><para>If <c>ChannelType</c> is <b>instagram</b>, this is an Instagram-Scoped User ID (IGSID) generated when a user interacts with your Instagram business or creator account.</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <c>ChannelType</c> is <b>viber</b>, this is the recipient\&quot;s phone number.</description></item>
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
        /// <para>This parameter is for internal testing, is not generally available, and can be ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bearer</para>
        /// </summary>
        [NameInMap("TokenType")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// <para>Custom tracking data for a Viber message. This parameter is available only on the International Site and can be ignored if you are using the China site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tracking Data</para>
        /// </summary>
        [NameInMap("TrackingData")]
        [Validation(Required=false)]
        public string TrackingData { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) for a Viber message. This parameter is available only on the International Site and can be ignored if you are using the China site.&lt;props=&quot;intl&quot;&gt; Unit: seconds. The value must be between 30 and 1209600.</para>
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
        /// <item><description><para><c>template</c>: A message template approved in the console. You can send this type of message at any time.</para>
        /// </description></item>
        /// <item><description><para><c>message</c>: A message of any format. You can send this type of message only within 24 hours of receiving the last message from a user.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>If you set <c>Type</c> to <c>template</c>, you must set the <c>TemplateCode</c> parameter. If you set <c>Type</c> to <c>message</c>, you must set the <c>MessageType</c> parameter.</para>
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
