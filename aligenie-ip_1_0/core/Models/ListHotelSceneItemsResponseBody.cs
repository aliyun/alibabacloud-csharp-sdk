// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelSceneItemsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListHotelSceneItemsResponseBodyResult Result { get; set; }
        public class ListHotelSceneItemsResponseBodyResult : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListHotelSceneItemsResponseBodyResultPage Page { get; set; }
            public class ListHotelSceneItemsResponseBodyResultPage : TeaModel {
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

            }

            [NameInMap("SceneItemList")]
            [Validation(Required=false)]
            public List<ListHotelSceneItemsResponseBodyResultSceneItemList> SceneItemList { get; set; }
            public class ListHotelSceneItemsResponseBodyResultSceneItemList : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("DeliveryMethod")]
                [Validation(Required=false)]
                public string DeliveryMethod { get; set; }

                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// id
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PaymentMethod")]
                [Validation(Required=false)]
                public string PaymentMethod { get; set; }

                [NameInMap("Price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("RobotName")]
                [Validation(Required=false)]
                public string RobotName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

    }

}
