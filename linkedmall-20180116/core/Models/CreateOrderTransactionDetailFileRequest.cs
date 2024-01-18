// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreateOrderTransactionDetailFileRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        [NameInMap("CreateEndTime")]
        [Validation(Required=false)]
        public string CreateEndTime { get; set; }

        [NameInMap("CreateStartTime")]
        [Validation(Required=false)]
        public string CreateStartTime { get; set; }

        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        [NameInMap("LmShopId")]
        [Validation(Required=false)]
        public string LmShopId { get; set; }

        [NameInMap("OrderStatus")]
        [Validation(Required=false)]
        public string OrderStatus { get; set; }

        [NameInMap("PayStatus")]
        [Validation(Required=false)]
        public string PayStatus { get; set; }

        [NameInMap("PaymentEndTime")]
        [Validation(Required=false)]
        public string PaymentEndTime { get; set; }

        [NameInMap("PaymentStartTime")]
        [Validation(Required=false)]
        public string PaymentStartTime { get; set; }

        [NameInMap("PoCode")]
        [Validation(Required=false)]
        public string PoCode { get; set; }

        [NameInMap("RefundEndTime")]
        [Validation(Required=false)]
        public string RefundEndTime { get; set; }

        [NameInMap("RefundStartTime")]
        [Validation(Required=false)]
        public string RefundStartTime { get; set; }

        [NameInMap("SellerId")]
        [Validation(Required=false)]
        public string SellerId { get; set; }

        [NameInMap("SellerName")]
        [Validation(Required=false)]
        public string SellerName { get; set; }

        [NameInMap("SettlementNode")]
        [Validation(Required=false)]
        public string SettlementNode { get; set; }

        [NameInMap("ShopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

        [NameInMap("TbMainOrderId")]
        [Validation(Required=false)]
        public string TbMainOrderId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

    }

}
