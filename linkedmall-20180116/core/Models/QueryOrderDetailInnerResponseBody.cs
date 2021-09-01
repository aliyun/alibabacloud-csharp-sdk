// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderDetailInnerResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryOrderDetailInnerResponseBodyModel Model { get; set; }
        public class QueryOrderDetailInnerResponseBodyModel : TeaModel {
            [NameInMap("order")]
            [Validation(Required=false)]
            public QueryOrderDetailInnerResponseBodyModelOrder Order { get; set; }
            public class QueryOrderDetailInnerResponseBodyModelOrder : TeaModel {
                [NameInMap("Eticket")]
                [Validation(Required=false)]
                public bool? Eticket { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("LogisticsCompName")]
                [Validation(Required=false)]
                public string LogisticsCompName { get; set; }

                [NameInMap("ChannelCode")]
                [Validation(Required=false)]
                public string ChannelCode { get; set; }

                [NameInMap("LogisticsMobilePhone")]
                [Validation(Required=false)]
                public string LogisticsMobilePhone { get; set; }

                [NameInMap("ResExtInfo")]
                [Validation(Required=false)]
                public string ResExtInfo { get; set; }

                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public int? EnableStatus { get; set; }

                [NameInMap("ChannelBizType")]
                [Validation(Required=false)]
                public string ChannelBizType { get; set; }

                [NameInMap("Shipping")]
                [Validation(Required=false)]
                public string Shipping { get; set; }

                [NameInMap("OrderPayInfo")]
                [Validation(Required=false)]
                public string OrderPayInfo { get; set; }

                [NameInMap("LogisticsStatusDesc")]
                [Validation(Required=false)]
                public string LogisticsStatusDesc { get; set; }

                [NameInMap("TbOrderId")]
                [Validation(Required=false)]
                public string TbOrderId { get; set; }

                [NameInMap("LogisticsStatus")]
                [Validation(Required=false)]
                public int? LogisticsStatus { get; set; }

                [NameInMap("LmOrderId")]
                [Validation(Required=false)]
                public long? LmOrderId { get; set; }

                [NameInMap("SellerId")]
                [Validation(Required=false)]
                public long? SellerId { get; set; }

                [NameInMap("ShopName")]
                [Validation(Required=false)]
                public string ShopName { get; set; }

                [NameInMap("OrderAmount")]
                [Validation(Required=false)]
                public long? OrderAmount { get; set; }

                [NameInMap("ExtInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtInfo { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("PayStatus")]
                [Validation(Required=false)]
                public int? PayStatus { get; set; }

                [NameInMap("LogisticsNo")]
                [Validation(Required=false)]
                public string LogisticsNo { get; set; }

                [NameInMap("LogisticsUserName")]
                [Validation(Required=false)]
                public string LogisticsUserName { get; set; }

                [NameInMap("LogisticsAddress")]
                [Validation(Required=false)]
                public string LogisticsAddress { get; set; }

                [NameInMap("PayWaterStatus")]
                [Validation(Required=false)]
                public int? PayWaterStatus { get; set; }

                [NameInMap("RefundStatus")]
                [Validation(Required=false)]
                public int? RefundStatus { get; set; }

                [NameInMap("SellerNick")]
                [Validation(Required=false)]
                public string SellerNick { get; set; }

                [NameInMap("ChannelOrderId")]
                [Validation(Required=false)]
                public string ChannelOrderId { get; set; }

                [NameInMap("SubItemOrderList")]
                [Validation(Required=false)]
                public QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderList SubItemOrderList { get; set; }
                public class QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderList : TeaModel {
                    [NameInMap("SubItemOrder")]
                    [Validation(Required=false)]
                    public List<QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrder> SubItemOrder { get; set; }
                    public class QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrder : TeaModel {
                        public long? LmOrderId { get; set; }
                        public string ItemPriceInfo { get; set; }
                        public string ItemTitle { get; set; }
                        public long? TbSubOrderId { get; set; }
                        public string LmItemId { get; set; }
                        public string TotalPaymentInfo { get; set; }
                        public string ItemPic { get; set; }
                        public long? ItemId { get; set; }
                        public string ChannelCode { get; set; }
                        public int? PayStatus { get; set; }
                        public string SkuName { get; set; }
                        public int? Number { get; set; }
                        public long? SkuId { get; set; }
                        public QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrderItemPriceList ItemPriceList { get; set; }
                        public class QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrderItemPriceList : TeaModel {
                            [NameInMap("ItemPrice")]
                            [Validation(Required=false)]
                            public List<QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrderItemPriceListItemPrice> ItemPrice { get; set; }
                            public class QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrderItemPriceListItemPrice : TeaModel {
                                [NameInMap("FundAmount")]
                                [Validation(Required=false)]
                                public long? FundAmount { get; set; }

                                [NameInMap("TbOrderId")]
                                [Validation(Required=false)]
                                public long? TbOrderId { get; set; }

                                [NameInMap("FundType")]
                                [Validation(Required=false)]
                                public string FundType { get; set; }

                                [NameInMap("FundAmountMoney")]
                                [Validation(Required=false)]
                                public long? FundAmountMoney { get; set; }

                                [NameInMap("TbSubOrderId")]
                                [Validation(Required=false)]
                                public long? TbSubOrderId { get; set; }

                            }

                        }
                    }
                };

                [NameInMap("FundStructureModels")]
                [Validation(Required=false)]
                public QueryOrderDetailInnerResponseBodyModelOrderFundStructureModels FundStructureModels { get; set; }
                public class QueryOrderDetailInnerResponseBodyModelOrderFundStructureModels : TeaModel {
                    [NameInMap("FundStructure")]
                    [Validation(Required=false)]
                    public List<QueryOrderDetailInnerResponseBodyModelOrderFundStructureModelsFundStructure> FundStructure { get; set; }
                    public class QueryOrderDetailInnerResponseBodyModelOrderFundStructureModelsFundStructure : TeaModel {
                        public long? FundAmount { get; set; }
                        public long? LmOrderId { get; set; }
                        public string FundType { get; set; }
                        public long? FundAmountMoney { get; set; }
                        public long? TbSubOrderId { get; set; }
                    }
                };

                [NameInMap("PostFee")]
                [Validation(Required=false)]
                public QueryOrderDetailInnerResponseBodyModelOrderPostFee PostFee { get; set; }
                public class QueryOrderDetailInnerResponseBodyModelOrderPostFee : TeaModel {
                    [NameInMap("FundAmount")]
                    [Validation(Required=false)]
                    public long? FundAmount { get; set; }
                    [NameInMap("LmOrderId")]
                    [Validation(Required=false)]
                    public long? LmOrderId { get; set; }
                    [NameInMap("FundType")]
                    [Validation(Required=false)]
                    public string FundType { get; set; }
                    [NameInMap("FundAmountMoney")]
                    [Validation(Required=false)]
                    public long? FundAmountMoney { get; set; }
                    [NameInMap("TbSubOrderId")]
                    [Validation(Required=false)]
                    public long? TbSubOrderId { get; set; }
                };

            }
        };

    }

}
