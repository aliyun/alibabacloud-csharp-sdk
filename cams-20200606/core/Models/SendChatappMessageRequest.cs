// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMessageRequest : TeaModel {
        /// <summary>
        /// <para>The channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>whatsapp</b></description></item>
        /// <item><description><b>viber</b></description></item>
        /// <item><description><b>line</b> (under development)</description></item>
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
        /// <para>The message content.</para>
        /// <para><b>Notes on WhatsApp messages:</b></para>
        /// <list type="bullet">
        /// <item><description>If you set <b>messageType</b> to <b>text</b>, you must specify <b>text</b> and must not specify <b>Caption</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>image</b>, you must specify <b>Link</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>video</b>, you must specify <b>Link</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>audio</b>, <b>Link</b> is required and <b>Caption</b> is invalid.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>document</b>, <b>Link</b> and <b>FileName</b> are required and <b>Caption</b> is invalid.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>interactive</b>, you must specify <b>type</b> and <b>action</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>contacts</b>, you must specify <b>name</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>location</b>, you must specify <b>longitude</b> and <b>latitude</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>sticker</b>, you must specify <b>Link</b>, and <b>Caption</b> and <b>FileName</b> are invalid.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>reaction</b>, you must specify <b>messageId</b> and <b>emoji</b>.</description></item>
        /// </list>
        /// <para><b>Notes on Viber messages:</b></para>
        /// <list type="bullet">
        /// <item><description>If you set <b>messageType</b> to <b>text</b>, you must specify <b>text</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>image</b>, you must specify <b>link</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>video</b>, you must specify <b>link</b>, <b>thumbnail</b>, <b>fileSize</b>, and <b>duration</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>document</b>, you must specify <b>link</b>, <b>fileName</b>, and <b>fileType</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>text_button</b>, you must specify <b>text</b>, <b>caption</b>, and <b>action</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>text_image_button</b>, you must specify <b>text</b>, <b>link</b>, <b>caption</b>, and <b>action</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>text_video</b>, you must specify <b>text</b>, <b>link</b>, <b>thumbnail</b>, <b>fileSize</b>, and <b>duration</b>.</description></item>
        /// <item><description>If you set <b>messageType</b> to <b>text_video_button</b>, you must specify <b>text</b>, <b>link</b>, <b>thumbnail</b>, <b>fileSize</b>, <b>duration</b>, and <b>caption</b>. In addition, you must not specify <b>action</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;text\&quot;: \&quot;hello whatsapp\&quot;, \&quot;link\&quot;: \&quot;\&quot;, \&quot;caption\&quot;: \&quot;\&quot;, \&quot;fileName\&quot;: \&quot;\&quot; }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the reply message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61851ccb2f1365b16aee****</para>
        /// </summary>
        [NameInMap("ContextMessageId")]
        [Validation(Required=false)]
        public string ContextMessageId { get; set; }

        /// <summary>
        /// <para>The space ID of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28251486512358****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The WhatsApp Business Account (WABA) ID of the RAM user within the independent software vendor (ISV) account.</para>
        /// <remarks>
        /// <para> CustWabaId is an obsolete parameter. Use CustSpaceId instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>65921621816****</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <para>The content of the fallback message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a fallback message.</para>
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        /// <summary>
        /// <para>Specifies the period of time after which the fallback message is sent if the message receipt that indicates the message is delivered to clients is not received. If this parameter is left empty, the fallback message is sent only when the <b>message fails to be sent</b> or <b>the message receipt that indicates the message is not delivered to clients</b> is received. Unit: seconds. Valid values: 60 to 43200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("FallBackDuration")]
        [Validation(Required=false)]
        public int? FallBackDuration { get; set; }

        /// <summary>
        /// <para>The ID of the fallback policy. You can create a fallback policy and view the information in the Chat App Message Service console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S_000001</para>
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// <para>The fallback rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>undelivered</b>: A fallback is triggered if the message is not delivered to clients. When the message is being sent, the template parameters are verified. If the parameters fail to pass the verification, the message fails to be sent. Whether the template and phone number are prohibited is not verified. By default, this value is used when FallBackRule is left empty.</description></item>
        /// <item><description><b>sentFailed</b>: A fallback is triggered even if the template parameters including variables fail to pass the verification. If the channelType, type, messageType, to, and from parameters fail to pass the verification, a fallback is not triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>undelivered</para>
        /// </summary>
        [NameInMap("FallBackRule")]
        [Validation(Required=false)]
        public string FallBackRule { get; set; }

        /// <summary>
        /// <para>The Flow action.</para>
        /// </summary>
        [NameInMap("FlowAction")]
        [Validation(Required=false)]
        public SendChatappMessageRequestFlowAction FlowAction { get; set; }
        public class SendChatappMessageRequestFlowAction : TeaModel {
            /// <summary>
            /// <para>The default parameter of the Flow.</para>
            /// </summary>
            [NameInMap("FlowActionData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FlowActionData { get; set; }

            /// <summary>
            /// <para>The Flow token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1122***</para>
            /// </summary>
            [NameInMap("FlowToken")]
            [Validation(Required=false)]
            public string FlowToken { get; set; }

        }

        /// <summary>
        /// <para>The mobile phone number of the message sender.</para>
        /// <remarks>
        /// <para> You can specify a mobile phone number that is registered for a WhatsApp account and is approved in the Chat App Message Service console.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1360000****</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The ISV verification code. This parameter is used to verify whether the RAM user is authorized by the ISV account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skdi3kksloslikdkkdk</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <para>The type of the Viber message. This parameter is required if ChannelType is set to viber. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>promotion</b></description></item>
        /// <item><description><b>transaction</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>promotion</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The language that is used in the message template. This parameter is required only if you set the Type parameter to <b>template</b>. For more information about language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The specific type of the message. This parameter is required only if you set the Type parameter to <b>message</b>.</para>
        /// <para><b>Valid values of MessageType when you set the ChannelType parameter to whatsapp:</b></para>
        /// <list type="bullet">
        /// <item><description><b>text</b>: a text message.</description></item>
        /// <item><description><b>image</b>: an image message.</description></item>
        /// <item><description><b>video</b>: a video message.</description></item>
        /// <item><description><b>audio</b>: an audio message.</description></item>
        /// <item><description><b>document</b>: a document message.</description></item>
        /// <item><description><b>interactive</b>: an interactive message.</description></item>
        /// <item><description><b>contacts</b>: a contact message.</description></item>
        /// <item><description><b>location</b>: a location message.</description></item>
        /// <item><description><b>sticker</b>: a sticker message.</description></item>
        /// <item><description><b>reaction</b>: a reaction message.</description></item>
        /// </list>
        /// <para><b>Valid values of MessageType when you set the ChannelType parameter to viber:</b></para>
        /// <list type="bullet">
        /// <item><description><b>text</b>: a text message.</description></item>
        /// <item><description><b>image</b>: an image message.</description></item>
        /// <item><description><b>video</b>: a video message.</description></item>
        /// <item><description><b>document</b>: a document message.</description></item>
        /// <item><description><b>text_button</b>: a message that contains the text and button media objects.</description></item>
        /// <item><description><b>text_image_button</b>: a message that contains multiple media objects, including the text, image, and button.</description></item>
        /// <item><description><b>text_video</b>: a message that contains the text and video media objects.</description></item>
        /// <item><description><b>text_video_button</b>: a message that contains multiple media objects, including text, video, and button.</description></item>
        /// <item><description><b>text_image</b>: a message that contains the text and image media objects.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/454530.html">Parameters of a message template</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// <para>The payload of the button.</para>
        /// 
        /// <b>Example:</b>
        /// <para>payloadtext1,payloadtext2,payloadtext3</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public List<string> Payload { get; set; }

        /// <summary>
        /// <para>The information about the products included in the WhatsApp catalog message or multi-product message (MPM).</para>
        /// </summary>
        [NameInMap("ProductAction")]
        [Validation(Required=false)]
        public SendChatappMessageRequestProductAction ProductAction { get; set; }
        public class SendChatappMessageRequestProductAction : TeaModel {
            /// <summary>
            /// <para>The products. Up to 30 products and 10 categories can be added.</para>
            /// </summary>
            [NameInMap("Sections")]
            [Validation(Required=false)]
            public List<SendChatappMessageRequestProductActionSections> Sections { get; set; }
            public class SendChatappMessageRequestProductActionSections : TeaModel {
                /// <summary>
                /// <para>The products.</para>
                /// </summary>
                [NameInMap("ProductItems")]
                [Validation(Required=false)]
                public List<SendChatappMessageRequestProductActionSectionsProductItems> ProductItems { get; set; }
                public class SendChatappMessageRequestProductActionSectionsProductItems : TeaModel {
                    /// <summary>
                    /// <para>The retailer ID of the product.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9I39E9E</para>
                    /// </summary>
                    [NameInMap("ProductRetailerId")]
                    [Validation(Required=false)]
                    public string ProductRetailerId { get; set; }

                }

                /// <summary>
                /// <para>The name of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The retailer ID of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S238SK</para>
            /// </summary>
            [NameInMap("ThumbnailProductRetailerId")]
            [Validation(Required=false)]
            public string ThumbnailProductRetailerId { get; set; }

        }

        /// <summary>
        /// <para>The tag information of the Viber message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000001</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The code of the message template. This parameter is required only if you set the Type parameter to <b>template</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>744c4b5c79c9432497a075bdfca3****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>The name of the message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The variables of the message template.</para>
        /// </summary>
        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> TemplateParams { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the message receiver.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// <para>The tracking data of the Viber message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tracking_id:123456</para>
        /// </summary>
        [NameInMap("TrackingData")]
        [Validation(Required=false)]
        public string TrackingData { get; set; }

        /// <summary>
        /// <para>The timeout period for sending the Viber message. Valid values: 30 to 1209600. Unit: seconds.</para>
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
        /// <item><description><b>template</b>: the template message. A template message is sent based on a template that is created and approved in the Chat App Message Service console. You can send template messages based on your business requirements.</description></item>
        /// <item><description><b>message</b>: the custom message. You can send a custom WhatsApp message to a user only within 24 hours after you receive the last message from the user. This limit does not apply to custom Viber messages.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
