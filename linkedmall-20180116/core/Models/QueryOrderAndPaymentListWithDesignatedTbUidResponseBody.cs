// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderAndPaymentListWithDesignatedTbUidResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<QueryOrderAndPaymentListWithDesignatedTbUidResponseBodyModel> Model { get; set; }
        public class QueryOrderAndPaymentListWithDesignatedTbUidResponseBodyModel : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public int? EnableStatus { get; set; }

            [NameInMap("ExtJson")]
            [Validation(Required=false)]
            public string ExtJson { get; set; }

            [NameInMap("FundStructureModels")]
            [Validation(Required=false)]
            public List<QueryOrderAndPaymentListWithDesignatedTbUidResponseBodyModelFundStructureModels> FundStructureModels { get; set; }
            public class QueryOrderAndPaymentListWithDesignatedTbUidResponseBodyModelFundStructureModels : TeaModel {
                [NameInMap("FundAmount")]
                [Validation(Required=false)]
                public long? FundAmount { get; set; }

                [NameInMap("FundAmountMoney")]
                [Validation(Required=false)]
                public long? FundAmountMoney { get; set; }

                [NameInMap("FundType")]
                [Validation(Required=false)]
                public string FundType { get; set; }

            }

            [NameInMap("LmOrderId")]
            [Validation(Required=false)]
            public long? LmOrderId { get; set; }

            [NameInMap("LmPaymentId")]
            [Validation(Required=false)]
            public string LmPaymentId { get; set; }

            [NameInMap("LogisticsStatus")]
            [Validation(Required=false)]
            public int? LogisticsStatus { get; set; }

            [NameInMap("OrderAmount")]
            [Validation(Required=false)]
            public long? OrderAmount { get; set; }

            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            [NameInMap("PostFee")]
            [Validation(Required=false)]
            public QueryOrderAndPaymentListWithDesignatedTbUidResponseBodyModelPostFee PostFee { get; set; }
            public class QueryOrderAndPaymentListWithDesignatedTbUidResponseBodyModelPostFee : TeaModel {
                [NameInMap("FundAmount")]
                [Validation(Required=false)]
                public long? FundAmount { get; set; }

                [NameInMap("FundAmountMoney")]
                [Validation(Required=false)]
                public long? FundAmountMoney { get; set; }

                [NameInMap("FundType")]
                [Validation(Required=false)]
                public string FundType { get; set; }

            }

            [NameInMap("ShopName")]
            [Validation(Required=false)]
            public string ShopName { get; set; }

            [NameInMap("SubOrderList")]
            [Validation(Required=false)]
            public List<QueryOrderAndPaymentListWithDesignatedTbUidResponseBodyModelSubOrderList> SubOrderList { get; set; }
            public class QueryOrderAndPaymentListWithDesignatedTbUidResponseBodyModelSubOrderList : TeaModel {
                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public int? EnableStatus { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("ItemPic")]
                [Validation(Required=false)]
                public string ItemPic { get; set; }

                [NameInMap("ItemPriceList")]
                [Validation(Required=false)]
                public List<QueryOrderAndPaymentListWithDesignatedTbUidResponseBodyModelSubOrderListItemPriceList> ItemPriceList { get; set; }
                public class QueryOrderAndPaymentListWithDesignatedTbUidResponseBodyModelSubOrderListItemPriceList : TeaModel {
                    [NameInMap("FundAmount")]
                    [Validation(Required=false)]
                    public long? FundAmount { get; set; }

                    [NameInMap("FundAmountMoney")]
                    [Validation(Required=false)]
                    public long? FundAmountMoney { get; set; }

                    [NameInMap("FundType")]
                    [Validation(Required=false)]
                    public string FundType { get; set; }

                }

                [NameInMap("ItemTitle")]
                [Validation(Required=false)]
                public string ItemTitle { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("LmOrderId")]
                [Validation(Required=false)]
                public long? LmOrderId { get; set; }

                [NameInMap("Number")]
                [Validation(Required=false)]
                public long? Number { get; set; }

                [NameInMap("OrderStatus")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                /// <summary>
                /// skuId
                /// </summary>
                [NameInMap("SkuId")]
                [Validation(Required=false)]
                public string SkuId { get; set; }

                [NameInMap("SkuName")]
                [Validation(Required=false)]
                public string SkuName { get; set; }

                [NameInMap("TbOrderId")]
                [Validation(Required=false)]
                public long? TbOrderId { get; set; }

            }

            [NameInMap("TbOrderId")]
            [Validation(Required=false)]
            public long? TbOrderId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
