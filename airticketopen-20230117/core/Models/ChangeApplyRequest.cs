// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeApplyRequest : TeaModel {
        /// <summary>
        /// <para>The list of passengers for the change.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("change_passenger_list")]
        [Validation(Required=false)]
        public List<ChangeApplyRequestChangePassengerList> ChangePassengerList { get; set; }
        public class ChangeApplyRequestChangePassengerList : TeaModel {
            /// <summary>
            /// <para>The document number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>411***********4411</para>
            /// </summary>
            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            /// <summary>
            /// <para>The first name of the passenger.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAN</para>
            /// </summary>
            [NameInMap("first_name")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// <para>The last name of the passenger.</para>
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
        /// <para>The target journey for the change.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("changed_journeys")]
        [Validation(Required=false)]
        public List<ChangeApplyRequestChangedJourneys> ChangedJourneys { get; set; }
        public class ChangeApplyRequestChangedJourneys : TeaModel {
            /// <summary>
            /// <para>The list of target segments for the change.</para>
            /// </summary>
            [NameInMap("segment_list")]
            [Validation(Required=false)]
            public List<ChangeApplyRequestChangedJourneysSegmentList> SegmentList { get; set; }
            public class ChangeApplyRequestChangedJourneysSegmentList : TeaModel {
                /// <summary>
                /// <para>The three-letter IATA code of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("arrival_airport")]
                [Validation(Required=false)]
                public string ArrivalAirport { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the arrival city.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MFM</para>
                /// </summary>
                [NameInMap("arrival_city")]
                [Validation(Required=false)]
                public string ArrivalCity { get; set; }

                /// <summary>
                /// <para>The arrival terminal of the flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T1</para>
                /// </summary>
                [NameInMap("arrive_terminal")]
                [Validation(Required=false)]
                public string ArriveTerminal { get; set; }

                /// <summary>
                /// <para>(该属性废弃)航班到达日期时间，utc时间戳</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677232999000</para>
                /// </summary>
                [NameInMap("arrive_time")]
                [Validation(Required=false)]
                public long? ArriveTime { get; set; }

                /// <summary>
                /// <para>(必填参数)航班到达日期时间，航班的旅行时间，格式：yyyy-MM-dd HH:mm:ss</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-20 12:30:00</para>
                /// </summary>
                [NameInMap("arrive_time_str")]
                [Validation(Required=false)]
                public string ArriveTimeStr { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight is a codeshare flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("code_share")]
                [Validation(Required=false)]
                public bool? CodeShare { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PVG</para>
                /// </summary>
                [NameInMap("departure_airport")]
                [Validation(Required=false)]
                public string DepartureAirport { get; set; }

                /// <summary>
                /// <para>The three-letter IATA code of the departure city.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHA</para>
                /// </summary>
                [NameInMap("departure_city")]
                [Validation(Required=false)]
                public string DepartureCity { get; set; }

                /// <summary>
                /// <para>The departure date (for example, yyyyMMdd).
                /// <a href="Deprecated">_single.params.changed_journeys.items.segment_list.items.departure_time.desc</a> The departure date and time of the flight, in UTC timestamp.
                /// <a href="Required">_single.params.changed_journeys.items.segment_list.items.departure_time_str.desc</a> The departure date and time of the flight, in local travel time. Format: yyyy-MM-dd HH:mm:ss.
                /// <a href="Deprecated">_single.params.changed_journeys.items.segment_list.items.arrive_time.desc</a> The arrival date and time of the flight, in UTC timestamp.
                /// <a href="Required">_single.params.changed_journeys.items.segment_list.items.arrive_time_str.desc</a> The arrival date and time of the flight, in local travel time. Format: yyyy-MM-dd HH:mm:ss.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20230320</para>
                /// </summary>
                [NameInMap("departure_date")]
                [Validation(Required=false)]
                public string DepartureDate { get; set; }

                /// <summary>
                /// <para>The departure terminal of the flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T2</para>
                /// </summary>
                [NameInMap("departure_terminal")]
                [Validation(Required=false)]
                public string DepartureTerminal { get; set; }

                /// <summary>
                /// <para>(该属性废弃)航班起飞日期，utc时间戳</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677232998000</para>
                /// </summary>
                [NameInMap("departure_time")]
                [Validation(Required=false)]
                public long? DepartureTime { get; set; }

                /// <summary>
                /// <para>(必填参数)航班起飞日期时间，航班的旅行时间，格式：yyyy-MM-dd HH:mm:ss</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-20 09:30:00</para>
                /// </summary>
                [NameInMap("departure_time_str")]
                [Validation(Required=false)]
                public string DepartureTimeStr { get; set; }

                /// <summary>
                /// <para>The marketing flight number (such as KA5809).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO1295</para>
                /// </summary>
                [NameInMap("marketing_flight_no")]
                [Validation(Required=false)]
                public string MarketingFlightNo { get; set; }

                /// <summary>
                /// <para>The operating flight number (such as CX601).</para>
                /// 
                /// <b>Example:</b>
                /// <para>HO1295</para>
                /// </summary>
                [NameInMap("operating_flight_no")]
                [Validation(Required=false)]
                public string OperatingFlightNo { get; set; }

            }

        }

        /// <summary>
        /// <para>The contact information for the change.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public ChangeApplyRequestContact Contact { get; set; }
        public class ChangeApplyRequestContact : TeaModel {
            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gao******@gmail.com</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The country calling code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("mobile_country_code")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>183*****92</para>
            /// </summary>
            [NameInMap("mobile_phone_num")]
            [Validation(Required=false)]
            public string MobilePhoneNum { get; set; }

        }

        /// <summary>
        /// <para>The order number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4988430***950</para>
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        /// <summary>
        /// <para>The buyer remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark desc</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The change type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: voluntary change</description></item>
        /// <item><description>1: flight schedule change or flight cancellation.</description></item>
        /// </list>
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
