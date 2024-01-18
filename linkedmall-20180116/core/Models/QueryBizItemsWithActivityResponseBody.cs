// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryBizItemsWithActivityResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public QueryBizItemsWithActivityResponseBodyItemList ItemList { get; set; }
        public class QueryBizItemsWithActivityResponseBodyItemList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<QueryBizItemsWithActivityResponseBodyItemListItem> Item { get; set; }
            public class QueryBizItemsWithActivityResponseBodyItemListItem : TeaModel {
                [NameInMap("Activities")]
                [Validation(Required=false)]
                public QueryBizItemsWithActivityResponseBodyItemListItemActivities Activities { get; set; }
                public class QueryBizItemsWithActivityResponseBodyItemListItemActivities : TeaModel {
                    [NameInMap("Activity")]
                    [Validation(Required=false)]
                    public List<QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivity> Activity { get; set; }
                    public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivity : TeaModel {
                        [NameInMap("ActivityItem")]
                        [Validation(Required=false)]
                        public QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivityItem ActivityItem { get; set; }
                        public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivityItem : TeaModel {
                            [NameInMap("ActivityItemSkuList")]
                            [Validation(Required=false)]
                            public QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivityItemActivityItemSkuList ActivityItemSkuList { get; set; }
                            public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivityItemActivityItemSkuList : TeaModel {
                                [NameInMap("ActivityItemSku")]
                                [Validation(Required=false)]
                                public List<QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivityItemActivityItemSkuListActivityItemSku> ActivityItemSku { get; set; }
                                public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivityItemActivityItemSkuListActivityItemSku : TeaModel {
                                    [NameInMap("ActivityPrice")]
                                    [Validation(Required=false)]
                                    public long? ActivityPrice { get; set; }

                                    /// <summary>
                                    /// skuId
                                    /// </summary>
                                    [NameInMap("SkuId")]
                                    [Validation(Required=false)]
                                    public long? SkuId { get; set; }

                                }

                            }

                            [NameInMap("ActivityQuantity")]
                            [Validation(Required=false)]
                            public long? ActivityQuantity { get; set; }

                            [NameInMap("LimitQuantityForPerson")]
                            [Validation(Required=false)]
                            public long? LimitQuantityForPerson { get; set; }

                        }

                        [NameInMap("ActivitySessions")]
                        [Validation(Required=false)]
                        public QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessions ActivitySessions { get; set; }
                        public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessions : TeaModel {
                            [NameInMap("ActivitySession")]
                            [Validation(Required=false)]
                            public List<QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySession> ActivitySession { get; set; }
                            public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySession : TeaModel {
                                [NameInMap("ActivitySessionItem")]
                                [Validation(Required=false)]
                                public QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySessionActivitySessionItem ActivitySessionItem { get; set; }
                                public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySessionActivitySessionItem : TeaModel {
                                    [NameInMap("ActivitySessionItemSkuList")]
                                    [Validation(Required=false)]
                                    public QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySessionActivitySessionItemActivitySessionItemSkuList ActivitySessionItemSkuList { get; set; }
                                    public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySessionActivitySessionItemActivitySessionItemSkuList : TeaModel {
                                        [NameInMap("Points")]
                                        [Validation(Required=false)]
                                        public long? Points { get; set; }

                                        [NameInMap("PointsAmount")]
                                        [Validation(Required=false)]
                                        public long? PointsAmount { get; set; }

                                        [NameInMap("PriceCent")]
                                        [Validation(Required=false)]
                                        public long? PriceCent { get; set; }

                                        /// <summary>
                                        /// skuId
                                        /// </summary>
                                        [NameInMap("SkuId")]
                                        [Validation(Required=false)]
                                        public long? SkuId { get; set; }

                                    }

                                    [NameInMap("LimitQuantityForPerson")]
                                    [Validation(Required=false)]
                                    public long? LimitQuantityForPerson { get; set; }

                                    [NameInMap("SaleableQuantity")]
                                    [Validation(Required=false)]
                                    public long? SaleableQuantity { get; set; }

                                    [NameInMap("SessionQuantity")]
                                    [Validation(Required=false)]
                                    public long? SessionQuantity { get; set; }

                                }

                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                [NameInMap("DisplayDate")]
                                [Validation(Required=false)]
                                public long? DisplayDate { get; set; }

                                [NameInMap("EndDate")]
                                [Validation(Required=false)]
                                public long? EndDate { get; set; }

                                [NameInMap("LmSessionId")]
                                [Validation(Required=false)]
                                public long? LmSessionId { get; set; }

                                [NameInMap("StartDate")]
                                [Validation(Required=false)]
                                public long? StartDate { get; set; }

                                [NameInMap("SubBizCode")]
                                [Validation(Required=false)]
                                public string SubBizCode { get; set; }

                                [NameInMap("Title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                        }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("EndDate")]
                        [Validation(Required=false)]
                        public long? EndDate { get; set; }

                        [NameInMap("LmActivityId")]
                        [Validation(Required=false)]
                        public long? LmActivityId { get; set; }

                        [NameInMap("StartDate")]
                        [Validation(Required=false)]
                        public long? StartDate { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                }

                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("ItemTitle")]
                [Validation(Required=false)]
                public string ItemTitle { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("MaxAllowedCount")]
                [Validation(Required=false)]
                public int? MaxAllowedCount { get; set; }

                [NameInMap("PicUrl")]
                [Validation(Required=false)]
                public string PicUrl { get; set; }

                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public long? Quantity { get; set; }

                [NameInMap("ReservePrice")]
                [Validation(Required=false)]
                public long? ReservePrice { get; set; }

                [NameInMap("SellerId")]
                [Validation(Required=false)]
                public long? SellerId { get; set; }

                [NameInMap("SkuList")]
                [Validation(Required=false)]
                public QueryBizItemsWithActivityResponseBodyItemListItemSkuList SkuList { get; set; }
                public class QueryBizItemsWithActivityResponseBodyItemListItemSkuList : TeaModel {
                    [NameInMap("Sku")]
                    [Validation(Required=false)]
                    public List<QueryBizItemsWithActivityResponseBodyItemListItemSkuListSku> Sku { get; set; }
                    public class QueryBizItemsWithActivityResponseBodyItemListItemSkuListSku : TeaModel {
                        [NameInMap("MaxAllowedCount")]
                        [Validation(Required=false)]
                        public int? MaxAllowedCount { get; set; }

                        [NameInMap("Points")]
                        [Validation(Required=false)]
                        public long? Points { get; set; }

                        [NameInMap("PointsAmount")]
                        [Validation(Required=false)]
                        public long? PointsAmount { get; set; }

                        [NameInMap("PointsInfo")]
                        [Validation(Required=false)]
                        public string PointsInfo { get; set; }

                        [NameInMap("PointsKey")]
                        [Validation(Required=false)]
                        public string PointsKey { get; set; }

                        [NameInMap("PriceCent")]
                        [Validation(Required=false)]
                        public long? PriceCent { get; set; }

                        [NameInMap("Quantity")]
                        [Validation(Required=false)]
                        public long? Quantity { get; set; }

                        /// <summary>
                        /// skuId
                        /// </summary>
                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public long? Status { get; set; }

                    }

                }

                [NameInMap("TaobaoShopName")]
                [Validation(Required=false)]
                public string TaobaoShopName { get; set; }

                [NameInMap("TotalSoldQuantity")]
                [Validation(Required=false)]
                public int? TotalSoldQuantity { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
