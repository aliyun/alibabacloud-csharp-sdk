// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class RecognizeMessageShrinkRequest : TeaModel {
        /// <summary>
        /// 单句的唯一ID
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// 客户端信息
        /// </summary>
        [NameInMap("ClientInfo")]
        [Validation(Required=false)]
        public string ClientInfoShrink { get; set; }

        /// <summary>
        /// 用户输入的query
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 用户输入的query类型
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// 上文期望的槽位
        /// </summary>
        [NameInMap("ExpectedSlots")]
        [Validation(Required=false)]
        public string ExpectedSlotsShrink { get; set; }

        /// <summary>
        /// query扩展信息, 通常在点击事件中使用
        /// </summary>
        [NameInMap("ExtraContent")]
        [Validation(Required=false)]
        public string ExtraContentShrink { get; set; }

        /// <summary>
        /// 焦点商品id
        /// </summary>
        [NameInMap("FocusItemId")]
        [Validation(Required=false)]
        public string FocusItemId { get; set; }

        /// <summary>
        /// 焦点订单id
        /// </summary>
        [NameInMap("FocusOrderId")]
        [Validation(Required=false)]
        public string FocusOrderId { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public string ItemsShrink { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        [NameInMap("Orders")]
        [Validation(Required=false)]
        public string OrdersShrink { get; set; }

        /// <summary>
        /// 调用知识包指令
        /// </summary>
        [NameInMap("Packages")]
        [Validation(Required=false)]
        public string PackagesShrink { get; set; }

        /// <summary>
        /// 机器人ID
        /// </summary>
        [NameInMap("RobotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// 当前的对话轮次
        /// </summary>
        [NameInMap("Round")]
        [Validation(Required=false)]
        public int? Round { get; set; }

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
        /// 机器人模式
        /// </summary>
        [NameInMap("ServiceMode")]
        [Validation(Required=false)]
        public string ServiceMode { get; set; }

        /// <summary>
        /// 买卖家之间的会话ID
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// 卖家接待人ID
        /// </summary>
        [NameInMap("StaffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// 卖家接待人nick
        /// </summary>
        [NameInMap("StaffNick")]
        [Validation(Required=false)]
        public string StaffNick { get; set; }

        /// <summary>
        /// 是否压测流量
        /// </summary>
        [NameInMap("StressTesting")]
        [Validation(Required=false)]
        public bool? StressTesting { get; set; }

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
