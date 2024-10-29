// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeApplyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("change_passenger_list")]
        [Validation(Required=false)]
        public List<ChangeApplyRequestChangePassengerList> ChangePassengerList { get; set; }
        public class ChangeApplyRequestChangePassengerList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>411***********4411</para>
            /// </summary>
            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAN</para>
            /// </summary>
            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANG</para>
            /// </summary>
            [NameInMap("last_name")]
            [Validation(Required=false)]
            public string LastName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("changed_journeys")]
        [Validation(Required=false)]
        public List<ChangeApplyRequestChangedJourneys> ChangedJourneys { get; set; }
        public class ChangeApplyRequestChangedJourneys : TeaModel {
            [NameInMap("segment_list")]
            [Validation(Required=false)]
            public List<ChangeApplyRequestChangedJourneysSegmentList> SegmentList { get; set; }
            public class ChangeApplyRequestChangedJourneysSegmentList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("arrival_airport")]
                [Validation(Required=false)]
                public string ArrivalAirport { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("arrival_city")]
                [Validation(Required=false)]
                public string ArrivalCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>T1</para>
                /// </summary>
                [NameInMap("arrive_terminal")]
                [Validation(Required=false)]
                public string ArriveTerminal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1677232999000</para>
                /// </summary>
                [NameInMap("arrive_time")]
                [Validation(Required=false)]
                public long? ArriveTime { get; set; }

                [NameInMap("arrive_time_str")]
                [Validation(Required=false)]
                public string ArriveTimeStr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("code_share")]
                [Validation(Required=false)]
                public bool? CodeShare { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PVG</para>
                /// </summary>
                [NameInMap("departure_airport")]
                [Validation(Required=false)]
                public string DepartureAirport { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("departure_city")]
                [Validation(Required=false)]
                public string DepartureCity { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20230320</para>
                /// </summary>
                [NameInMap("departure_date")]
                [Validation(Required=false)]
                public string DepartureDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>T2</para>
                /// </summary>
                [NameInMap("departure_terminal")]
                [Validation(Required=false)]
                public string DepartureTerminal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1677232998000</para>
                /// </summary>
                [NameInMap("departure_time")]
                [Validation(Required=false)]
                public long? DepartureTime { get; set; }

                [NameInMap("departure_time_str")]
                [Validation(Required=false)]
                public string DepartureTimeStr { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO1295</para>
                /// </summary>
                [NameInMap("marketing_flight_no")]
                [Validation(Required=false)]
                public string MarketingFlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HO1295</para>
                /// </summary>
                [NameInMap("operating_flight_no")]
                [Validation(Required=false)]
                public string OperatingFlightNo { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public ChangeApplyRequestContact Contact { get; set; }
        public class ChangeApplyRequestContact : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>gao******@gmail.com</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("mobile_country_code")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>183*****92</para>
            /// </summary>
            [NameInMap("mobile_phone_num")]
            [Validation(Required=false)]
            public string MobilePhoneNum { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4988430***950</para>
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>remark desc</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
