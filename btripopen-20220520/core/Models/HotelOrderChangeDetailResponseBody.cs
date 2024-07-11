// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderChangeDetailResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelOrderChangeDetailResponseBodyModule Module { get; set; }
        public class HotelOrderChangeDetailResponseBodyModule : TeaModel {
            [NameInMap("change_order_id")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            [NameInMap("change_type")]
            [Validation(Required=false)]
            public int? ChangeType { get; set; }

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            [NameInMap("room_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderChangeDetailResponseBodyModuleRoomInfoList> RoomInfoList { get; set; }
            public class HotelOrderChangeDetailResponseBodyModuleRoomInfoList : TeaModel {
                [NameInMap("cancel_date")]
                [Validation(Required=false)]
                public List<string> CancelDate { get; set; }

                [NameInMap("room_daily_refund_infos")]
                [Validation(Required=false)]
                public List<HotelOrderChangeDetailResponseBodyModuleRoomInfoListRoomDailyRefundInfos> RoomDailyRefundInfos { get; set; }
                public class HotelOrderChangeDetailResponseBodyModuleRoomInfoListRoomDailyRefundInfos : TeaModel {
                    [NameInMap("check_in_date")]
                    [Validation(Required=false)]
                    public string CheckInDate { get; set; }

                    [NameInMap("penalty_price")]
                    [Validation(Required=false)]
                    public long? PenaltyPrice { get; set; }

                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    [NameInMap("refund_price")]
                    [Validation(Required=false)]
                    public long? RefundPrice { get; set; }

                }

                [NameInMap("room_no")]
                [Validation(Required=false)]
                public int? RoomNo { get; set; }

            }

            [NameInMap("sale_order_id")]
            [Validation(Required=false)]
            public string SaleOrderId { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public int? Source { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("work_order_id")]
            [Validation(Required=false)]
            public string WorkOrderId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
