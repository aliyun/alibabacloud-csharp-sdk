// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderCreateRequest : TeaModel {
        [NameInMap("accept_no_seat")]
        [Validation(Required=false)]
        public string AcceptNoSeat { get; set; }

        [NameInMap("book_train_infos")]
        [Validation(Required=false)]
        public List<TrainOrderCreateRequestBookTrainInfos> BookTrainInfos { get; set; }
        public class TrainOrderCreateRequestBookTrainInfos : TeaModel {
            [NameInMap("arr_station_code")]
            [Validation(Required=false)]
            public string ArrStationCode { get; set; }

            [NameInMap("book_ticket_infos")]
            [Validation(Required=false)]
            public List<TrainOrderCreateRequestBookTrainInfosBookTicketInfos> BookTicketInfos { get; set; }
            public class TrainOrderCreateRequestBookTrainInfosBookTicketInfos : TeaModel {
                [NameInMap("passenger_id")]
                [Validation(Required=false)]
                public string PassengerId { get; set; }

                [NameInMap("seat_type")]
                [Validation(Required=false)]
                public string SeatType { get; set; }

                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public long? TicketPrice { get; set; }

                [NameInMap("ticket_type")]
                [Validation(Required=false)]
                public string TicketType { get; set; }

            }

            [NameInMap("choose_beds")]
            [Validation(Required=false)]
            public string ChooseBeds { get; set; }

            [NameInMap("choose_seats")]
            [Validation(Required=false)]
            public string ChooseSeats { get; set; }

            [NameInMap("dep_station_code")]
            [Validation(Required=false)]
            public string DepStationCode { get; set; }

            [NameInMap("dep_time")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            [NameInMap("train_no")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

        }

        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("btrip_user_name")]
        [Validation(Required=false)]
        public string BtripUserName { get; set; }

        [NameInMap("business_info")]
        [Validation(Required=false)]
        public TrainOrderCreateRequestBusinessInfo BusinessInfo { get; set; }
        public class TrainOrderCreateRequestBusinessInfo : TeaModel {
            [NameInMap("customer_apply_id")]
            [Validation(Required=false)]
            public string CustomerApplyId { get; set; }

            [NameInMap("customer_itinerary_id")]
            [Validation(Required=false)]
            public string CustomerItineraryId { get; set; }

        }

        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public TrainOrderCreateRequestContactInfo ContactInfo { get; set; }
        public class TrainOrderCreateRequestContactInfo : TeaModel {
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public string PassengerId { get; set; }

            [NameInMap("passenger_mobile")]
            [Validation(Required=false)]
            public string PassengerMobile { get; set; }

            [NameInMap("passenger_name")]
            [Validation(Required=false)]
            public string PassengerName { get; set; }

        }

        [NameInMap("force_match")]
        [Validation(Required=false)]
        public string ForceMatch { get; set; }

        [NameInMap("is_pay_now")]
        [Validation(Required=false)]
        public bool? IsPayNow { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

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

                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public string CostCenterId { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("cost_center_no")]
                [Validation(Required=false)]
                public string CostCenterNo { get; set; }

                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                [NameInMap("depart_name")]
                [Validation(Required=false)]
                public string DepartName { get; set; }

                [NameInMap("invoice_id")]
                [Validation(Required=false)]
                public string InvoiceId { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_name")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            [NameInMap("country_code")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            [NameInMap("passenger_cert_no")]
            [Validation(Required=false)]
            public string PassengerCertNo { get; set; }

            [NameInMap("passenger_cert_type")]
            [Validation(Required=false)]
            public string PassengerCertType { get; set; }

            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public string PassengerId { get; set; }

            [NameInMap("passenger_mobile")]
            [Validation(Required=false)]
            public string PassengerMobile { get; set; }

            [NameInMap("passenger_name")]
            [Validation(Required=false)]
            public string PassengerName { get; set; }

            [NameInMap("valid_date_end")]
            [Validation(Required=false)]
            public string ValidDateEnd { get; set; }

        }

    }

}
