// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeApplyRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("change_passenger_list")]
        [Validation(Required=false)]
        public List<ChangeApplyRequestChangePassengerList> ChangePassengerList { get; set; }
        public class ChangeApplyRequestChangePassengerList : TeaModel {
            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("changed_journeys")]
        [Validation(Required=false)]
        public List<ChangeApplyRequestChangedJourneys> ChangedJourneys { get; set; }
        public class ChangeApplyRequestChangedJourneys : TeaModel {
            [NameInMap("segment_list")]
            [Validation(Required=false)]
            public List<ChangeApplyRequestChangedJourneysSegmentList> SegmentList { get; set; }
            public class ChangeApplyRequestChangedJourneysSegmentList : TeaModel {
                [NameInMap("arrival_airport")]
                [Validation(Required=false)]
                public string ArrivalAirport { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("arrival_city")]
                [Validation(Required=false)]
                public string ArrivalCity { get; set; }

                [NameInMap("arrive_terminal")]
                [Validation(Required=false)]
                public string ArriveTerminal { get; set; }

                [NameInMap("arrive_time")]
                [Validation(Required=false)]
                public long? ArriveTime { get; set; }

                [NameInMap("code_share")]
                [Validation(Required=false)]
                public bool? CodeShare { get; set; }

                [NameInMap("departure_airport")]
                [Validation(Required=false)]
                public string DepartureAirport { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("departure_city")]
                [Validation(Required=false)]
                public string DepartureCity { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("departure_date")]
                [Validation(Required=false)]
                public string DepartureDate { get; set; }

                [NameInMap("departure_terminal")]
                [Validation(Required=false)]
                public string DepartureTerminal { get; set; }

                [NameInMap("departure_time")]
                [Validation(Required=false)]
                public long? DepartureTime { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("marketing_flight_no")]
                [Validation(Required=false)]
                public string MarketingFlightNo { get; set; }

                [NameInMap("operating_flight_no")]
                [Validation(Required=false)]
                public string OperatingFlightNo { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public ChangeApplyRequestContact Contact { get; set; }
        public class ChangeApplyRequestContact : TeaModel {
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("mobile_country_code")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            [NameInMap("mobile_phone_num")]
            [Validation(Required=false)]
            public string MobilePhoneNum { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
