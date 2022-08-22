// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelSceneItemResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListHotelSceneItemResponseBodyPage Page { get; set; }
        public class ListHotelSceneItemResponseBodyPage : TeaModel {
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListHotelSceneItemResponseBodyResult Result { get; set; }
        public class ListHotelSceneItemResponseBodyResult : TeaModel {
            [NameInMap("SecondCategoryList")]
            [Validation(Required=false)]
            public List<ListHotelSceneItemResponseBodyResultSecondCategoryList> SecondCategoryList { get; set; }
            public class ListHotelSceneItemResponseBodyResultSecondCategoryList : TeaModel {
                public List<ListHotelSceneItemResponseBodyResultSecondCategoryListItemList> ItemList { get; set; }
                public class ListHotelSceneItemResponseBodyResultSecondCategoryListItemList : TeaModel {
                    public string Category { get; set; }
                    public string Icon { get; set; }
                    public string Id { get; set; }
                    public string Name { get; set; }
                    public long? Price { get; set; }
                    public string Status { get; set; }
                    public string Type { get; set; }
                }
                public string SecondCategoryName { get; set; }
            }
        };

    }

}
