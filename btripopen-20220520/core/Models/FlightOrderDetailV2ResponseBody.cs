// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderDetailV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightOrderDetailV2ResponseBodyModule Module { get; set; }
        public class FlightOrderDetailV2ResponseBodyModule : TeaModel {
            [NameInMap("b2g_vip_code")]
            [Validation(Required=false)]
            public string B2gVipCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-29 15:28:44</para>
            /// </summary>
            [NameInMap("book_succ_time")]
            [Validation(Required=false)]
            public string BookSuccTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qingg1234</para>
            /// </summary>
            [NameInMap("book_user_id")]
            [Validation(Required=false)]
            public string BookUserId { get; set; }

            [NameInMap("book_user_name")]
            [Validation(Required=false)]
            public string BookUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("build_price")]
            [Validation(Required=false)]
            public long? BuildPrice { get; set; }

            [NameInMap("contact_info_d_t_o")]
            [Validation(Required=false)]
            public FlightOrderDetailV2ResponseBodyModuleContactInfoDTO ContactInfoDTO { get; set; }
            public class FlightOrderDetailV2ResponseBodyModuleContactInfoDTO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:178169630111@163.com">178169630111@163.com</a></para>
                /// </summary>
                [NameInMap("contact_email")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>178169630111</para>
                /// </summary>
                [NameInMap("contact_phone")]
                [Validation(Required=false)]
                public string ContactPhone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("send_msg_to_passenger")]
                [Validation(Required=false)]
                public bool? SendMsgToPassenger { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-29 15:03:11</para>
            /// </summary>
            [NameInMap("create_time")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>126000</para>
            /// </summary>
            [NameInMap("facevalue")]
            [Validation(Required=false)]
            public long? Facevalue { get; set; }

            [NameInMap("flight_tale_info_d_t_o")]
            [Validation(Required=false)]
            public FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTO FlightTaleInfoDTO { get; set; }
            public class FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTO : TeaModel {
                [NameInMap("journeys")]
                [Validation(Required=false)]
                public List<FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneys> Journeys { get; set; }
                public class FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneys : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>85</para>
                    /// </summary>
                    [NameInMap("all_fly_duration")]
                    [Validation(Required=false)]
                    public long? AllFlyDuration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>85</para>
                    /// </summary>
                    [NameInMap("all_fly_duration_after_change")]
                    [Validation(Required=false)]
                    public long? AllFlyDurationAfterChange { get; set; }

                    [NameInMap("apply_id")]
                    [Validation(Required=false)]
                    public long? ApplyId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XIL</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    [NameInMap("arr_city_name")]
                    [Validation(Required=false)]
                    public string ArrCityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-07-20 08:25:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("baggage_details")]
                    [Validation(Required=false)]
                    public string BaggageDetails { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    [NameInMap("dep_city_name")]
                    [Validation(Required=false)]
                    public string DepCityName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-07-20 07:00:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("flight_status")]
                    [Validation(Required=false)]
                    public string FlightStatus { get; set; }

                    /// <summary>
                    /// <para>iata_no</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>iata_no</para>
                    /// </summary>
                    [NameInMap("iata_no")]
                    [Validation(Required=false)]
                    public string IataNo { get; set; }

                    [NameInMap("is_reshop_journey")]
                    [Validation(Required=false)]
                    public bool? IsReshopJourney { get; set; }

                    [NameInMap("is_transfer")]
                    [Validation(Required=false)]
                    public bool? IsTransfer { get; set; }

                    [NameInMap("journey_title")]
                    [Validation(Required=false)]
                    public string JourneyTitle { get; set; }

                    [NameInMap("refund_change_details")]
                    [Validation(Required=false)]
                    public string RefundChangeDetails { get; set; }

                    [NameInMap("segment_list")]
                    [Validation(Required=false)]
                    public List<FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentList> SegmentList { get; set; }
                    public class FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CA</para>
                        /// </summary>
                        [NameInMap("air_line_code")]
                        [Validation(Required=false)]
                        public string AirLineCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Air China Limited</para>
                        /// </summary>
                        [NameInMap("air_line_english_name")]
                        [Validation(Required=false)]
                        public string AirLineEnglishName { get; set; }

                        [NameInMap("air_line_name")]
                        [Validation(Required=false)]
                        public string AirLineName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>95583</para>
                        /// </summary>
                        [NameInMap("air_line_phone")]
                        [Validation(Required=false)]
                        public string AirLinePhone { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para><a href="https://gw.alicdn.com/tfs/TB12fJAFHr1gK0jSZR0XXbP8XXa-450-450.png">https://gw.alicdn.com/tfs/TB12fJAFHr1gK0jSZR0XXbP8XXa-450-450.png</a></para>
                        /// </summary>
                        [NameInMap("airline_icon_url")]
                        [Validation(Required=false)]
                        public string AirlineIconUrl { get; set; }

                        [NameInMap("airline_short_name")]
                        [Validation(Required=false)]
                        public string AirlineShortName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>XIL</para>
                        /// </summary>
                        [NameInMap("arr_airport_code")]
                        [Validation(Required=false)]
                        public string ArrAirportCode { get; set; }

                        [NameInMap("arr_airport_name")]
                        [Validation(Required=false)]
                        public string ArrAirportName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>XIL</para>
                        /// </summary>
                        [NameInMap("arr_city_code")]
                        [Validation(Required=false)]
                        public string ArrCityCode { get; set; }

                        [NameInMap("arr_city_name")]
                        [Validation(Required=false)]
                        public string ArrCityName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-07-20 08:25:00</para>
                        /// </summary>
                        [NameInMap("arr_time")]
                        [Validation(Required=false)]
                        public string ArrTime { get; set; }

                        [NameInMap("arrive_terminal")]
                        [Validation(Required=false)]
                        public string ArriveTerminal { get; set; }

                        /// <summary>
                        /// <para>cabin</para>
                        /// </summary>
                        [NameInMap("cabin")]
                        [Validation(Required=false)]
                        public string Cabin { get; set; }

                        [NameInMap("cabin_and_discount")]
                        [Validation(Required=false)]
                        public string CabinAndDiscount { get; set; }

                        /// <summary>
                        /// <para>cabin_class</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Y</para>
                        /// </summary>
                        [NameInMap("cabin_class")]
                        [Validation(Required=false)]
                        public string CabinClass { get; set; }

                        /// <summary>
                        /// <para>cabin_class_name</para>
                        /// </summary>
                        [NameInMap("cabin_class_name")]
                        [Validation(Required=false)]
                        public string CabinClassName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("code_share")]
                        [Validation(Required=false)]
                        public bool? CodeShare { get; set; }

                        [NameInMap("deadline_text")]
                        [Validation(Required=false)]
                        public string DeadlineText { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>PEK</para>
                        /// </summary>
                        [NameInMap("dep_airport_code")]
                        [Validation(Required=false)]
                        public string DepAirportCode { get; set; }

                        [NameInMap("dep_airport_name")]
                        [Validation(Required=false)]
                        public string DepAirportName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>BJS</para>
                        /// </summary>
                        [NameInMap("dep_city_code")]
                        [Validation(Required=false)]
                        public string DepCityCode { get; set; }

                        [NameInMap("dep_city_name")]
                        [Validation(Required=false)]
                        public string DepCityName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-07-29</para>
                        /// </summary>
                        [NameInMap("dep_date")]
                        [Validation(Required=false)]
                        public string DepDate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-07-20 07:00:00</para>
                        /// </summary>
                        [NameInMap("dep_time")]
                        [Validation(Required=false)]
                        public string DepTime { get; set; }

                        [NameInMap("depart_terminal")]
                        [Validation(Required=false)]
                        public string DepartTerminal { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.4</para>
                        /// </summary>
                        [NameInMap("discount")]
                        [Validation(Required=false)]
                        public double? Discount { get; set; }

                        [NameInMap("flight_change")]
                        [Validation(Required=false)]
                        public FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentListFlightChange FlightChange { get; set; }
                        public class FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentListFlightChange : TeaModel {
                            [NameInMap("change_desc")]
                            [Validation(Required=false)]
                            public string ChangeDesc { get; set; }

                            [NameInMap("change_status")]
                            [Validation(Required=false)]
                            public string ChangeStatus { get; set; }

                            [NameInMap("change_status_code")]
                            [Validation(Required=false)]
                            public string ChangeStatusCode { get; set; }

                            [NameInMap("new_segment")]
                            [Validation(Required=false)]
                            public object NewSegment { get; set; }

                            [NameInMap("passenger_names")]
                            [Validation(Required=false)]
                            public List<string> PassengerNames { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CA1110</para>
                        /// </summary>
                        [NameInMap("flight_no")]
                        [Validation(Required=false)]
                        public string FlightNo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ARJ</para>
                        /// </summary>
                        [NameInMap("flight_type")]
                        [Validation(Required=false)]
                        public string FlightType { get; set; }

                        [NameInMap("fly_duration")]
                        [Validation(Required=false)]
                        public int? FlyDuration { get; set; }

                        [NameInMap("manufacturer")]
                        [Validation(Required=false)]
                        public string Manufacturer { get; set; }

                        [NameInMap("meal_desc")]
                        [Validation(Required=false)]
                        public string MealDesc { get; set; }

                        [NameInMap("on_time_rate")]
                        [Validation(Required=false)]
                        public string OnTimeRate { get; set; }

                        [NameInMap("operating_air_short_name")]
                        [Validation(Required=false)]
                        public string OperatingAirShortName { get; set; }

                        [NameInMap("operating_airline_code")]
                        [Validation(Required=false)]
                        public string OperatingAirlineCode { get; set; }

                        [NameInMap("operating_airline_english_name")]
                        [Validation(Required=false)]
                        public string OperatingAirlineEnglishName { get; set; }

                        [NameInMap("operating_airline_icon_url")]
                        [Validation(Required=false)]
                        public string OperatingAirlineIconUrl { get; set; }

                        [NameInMap("operating_airline_name")]
                        [Validation(Required=false)]
                        public string OperatingAirlineName { get; set; }

                        [NameInMap("operating_airline_phone")]
                        [Validation(Required=false)]
                        public string OperatingAirlinePhone { get; set; }

                        [NameInMap("operating_flight_no")]
                        [Validation(Required=false)]
                        public string OperatingFlightNo { get; set; }

                        [NameInMap("plane_type")]
                        [Validation(Required=false)]
                        public string PlaneType { get; set; }

                        [NameInMap("raise_price")]
                        [Validation(Required=false)]
                        public long? RaisePrice { get; set; }

                        [NameInMap("segment_id")]
                        [Validation(Required=false)]
                        public string SegmentId { get; set; }

                        /// <summary>
                        /// <para>segmentIndex</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                        [NameInMap("segment_position")]
                        [Validation(Required=false)]
                        public FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentListSegmentPosition SegmentPosition { get; set; }
                        public class FlightOrderDetailV2ResponseBodyModuleFlightTaleInfoDTOJourneysSegmentListSegmentPosition : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("journey_index")]
                            [Validation(Required=false)]
                            public int? JourneyIndex { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("segment_index")]
                            [Validation(Required=false)]
                            public int? SegmentIndex { get; set; }

                        }

                        [NameInMap("stop_airport")]
                        [Validation(Required=false)]
                        public string StopAirport { get; set; }

                        [NameInMap("stop_arr_time")]
                        [Validation(Required=false)]
                        public string StopArrTime { get; set; }

                        [NameInMap("stop_city")]
                        [Validation(Required=false)]
                        public string StopCity { get; set; }

                        [NameInMap("stop_city_name")]
                        [Validation(Required=false)]
                        public string StopCityName { get; set; }

                        [NameInMap("stop_dep_time")]
                        [Validation(Required=false)]
                        public string StopDepTime { get; set; }

                        [NameInMap("stop_quantity")]
                        [Validation(Required=false)]
                        public int? StopQuantity { get; set; }

                    }

                }

                [NameInMap("notice_tips")]
                [Validation(Required=false)]
                public string NoticeTips { get; set; }

                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public string TripType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("trip_type_code")]
                [Validation(Required=false)]
                public int? TripTypeCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("is_protocol")]
            [Validation(Required=false)]
            public bool? IsProtocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isemergency")]
            [Validation(Required=false)]
            public bool? Isemergency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("issendmessage")]
            [Validation(Required=false)]
            public bool? Issendmessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4000</para>
            /// </summary>
            [NameInMap("oil_price")]
            [Validation(Required=false)]
            public long? OilPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1017002195370467200</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8500</para>
            /// </summary>
            [NameInMap("order_price")]
            [Validation(Required=false)]
            public long? OrderPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1017002195370467137</para>
            /// </summary>
            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            [NameInMap("passenger_list")]
            [Validation(Required=false)]
            public List<FlightOrderDetailV2ResponseBodyModulePassengerList> PassengerList { get; set; }
            public class FlightOrderDetailV2ResponseBodyModulePassengerList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1991-06-21 00:00:00</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12172819047252004460056</para>
                /// </summary>
                [NameInMap("btrip_user_id")]
                [Validation(Required=false)]
                public string BtripUserId { get; set; }

                [NameInMap("code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                [NameInMap("country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("country_code")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("credential")]
                [Validation(Required=false)]
                public FlightOrderDetailV2ResponseBodyModulePassengerListCredential Credential { get; set; }
                public class FlightOrderDetailV2ResponseBodyModulePassengerListCredential : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1991-06-21 00:00:00</para>
                    /// </summary>
                    [NameInMap("birth_date")]
                    [Validation(Required=false)]
                    public string BirthDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1991-06-21 00:00:00</para>
                    /// </summary>
                    [NameInMap("cert_issue_date")]
                    [Validation(Required=false)]
                    public string CertIssueDate { get; set; }

                    [NameInMap("cert_issue_place")]
                    [Validation(Required=false)]
                    public string CertIssuePlace { get; set; }

                    [NameInMap("credential_no")]
                    [Validation(Required=false)]
                    public string CredentialNo { get; set; }

                    [NameInMap("drive_licence_first")]
                    [Validation(Required=false)]
                    public string DriveLicenceFirst { get; set; }

                    [NameInMap("drive_licence_type")]
                    [Validation(Required=false)]
                    public string DriveLicenceType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1991-06-21 00:00:00</para>
                    /// </summary>
                    [NameInMap("expire_date")]
                    [Validation(Required=false)]
                    public string ExpireDate { get; set; }

                    [NameInMap("holder_nationality")]
                    [Validation(Required=false)]
                    public string HolderNationality { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>131332</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("id_check_code")]
                    [Validation(Required=false)]
                    public string IdCheckCode { get; set; }

                    [NameInMap("issue_country")]
                    [Validation(Required=false)]
                    public string IssueCountry { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                [NameInMap("credentials")]
                [Validation(Required=false)]
                public List<FlightOrderDetailV2ResponseBodyModulePassengerListCredentials> Credentials { get; set; }
                public class FlightOrderDetailV2ResponseBodyModulePassengerListCredentials : TeaModel {
                    [NameInMap("birth_date")]
                    [Validation(Required=false)]
                    public string BirthDate { get; set; }

                    [NameInMap("cert_issue_date")]
                    [Validation(Required=false)]
                    public string CertIssueDate { get; set; }

                    [NameInMap("cert_issue_place")]
                    [Validation(Required=false)]
                    public string CertIssuePlace { get; set; }

                    [NameInMap("credential_no")]
                    [Validation(Required=false)]
                    public string CredentialNo { get; set; }

                    [NameInMap("drive_licence_first")]
                    [Validation(Required=false)]
                    public string DriveLicenceFirst { get; set; }

                    [NameInMap("drive_licence_type")]
                    [Validation(Required=false)]
                    public string DriveLicenceType { get; set; }

                    [NameInMap("expire_date")]
                    [Validation(Required=false)]
                    public string ExpireDate { get; set; }

                    [NameInMap("holder_nationality")]
                    [Validation(Required=false)]
                    public string HolderNationality { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>131332</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("id_check_code")]
                    [Validation(Required=false)]
                    public string IdCheckCode { get; set; }

                    [NameInMap("issue_country")]
                    [Validation(Required=false)]
                    public string IssueCountry { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:17800000001@163.com">17800000001@163.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>san</para>
                /// </summary>
                [NameInMap("en_first_name")]
                [Validation(Required=false)]
                public string EnFirstName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zhang</para>
                /// </summary>
                [NameInMap("en_last_name")]
                [Validation(Required=false)]
                public string EnLastName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("english_name")]
                [Validation(Required=false)]
                public string EnglishName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gender")]
                [Validation(Required=false)]
                public int? Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3243028</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_complete")]
                [Validation(Required=false)]
                public bool? IsComplete { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("is_frequently")]
                [Validation(Required=false)]
                public bool? IsFrequently { get; set; }

                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>86</para>
                /// </summary>
                [NameInMap("mobile_country_code")]
                [Validation(Required=false)]
                public string MobileCountryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>17800000001</para>
                /// </summary>
                [NameInMap("mobile_phone_number")]
                [Validation(Required=false)]
                public string MobilePhoneNumber { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("oneself")]
                [Validation(Required=false)]
                public bool? Oneself { get; set; }

                [NameInMap("order_name")]
                [Validation(Required=false)]
                public string OrderName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("out_passenger_id")]
                [Validation(Required=false)]
                public string OutPassengerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>17800000001</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("sheng_pi_pinyin")]
                [Validation(Required=false)]
                public string ShengPiPinyin { get; set; }

                [NameInMap("ticket_nos")]
                [Validation(Required=false)]
                public List<string> TicketNos { get; set; }

                [NameInMap("tickets")]
                [Validation(Required=false)]
                public List<FlightOrderDetailV2ResponseBodyModulePassengerListTickets> Tickets { get; set; }
                public class FlightOrderDetailV2ResponseBodyModulePassengerListTickets : TeaModel {
                    [NameInMap("channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    [NameInMap("journey_title")]
                    [Validation(Required=false)]
                    public string JourneyTitle { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OPEN_FOR_USE</para>
                    /// </summary>
                    [NameInMap("open_ticket_status")]
                    [Validation(Required=false)]
                    public string OpenTicketStatus { get; set; }

                    /// <summary>
                    /// <para>pcc/office</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pcc/office</para>
                    /// </summary>
                    [NameInMap("pcc")]
                    [Validation(Required=false)]
                    public string Pcc { get; set; }

                    [NameInMap("segment_open_ticket_list")]
                    [Validation(Required=false)]
                    public List<FlightOrderDetailV2ResponseBodyModulePassengerListTicketsSegmentOpenTicketList> SegmentOpenTicketList { get; set; }
                    public class FlightOrderDetailV2ResponseBodyModulePassengerListTicketsSegmentOpenTicketList : TeaModel {
                        [NameInMap("journey_index")]
                        [Validation(Required=false)]
                        public int? JourneyIndex { get; set; }

                        [NameInMap("open_ticket_status")]
                        [Validation(Required=false)]
                        public int? OpenTicketStatus { get; set; }

                        [NameInMap("segment_index")]
                        [Validation(Required=false)]
                        public int? SegmentIndex { get; set; }

                    }

                    [NameInMap("ticket_auth_memo")]
                    [Validation(Required=false)]
                    public string TicketAuthMemo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("ticket_auth_status")]
                    [Validation(Required=false)]
                    public int? TicketAuthStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>444-2023062999</para>
                    /// </summary>
                    [NameInMap("ticket_no")]
                    [Validation(Required=false)]
                    public string TicketNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4500</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                    [NameInMap("ticket_status")]
                    [Validation(Required=false)]
                    public string TicketStatus { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>312312</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>key :passengerId</para>
            /// <para>value :segmentId</para>
            /// </summary>
            [NameInMap("passenger_segment_map")]
            [Validation(Required=false)]
            public Dictionary<string, string> PassengerSegmentMap { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-29 15:03:59</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4500</para>
            /// </summary>
            [NameInMap("saleprice")]
            [Validation(Required=false)]
            public long? Saleprice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sendcpsms")]
            [Validation(Required=false)]
            public bool? Sendcpsms { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("total_service_fee_price")]
            [Validation(Required=false)]
            public long? TotalServiceFeePrice { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5F4ACF5-5677-1515-9999-ABBB5E668032</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc60a16917251281873772dac41</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
