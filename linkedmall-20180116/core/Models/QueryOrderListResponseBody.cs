// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderListResponseBody : TeaModel {
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
        public QueryOrderListResponseBodyPostFee PostFee { get; set; }
        public class QueryOrderListResponseBodyPostFee : TeaModel {
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
        public QueryOrderListResponseBodyLmOrderList LmOrderList { get; set; }
        public class QueryOrderListResponseBodyLmOrderList : TeaModel {
            [NameInMap("LmOrderList")]
            [Validation(Required=false)]
            public List<QueryOrderListResponseBodyLmOrderListLmOrderList> LmOrderList { get; set; }
            public class QueryOrderListResponseBodyLmOrderListLmOrderList : TeaModel {
                public long? LmOrderId { get; set; }
                public int? EnableStatus { get; set; }
                public string ExtJson { get; set; }
                public int? OrderStatus { get; set; }
                public string ShopName { get; set; }
                public long? TbOrderId { get; set; }
                public long? OrderAmount { get; set; }
                public int? LogisticsStatus { get; set; }
                public string CreateDate { get; set; }
                public QueryOrderListResponseBodyLmOrderListLmOrderListFundStructureModels FundStructureModels { get; set; }
                public class QueryOrderListResponseBodyLmOrderListLmOrderListFundStructureModels : TeaModel {
                    [NameInMap("FundStructureModels")]
                    [Validation(Required=false)]
                    public List<QueryOrderListResponseBodyLmOrderListLmOrderListFundStructureModelsFundStructureModels> FundStructureModels { get; set; }
                    public class QueryOrderListResponseBodyLmOrderListLmOrderListFundStructureModelsFundStructureModels : TeaModel {
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
                public QueryOrderListResponseBodyLmOrderListLmOrderListSubOrderList SubOrderList { get; set; }
                public class QueryOrderListResponseBodyLmOrderListLmOrderListSubOrderList : TeaModel {
                    [NameInMap("SubOrderList")]
                    [Validation(Required=false)]
                    public List<QueryOrderListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderList> SubOrderList { get; set; }
                    public class QueryOrderListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderList : TeaModel {
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
                        public QueryOrderListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceList ItemPriceList { get; set; }
                        public class QueryOrderListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceList : TeaModel {
                            [NameInMap("ItemPriceList")]
                            [Validation(Required=false)]
                            public List<QueryOrderListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceListItemPriceList> ItemPriceList { get; set; }
                            public class QueryOrderListResponseBodyLmOrderListLmOrderListSubOrderListSubOrderListItemPriceListItemPriceList : TeaModel {
                                public long? FundAmount { get; set; }
                                public string FundType { get; set; }
                                public long? FundAmountMoney { get; set; }
                            }
                        };

                    }

                }
                public QueryOrderListResponseBodyLmOrderListLmOrderListPostFee PostFee { get; set; }
                public class QueryOrderListResponseBodyLmOrderListLmOrderListPostFee : TeaModel {
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
