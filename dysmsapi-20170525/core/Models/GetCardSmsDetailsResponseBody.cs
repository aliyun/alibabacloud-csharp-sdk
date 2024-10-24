// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetCardSmsDetailsResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>卡片短信发送结果</para>
        /// </summary>
        [NameInMap("CardSendDetailDTO")]
        [Validation(Required=false)]
        public GetCardSmsDetailsResponseBodyCardSendDetailDTO CardSendDetailDTO { get; set; }
        public class GetCardSmsDetailsResponseBodyCardSendDetailDTO : TeaModel {
            /// <summary>
            /// <para>页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            /// <summary>
            /// <para>页数</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<GetCardSmsDetailsResponseBodyCardSendDetailDTORecords> Records { get; set; }
            public class GetCardSmsDetailsResponseBodyCardSendDetailDTORecords : TeaModel {
                /// <summary>
                /// <para>发送错误码</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ErrCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                /// <summary>
                /// <para>客户传输outId</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678</para>
                /// </summary>
                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// <para>接收短信手机号</para>
                /// 
                /// <b>Example:</b>
                /// <para>156****9080</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <para>接收时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-27 11:26:35</para>
                /// </summary>
                [NameInMap("ReceiveDate")]
                [Validation(Required=false)]
                public string ReceiveDate { get; set; }

                /// <summary>
                /// <para>接收短信类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>CARD_SMS</para>
                /// </summary>
                [NameInMap("ReceiveType")]
                [Validation(Required=false)]
                public string ReceiveType { get; set; }

                /// <summary>
                /// <para>渲染时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-27 12:13:39</para>
                /// </summary>
                [NameInMap("RenderDate")]
                [Validation(Required=false)]
                public string RenderDate { get; set; }

                /// <summary>
                /// <para>解析状态.。0：未解析；1：解析成功；3：未解析</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RenderStatus")]
                [Validation(Required=false)]
                public long? RenderStatus { get; set; }

                /// <summary>
                /// <para>短信发送时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-27 11:26:32</para>
                /// </summary>
                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                /// <summary>
                /// <para>发送状态 1：发送中；2：发送失败；3：发送成功；4：寻址失败</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SendStatus")]
                [Validation(Required=false)]
                public long? SendStatus { get; set; }

                /// <summary>
                /// <para>短信内容。只有文本短信有值</para>
                /// 
                /// <b>Example:</b>
                /// <para>您收到一条短信消息</para>
                /// </summary>
                [NameInMap("SmsContent")]
                [Validation(Required=false)]
                public string SmsContent { get; set; }

                /// <summary>
                /// <para>模板code</para>
                /// 
                /// <b>Example:</b>
                /// <para>CARD_SMS_6***</para>
                /// </summary>
                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

            /// <summary>
            /// <para>总量</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>状态描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
