// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMessageRequest : TeaModel {
        /// <summary>
        /// The type of the message channel. Valid values:
        /// 
        /// *   **whatsapp**
        /// *   **viber**
        /// *   line. The feature that ChatAPP sends messages by using Line is under development.
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// The content of the message.
        /// 
        /// **Usage notes when you set the ChannelType parameter to whatsapp:**
        /// 
        /// *   When you set the **MessageType** parameter to **text**, the **text** parameter is required and the **caption** parameter cannot be specified.
        /// *   When you set the **MessageType** parameter to **image**, the **link** parameter is required.
        /// *   When you set the **MessageType** parameter to **video**, the **link** parameter is required.
        /// *   When you set the **MessageType** parameter to **audio**, the **link** parameter is required and the **caption** parameter is invalid.
        /// *   When you set the **MessageType** parameter to **document**, the **link** and **fileName** parameters are required and the **caption** parameter is invalid.
        /// *   When you set the **MessageType** parameter to **interactive**, the **type** and **action** parameters are required.
        /// *   When you set the **MessageType** parameter to **contacts**, the **name** parameter is required.
        /// *   When you set the **MessageType** parameter to **location**, the **longitude** and **latitude** parameters are required.
        /// *   When you set the **MessageType** parameter to **sticker**, the **link** parameter is required, and the **caption** and **fileName** parameters are invalid.
        /// *   When you set the **MessageType** parameter to **reaction**, the **messageId** and **emoji** parameters are required.
        /// 
        /// **Usage notes when you set the ChannelType parameter to viber:**
        /// 
        /// *   When you set the **MessageType** parameter to **text**, the **text** parameter is required.
        /// *   When you set the **MessageType** parameter to **image**, the **link** parameter is required.
        /// *   When you set the **MessageType** parameter to **video**, the **link**, **thumbnail**, **fileSize**, and **duration** parameters are required.
        /// *   When you set the **MessageType** parameter to **document**, the **link**, **fileName**, and **fileType** parameters are required.
        /// *   When you set the **MessageType** parameter to **text_button**, the **text**, **caption**, and **action** parameters are required.
        /// *   When you set the **MessageType** parameter to **text_image_button**, the **text**, **link**, **caption**, and **action** parameters are required.
        /// *   When you set the **MessageType** parameter to **text_video**, the **text**, **link**, **thumbnail**, **fileSize**, and **duration** parameters are required.
        /// *   When you set the **MessageType** parameter to **text_video_button**, the **text**, **link**, **thumbnail**, **fileSize**, **duration**, and **caption** parameters are required. The **action** parameter is invalid.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The ID of the message to reply to.
        /// </summary>
        [NameInMap("ContextMessageId")]
        [Validation(Required=false)]
        public string ContextMessageId { get; set; }

        /// <summary>
        /// The space ID of the user.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The ID of the WhatsApp account that you register.
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// The content of the fallback message.
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        /// <summary>
        /// Specifies the period of time after which the fallback Short Message Service (SMS) message is sent if the message receipt that indicates the message is delivered to customers is not received. If this parameter is left empty, the fallback SMS message is sent only when the **message fails to be sent** or **the message receipt that indicates the message is not delivered to customers** is received. Valid values: 60 to 43200. Unit: seconds.
        /// </summary>
        [NameInMap("FallBackDuration")]
        [Validation(Required=false)]
        public int? FallBackDuration { get; set; }

        /// <summary>
        /// The ID of the fallback strategy. You can create a fallback strategy and view the information in the console.
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// 回落规则。
        /// 
        /// > 取值范围
        /// > - undelivered  消息不能发送到端时回落（在发送状态时模板、参数需要校验通过，模板被封、号码被封等不做校验）。参数值为空时默认使用此规则
        /// > - sentFailed  消息在校验模板、模板变量等参数时，校验不通过也会回落。只会强校验channelType, type, messageType, to, from(是否存在) 几个参数。
        /// 
        /// <props="china">
        /// 
        /// > 中国站此字段无效
        /// </props>
        /// </summary>
        [NameInMap("FallBackRule")]
        [Validation(Required=false)]
        public string FallBackRule { get; set; }

        /// <summary>
        /// Flow发送数据
        /// </summary>
        [NameInMap("FlowAction")]
        [Validation(Required=false)]
        public SendChatappMessageRequestFlowAction FlowAction { get; set; }
        public class SendChatappMessageRequestFlowAction : TeaModel {
            /// <summary>
            /// flow默认参数
            /// </summary>
            [NameInMap("FlowActionData")]
            [Validation(Required=false)]
            public Dictionary<string, string> FlowActionData { get; set; }

            /// <summary>
            /// flow token信息
            /// </summary>
            [NameInMap("FlowToken")]
            [Validation(Required=false)]
            public string FlowToken { get; set; }

        }

        /// <summary>
        /// The phone number of the message sender.
        /// 
        /// > You can specify a mobile phone number that is registered for a WhatsApp account and is approved in the ChatAPP console.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The independent software vendor (ISV) verification code, which is used to verify whether the user is authorized by the ISV account.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// The type of the Viber message. This parameter is required if you set the ChannelType parameter to viber. Valid values: promotion and transaction.
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// The language that is used in the message template. This parameter is required only if you set the Type parameter to **template**. For more information about language codes, see [Language codes](~~463420~~).
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The specific type of the message. This parameter is required only if you set the Type parameter to **message**.
        /// 
        /// **Valid values of MessageType when you set the ChannelType parameter to whatsapp:**
        /// 
        /// *   **text**: a text message.
        /// *   **image**: an image message.
        /// *   **video**: a video message.
        /// *   **audio**: an audio message.
        /// *   **document**: a document message.
        /// *   **interactive**: an interactive message.
        /// *   **contacts**: a contact message.
        /// *   **location**: a location message.
        /// *   **sticker**: a sticker message.
        /// *   **reaction**: a reaction message.
        /// 
        /// **Valid values of MessageType when you set the ChannelType parameter to viber:**
        /// 
        /// *   **text**: a text message.
        /// *   **image**: an image message.
        /// *   **video**: a video message.
        /// *   **document**: a document message.
        /// *   **text_button**: a message that contains the text and button media objects.
        /// *   **text_image_button**: a message that contains multiple media objects, including the text, image, and button.
        /// *   **text_video**: a message that contains the text and video media objects.
        /// *   **text_video_button**: a message that contains multiple media objects, including text, video, and button.
        /// *   **text_image**: a message that contains the text and image media objects.
        /// 
        /// > For more information, see [Parameters of a message template](~~454530~~).
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// The payload of the button.
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public List<string> Payload { get; set; }

        /// <summary>
        /// The information about the products included in the WhatsApp catalog message or multi-product message (MPM).
        /// </summary>
        [NameInMap("ProductAction")]
        [Validation(Required=false)]
        public SendChatappMessageRequestProductAction ProductAction { get; set; }
        public class SendChatappMessageRequestProductAction : TeaModel {
            /// <summary>
            /// The products. Up to 30 products can be added. The products can be divided into up to 10 categories.
            /// </summary>
            [NameInMap("Sections")]
            [Validation(Required=false)]
            public List<SendChatappMessageRequestProductActionSections> Sections { get; set; }
            public class SendChatappMessageRequestProductActionSections : TeaModel {
                /// <summary>
                /// The products.
                /// </summary>
                [NameInMap("ProductItems")]
                [Validation(Required=false)]
                public List<SendChatappMessageRequestProductActionSectionsProductItems> ProductItems { get; set; }
                public class SendChatappMessageRequestProductActionSectionsProductItems : TeaModel {
                    /// <summary>
                    /// The retailer ID of the product.
                    /// </summary>
                    [NameInMap("ProductRetailerId")]
                    [Validation(Required=false)]
                    public string ProductRetailerId { get; set; }

                }

                /// <summary>
                /// The name of the category.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// The retailer ID of the product.
            /// </summary>
            [NameInMap("ThumbnailProductRetailerId")]
            [Validation(Required=false)]
            public string ThumbnailProductRetailerId { get; set; }

        }

        /// <summary>
        /// The tag information of the Viber message.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The code of the message template. This parameter is required only if you set the Type parameter to **template**.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The variables of the message template.
        /// </summary>
        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> TemplateParams { get; set; }

        /// <summary>
        /// The phone number that receives the message.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// The tracking ID of the Viber message.
        /// </summary>
        [NameInMap("TrackingData")]
        [Validation(Required=false)]
        public string TrackingData { get; set; }

        /// <summary>
        /// The timeout period for sending the Viber message. Valid values: 30 to 1209600. Unit: seconds.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// The type of the message. Valid values:
        /// 
        /// *   **template**: a template message. A template message is sent based on a template that is created in the ChatAPP console and is approved. You can send template messages at any time based on your business requirements.
        /// *   **message**: a custom message. You can send a custom message to a user only within 24 hours after you receive the last message from the user.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
