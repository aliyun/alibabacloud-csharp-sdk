// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateHotelSceneBookItemRequest : TeaModel {
        /// <summary>
        /// hotelID
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// updateHotelSceneBookReq
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UpdateHotelSceneBookReq")]
        [Validation(Required=false)]
        public UpdateHotelSceneBookItemRequestUpdateHotelSceneBookReq UpdateHotelSceneBookReq { get; set; }
        public class UpdateHotelSceneBookItemRequestUpdateHotelSceneBookReq : TeaModel {
            /// <summary>
            /// icon
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

        }

    }

}
