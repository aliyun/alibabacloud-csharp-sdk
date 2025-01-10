// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelRoomsRequest : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("HotelAdminRoom")]
        [Validation(Required=false)]
        public ListHotelRoomsRequestHotelAdminRoom HotelAdminRoom { get; set; }
        public class ListHotelRoomsRequestHotelAdminRoom : TeaModel {
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e6dd44fd16084db8a60d69fd625d9f0f</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

    }

}
