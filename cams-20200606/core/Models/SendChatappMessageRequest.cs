// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMessageRequest : TeaModel {
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
        /// <para>The message type (for WhatsApp direct send).</para>
        /// <remarks>
        /// <para>Warning: Do not specify this parameter if you are not a Meta-invited customer. Otherwise, message sending fails.</para>
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
        /// <item><description><para><b>line</b></para>
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
        /// <details>
        /// <summary>WhatsApp message notes:</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>When <b>messageType</b> is <b>text</b>, the <b>text</b> field is required and the <b>Caption</b> field must not be specified.</description></item>
        /// <item><description>When <b>messageType</b> is <b>image</b>, the <b>Link</b> field is required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>video</b>, the <b>Link</b> field is required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>audio</b>, the <b>Link</b> field is required and the <b>Caption</b> field is invalid.</description></item>
        /// <item><description>When <b>messageType</b> is <b>document</b>, the <b>Link</b> and <b>FileName</b> fields are required and the <b>Caption</b> field is invalid.</description></item>
        /// <item><description>When <b>messageType</b> is <b>interactive</b>, the <b>type</b> and <b>action</b> fields are required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>contacts</b>, the <b>name</b> field is required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>location</b>, the <b>longitude</b> and <b>latitude</b> fields are required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>sticker</b>, the <b>Link</b> field is required and the <b>Caption</b> and <b>FileName</b> fields are invalid.</description></item>
        /// <item><description>When <b>messageType</b> is <b>reaction</b>, the <b>messageId</b> and <b>emoji</b> fields are required.</details></description></item>
        /// </list>
        /// <details>
        /// <summary>Messenger message notes:</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>When <b>messageType</b> is <b>text</b>, the <b>text</b> field is required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>image</b>, <b>video</b>, <b>audio</b>, or <b>document</b>, the <b>link</b> field is required.</details></description></item>
        /// </list>
        /// <details>
        /// <summary>Instagram message notes:</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>When <b>messageType</b> is <b>text</b>, the <b>text</b> field is required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>image</b>, <b>video</b>, or <b>audio</b>, the <b>link</b> field is required.</details></description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <details>
        /// <summary>Viber message notes:</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>When <b>messageType</b> is <b>text</b>, the <b>text</b> field is required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>image</b>, the <b>link</b> field is required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>video</b>, the <b>link</b>, <b>thumbnail</b>, <b>fileSize</b>, and <b>duration</b> fields are required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>document</b>, the <b>link</b>, <b>fileName</b>, and <b>fileType</b> fields are required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>text_button</b>, the <b>text</b>, <b>caption</b>, and <b>action</b> fields are required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>text_image_button</b>, the <b>text</b>, <b>link</b>, <b>caption</b>, and <b>action</b> fields are required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>text_video</b>, the <b>text</b>, <b>link</b>, <b>thumbnail</b>, <b>fileSize</b>, and <b>duration</b> fields are required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>text_video_button</b>, the <b>text</b>, <b>link</b>, <b>thumbnail</b>, <b>fileSize</b>, <b>duration</b>, and <b>caption</b> fields are required, and the <b>action</b> field must not be empty.</details></description></item>
        /// </list>
        /// <details>
        /// <summary>Telegram message notes:</summary>
        /// 
        /// <list type="bullet">
        /// <item><description>When <b>messageType</b> is <b>text</b>, the <b>text</b> field is required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>image</b>, <b>video</b>, <b>audio</b>, <b>gif</b>, or <b>sticker</b>, the <b>link</b> field is required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>location</b>, the <b>latitude</b> and <b>longitude</b> fields are required.</description></item>
        /// <item><description>When <b>messageType</b> is <b>interactive</b>, the <b>type</b> field is required. You can send various Telegram message types. Example: {&quot;type&quot;: &quot;sendPhoto&quot;, &quot;sendPhoto&quot;: {&quot;photo&quot;:&quot;<a href="http://img.png%22,%22caption%22:%2221%22%7D%7D">http://img.png&quot;,&quot;caption&quot;:&quot;21&quot;}}</a>. This can be used to send a Photo type message. For more information about message types, see <a href="https://core.telegram.org/bots/api#sendphoto">Telegram message body</a>.</details></description></item>
        /// </list>
        /// <details>
        /// <summary>LINE message notes:</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>When <b>messageType</b> is <b>text</b> or <b>textV2</b>, the <b>text</b> field is required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>image</b> or <b>video</b>, the <b>link</b> and <b>previewImageUrl</b> fields are required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>audio</b>, the <b>link</b> and <b>duration</b> fields are required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>buttons</b> or <b>confirm</b>, the <b>text</b> and <b>actions</b> fields are required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>carousel</b> or <b>imageCarousel</b>, the <b>columns</b> field is required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>quickReply</b>, the <b>text</b> and <b>items</b> fields are required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>sticker</b>, the <b>packageId</b> and <b>stickerId</b> fields are required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>location</b>, the <b>title</b>, <b>address</b>, <b>latitude</b>, and <b>longitude</b> fields are required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>coupon</b>, the <b>couponId</b> field is required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>imagemap</b>, the <b>baseUrl</b> and <b>altText</b> fields are required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>flex</b>, the <b>contents</b> and <b>altText</b> fields are required.</para>
        /// </description></item>
        /// <item><description><para>When <b>messageType</b> is <b>interactive</b>, you can pass in message formats supported by LINE:</para>
        /// <list type="bullet">
        /// <item><description>To send a single message, the <b>type</b> field is required, and other fields follow the LINE message body format. Example: {&quot;type&quot;: &quot;text&quot;, &quot;text&quot;: &quot;test&quot;}</description></item>
        /// <item><description>To send multiple messages (LINE supports up to 5 messages at a time), the <b>messages</b> field is required. Example: {&quot;messages&quot;: [{&quot;type&quot;: &quot;text&quot;, &quot;text&quot;: &quot;test&quot;}, {&quot;type&quot;: &quot;image&quot;, &quot;originalContentUrl&quot;: &quot;<a href="http://img.png">http://img.png</a>&quot;, &quot;previewImageUrl&quot;: &quot;<a href="http://img2.png%22%7D%5D%7D">http://img2.png&quot;}]}</a></description></item>
        /// <item><description>For more information, see <a href="https://developers.line.biz/en/reference/messaging-api/#message-objects">LINE message body</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </details>
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
        /// <para>The SpaceId of the ISV sub-customer or the instance ID of a direct customer. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> page.</para>
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
        /// <para>The ISV customer WABA ID. </para>
        /// <remarks>
        /// <para>This parameter is deprecated. Use CustSpaceId instead.</para>
        /// <list type="bullet">
        /// <item><description>You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> page.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8c8*********</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The custom fallback content. This parameter is for the China International site. China site users can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fallback SMS</para>
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        /// <summary>
        /// <para>The fallback trigger time. This parameter is for the China International site. China site users can ignore this parameter. &lt;props=&quot;intl&quot;&gt;If the message does not return a delivered receipt within the specified time, fallback is triggered. If this parameter is not specified, fallback is triggered only when the message fails to send or a failure status report is received. Unit: seconds. Minimum value: 60. Maximum value: 43200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("FallBackDuration")]
        [Validation(Required=false)]
        public int? FallBackDuration { get; set; }

        /// <summary>
        /// <para>The fallback policy ID. This parameter is for the China International site. China site users can ignore this parameter. &lt;props=&quot;intl&quot;&gt;You can view the policy ID on the <a href="https://chatapp.console.alibabacloud.com/FallbackStrategy"><b>Fallback Strategy</b></a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S0****</para>
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// <para>The fallback rule. This parameter is for the China International site. China site users can ignore this parameter.
        /// &lt;props=&quot;intl&quot;&gt;Valid values:
        /// &lt;props=&quot;intl&quot;&gt;- <b>undelivered</b>: fallback is triggered when the message cannot be delivered to the endpoint (template and parameter validation must pass during the sending state; blocked templates or numbers are not validated). This rule is used by default when the parameter value is empty.
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
        /// <remarks>
        /// <para>Valid only for WHATSAPP.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("FlowAction")]
        [Validation(Required=false)]
        public SendChatappMessageRequestFlowAction FlowAction { get; set; }
        public class SendChatappMessageRequestFlowAction : TeaModel {
            /// <summary>
            /// <para>The collection of Flow default parameters.</para>
            /// </summary>
            [NameInMap("FlowActionData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FlowActionData { get; set; }

            /// <summary>
            /// <para>The custom Flow token information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kde****</para>
            /// </summary>
            [NameInMap("FlowToken")]
            [Validation(Required=false)]
            public string FlowToken { get; set; }

        }

        /// <summary>
        /// <para>The sender number.</para>
        /// <list type="bullet">
        /// <item><description>When ChannelType is <b>whatsapp</b>, this is the phone number registered and bindng with WhatsApp. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>WABA Management</b> &gt; <b>Number Management</b> page.</description></item>
        /// <item><description>When ChannelType is <b>messenger</b>, this is the Page ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Public Page</b> page.</description></item>
        /// <item><description>When ChannelType is <b>instagram</b>, this is the Instagram professional account ID (Account ID). You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Professional Account</b> page.
        /// &lt;props=&quot;intl&quot;&gt;- When ChannelType is <b>viber</b>, this is the Viber Service ID. You can view it on the <a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Service ID Management</b> page.</description></item>
        /// <item><description>When ChannelType is <b>telegram</b>, this is the Telegram bot ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Bot Management</b> page.</description></item>
        /// <item><description>When ChannelType is <b>line</b>, this is the LINE Channel ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>LINE Official Account</b> page.</description></item>
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
        /// <para>The ISV verification code.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. You can ignore it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123123******</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        [Obsolete]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The Viber message type. This parameter is for the China International site. China site users can ignore this parameter.
        /// &lt;props=&quot;intl&quot;&gt;Valid values:
        /// &lt;props=&quot;intl&quot;&gt;- <b>pormotion</b>: marketing or promotional messages.
        /// &lt;props=&quot;intl&quot;&gt;- <b>transaction</b>: notification messages.</para>
        /// <remarks>
        /// <para>Valid only for VIBER.</para>
        /// </remarks>
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
        /// <item><description><para>pin: pin or unpin message (group messages only).</para>
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
        /// <item><description><para>interactive: custom pass-through Telegram message.</para>
        /// </description></item>
        /// </list>
        /// </details>
        /// 
        /// <details>
        /// <summary>LINE</summary>
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
        /// <item><description><para>buttons: button message.</para>
        /// </description></item>
        /// <item><description><para>confirm: confirm message.</para>
        /// </description></item>
        /// <item><description><para>carousel: carousel message.</para>
        /// </description></item>
        /// <item><description><para>imageCarousel: image carousel message.</para>
        /// </description></item>
        /// <item><description><para>quickReply: quick reply message.</para>
        /// </description></item>
        /// <item><description><para>sticker: sticker message.</para>
        /// </description></item>
        /// <item><description><para>location: location message.</para>
        /// </description></item>
        /// <item><description><para>textV2: text message (V2).</para>
        /// </description></item>
        /// <item><description><para>coupon: coupon message.</para>
        /// </description></item>
        /// <item><description><para>imagemap: imagemap message.</para>
        /// </description></item>
        /// <item><description><para>flex: flex message.</para>
        /// </description></item>
        /// <item><description><para>interactive: custom pass-through LINE message.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para><a href="https://developers.line.biz/en/reference/messaging-api/#message-objects">For more information, see the message types supported by LINE</a></para>
        /// </remarks>
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
        /// <remarks>
        /// <para>This parameter is valid only for WHATSAPP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>payloadtext1,payloadtext2,payloadtext3</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public List<string> Payload { get; set; }

        /// <summary>
        /// <para>The product information. This parameter is valid only for WhatsApp channel types. It refers to the product information you uploaded on Meta.</para>
        /// <remarks>
        /// <para>Valid only for WHATSAPP.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ProductAction")]
        [Validation(Required=false)]
        public SendChatappMessageRequestProductAction ProductAction { get; set; }
        public class SendChatappMessageRequestProductAction : TeaModel {
            /// <summary>
            /// <para>The list of product categories (up to 10 categories and 30 products).</para>
            /// </summary>
            [NameInMap("Sections")]
            [Validation(Required=false)]
            public List<SendChatappMessageRequestProductActionSections> Sections { get; set; }
            public class SendChatappMessageRequestProductActionSections : TeaModel {
                /// <summary>
                /// <para>The list of product items.</para>
                /// </summary>
                [NameInMap("ProductItems")]
                [Validation(Required=false)]
                public List<SendChatappMessageRequestProductActionSectionsProductItems> ProductItems { get; set; }
                public class SendChatappMessageRequestProductActionSectionsProductItems : TeaModel {
                    /// <summary>
                    /// <para>The product ID. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Catalog Management</b> &gt; <b>Product Management</b> page, or obtain it by calling the <a href="https://help.aliyun.com/document_detail/2557786.html">ListProduct</a> operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ksi3****</para>
                    /// </summary>
                    [NameInMap("ProductRetailerId")]
                    [Validation(Required=false)]
                    public string ProductRetailerId { get; set; }

                }

                /// <summary>
                /// <para>The category name. You can view it on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList"><b>Channel Management</b></a> &gt; <b>Management</b> &gt; <b>Catalog Management</b> &gt; <b>Product Management</b> page, or obtain it by calling the <a href="https://help.aliyun.com/document_detail/2557786.html">ListProduct</a> operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The product catalog ID. You can obtain it by calling the <a href="https://help.aliyun.com/document_detail/2539783.html">ListProductCatalog</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skkks99****</para>
            /// </summary>
            [NameInMap("ThumbnailProductRetailerId")]
            [Validation(Required=false)]
            public string ThumbnailProductRetailerId { get; set; }

        }

        /// <summary>
        /// <para>The recipient type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>individual: an individual.</para>
        /// </description></item>
        /// <item><description><para>group: a group.</para>
        /// </description></item>
        /// <item><description><para>userId: WhatsApp BSUID. Valid only for WHATSAPP.</para>
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
        /// <para>The tag information. Custom tag information when sending Viber messages.</para>
        /// <remarks>
        /// <para>Valid only for VIBER.</para>
        /// </remarks>
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
        public Dictionary<string, string> TemplateParams { get; set; }

        /// <summary>
        /// <para>The recipient number.</para>
        /// <list type="bullet">
        /// <item><description>When ChannelType is <b>whatsapp</b>, this is the phone number or BSUID of the message recipient.</description></item>
        /// <item><description>When ChannelType is <b>messenger</b>, this is the Page-Scoped User ID generated when the user interacts with the Facebook page.</description></item>
        /// <item><description>When ChannelType is <b>instagram</b>, this is the Instagram User ID generated when the user interacts with the Instagram business or creator account.
        /// &lt;props=&quot;intl&quot;&gt;- When ChannelType is <b>viber</b>, this is the phone number of the message recipient.</description></item>
        /// <item><description>When ChannelType is <b>telegram</b>, this is the Telegram chatId.</description></item>
        /// <item><description>When ChannelType is <b>line</b>, this is the LINE User ID.</description></item>
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
        /// <para>The custom tracking data passed in for Viber message types. This parameter is for the China International site. China site users can ignore this parameter.</para>
        /// <remarks>
        /// <para>Valid only for VIBER.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Tracking Data</para>
        /// </summary>
        [NameInMap("TrackingData")]
        [Validation(Required=false)]
        public string TrackingData { get; set; }

        /// <summary>
        /// <para>The Viber message sending timeout period. This parameter is for the China International site. China site users can ignore this parameter. &lt;props=&quot;intl&quot;&gt;Unit: seconds. Valid values: 30 to 1209600.</para>
        /// <remarks>
        /// <para>Valid only for VIBER.</para>
        /// </remarks>
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
        /// <item><description><para>message: a message in any format. This type of message can only be sent within 24 hours after receiving the last message from the user.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: When Type is set to template, you must specify TemplateCode. When Type is set to message, you must specify MessageType.</para>
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
