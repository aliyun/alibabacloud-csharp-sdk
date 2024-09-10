// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateHotelSceneBookItemShrinkRequest : TeaModel {
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
        public string UpdateHotelSceneBookReqShrink { get; set; }

    }

}
