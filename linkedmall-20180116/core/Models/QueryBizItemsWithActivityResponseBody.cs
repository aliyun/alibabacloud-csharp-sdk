// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryBizItemsWithActivityResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public QueryBizItemsWithActivityResponseBodyItemList ItemList { get; set; }
        public class QueryBizItemsWithActivityResponseBodyItemList : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<QueryBizItemsWithActivityResponseBodyItemListItem> Item { get; set; }
            public class QueryBizItemsWithActivityResponseBodyItemListItem : TeaModel {
                public string PicUrl { get; set; }
                public string ItemTitle { get; set; }
                public long? SellerId { get; set; }
                public string LmItemId { get; set; }
                public QueryBizItemsWithActivityResponseBodyItemListItemSkuList SkuList { get; set; }
                public class QueryBizItemsWithActivityResponseBodyItemListItemSkuList : TeaModel {
                    [NameInMap("Sku")]
                    [Validation(Required=false)]
                    public List<QueryBizItemsWithActivityResponseBodyItemListItemSkuListSku> Sku { get; set; }
                    public class QueryBizItemsWithActivityResponseBodyItemListItemSkuListSku : TeaModel {
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public long? Status { get; set; }

                        [NameInMap("PriceCent")]
                        [Validation(Required=false)]
                        public long? PriceCent { get; set; }

                        [NameInMap("PointsInfo")]
                        [Validation(Required=false)]
                        public string PointsInfo { get; set; }

                        [NameInMap("MaxAllowedCount")]
                        [Validation(Required=false)]
                        public int? MaxAllowedCount { get; set; }

                        [NameInMap("PointsKey")]
                        [Validation(Required=false)]
                        public string PointsKey { get; set; }

                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("Points")]
                        [Validation(Required=false)]
                        public long? Points { get; set; }

                        [NameInMap("PointsAmount")]
                        [Validation(Required=false)]
                        public long? PointsAmount { get; set; }

                        [NameInMap("Quantity")]
                        [Validation(Required=false)]
                        public long? Quantity { get; set; }

                    }

                }
                public long? ItemId { get; set; }
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
                            [NameInMap("LimitQuantityForPerson")]
                            [Validation(Required=false)]
                            public long? LimitQuantityForPerson { get; set; }
                            [NameInMap("ActivityQuantity")]
                            [Validation(Required=false)]
                            public long? ActivityQuantity { get; set; }
                            [NameInMap("ActivityItemSkuList")]
                            [Validation(Required=false)]
                            public QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivityItemActivityItemSkuList ActivityItemSkuList { get; set; }
                            public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivityItemActivityItemSkuList : TeaModel {
                                [NameInMap("ActivityItemSku")]
                                [Validation(Required=false)]
                                public List<QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivityItemActivityItemSkuListActivityItemSku> ActivityItemSku { get; set; }
                                public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivityItemActivityItemSkuListActivityItemSku : TeaModel {
                                    [NameInMap("SkuId")]
                                    [Validation(Required=false)]
                                    public long? SkuId { get; set; }

                                    [NameInMap("ActivityPrice")]
                                    [Validation(Required=false)]
                                    public long? ActivityPrice { get; set; }

                                }

                            }
                        };

                        [NameInMap("EndDate")]
                        [Validation(Required=false)]
                        public long? EndDate { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("ActivitySessions")]
                        [Validation(Required=false)]
                        public QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessions ActivitySessions { get; set; }
                        public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessions : TeaModel {
                            [NameInMap("ActivitySession")]
                            [Validation(Required=false)]
                            public List<QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySession> ActivitySession { get; set; }
                            public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySession : TeaModel {
                                public string SubBizCode { get; set; }
                                public long? EndDate { get; set; }
                                public long? DisplayDate { get; set; }
                                public long? LmSessionId { get; set; }
                                public string Description { get; set; }
                                public QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySessionActivitySessionItem ActivitySessionItem { get; set; }
                                public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySessionActivitySessionItem : TeaModel {
                                    [NameInMap("LimitQuantityForPerson")]
                                    [Validation(Required=false)]
                                    public long? LimitQuantityForPerson { get; set; }

                                    [NameInMap("SaleableQuantity")]
                                    [Validation(Required=false)]
                                    public long? SaleableQuantity { get; set; }

                                    [NameInMap("SessionQuantity")]
                                    [Validation(Required=false)]
                                    public long? SessionQuantity { get; set; }

                                    [NameInMap("ActivitySessionItemSkuList")]
                                    [Validation(Required=false)]
                                    public QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySessionActivitySessionItemActivitySessionItemSkuList ActivitySessionItemSkuList { get; set; }
                                    public class QueryBizItemsWithActivityResponseBodyItemListItemActivitiesActivityActivitySessionsActivitySessionActivitySessionItemActivitySessionItemSkuList : TeaModel {
                                        [NameInMap("PriceCent")]
                                        [Validation(Required=false)]
                                        public long? PriceCent { get; set; }
                                        [NameInMap("SkuId")]
                                        [Validation(Required=false)]
                                        public long? SkuId { get; set; }
                                        [NameInMap("Points")]
                                        [Validation(Required=false)]
                                        public long? Points { get; set; }
                                        [NameInMap("PointsAmount")]
                                        [Validation(Required=false)]
                                        public long? PointsAmount { get; set; }
                                    };

                                }
                                public long? StartDate { get; set; }
                                public string Title { get; set; }
                            }
                        };

                        [NameInMap("StartDate")]
                        [Validation(Required=false)]
                        public long? StartDate { get; set; }

                        [NameInMap("LmActivityId")]
                        [Validation(Required=false)]
                        public long? LmActivityId { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                }
                public string TaobaoShopName { get; set; }
                public int? TotalSoldQuantity { get; set; }
                public int? MaxAllowedCount { get; set; }
                public long? CategoryId { get; set; }
                public long? ReservePrice { get; set; }
                public long? Quantity { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
