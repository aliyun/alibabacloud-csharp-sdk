// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class QueryItemsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryItemsResponseBodyData Data { get; set; }
        public class QueryItemsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<QueryItemsResponseBodyDataItems> Items { get; set; }
            public class QueryItemsResponseBodyDataItems : TeaModel {
                public long? CategoryId { get; set; }
                public long? CreateTime { get; set; }
                public string Description { get; set; }
                public List<QueryItemsResponseBodyDataItemsGames> Games { get; set; }
                public class QueryItemsResponseBodyDataItemsGames : TeaModel {
                    public string GameId { get; set; }
                    public string Name { get; set; }
                }
                public string ItemId { get; set; }
                public long? ModifyTime { get; set; }
                public long? OriginPrice { get; set; }
                public long? SalePrice { get; set; }
                public string SellerId { get; set; }
                public List<QueryItemsResponseBodyDataItemsSkus> Skus { get; set; }
                public class QueryItemsResponseBodyDataItemsSkus : TeaModel {
                    public long? CreateTime { get; set; }
                    public string ItemId { get; set; }
                    public long? ModifyTime { get; set; }
                    public long? OriginPrice { get; set; }
                    public long? SalePrice { get; set; }
                    public List<QueryItemsResponseBodyDataItemsSkusSaleProps> SaleProps { get; set; }
                    public class QueryItemsResponseBodyDataItemsSkusSaleProps : TeaModel {
                        public long? PropertyId { get; set; }
                        public string PropertyName { get; set; }
                        public string Value { get; set; }
                        public long? ValueId { get; set; }
                    }
                    public string SkuId { get; set; }
                    public int? Status { get; set; }
                }
                public int? Status { get; set; }
                public string Supplier { get; set; }
                public string Title { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
