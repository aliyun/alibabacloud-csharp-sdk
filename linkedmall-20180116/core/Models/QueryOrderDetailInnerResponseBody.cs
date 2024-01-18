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

        [NameInMap("Model")]
        [Validation(Required=false)]
        public QueryOrderDetailInnerResponseBodyModel Model { get; set; }
        public class QueryOrderDetailInnerResponseBodyModel : TeaModel {
            [NameInMap("order")]
            [Validation(Required=false)]
            public QueryOrderDetailInnerResponseBodyModelOrder Order { get; set; }
            public class QueryOrderDetailInnerResponseBodyModelOrder : TeaModel {
                [NameInMap("ChannelBizType")]
                [Validation(Required=false)]
                public string ChannelBizType { get; set; }

                [NameInMap("ChannelCode")]
                [Validation(Required=false)]
                public string ChannelCode { get; set; }

                [NameInMap("ChannelOrderId")]
                [Validation(Required=false)]
                public string ChannelOrderId { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public int? EnableStatus { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("Eticket")]
                [Validation(Required=false)]
                public bool? Eticket { get; set; }

                [NameInMap("ExtInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtInfo { get; set; }

                [NameInMap("FundStructureModels")]
                [Validation(Required=false)]
                public QueryOrderDetailInnerResponseBodyModelOrderFundStructureModels FundStructureModels { get; set; }
                public class QueryOrderDetailInnerResponseBodyModelOrderFundStructureModels : TeaModel {
                    [NameInMap("FundStructure")]
                    [Validation(Required=false)]
                    public List<QueryOrderDetailInnerResponseBodyModelOrderFundStructureModelsFundStructure> FundStructure { get; set; }
                    public class QueryOrderDetailInnerResponseBodyModelOrderFundStructureModelsFundStructure : TeaModel {
                        [NameInMap("FundAmount")]
                        [Validation(Required=false)]
                        public long? FundAmount { get; set; }

                        [NameInMap("FundAmountMoney")]
                        [Validation(Required=false)]
                        public long? FundAmountMoney { get; set; }

                        [NameInMap("FundType")]
                        [Validation(Required=false)]
                        public string FundType { get; set; }

                        [NameInMap("LmOrderId")]
                        [Validation(Required=false)]
                        public long? LmOrderId { get; set; }

                        [NameInMap("TbSubOrderId")]
                        [Validation(Required=false)]
                        public long? TbSubOrderId { get; set; }

                    }

                }

                [NameInMap("LmOrderId")]
                [Validation(Required=false)]
                public long? LmOrderId { get; set; }

                [NameInMap("LogisticsAddress")]
                [Validation(Required=false)]
                public string LogisticsAddress { get; set; }

                [NameInMap("LogisticsCompName")]
                [Validation(Required=false)]
                public string LogisticsCompName { get; set; }

                [NameInMap("LogisticsMobilePhone")]
                [Validation(Required=false)]
                public string LogisticsMobilePhone { get; set; }

                [NameInMap("LogisticsNo")]
                [Validation(Required=false)]
                public string LogisticsNo { get; set; }

                [NameInMap("LogisticsStatus")]
                [Validation(Required=false)]
                public int? LogisticsStatus { get; set; }

                [NameInMap("LogisticsStatusDesc")]
                [Validation(Required=false)]
                public string LogisticsStatusDesc { get; set; }

                [NameInMap("LogisticsUserName")]
                [Validation(Required=false)]
                public string LogisticsUserName { get; set; }

                [NameInMap("OrderAmount")]
                [Validation(Required=false)]
                public long? OrderAmount { get; set; }

                [NameInMap("OrderPayInfo")]
                [Validation(Required=false)]
                public string OrderPayInfo { get; set; }

                [NameInMap("PayStatus")]
                [Validation(Required=false)]
                public int? PayStatus { get; set; }

                [NameInMap("PayWaterStatus")]
                [Validation(Required=false)]
                public int? PayWaterStatus { get; set; }

                [NameInMap("PostFee")]
                [Validation(Required=false)]
                public QueryOrderDetailInnerResponseBodyModelOrderPostFee PostFee { get; set; }
                public class QueryOrderDetailInnerResponseBodyModelOrderPostFee : TeaModel {
                    [NameInMap("FundAmount")]
                    [Validation(Required=false)]
                    public long? FundAmount { get; set; }

                    [NameInMap("FundAmountMoney")]
                    [Validation(Required=false)]
                    public long? FundAmountMoney { get; set; }

                    [NameInMap("FundType")]
                    [Validation(Required=false)]
                    public string FundType { get; set; }

                    [NameInMap("LmOrderId")]
                    [Validation(Required=false)]
                    public long? LmOrderId { get; set; }

                    [NameInMap("TbSubOrderId")]
                    [Validation(Required=false)]
                    public long? TbSubOrderId { get; set; }

                }

                [NameInMap("RefundStatus")]
                [Validation(Required=false)]
                public int? RefundStatus { get; set; }

                [NameInMap("ResExtInfo")]
                [Validation(Required=false)]
                public string ResExtInfo { get; set; }

                [NameInMap("SellerId")]
                [Validation(Required=false)]
                public long? SellerId { get; set; }

                [NameInMap("SellerNick")]
                [Validation(Required=false)]
                public string SellerNick { get; set; }

                [NameInMap("Shipping")]
                [Validation(Required=false)]
                public string Shipping { get; set; }

                [NameInMap("ShopName")]
                [Validation(Required=false)]
                public string ShopName { get; set; }

                [NameInMap("SubItemOrderList")]
                [Validation(Required=false)]
                public QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderList SubItemOrderList { get; set; }
                public class QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderList : TeaModel {
                    [NameInMap("SubItemOrder")]
                    [Validation(Required=false)]
                    public List<QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrder> SubItemOrder { get; set; }
                    public class QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrder : TeaModel {
                        [NameInMap("ChannelCode")]
                        [Validation(Required=false)]
                        public string ChannelCode { get; set; }

                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public long? ItemId { get; set; }

                        [NameInMap("ItemPic")]
                        [Validation(Required=false)]
                        public string ItemPic { get; set; }

                        [NameInMap("ItemPriceInfo")]
                        [Validation(Required=false)]
                        public string ItemPriceInfo { get; set; }

                        [NameInMap("ItemPriceList")]
                        [Validation(Required=false)]
                        public QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrderItemPriceList ItemPriceList { get; set; }
                        public class QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrderItemPriceList : TeaModel {
                            [NameInMap("ItemPrice")]
                            [Validation(Required=false)]
                            public List<QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrderItemPriceListItemPrice> ItemPrice { get; set; }
                            public class QueryOrderDetailInnerResponseBodyModelOrderSubItemOrderListSubItemOrderItemPriceListItemPrice : TeaModel {
                                [NameInMap("FundAmount")]
                                [Validation(Required=false)]
                                public long? FundAmount { get; set; }

                                [NameInMap("FundAmountMoney")]
                                [Validation(Required=false)]
                                public long? FundAmountMoney { get; set; }

                                [NameInMap("FundType")]
                                [Validation(Required=false)]
                                public string FundType { get; set; }

                                [NameInMap("TbOrderId")]
                                [Validation(Required=false)]
                                public long? TbOrderId { get; set; }

                                [NameInMap("TbSubOrderId")]
                                [Validation(Required=false)]
                                public long? TbSubOrderId { get; set; }

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
                        public int? Number { get; set; }

                        [NameInMap("PayStatus")]
                        [Validation(Required=false)]
                        public int? PayStatus { get; set; }

                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("SkuName")]
                        [Validation(Required=false)]
                        public string SkuName { get; set; }

                        [NameInMap("TbSubOrderId")]
                        [Validation(Required=false)]
                        public long? TbSubOrderId { get; set; }

                        [NameInMap("TotalPaymentInfo")]
                        [Validation(Required=false)]
                        public string TotalPaymentInfo { get; set; }

                    }

                }

                [NameInMap("TbOrderId")]
                [Validation(Required=false)]
                public string TbOrderId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
