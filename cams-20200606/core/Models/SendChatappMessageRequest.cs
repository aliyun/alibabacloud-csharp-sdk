// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SendChatappMessageRequest : TeaModel {
        /// <summary>
        /// 通道类型 whatsapp/viber/line
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// 消息内容
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 发送方
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// 当发送模板消息时，模板中包含按钮类型是QUICK_REPLY时有效，在快速回复的时候会再上行
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public string Payload { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板参数
        /// </summary>
        [NameInMap("TemplateParams")]
        [Validation(Required=false)]
        public string TemplateParams { get; set; }

        /// <summary>
        /// 接收号码
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

        /// <summary>
        /// 消息大类
        /// template--模板
        /// message--非模板
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
