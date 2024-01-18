// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryBizItemListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public QueryBizItemListResponseBodyItemList ItemList { get; set; }
        public class QueryBizItemListResponseBodyItemList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<QueryBizItemListResponseBodyItemListItem> Item { get; set; }
            public class QueryBizItemListResponseBodyItemListItem : TeaModel {
                [NameInMap("CanSell")]
                [Validation(Required=false)]
                public bool? CanSell { get; set; }

                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                [NameInMap("CustomizedItemName")]
                [Validation(Required=false)]
                public string CustomizedItemName { get; set; }

                [NameInMap("ExtJson")]
                [Validation(Required=false)]
                public string ExtJson { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("ItemTitle")]
                [Validation(Required=false)]
                public string ItemTitle { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("MainPicUrl")]
                [Validation(Required=false)]
                public string MainPicUrl { get; set; }

                [NameInMap("ReservePrice")]
                [Validation(Required=false)]
                public long? ReservePrice { get; set; }

                [NameInMap("SellerId")]
                [Validation(Required=false)]
                public long? SellerId { get; set; }

                [NameInMap("SkuList")]
                [Validation(Required=false)]
                public QueryBizItemListResponseBodyItemListItemSkuList SkuList { get; set; }
                public class QueryBizItemListResponseBodyItemListItemSkuList : TeaModel {
                    [NameInMap("Sku")]
                    [Validation(Required=false)]
                    public List<QueryBizItemListResponseBodyItemListItemSkuListSku> Sku { get; set; }
                    public class QueryBizItemListResponseBodyItemListItemSkuListSku : TeaModel {
                        [NameInMap("BenefitId")]
                        [Validation(Required=false)]
                        public string BenefitId { get; set; }

                        [NameInMap("CanSell")]
                        [Validation(Required=false)]
                        public bool? CanSell { get; set; }

                        [NameInMap("CustomizedAttributeMap")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> CustomizedAttributeMap { get; set; }

                        [NameInMap("GradePriceModels")]
                        [Validation(Required=false)]
                        public QueryBizItemListResponseBodyItemListItemSkuListSkuGradePriceModels GradePriceModels { get; set; }
                        public class QueryBizItemListResponseBodyItemListItemSkuListSkuGradePriceModels : TeaModel {
                            [NameInMap("GradePriceModel")]
                            [Validation(Required=false)]
                            public List<QueryBizItemListResponseBodyItemListItemSkuListSkuGradePriceModelsGradePriceModel> GradePriceModel { get; set; }
                            public class QueryBizItemListResponseBodyItemListItemSkuListSkuGradePriceModelsGradePriceModel : TeaModel {
                                [NameInMap("AccessUrl")]
                                [Validation(Required=false)]
                                public string AccessUrl { get; set; }

                                [NameInMap("CanBuy")]
                                [Validation(Required=false)]
                                public bool? CanBuy { get; set; }

                                [NameInMap("CharacteristicCode")]
                                [Validation(Required=false)]
                                public string CharacteristicCode { get; set; }

                                [NameInMap("CharacteristicName")]
                                [Validation(Required=false)]
                                public string CharacteristicName { get; set; }

                                [NameInMap("Exclusive")]
                                [Validation(Required=false)]
                                public bool? Exclusive { get; set; }

                                [NameInMap("Icon")]
                                [Validation(Required=false)]
                                public string Icon { get; set; }

                                [NameInMap("PointPrice")]
                                [Validation(Required=false)]
                                public long? PointPrice { get; set; }

                                [NameInMap("Points")]
                                [Validation(Required=false)]
                                public long? Points { get; set; }

                                [NameInMap("PointsAmount")]
                                [Validation(Required=false)]
                                public long? PointsAmount { get; set; }

                                [NameInMap("PriceCent")]
                                [Validation(Required=false)]
                                public long? PriceCent { get; set; }

                                [NameInMap("Recommend")]
                                [Validation(Required=false)]
                                public bool? Recommend { get; set; }

                                [NameInMap("ShowName")]
                                [Validation(Required=false)]
                                public string ShowName { get; set; }

                                [NameInMap("SubBizCode")]
                                [Validation(Required=false)]
                                public string SubBizCode { get; set; }

                                [NameInMap("UserLabelList")]
                                [Validation(Required=false)]
                                public QueryBizItemListResponseBodyItemListItemSkuListSkuGradePriceModelsGradePriceModelUserLabelList UserLabelList { get; set; }
                                public class QueryBizItemListResponseBodyItemListItemSkuListSkuGradePriceModelsGradePriceModelUserLabelList : TeaModel {
                                    [NameInMap("UserLabelList")]
                                    [Validation(Required=false)]
                                    public List<string> UserLabelList { get; set; }

                                }

                            }

                        }

                        [NameInMap("Points")]
                        [Validation(Required=false)]
                        public long? Points { get; set; }

                        [NameInMap("PointsAmount")]
                        [Validation(Required=false)]
                        public long? PointsAmount { get; set; }

                        [NameInMap("PriceCent")]
                        [Validation(Required=false)]
                        public long? PriceCent { get; set; }

                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("SkuPicUrl")]
                        [Validation(Required=false)]
                        public string SkuPicUrl { get; set; }

                        [NameInMap("SkuTitle")]
                        [Validation(Required=false)]
                        public string SkuTitle { get; set; }

                        [NameInMap("TaoBaoCurrentPrice")]
                        [Validation(Required=false)]
                        public long? TaoBaoCurrentPrice { get; set; }

                        [NameInMap("UserLabelList")]
                        [Validation(Required=false)]
                        public QueryBizItemListResponseBodyItemListItemSkuListSkuUserLabelList UserLabelList { get; set; }
                        public class QueryBizItemListResponseBodyItemListItemSkuListSkuUserLabelList : TeaModel {
                            [NameInMap("UserLabelList")]
                            [Validation(Required=false)]
                            public List<string> UserLabelList { get; set; }

                        }

                    }

                }

                [NameInMap("TaobaoShopName")]
                [Validation(Required=false)]
                public string TaobaoShopName { get; set; }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
