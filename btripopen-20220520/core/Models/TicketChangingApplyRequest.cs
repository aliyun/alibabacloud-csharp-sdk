// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingApplyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis1234</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mid1243</para>
        /// </summary>
        [NameInMap("dis_sub_order_id")]
        [Validation(Required=false)]
        public string DisSubOrderId { get; set; }

        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public int? IsVoluntary { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("modify_flight_info_list")]
        [Validation(Required=false)]
        public List<TicketChangingApplyRequestModifyFlightInfoList> ModifyFlightInfoList { get; set; }
        public class TicketChangingApplyRequestModifyFlightInfoList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BJS</para>
            /// </summary>
            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("cabin")]
            [Validation(Required=false)]
            public string Cabin { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HGH</para>
            /// </summary>
            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CA1704</para>
            /// </summary>
            [NameInMap("flight_no")]
            [Validation(Required=false)]
            public string FlightNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("passenger_info_list")]
            [Validation(Required=false)]
            public List<TicketChangingApplyRequestModifyFlightInfoListPassengerInfoList> PassengerInfoList { get; set; }
            public class TicketChangingApplyRequestModifyFlightInfoListPassengerInfoList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA1703</para>
                /// </summary>
                [NameInMap("origin_flight_no")]
                [Validation(Required=false)]
                public string OriginFlightNo { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("out_user_id")]
                [Validation(Required=false)]
                public string OutUserId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1s8837sh991hsj92h</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>us88s2bsbin22hjusd8i</para>
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("whether_retry")]
        [Validation(Required=false)]
        public bool? WhetherRetry { get; set; }

    }

}
