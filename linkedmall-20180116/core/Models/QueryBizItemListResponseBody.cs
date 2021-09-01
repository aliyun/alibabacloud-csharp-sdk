// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryBizItemListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public QueryBizItemListResponseBodyItemList ItemList { get; set; }
        public class QueryBizItemListResponseBodyItemList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<QueryBizItemListResponseBodyItemListItem> Item { get; set; }
            public class QueryBizItemListResponseBodyItemListItem : TeaModel {
                public string ExtJson { get; set; }
                public string MainPicUrl { get; set; }
                public string ItemTitle { get; set; }
                public string LmItemId { get; set; }
                public long? SellerId { get; set; }
                public long? CategoryId { get; set; }
                public bool? CanSell { get; set; }
                public string CustomizedItemName { get; set; }
                public long? ItemId { get; set; }
                public long? ReservePrice { get; set; }
                public string TaobaoShopName { get; set; }
                public QueryBizItemListResponseBodyItemListItemSkuList SkuList { get; set; }
                public class QueryBizItemListResponseBodyItemListItemSkuList : TeaModel {
                    [NameInMap("Sku")]
                    [Validation(Required=false)]
                    public List<QueryBizItemListResponseBodyItemListItemSkuListSku> Sku { get; set; }
                    public class QueryBizItemListResponseBodyItemListItemSkuListSku : TeaModel {
                        [NameInMap("PriceCent")]
                        [Validation(Required=false)]
                        public long? PriceCent { get; set; }

                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("TaoBaoCurrentPrice")]
                        [Validation(Required=false)]
                        public long? TaoBaoCurrentPrice { get; set; }

                        [NameInMap("CanSell")]
                        [Validation(Required=false)]
                        public bool? CanSell { get; set; }

                        [NameInMap("SkuPicUrl")]
                        [Validation(Required=false)]
                        public string SkuPicUrl { get; set; }

                        [NameInMap("Points")]
                        [Validation(Required=false)]
                        public long? Points { get; set; }

                        [NameInMap("SkuTitle")]
                        [Validation(Required=false)]
                        public string SkuTitle { get; set; }

                        [NameInMap("PointsAmount")]
                        [Validation(Required=false)]
                        public long? PointsAmount { get; set; }

                        [NameInMap("BenefitId")]
                        [Validation(Required=false)]
                        public string BenefitId { get; set; }

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
                                public bool? Recommend { get; set; }
                                public string ShowName { get; set; }
                                public long? PriceCent { get; set; }
                                public string Icon { get; set; }
                                public long? PointPrice { get; set; }
                                public bool? Exclusive { get; set; }
                                public string CharacteristicName { get; set; }
                                public string AccessUrl { get; set; }
                                public string SubBizCode { get; set; }
                                public string CharacteristicCode { get; set; }
                                public bool? CanBuy { get; set; }
                                public long? Points { get; set; }
                                public long? PointsAmount { get; set; }
                                public QueryBizItemListResponseBodyItemListItemSkuListSkuGradePriceModelsGradePriceModelUserLabelList UserLabelList { get; set; }
                                public class QueryBizItemListResponseBodyItemListItemSkuListSkuGradePriceModelsGradePriceModelUserLabelList : TeaModel {
                                    [NameInMap("UserLabelList")]
                                    [Validation(Required=false)]
                                    public List<string> UserLabelList { get; set; }

                                }
                            }
                        };

                        [NameInMap("UserLabelList")]
                        [Validation(Required=false)]
                        public QueryBizItemListResponseBodyItemListItemSkuListSkuUserLabelList UserLabelList { get; set; }
                        public class QueryBizItemListResponseBodyItemListItemSkuListSkuUserLabelList : TeaModel {
                            [NameInMap("UserLabelList")]
                            [Validation(Required=false)]
                            public List<string> UserLabelList { get; set; }
                        };

                    }

                }
            }
        };

    }

}
