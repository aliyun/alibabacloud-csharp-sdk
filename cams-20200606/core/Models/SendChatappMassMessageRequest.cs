// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMassMessageRequest : TeaModel {
        /// <summary>
        /// <para>The type of the channel. Valid values:</para>
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
        /// <para>Fallback message</para>
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        /// <summary>
        /// <para>Specifies the period of time after which the fallback message is sent if the message receipt that indicates the message is delivered to clients is not received. If this parameter is left empty, the fallback message is sent only when the message fails to be sent or the message receipt that indicates the message is not delivered to clients is received. Unit: seconds. Valid values: 60 to 43200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("FallBackDuration")]
        [Validation(Required=false)]
        public int? FallBackDuration { get; set; }

        /// <summary>
        /// <para>The ID of the fallback policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S00001</para>
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
        /// <para>The mobile phone number of the message sender.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>861387777****</para>
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
        /// <para>The type of the Viber message. Valid values:</para>
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
        /// <para>The language. For more information about language codes, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The mobile phone numbers of the message receivers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SenderList")]
        [Validation(Required=false)]
        public List<SendChatappMassMessageRequestSenderList> SenderList { get; set; }
        public class SendChatappMassMessageRequestSenderList : TeaModel {
            /// <summary>
            /// <para>The Flow action.</para>
            /// </summary>
            [NameInMap("FlowAction")]
            [Validation(Required=false)]
            public SendChatappMassMessageRequestSenderListFlowAction FlowAction { get; set; }
            public class SendChatappMassMessageRequestSenderListFlowAction : TeaModel {
                /// <summary>
                /// <para>The default parameter of the Flow.</para>
                /// </summary>
                [NameInMap("FlowActionData")]
                [Validation(Required=false)]
                public Dictionary<string, object> FlowActionData { get; set; }

                /// <summary>
                /// <para>The information about the Flow token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kde****</para>
                /// </summary>
                [NameInMap("FlowToken")]
                [Validation(Required=false)]
                public string FlowToken { get; set; }

            }

            /// <summary>
            /// <para>The payload of the button.</para>
            /// </summary>
            [NameInMap("Payload")]
            [Validation(Required=false)]
            public List<string> Payload { get; set; }

            /// <summary>
            /// <para>The information about the product.</para>
            /// </summary>
            [NameInMap("ProductAction")]
            [Validation(Required=false)]
            public SendChatappMassMessageRequestSenderListProductAction ProductAction { get; set; }
            public class SendChatappMassMessageRequestSenderListProductAction : TeaModel {
                /// <summary>
                /// <para>The products. Up to 30 products and 10 categories can be added.</para>
                /// </summary>
                [NameInMap("Sections")]
                [Validation(Required=false)]
                public List<SendChatappMassMessageRequestSenderListProductActionSections> Sections { get; set; }
                public class SendChatappMassMessageRequestSenderListProductActionSections : TeaModel {
                    /// <summary>
                    /// <para>The products.</para>
                    /// </summary>
                    [NameInMap("ProductItems")]
                    [Validation(Required=false)]
                    public List<SendChatappMassMessageRequestSenderListProductActionSectionsProductItems> ProductItems { get; set; }
                    public class SendChatappMassMessageRequestSenderListProductActionSectionsProductItems : TeaModel {
                        /// <summary>
                        /// <para>The retailer ID of the product.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ksi399d8</para>
                        /// </summary>
                        [NameInMap("ProductRetailerId")]
                        [Validation(Required=false)]
                        public string ProductRetailerId { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abcd</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The retailer ID of the product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skkks999393</para>
                /// </summary>
                [NameInMap("ThumbnailProductRetailerId")]
                [Validation(Required=false)]
                public string ThumbnailProductRetailerId { get; set; }

            }

            /// <summary>
            /// <para>The parameters of the template.</para>
            /// </summary>
            [NameInMap("TemplateParams")]
            [Validation(Required=false)]
            public Dictionary<string, string> TemplateParams { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the message receiver.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>861388988****</para>
            /// </summary>
            [NameInMap("To")]
            [Validation(Required=false)]
            public string To { get; set; }

        }

        /// <summary>
        /// <para>The tag information when the ChannelType parameter is set to viber.</para>
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
        /// <para>The template code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>744c4b5c79c9432497a075bdfca36bf5</para>
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
        /// <para>The timeout period for sending messages when the ChannelType parameter is set to viber. Valid values: 30 to 1209600. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public long? Ttl { get; set; }

    }

}
