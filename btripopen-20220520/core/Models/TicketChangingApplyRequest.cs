// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingApplyRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dis_sub_order_id")]
        [Validation(Required=false)]
        public string DisSubOrderId { get; set; }

        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public int? IsVoluntary { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modify_flight_info_list")]
        [Validation(Required=false)]
        public List<TicketChangingApplyRequestModifyFlightInfoList> ModifyFlightInfoList { get; set; }
        public class TicketChangingApplyRequestModifyFlightInfoList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            [NameInMap("cabin")]
            [Validation(Required=false)]
            public string Cabin { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("flight_no")]
            [Validation(Required=false)]
            public string FlightNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("passenger_info_list")]
            [Validation(Required=false)]
            public List<TicketChangingApplyRequestModifyFlightInfoListPassengerInfoList> PassengerInfoList { get; set; }
            public class TicketChangingApplyRequestModifyFlightInfoListPassengerInfoList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("origin_flight_no")]
                [Validation(Required=false)]
                public string OriginFlightNo { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("out_user_id")]
                [Validation(Required=false)]
                public string OutUserId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("whether_retry")]
        [Validation(Required=false)]
        public bool? WhetherRetry { get; set; }

    }

}
