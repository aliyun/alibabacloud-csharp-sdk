// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderChangeApplyRequest : TeaModel {
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("room_info_list")]
        [Validation(Required=false)]
        public List<HotelOrderChangeApplyRequestRoomInfoList> RoomInfoList { get; set; }
        public class HotelOrderChangeApplyRequestRoomInfoList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cancel_date")]
            [Validation(Required=false)]
            public List<string> CancelDate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("room_no")]
            [Validation(Required=false)]
            public int? RoomNo { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sale_order_id")]
        [Validation(Required=false)]
        public string SaleOrderId { get; set; }

    }

}
