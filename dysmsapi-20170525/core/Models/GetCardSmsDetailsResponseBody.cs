// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details. This parameter is returned only when the RAM check fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The card SMS sending result.</para>
        /// </summary>
        [NameInMap("CardSendDetailDTO")]
        [Validation(Required=false)]
        public GetCardSmsDetailsResponseBodyCardSendDetailDTO CardSendDetailDTO { get; set; }
        public class GetCardSmsDetailsResponseBodyCardSendDetailDTO : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The list of card SMS sending records.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<GetCardSmsDetailsResponseBodyCardSendDetailDTORecords> Records { get; set; }
            public class GetCardSmsDetailsResponseBodyCardSendDetailDTORecords : TeaModel {
                /// <summary>
                /// <para>The sending error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ErrCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                /// <summary>
                /// <para>The outId passed by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// <para>The phone number that received the SMS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>156****9080</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <para>The receive time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-27 11:26:35</para>
                /// </summary>
                [NameInMap("ReceiveDate")]
                [Validation(Required=false)]
                public string ReceiveDate { get; set; }

                /// <summary>
                /// <para>The SMS receive type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CARD_SMS</para>
                /// </summary>
                [NameInMap("ReceiveType")]
                [Validation(Required=false)]
                public string ReceiveType { get; set; }

                /// <summary>
                /// <para>The render time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-27 12:13:39</para>
                /// </summary>
                [NameInMap("RenderDate")]
                [Validation(Required=false)]
                public string RenderDate { get; set; }

                /// <summary>
                /// <para>The parsing status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: not parsed.</description></item>
                /// <item><description>1: parsed successfully.</description></item>
                /// <item><description>3: not parsed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RenderStatus")]
                [Validation(Required=false)]
                public long? RenderStatus { get; set; }

                /// <summary>
                /// <para>The SMS sending time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-27 11:26:32</para>
                /// </summary>
                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                /// <summary>
                /// <para>The sending status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: sending.</description></item>
                /// <item><description>2: sending failed.</description></item>
                /// <item><description>3: sending succeeded.</description></item>
                /// <item><description>4: addressing failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SendStatus")]
                [Validation(Required=false)]
                public long? SendStatus { get; set; }

                /// <summary>
                /// <para>The SMS content. Only text SMS has a value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>您收到一条短信消息</para>
                /// </summary>
                [NameInMap("SmsContent")]
                [Validation(Required=false)]
                public string SmsContent { get; set; }

                /// <summary>
                /// <para>The template code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CARD_SMS_6***</para>
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description>OK indicates that the request was successful.</description></item>
        /// <item><description>For other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">API error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
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
