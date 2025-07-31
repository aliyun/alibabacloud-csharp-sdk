// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
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
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("ContextMessageId")]
        [Validation(Required=false)]
        public string ContextMessageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        public string CustWabaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("FallBackContent")]
        [Validation(Required=false)]
        public string FallBackContent { get; set; }

        [NameInMap("FallBackDuration")]
        [Validation(Required=false)]
        public int? FallBackDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("FallBackId")]
        [Validation(Required=false)]
        public string FallBackId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("FallBackRule")]
        [Validation(Required=false)]
        public string FallBackRule { get; set; }

        [NameInMap("FlowAction")]
        [Validation(Required=false)]
        public SendChatappMessageRequestFlowAction FlowAction { get; set; }
        public class SendChatappMessageRequestFlowAction : TeaModel {
            [NameInMap("FlowActionData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FlowActionData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("FlowToken")]
            [Validation(Required=false)]
            public string FlowToken { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The payload of the button.</para>
        /// 
        /// <b>Example:</b>
        /// <para>payloadtext1,payloadtext2,payloadtext3</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public List<string> Payload { get; set; }

        [NameInMap("ProductAction")]
        [Validation(Required=false)]
        public SendChatappMessageRequestProductAction ProductAction { get; set; }
        public class SendChatappMessageRequestProductAction : TeaModel {
            [NameInMap("Sections")]
            [Validation(Required=false)]
            public List<SendChatappMessageRequestProductActionSections> Sections { get; set; }
            public class SendChatappMessageRequestProductActionSections : TeaModel {
                [NameInMap("ProductItems")]
                [Validation(Required=false)]
                public List<SendChatappMessageRequestProductActionSectionsProductItems> ProductItems { get; set; }
                public class SendChatappMessageRequestProductActionSectionsProductItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>示例值示例值</para>
                    /// </summary>
                    [NameInMap("ProductRetailerId")]
                    [Validation(Required=false)]
                    public string ProductRetailerId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("ThumbnailProductRetailerId")]
            [Validation(Required=false)]
            public string ThumbnailProductRetailerId { get; set; }

        }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> TemplateParams { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("TrackingData")]
        [Validation(Required=false)]
        public string TrackingData { get; set; }

        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
