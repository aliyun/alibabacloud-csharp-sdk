// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListHotelSceneItemsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>hotelID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80d84ea8ed9e422fbad52715c8fc56f1</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <para>ListHotelSceneReq</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListHotelSceneReq")]
        [Validation(Required=false)]
        public string ListHotelSceneReqShrink { get; set; }

    }

}
