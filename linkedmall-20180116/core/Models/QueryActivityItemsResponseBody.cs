// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryActivityItemsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("LmActivityItemModelList")]
        [Validation(Required=false)]
        public QueryActivityItemsResponseBodyLmActivityItemModelList LmActivityItemModelList { get; set; }
        public class QueryActivityItemsResponseBodyLmActivityItemModelList : TeaModel {
            [NameInMap("LmActivityItemModel")]
            [Validation(Required=false)]
            public List<QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModel> LmActivityItemModel { get; set; }
            public class QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModel : TeaModel {
                public long? TbSellerId { get; set; }
                public string ItemTitle { get; set; }
                public int? SellableQuantity { get; set; }
                public long? TbShopId { get; set; }
                public int? ItemActivityQuantity { get; set; }
                public string TbShopName { get; set; }
                public string LmItemId { get; set; }
                public long? LmActivityId { get; set; }
                public long? ItemId { get; set; }
                public bool? CanSell { get; set; }
                public string MainPicUrl { get; set; }
                public string Tips { get; set; }
                public string LmShopId { get; set; }
                public QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModelSkuModelList SkuModelList { get; set; }
                public class QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModelSkuModelList : TeaModel {
                    [NameInMap("LmActivityItemSkuModel")]
                    [Validation(Required=false)]
                    public List<QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModelSkuModelListLmActivityItemSkuModel> LmActivityItemSkuModel { get; set; }
                    public class QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModelSkuModelListLmActivityItemSkuModel : TeaModel {
                        [NameInMap("ReservedPrice")]
                        [Validation(Required=false)]
                        public long? ReservedPrice { get; set; }

                        [NameInMap("Tips")]
                        [Validation(Required=false)]
                        public string Tips { get; set; }

                        [NameInMap("LmItemId")]
                        [Validation(Required=false)]
                        public string LmItemId { get; set; }

                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("LmActivityId")]
                        [Validation(Required=false)]
                        public long? LmActivityId { get; set; }

                        [NameInMap("ActivityStatus")]
                        [Validation(Required=false)]
                        public string ActivityStatus { get; set; }

                        [NameInMap("BizId")]
                        [Validation(Required=false)]
                        public string BizId { get; set; }

                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public long? ItemId { get; set; }

                        [NameInMap("SkuPicUrl")]
                        [Validation(Required=false)]
                        public string SkuPicUrl { get; set; }

                        [NameInMap("ActivityPrice")]
                        [Validation(Required=false)]
                        public long? ActivityPrice { get; set; }

                        [NameInMap("SkuTitle")]
                        [Validation(Required=false)]
                        public string SkuTitle { get; set; }

                    }

                }
                public string ItemActivityStatus { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
