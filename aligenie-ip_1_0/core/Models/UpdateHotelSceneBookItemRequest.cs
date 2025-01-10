// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateHotelSceneBookItemRequest : TeaModel {
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
        /// <para>updateHotelSceneBookReq</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateHotelSceneBookReq")]
        [Validation(Required=false)]
        public UpdateHotelSceneBookItemRequestUpdateHotelSceneBookReq UpdateHotelSceneBookReq { get; set; }
        public class UpdateHotelSceneBookItemRequestUpdateHotelSceneBookReq : TeaModel {
            /// <summary>
            /// <para>icon</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://ailabs.alibabausercontent.com/platform/28d7a91e3c05db3855725fc39e0387e7/welcome_audios/aa918294b6ca3aa115c51135bf9b80cb/l9f996sq.png">https://ailabs.alibabausercontent.com/platform/28d7a91e3c05db3855725fc39e0387e7/welcome_audios/aa918294b6ca3aa115c51135bf9b80cb/l9f996sq.png</a></para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>青椒肉丝</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

        }

    }

}
