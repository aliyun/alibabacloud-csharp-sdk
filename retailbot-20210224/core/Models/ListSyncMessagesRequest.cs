// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListSyncMessagesRequest : TeaModel {
        /// <summary>
        /// 人人数据DTO
        /// </summary>
        [NameInMap("MessageDTOList")]
        [Validation(Required=false)]
        public List<ListSyncMessagesRequestMessageDTOList> MessageDTOList { get; set; }
        public class ListSyncMessagesRequestMessageDTOList : TeaModel {
            /// <summary>
            /// 对话chatId
            /// </summary>
            [NameInMap("ChatId")]
            [Validation(Required=false)]
            public string ChatId { get; set; }

            /// <summary>
            /// 消息内容
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 消息类型
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// 消息发送方向
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// 消息ID
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// 机器人code
            /// </summary>
            [NameInMap("RobotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

            /// <summary>
            /// 卖家ID
            /// </summary>
            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public string SellerId { get; set; }

            /// <summary>
            /// 卖家nick
            /// </summary>
            [NameInMap("SellerNick")]
            [Validation(Required=false)]
            public string SellerNick { get; set; }

            /// <summary>
            /// 消息发送时间戳
            /// </summary>
            [NameInMap("SendTime")]
            [Validation(Required=false)]
            public long? SendTime { get; set; }

            /// <summary>
            /// 对话sessionId
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// 消息来源
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// 卖家小二ID
            /// </summary>
            [NameInMap("StaffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

            /// <summary>
            /// 卖家小二nick
            /// </summary>
            [NameInMap("StaffNick")]
            [Validation(Required=false)]
            public string StaffNick { get; set; }

            /// <summary>
            /// 买家ID
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 买家nick
            /// </summary>
            [NameInMap("UserNick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

        }

    }

}
