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

        /// <summary>
        /// 消息在指定时间内没有返回已到达回执时回落, 不填代表不根据此时间判断回落，只有发送失败和有失败的状态报告时才会回落。时间单位为秒 最小值为60，最大值43200
        /// </summary>
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
        /// The phone number of the message sender.
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
        /// The language. For more information about language codes, see [Language codes](~~463420~~).
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The list of phone numbers that receive the message.
        /// </summary>
        [NameInMap("SenderList")]
        [Validation(Required=false)]
        public List<SendChatappMassMessageRequestSenderList> SenderList { get; set; }
        public class SendChatappMassMessageRequestSenderList : TeaModel {
            /// <summary>
            /// payload
            /// </summary>
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public List<string> Payload { get; set; }

            [NameInMap("ProductAction")]
            [Validation(Required=false)]
            public SendChatappMassMessageRequestSenderListProductAction ProductAction { get; set; }
            public class SendChatappMassMessageRequestSenderListProductAction : TeaModel {
                [NameInMap("Sections")]
                [Validation(Required=false)]
                public List<SendChatappMassMessageRequestSenderListProductActionSections> Sections { get; set; }
                public class SendChatappMassMessageRequestSenderListProductActionSections : TeaModel {
                    [NameInMap("ProductItems")]
                    [Validation(Required=false)]
                    public List<SendChatappMassMessageRequestSenderListProductActionSectionsProductItems> ProductItems { get; set; }
                    public class SendChatappMassMessageRequestSenderListProductActionSectionsProductItems : TeaModel {
                        [NameInMap("ProductRetailerId")]
                        [Validation(Required=false)]
                        public string ProductRetailerId { get; set; }

                    }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("ThumbnailProductRetailerId")]
                [Validation(Required=false)]
                public string ThumbnailProductRetailerId { get; set; }

            }

            /// <summary>
            /// The parameters of the message template.
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

        /// <summary>
        /// The timeout period for sending messages when the ChannelType parameter is set to viber. Valid values: 30 to 1209600. Unit: seconds.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public long? Ttl { get; set; }

    }

}
