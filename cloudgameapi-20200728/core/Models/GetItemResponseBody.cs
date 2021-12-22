// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class GetItemResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetItemResponseBodyData Data { get; set; }
        public class GetItemResponseBodyData : TeaModel {
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Games")]
            [Validation(Required=false)]
            public List<GetItemResponseBodyDataGames> Games { get; set; }
            public class GetItemResponseBodyDataGames : TeaModel {
                public string GameId { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }
            [NameInMap("OriginPrice")]
            [Validation(Required=false)]
            public long? OriginPrice { get; set; }
            [NameInMap("SalePrice")]
            [Validation(Required=false)]
            public long? SalePrice { get; set; }
            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public string SellerId { get; set; }
            [NameInMap("Skus")]
            [Validation(Required=false)]
            public List<GetItemResponseBodyDataSkus> Skus { get; set; }
            public class GetItemResponseBodyDataSkus : TeaModel {
                public long? CreateTime { get; set; }
                public string ItemId { get; set; }
                public long? ModifyTime { get; set; }
                public long? OriginPrice { get; set; }
                public long? SalePrice { get; set; }
                public List<GetItemResponseBodyDataSkusSaleProps> SaleProps { get; set; }
                public class GetItemResponseBodyDataSkusSaleProps : TeaModel {
                    public long? PropertyId { get; set; }
                    public string PropertyName { get; set; }
                    public string Value { get; set; }
                    public long? ValueId { get; set; }
                }
                public string SkuId { get; set; }
                public int? Status { get; set; }
            }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("Supplier")]
            [Validation(Required=false)]
            public string Supplier { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
