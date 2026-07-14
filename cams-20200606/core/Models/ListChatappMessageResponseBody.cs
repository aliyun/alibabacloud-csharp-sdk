// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatappMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description><para>OK: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of returned data objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListChatappMessageResponseBodyData> Data { get; set; }
        public class ListChatappMessageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86183********</para>
            /// </summary>
            [NameInMap("BusinessNumber")]
            [Validation(Required=false)]
            public string BusinessNumber { get; set; }

            /// <summary>
            /// <para>The channel type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WHATSAPP</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The name of the message receiving status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ClientAcceptStatusName")]
            [Validation(Required=false)]
            public string ClientAcceptStatusName { get; set; }

            /// <summary>
            /// <para>The message read status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ClientReadStatus")]
            [Validation(Required=false)]
            public string ClientReadStatus { get; set; }

            /// <summary>
            /// <para>The message read status name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ClientReadStatusName")]
            [Validation(Required=false)]
            public string ClientReadStatusName { get; set; }

            /// <summary>
            /// <para>The conversation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>805a66**************************</para>
            /// </summary>
            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <para>The inbound or outbound message type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DOWN</para>
            /// </summary>
            [NameInMap("EventAction")]
            [Validation(Required=false)]
            public string EventAction { get; set; }

            /// <summary>
            /// <para>The name of the inbound or outbound message type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DOWN: outbound message.</para>
            /// </description></item>
            /// <item><description><para>UP: inbound message.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DOWN</para>
            /// </summary>
            [NameInMap("EventActionName")]
            [Validation(Required=false)]
            public string EventActionName { get; set; }

            /// <summary>
            /// <para>The fallback content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("FailBackContent")]
            [Validation(Required=false)]
            public string FailBackContent { get; set; }

            /// <summary>
            /// <para>Indicates whether the message falls back to SMS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Y: Yes.</para>
            /// </description></item>
            /// <item><description><para>N: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("FailBackFlag")]
            [Validation(Required=false)]
            public string FailBackFlag { get; set; }

            /// <summary>
            /// <para>The reason for the sending failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>timeout</para>
            /// </summary>
            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            /// <summary>
            /// <para>The template language. For more languages, see <a href="https://help.aliyun.com/document_detail/463420.html">Language codes</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("LanguageCode")]
            [Validation(Required=false)]
            public string LanguageCode { get; set; }

            /// <summary>
            /// <para>The message content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202509*******************</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The message source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api</para>
            /// </summary>
            [NameInMap("MessageSource")]
            [Validation(Required=false)]
            public string MessageSource { get; set; }

            /// <summary>
            /// <para>The message status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("MessageStatus")]
            [Validation(Required=false)]
            public string MessageStatus { get; set; }

            /// <summary>
            /// <para>The message status name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("MessageStatusName")]
            [Validation(Required=false)]
            public string MessageStatusName { get; set; }

            /// <summary>
            /// <para>The message type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INTERACTIVE</para>
            /// </summary>
            [NameInMap("MessageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// <para>The message type name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>interactive</para>
            /// </summary>
            [NameInMap("MessageTypeName")]
            [Validation(Required=false)]
            public string MessageTypeName { get; set; }

            /// <summary>
            /// <para>The month of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202507</para>
            /// </summary>
            [NameInMap("Month")]
            [Validation(Required=false)]
            public string Month { get; set; }

            /// <summary>
            /// <para>The sending time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-11T01:16:49.761+00:00</para>
            /// </summary>
            [NameInMap("SendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            /// <summary>
            /// <para>The template code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1103***************</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>picture_template</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>message</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The unique message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250911******************************</para>
            /// </summary>
            [NameInMap("UniqueMessageId")]
            [Validation(Required=false)]
            public string UniqueMessageId { get; set; }

            /// <summary>
            /// <para>The user phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86177********</para>
            /// </summary>
            [NameInMap("UserNumber")]
            [Validation(Required=false)]
            public string UserNumber { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>608F9CCA-B5EB-3D72-8047-B25D6D75BDEC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
