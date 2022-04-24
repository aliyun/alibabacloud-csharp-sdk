// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class RecognizeMessageForTestRequest : TeaModel {
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
        public RecognizeMessageForTestRequestClientInfo ClientInfo { get; set; }
        public class RecognizeMessageForTestRequestClientInfo : TeaModel {
            [NameInMap("ClientApp")]
            [Validation(Required=false)]
            public string ClientApp { get; set; }
            [NameInMap("ClientOs")]
            [Validation(Required=false)]
            public string ClientOs { get; set; }
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }
        };

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
        public List<RecognizeMessageForTestRequestExpectedSlots> ExpectedSlots { get; set; }
        public class RecognizeMessageForTestRequestExpectedSlots : TeaModel {
            /// <summary>
            /// 槽位key
            /// </summary>
            [NameInMap("SlotKey")]
            [Validation(Required=false)]
            public string SlotKey { get; set; }

        }

        /// <summary>
        /// query扩展信息, 通常在点击事件中使用
        /// </summary>
        [NameInMap("ExtraContent")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraContent { get; set; }

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
        /// 是否忽略场景开关
        /// </summary>
        [NameInMap("IgnoreSceneSwitch")]
        [Validation(Required=false)]
        public bool? IgnoreSceneSwitch { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<RecognizeMessageForTestRequestItems> Items { get; set; }
        public class RecognizeMessageForTestRequestItems : TeaModel {
            /// <summary>
            /// 商品叶子类目id
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// 商品id
            /// </summary>
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// 商品主图url
            /// </summary>
            [NameInMap("PicUrl")]
            [Validation(Required=false)]
            public string PicUrl { get; set; }

            /// <summary>
            /// 商品价格
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public float? Price { get; set; }

            /// <summary>
            /// 商品属性
            /// </summary>
            [NameInMap("Property")]
            [Validation(Required=false)]
            public Dictionary<string, string> Property { get; set; }

            /// <summary>
            /// 卖家id
            /// </summary>
            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public string SellerId { get; set; }

            /// <summary>
            /// 商品店铺类目
            /// </summary>
            [NameInMap("ShopCategoryIds")]
            [Validation(Required=false)]
            public List<string> ShopCategoryIds { get; set; }

            /// <summary>
            /// 商品标题
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 订单列表
        /// </summary>
        [NameInMap("Orders")]
        [Validation(Required=false)]
        public List<RecognizeMessageForTestRequestOrders> Orders { get; set; }
        public class RecognizeMessageForTestRequestOrders : TeaModel {
            /// <summary>
            /// 买家id
            /// </summary>
            [NameInMap("BuyerId")]
            [Validation(Required=false)]
            public string BuyerId { get; set; }

            /// <summary>
            /// 评价状态
            /// </summary>
            [NameInMap("BuyerRateStatus")]
            [Validation(Required=false)]
            public string BuyerRateStatus { get; set; }

            /// <summary>
            /// 订单中的商品数量
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// 订单创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 订单中的商品id
            /// </summary>
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// 商品主图url
            /// </summary>
            [NameInMap("ItemPic")]
            [Validation(Required=false)]
            public string ItemPic { get; set; }

            /// <summary>
            /// 商品标题
            /// </summary>
            [NameInMap("ItemTitle")]
            [Validation(Required=false)]
            public string ItemTitle { get; set; }

            /// <summary>
            /// 物流状态
            /// </summary>
            [NameInMap("LogisticsStatus")]
            [Validation(Required=false)]
            public string LogisticsStatus { get; set; }

            /// <summary>
            /// 子订单id
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// 主订单id
            /// </summary>
            [NameInMap("ParentOrderId")]
            [Validation(Required=false)]
            public string ParentOrderId { get; set; }

            /// <summary>
            /// 支付状态
            /// </summary>
            [NameInMap("PayStatus")]
            [Validation(Required=false)]
            public string PayStatus { get; set; }

            /// <summary>
            /// 订单支付时间
            /// </summary>
            [NameInMap("PayTime")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            /// <summary>
            /// 订单价格
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public float? Price { get; set; }

            /// <summary>
            /// 退款状态
            /// </summary>
            [NameInMap("RefundStatus")]
            [Validation(Required=false)]
            public string RefundStatus { get; set; }

            /// <summary>
            /// 卖家id
            /// </summary>
            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public string SellerId { get; set; }

            /// <summary>
            /// sku属性
            /// </summary>
            [NameInMap("SkuProperty")]
            [Validation(Required=false)]
            public string SkuProperty { get; set; }

        }

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
