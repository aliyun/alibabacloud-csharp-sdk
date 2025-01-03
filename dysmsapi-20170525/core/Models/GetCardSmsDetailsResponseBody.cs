// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>Access denied detail; this field is returned only if the RAM check fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Card SMS sending result</para>
        /// </summary>
        [NameInMap("CardSendDetailDTO")]
        [Validation(Required=false)]
        public GetCardSmsDetailsResponseBodyCardSendDetailDTO CardSendDetailDTO { get; set; }
        public class GetCardSmsDetailsResponseBodyCardSendDetailDTO : TeaModel {
            /// <summary>
            /// <para>Current page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>Page size</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>List of card SMS sending records</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<GetCardSmsDetailsResponseBodyCardSendDetailDTORecords> Records { get; set; }
            public class GetCardSmsDetailsResponseBodyCardSendDetailDTORecords : TeaModel {
                /// <summary>
                /// <para>Error code for sending</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ErrCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                /// <summary>
                /// <para>Customer-transmitted outId</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// <para>Phone number that received the SMS</para>
                /// 
                /// <b>Example:</b>
                /// <para>156****9080</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <para>Receive date</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-27 11:26:35</para>
                /// </summary>
                [NameInMap("ReceiveDate")]
                [Validation(Required=false)]
                public string ReceiveDate { get; set; }

                /// <summary>
                /// <para>Receive SMS type</para>
                /// 
                /// <b>Example:</b>
                /// <para>CARD_SMS</para>
                /// </summary>
                [NameInMap("ReceiveType")]
                [Validation(Required=false)]
                public string ReceiveType { get; set; }

                /// <summary>
                /// <para>Render date</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-27 12:13:39</para>
                /// </summary>
                [NameInMap("RenderDate")]
                [Validation(Required=false)]
                public string RenderDate { get; set; }

                /// <summary>
                /// <para>Render status. 0: Not rendered; 1: Rendered successfully; 3: Not rendered</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RenderStatus")]
                [Validation(Required=false)]
                public long? RenderStatus { get; set; }

                /// <summary>
                /// <para>Time when the SMS was sent</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-27 11:26:32</para>
                /// </summary>
                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                /// <summary>
                /// <para>Sending status. 1: Sending; 2: Send failed; 3: Sent successfully; 4: Addressing failed</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SendStatus")]
                [Validation(Required=false)]
                public long? SendStatus { get; set; }

                /// <summary>
                /// <para>SMS content. Only applicable for text messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>您收到一条短信消息</para>
                /// </summary>
                [NameInMap("SmsContent")]
                [Validation(Required=false)]
                public string SmsContent { get; set; }

                /// <summary>
                /// <para>Template code</para>
                /// 
                /// <b>Example:</b>
                /// <para>CARD_SMS_6***</para>
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

            /// <summary>
            /// <para>Total count</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Request status code.</para>
        /// <list type="bullet">
        /// <item><description>OK indicates a successful request.</description></item>
        /// <item><description>For other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">API Error Codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> - <b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
