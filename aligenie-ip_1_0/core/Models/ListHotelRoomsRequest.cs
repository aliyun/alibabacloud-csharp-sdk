// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelRoomsRequest : TeaModel {
        [NameInMap("HotelAdminRoom")]
        [Validation(Required=false)]
        public ListHotelRoomsRequestHotelAdminRoom HotelAdminRoom { get; set; }
        public class ListHotelRoomsRequestHotelAdminRoom : TeaModel {
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

    }

}
