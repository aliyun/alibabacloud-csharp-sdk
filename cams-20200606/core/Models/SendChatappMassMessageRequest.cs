// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMassMessageRequest : TeaModel {
        /// <summary>
        /// The channel type. Valid values: whatsapp, viber, and line.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// The space ID of the user.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The ID of the WhatsApp Business account under the ISV account.
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// The fallback content.
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        [NameInMap("FallBackDuration")]
        [Validation(Required=false)]
        public int? FallBackDuration { get; set; }

        /// <summary>
        /// The ID of the fallback strategy.
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// The fallback rule.
        /// 
        /// >  Valid values:
        /// 
        /// *   undelivered: A fallback is triggered if the WhatsApp message is not delivered to clients. When the WhatsApp message is being sent, the template parameters are verified. If the parameters fail to pass the verification, the message fails to be sent. Whether the template and phone number are prohibited is not verified. By default, this value is used when FallBackRule is left empty.
        /// 
        /// *   sentfailed: A fallback is triggered even if the template parameters including variables fail to pass the verification. If the channelType, type, messageType, to, and from parameters fail to pass the verification, a fallback is not triggered.
        /// </summary>
        [NameInMap("FallBackRule")]
        [Validation(Required=false)]
        public string FallBackRule { get; set; }

        /// <summary>
        /// The phone number of the message sender.
        /// 
        /// This parameter is required.
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
        /// The message type when the ChannelType parameter is set to viber. Valid values: promotion and transaction.
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// The language. For more information about language codes, see [Language codes](https://help.aliyun.com/document_detail/463420.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The phone numbers to which the message is sent.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SenderList")]
        [Validation(Required=false)]
        public List<SendChatappMassMessageRequestSenderList> SenderList { get; set; }
        public class SendChatappMassMessageRequestSenderList : TeaModel {
            [NameInMap("FlowAction")]
            [Validation(Required=false)]
            public SendChatappMassMessageRequestSenderListFlowAction FlowAction { get; set; }
            public class SendChatappMassMessageRequestSenderListFlowAction : TeaModel {
                [NameInMap("FlowActionData")]
                [Validation(Required=false)]
                public Dictionary<string, string> FlowActionData { get; set; }

                [NameInMap("FlowToken")]
                [Validation(Required=false)]
                public string FlowToken { get; set; }

            }

            /// <summary>
            /// The payload.
            /// </summary>
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public List<string> Payload { get; set; }

            /// <summary>
            /// The information about the product.
            /// </summary>
            [NameInMap("ProductAction")]
            [Validation(Required=false)]
            public SendChatappMassMessageRequestSenderListProductAction ProductAction { get; set; }
            public class SendChatappMassMessageRequestSenderListProductAction : TeaModel {
                /// <summary>
                /// The products. Up to 30 products and 10 categories can be added.
                /// </summary>
                [NameInMap("Sections")]
                [Validation(Required=false)]
                public List<SendChatappMassMessageRequestSenderListProductActionSections> Sections { get; set; }
                public class SendChatappMassMessageRequestSenderListProductActionSections : TeaModel {
                    /// <summary>
                    /// The products.
                    /// </summary>
                    [NameInMap("ProductItems")]
                    [Validation(Required=false)]
                    public List<SendChatappMassMessageRequestSenderListProductActionSectionsProductItems> ProductItems { get; set; }
                    public class SendChatappMassMessageRequestSenderListProductActionSectionsProductItems : TeaModel {
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
            /// The parameters of the template.
            /// </summary>
            [NameInMap("TemplateParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> TemplateParams { get; set; }

            /// <summary>
            /// The phone number to which the message is sent.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// The tag information when the ChannelType parameter is set to viber.
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
        /// The encoding of the message template.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The timeout period for sending messages when the ChannelType parameter is set to viber. Valid values: 30 to 1209600. Unit: seconds.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public long? Ttl { get; set; }

    }

}
