// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class ReplyMessageApiRequest : TeaModel {
        /// <summary>
        /// 消息内容
        /// </summary>
        [NameInMap("MsgContent")]
        [Validation(Required=false)]
        public string MsgContent { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [NameInMap("MsgType")]
        [Validation(Required=false)]
        public string MsgType { get; set; }

        /// <summary>
        /// 群Id
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// 任务单Id
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 消息发送人Id
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 消息发送人
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
