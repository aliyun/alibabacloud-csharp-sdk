// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelSceneItemsRequest : TeaModel {
        /// <summary>
        /// hotelID
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// ListHotelSceneReq
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListHotelSceneReq")]
        [Validation(Required=false)]
        public ListHotelSceneItemsRequestListHotelSceneReq ListHotelSceneReq { get; set; }
        public class ListHotelSceneItemsRequestListHotelSceneReq : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public string Keywords { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListHotelSceneItemsRequestListHotelSceneReqPage Page { get; set; }
            public class ListHotelSceneItemsRequestListHotelSceneReqPage : TeaModel {
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
