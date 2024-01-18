// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryActivityItemsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LmActivityItemModelList")]
        [Validation(Required=false)]
        public QueryActivityItemsResponseBodyLmActivityItemModelList LmActivityItemModelList { get; set; }
        public class QueryActivityItemsResponseBodyLmActivityItemModelList : TeaModel {
            [NameInMap("LmActivityItemModel")]
            [Validation(Required=false)]
            public List<QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModel> LmActivityItemModel { get; set; }
            public class QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModel : TeaModel {
                [NameInMap("CanSell")]
                [Validation(Required=false)]
                public bool? CanSell { get; set; }

                [NameInMap("ItemActivityQuantity")]
                [Validation(Required=false)]
                public int? ItemActivityQuantity { get; set; }

                [NameInMap("ItemActivityStatus")]
                [Validation(Required=false)]
                public string ItemActivityStatus { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                [NameInMap("ItemTitle")]
                [Validation(Required=false)]
                public string ItemTitle { get; set; }

                [NameInMap("LmActivityId")]
                [Validation(Required=false)]
                public long? LmActivityId { get; set; }

                [NameInMap("LmItemId")]
                [Validation(Required=false)]
                public string LmItemId { get; set; }

                [NameInMap("LmShopId")]
                [Validation(Required=false)]
                public string LmShopId { get; set; }

                [NameInMap("MainPicUrl")]
                [Validation(Required=false)]
                public string MainPicUrl { get; set; }

                [NameInMap("SellableQuantity")]
                [Validation(Required=false)]
                public int? SellableQuantity { get; set; }

                [NameInMap("SkuModelList")]
                [Validation(Required=false)]
                public QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModelSkuModelList SkuModelList { get; set; }
                public class QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModelSkuModelList : TeaModel {
                    [NameInMap("LmActivityItemSkuModel")]
                    [Validation(Required=false)]
                    public List<QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModelSkuModelListLmActivityItemSkuModel> LmActivityItemSkuModel { get; set; }
                    public class QueryActivityItemsResponseBodyLmActivityItemModelListLmActivityItemModelSkuModelListLmActivityItemSkuModel : TeaModel {
                        [NameInMap("ActivityPrice")]
                        [Validation(Required=false)]
                        public long? ActivityPrice { get; set; }

                        [NameInMap("ActivityStatus")]
                        [Validation(Required=false)]
                        public string ActivityStatus { get; set; }

                        [NameInMap("BizId")]
                        [Validation(Required=false)]
                        public string BizId { get; set; }

                        [NameInMap("ItemId")]
                        [Validation(Required=false)]
                        public long? ItemId { get; set; }

                        [NameInMap("LmActivityId")]
                        [Validation(Required=false)]
                        public long? LmActivityId { get; set; }

                        [NameInMap("LmItemId")]
                        [Validation(Required=false)]
                        public string LmItemId { get; set; }

                        [NameInMap("ReservedPrice")]
                        [Validation(Required=false)]
                        public long? ReservedPrice { get; set; }

                        /// <summary>
                        /// skuID
                        /// </summary>
                        [NameInMap("SkuId")]
                        [Validation(Required=false)]
                        public long? SkuId { get; set; }

                        [NameInMap("SkuPicUrl")]
                        [Validation(Required=false)]
                        public string SkuPicUrl { get; set; }

                        [NameInMap("SkuTitle")]
                        [Validation(Required=false)]
                        public string SkuTitle { get; set; }

                        [NameInMap("Tips")]
                        [Validation(Required=false)]
                        public string Tips { get; set; }

                    }

                }

                [NameInMap("TbSellerId")]
                [Validation(Required=false)]
                public long? TbSellerId { get; set; }

                [NameInMap("TbShopId")]
                [Validation(Required=false)]
                public long? TbShopId { get; set; }

                [NameInMap("TbShopName")]
                [Validation(Required=false)]
                public string TbShopName { get; set; }

                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
