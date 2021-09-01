// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderAndPaymentListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PostFee")]
        [Validation(Required=false)]
        public QueryOrderAndPaymentListResponseBodyPostFee PostFee { get; set; }
        public class QueryOrderAndPaymentListResponseBodyPostFee : TeaModel {
            [NameInMap("FundAmount")]
            [Validation(Required=false)]
            public long? FundAmount { get; set; }
            [NameInMap("FundType")]
            [Validation(Required=false)]
            public string FundType { get; set; }
            [NameInMap("FundAmountMoney")]
            [Validation(Required=false)]
            public long? FundAmountMoney { get; set; }
        };

        [NameInMap("LmOrderList")]
        [Validation(Required=false)]
        public QueryOrderAndPaymentListResponseBodyLmOrderList LmOrderList { get; set; }
        public class QueryOrderAndPaymentListResponseBodyLmOrderList : TeaModel {
            [NameInMap("LmOrderList")]
            [Validation(Required=false)]
            public List<QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderList> LmOrderList { get; set; }
            public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderList : TeaModel {
                public long? LmOrderId { get; set; }
                public int? EnableStatus { get; set; }
                public string ExtJson { get; set; }
                public int? OrderStatus { get; set; }
                public string LmPaymentId { get; set; }
                public string ShopName { get; set; }
                public long? TbOrderId { get; set; }
                public long? OrderAmount { get; set; }
                public int? LogisticsStatus { get; set; }
                public string CreateDate { get; set; }
                public QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListFundStructureModels FundStructureModels { get; set; }
                public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListFundStructureModels : TeaModel {
                    [NameInMap("FundStructureModels")]
                    [Validation(Required=false)]
                    public List<QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListFundStructureModelsFundStructureModels> FundStructureModels { get; set; }
                    public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListFundStructureModelsFundStructureModels : TeaModel {
                        [NameInMap("FundAmount")]
                        [Validation(Required=false)]
                        public long? FundAmount { get; set; }

                        [NameInMap("FundType")]
                        [Validation(Required=false)]
                        public string FundType { get; set; }

                        [NameInMap("FundAmountMoney")]
                        [Validation(Required=false)]
                        public long? FundAmountMoney { get; set; }

                    }

                }
                public QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderList SubOrderList { get; set; }
                public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderList : TeaModel {
                    [NameInMap("SubOrderList")]
                    [Validation(Required=false)]
                    public List<QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderList> SubOrderList { get; set; }
                    public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderList : TeaModel {
                        [NameInMap("LmOrderId")]
                        [Validation(Required=false)]
                        public long? LmOrderId { get; set; }

                        [NameInMap("EnableStatus")]
                        [Validation(Required=false)]
                        public int? EnableStatus { get; set; }

                        [NameInMap("ItemTitle")]
                        [Validation(Required=false)]
                        public string ItemTitle { get; set; }

                        [NameInMap("OrderStatus")]
                        [Validation(Required=false)]
                        public int? OrderStatus { get; set; }

                        [NameInMap("SkuName")]
                        [Validation(Required=false)]
                        public string SkuName { get; set; }

                        [NameInMap("LmItemId")]
                        [Validation(Required=false)]
                        public string LmItemId { get; set; }

                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("Number")]
                        [Validation(Required=false)]
                        public long? Number { get; set; }

                        [NameInMap("TbOrderId")]
                        [Validation(Required=false)]
                        public long? TbOrderId { get; set; }

                        [NameInMap("ItemPic")]
                        [Validation(Required=false)]
                        public string ItemPic { get; set; }

                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public long? ItemId { get; set; }

                        [NameInMap("ItemPriceList")]
                        [Validation(Required=false)]
                        public QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceList ItemPriceList { get; set; }
                        public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceList : TeaModel {
                            [NameInMap("ItemPriceList")]
                            [Validation(Required=false)]
                            public List<QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceListItemPriceList> ItemPriceList { get; set; }
                            public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceListItemPriceList : TeaModel {
                                public long? FundAmount { get; set; }
                                public string FundType { get; set; }
                                public long? FundAmountMoney { get; set; }
                            }
                        };

                    }

                }
                public QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListPostFee PostFee { get; set; }
                public class QueryOrderAndPaymentListResponseBodyLmOrderListLmOrderListPostFee : TeaModel {
                    [NameInMap("FundAmount")]
                    [Validation(Required=false)]
                    public long? FundAmount { get; set; }

                    [NameInMap("FundType")]
                    [Validation(Required=false)]
                    public string FundType { get; set; }

                    [NameInMap("FundAmountMoney")]
                    [Validation(Required=false)]
                    public long? FundAmountMoney { get; set; }

                }
            }
        };

    }

}
