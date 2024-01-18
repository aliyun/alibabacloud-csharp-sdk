// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderAndPaymentListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LmOrderList")]
        [Validation(Required=false)]
        public QueryOrderAndPaymentListResponseBodyLmOrderList LmOrderList { get; set; }
        public class QueryOrderAndPaymentListResponseBodyLmOrderList : TeaModel {
            [NameInMap("LmOrderList")]
            [Validation(Required=false)]
            public List<QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderList> LmOrderList { get; set; }
            public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderList : TeaModel {
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public int? EnableStatus { get; set; }

                [NameInMap("ExtJson")]
                [Validation(Required=false)]
                public string ExtJson { get; set; }

                [NameInMap("FundStructureModels")]
                [Validation(Required=false)]
                public QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListFundStructureModels FundStructureModels { get; set; }
                public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListFundStructureModels : TeaModel {
                    [NameInMap("FundStructureModels")]
                    [Validation(Required=false)]
                    public List<QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListFundStructureModelsFundStructureModels> FundStructureModels { get; set; }
                    public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListFundStructureModelsFundStructureModels : TeaModel {
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
                public QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListPostFee PostFee { get; set; }
                public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListPostFee : TeaModel {
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
                public QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderList SubOrderList { get; set; }
                public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderList : TeaModel {
                    [NameInMap("SubOrderList")]
                    [Validation(Required=false)]
                    public List<QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderList> SubOrderList { get; set; }
                    public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderList : TeaModel {
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
                        public QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceList ItemPriceList { get; set; }
                        public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceList : TeaModel {
                            [NameInMap("ItemPriceList")]
                            [Validation(Required=false)]
                            public List<QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceListItemPriceList> ItemPriceList { get; set; }
                            public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceListItemPriceList : TeaModel {
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

                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("SkuName")]
                        [Validation(Required=false)]
                        public string SkuName { get; set; }

                        [NameInMap("TbOrderId")]
                        [Validation(Required=false)]
                        public long? TbOrderId { get; set; }

                    }

                }

                [NameInMap("TbOrderId")]
                [Validation(Required=false)]
                public long? TbOrderId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PostFee")]
        [Validation(Required=false)]
        public QueryOrderAndPaymentListResponseBodyPostFee PostFee { get; set; }
        public class QueryOrderAndPaymentListResponseBodyPostFee : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
