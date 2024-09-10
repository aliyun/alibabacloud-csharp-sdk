// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateHotelSceneItemShrinkRequest : TeaModel {
        /// <summary>
        /// hotelID
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// updateHotelSceneReq
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UpdateHotelSceneOperateReq")]
        [Validation(Required=false)]
        public string UpdateHotelSceneOperateReqShrink { get; set; }

        /// <summary>
        /// UpdateHotelSceneReq
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UpdateHotelSceneReq")]
        [Validation(Required=false)]
        public string UpdateHotelSceneReqShrink { get; set; }

    }

}
