// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderCreateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("accept_no_seat")]
        [Validation(Required=false)]
        public string AcceptNoSeat { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("book_train_infos")]
        [Validation(Required=false)]
        public List<TrainOrderCreateRequestBookTrainInfos> BookTrainInfos { get; set; }
        public class TrainOrderCreateRequestBookTrainInfos : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BDC</para>
            /// </summary>
            [NameInMap("arr_station_code")]
            [Validation(Required=false)]
            public string ArrStationCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("book_ticket_infos")]
            [Validation(Required=false)]
            public List<TrainOrderCreateRequestBookTrainInfosBookTicketInfos> BookTicketInfos { get; set; }
            public class TrainOrderCreateRequestBookTrainInfosBookTicketInfos : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("seat_type")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public long? TicketPrice { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ticket_type")]
                [Validation(Required=false)]
                public string TicketType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1T</para>
            /// </summary>
            [NameInMap("choose_beds")]
            [Validation(Required=false)]
            public string ChooseBeds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1T</para>
            /// </summary>
            [NameInMap("choose_seats")]
            [Validation(Required=false)]
            public string ChooseSeats { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BTC</para>
            /// </summary>
            [NameInMap("dep_station_code")]
            [Validation(Required=false)]
            public string DepStationCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-06 15:19:01</para>
            /// </summary>
            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>K123456</para>
            /// </summary>
            [NameInMap("train_no")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12344321</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("btrip_user_name")]
        [Validation(Required=false)]
        public string BtripUserName { get; set; }

        [NameInMap("business_info")]
        [Validation(Required=false)]
        public TrainOrderCreateRequestBusinessInfo BusinessInfo { get; set; }
        public class TrainOrderCreateRequestBusinessInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4321</para>
            /// </summary>
            [NameInMap("customer_apply_id")]
            [Validation(Required=false)]
            public string CustomerApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("customer_itinerary_id")]
            [Validation(Required=false)]
            public string CustomerItineraryId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public TrainOrderCreateRequestContactInfo ContactInfo { get; set; }
        public class TrainOrderCreateRequestContactInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public string PassengerId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b6a6fc1bdf1ba60e25c2e132b612c8819</para>
            /// </summary>
            [NameInMap("passenger_mobile")]
            [Validation(Required=false)]
            public string PassengerMobile { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>949c9f34f677a0e5d249dfc94f5e62cc7</para>
            /// </summary>
            [NameInMap("passenger_name")]
            [Validation(Required=false)]
            public string PassengerName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("force_match")]
        [Validation(Required=false)]
        public string ForceMatch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_pay_now")]
        [Validation(Required=false)]
        public bool? IsPayNow { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_open_info_s")]
        [Validation(Required=false)]
        public List<TrainOrderCreateRequestPassengerOpenInfoS> PassengerOpenInfoS { get; set; }
        public class TrainOrderCreateRequestPassengerOpenInfoS : TeaModel {
            [NameInMap("cost_center_info")]
            [Validation(Required=false)]
            public TrainOrderCreateRequestPassengerOpenInfoSCostCenterInfo CostCenterInfo { get; set; }
            public class TrainOrderCreateRequestPassengerOpenInfoSCostCenterInfo : TeaModel {
                [NameInMap("cascade_dept_name")]
                [Validation(Required=false)]
                public string CascadeDeptName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123321</para>
                /// </summary>
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public string CostCenterId { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12332112344</para>
                /// </summary>
                [NameInMap("cost_center_no")]
                [Validation(Required=false)]
                public string CostCenterNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>010000009</para>
                /// </summary>
                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                [NameInMap("depart_name")]
                [Validation(Required=false)]
                public string DepartName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111111</para>
                /// </summary>
                [NameInMap("invoice_id")]
                [Validation(Required=false)]
                public string InvoiceId { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>291487e553c5abde3b611aae283e2526f0d733ab55094aadc0b5ba587222a233c</para>
            /// </summary>
            [NameInMap("country_code")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>291487e553c5abde3b611aae283e2526f0d733ab55094aadc0b5ba587222a233c</para>
            /// </summary>
            [NameInMap("passenger_cert_no")]
            [Validation(Required=false)]
            public string PassengerCertNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>949c9f34f677a0e5d249dfc94f5e62cc7</para>
            /// </summary>
            [NameInMap("passenger_cert_type")]
            [Validation(Required=false)]
            public string PassengerCertType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public string PassengerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b6a6fc1bdf1ba60e25c2e132b612c8819</para>
            /// </summary>
            [NameInMap("passenger_mobile")]
            [Validation(Required=false)]
            public string PassengerMobile { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>949c9f34f677a0e5d249dfc94f5e62cc7</para>
            /// </summary>
            [NameInMap("passenger_name")]
            [Validation(Required=false)]
            public string PassengerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>291487e553c5abde3b611aae283e2526f0d733ab55094aadc0b5ba587222a233c</para>
            /// </summary>
            [NameInMap("valid_date_end")]
            [Validation(Required=false)]
            public string ValidDateEnd { get; set; }

        }

    }

}
