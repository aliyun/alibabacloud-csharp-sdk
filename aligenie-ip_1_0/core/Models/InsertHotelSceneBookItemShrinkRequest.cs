// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class InsertHotelSceneBookItemShrinkRequest : TeaModel {
        /// <summary>
        /// addHotelSceneItemReq
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AddHotelSceneItemReq")]
        [Validation(Required=false)]
        public string AddHotelSceneItemReqShrink { get; set; }

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
