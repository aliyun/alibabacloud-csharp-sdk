// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class InsertHotelSceneBookItemRequest : TeaModel {
        /// <summary>
        /// addHotelSceneItemReq
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AddHotelSceneItemReq")]
        [Validation(Required=false)]
        public InsertHotelSceneBookItemRequestAddHotelSceneItemReq AddHotelSceneItemReq { get; set; }
        public class InsertHotelSceneBookItemRequestAddHotelSceneItemReq : TeaModel {
            /// <summary>
            /// icon
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// hotelID
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

    }

}
