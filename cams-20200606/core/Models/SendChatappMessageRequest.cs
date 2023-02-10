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
        /// *   viber, which is under development
        /// *   line, which is under development
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// The content of the message.
        /// 
        /// *   When you set the **MessageType** parameter to **text**, the **text** parameter is required and the **caption** parameter cannot be specified.
        /// *   When you set the **MessageType** parameter to **image**, the **link** parameter is required.
        /// *   When you set the **MessageType** parameter to **video**, the **link** parameter is required.
        /// *   When you set the **MessageType** parameter to **audio**, the **link** parameter is required and **caption** parameter is invalid.
        /// *   When you set the **MessageType** parameter to **document**, the **link** and **fileName** parameters are required and **caption** parameter is invalid.
        /// *   When you set the **MessageType** parameter to **interactive**, the **type** and **action** parameters are required.
        /// *   When you set the **MessageType** parameter to **contacts**, the **name** parameter is required.
        /// *   When you set the **MessageType** parameter to **location**, the **longitude** and **latitude** parameters are required.
        /// *   When you set the **MessageType** parameter to **sticker**, the **link** parameter is required, and the **caption** and **fileName** parameters are invalid.
        /// *   When you set the **MessageType** parameter to **reaction**, the **messageId** and **emoji** parameters are required.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// The ID of the reply message.
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
        /// The unique identifier of the WhatsApp account that you register.
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
        /// The ID of the fallback policy. You can create a fallback policy and view information about the policy in the console.
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// The phone number of the message sender.
        /// 
        /// >  You can specify a mobile phone number that is registered for a WhatsApp account and is approved in the ChatApp console.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The ISV verification code, which is used to verify whether the user is authorized by the ISV account.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// The message type when the ChannelType parameter is set to viber. Valid values: pormotion and transition.
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
        /// The type of the message. This parameter is required only if you set the Type parameter to **message**. Valid values:
        /// 
        /// *   **text**: the text message.
        /// *   **image**: the image message.
        /// *   **video**: the video message.
        /// *   **audio**: the audio message.
        /// *   **document**: the document message.
        /// *   **interactive**: the interactive message.
        /// *   **contacts**: the contact message.
        /// *   **location**: the location message.
        /// *   **sticker**: the sticker message.
        /// *   **reaction**: the reaction message.
        /// 
        /// >  For more information about parameters of location, contacts, interactive, and media, see [Parameters of a message template](~~454530~~).
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
        /// The tag information when the ChannelType parameter is set to viber.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// The code of the message template. This parameter is required only if you set the Type parameter to **template**.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// The variables of the message template.
        /// </summary>
        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> TemplateParams { get; set; }

        /// <summary>
        /// The phone number of the message receiver.
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// The tracking data when the ChannelType parameter is set to viber.
        /// </summary>
        [NameInMap("TrackingData")]
        [Validation(Required=false)]
        public string TrackingData { get; set; }

        /// <summary>
        /// The timeout period for sending messages when the ChannelType parameter is set to viber. Valid values: 30 to 1209600, in seconds.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// The type of the message. Valid values:
        /// 
        /// *   **template**: a template message. A template message is sent based on a template that is created in the ChatApp console and is approved. You can send template messages at any time based on your business requirements.
        /// *   **message**: a custom message. You can send a custom message to a user only within 24 hours after you receive the last message from the user.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
