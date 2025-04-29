// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightOrderQueryResponseBodyModule Module { get; set; }
        public class FlightOrderQueryResponseBodyModule : TeaModel {
            [NameInMap("flight_change_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightChangeTicketInfoList> FlightChangeTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightChangeTicketInfoList : TeaModel {
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("arr_airport")]
                [Validation(Required=false)]
                public string ArrAirport { get; set; }

                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>V</para>
                /// </summary>
                [NameInMap("change_cabin")]
                [Validation(Required=false)]
                public string ChangeCabin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("change_cabin_level")]
                [Validation(Required=false)]
                public string ChangeCabinLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("change_fee")]
                [Validation(Required=false)]
                public double? ChangeFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MU7767</para>
                /// </summary>
                [NameInMap("change_flight_no")]
                [Validation(Required=false)]
                public string ChangeFlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>33576</para>
                /// </summary>
                [NameInMap("change_order_id")]
                [Validation(Required=false)]
                public long? ChangeOrderId { get; set; }

                [NameInMap("change_reason")]
                [Validation(Required=false)]
                public string ChangeReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("change_type")]
                [Validation(Required=false)]
                public int? ChangeType { get; set; }

                [NameInMap("dep_airport")]
                [Validation(Required=false)]
                public string DepAirport { get; set; }

                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("discount")]
                [Validation(Required=false)]
                public string Discount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00-123123</para>
                /// </summary>
                [NameInMap("origin_ticket_no")]
                [Validation(Required=false)]
                public string OriginTicketNo { get; set; }

                [NameInMap("out_apply_id")]
                [Validation(Required=false)]
                public string OutApplyId { get; set; }

                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>000-123123</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public string TicketStatus { get; set; }

                [NameInMap("ticket_status_code")]
                [Validation(Required=false)]
                public int? TicketStatusCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("upgrade_fee")]
                [Validation(Required=false)]
                public double? UpgradeFee { get; set; }

            }

            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>MU</para>
                /// </summary>
                [NameInMap("airline_code")]
                [Validation(Required=false)]
                public string AirlineCode { get; set; }

                [NameInMap("airline_name")]
                [Validation(Required=false)]
                public string AirlineName { get; set; }

                [NameInMap("arr_airport_city_county")]
                [Validation(Required=false)]
                public FlightOrderQueryResponseBodyModuleFlightInfoListArrAirportCityCounty ArrAirportCityCounty { get; set; }
                public class FlightOrderQueryResponseBodyModuleFlightInfoListArrAirportCityCounty : TeaModel {
                    [NameInMap("adcode")]
                    [Validation(Required=false)]
                    public string Adcode { get; set; }

                    [NameInMap("airport_city_code")]
                    [Validation(Required=false)]
                    public string AirportCityCode { get; set; }

                    [NameInMap("airport_city_name")]
                    [Validation(Required=false)]
                    public string AirportCityName { get; set; }

                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("airport_parent_city_name")]
                    [Validation(Required=false)]
                    public string AirportParentCityName { get; set; }

                    [NameInMap("county_city_adcode")]
                    [Validation(Required=false)]
                    public string CountyCityAdcode { get; set; }

                    [NameInMap("county_city_name")]
                    [Validation(Required=false)]
                    public string CountyCityName { get; set; }

                    [NameInMap("prefecture_city_adcode")]
                    [Validation(Required=false)]
                    public string PrefectureCityAdcode { get; set; }

                    [NameInMap("prefecture_city_name")]
                    [Validation(Required=false)]
                    public string PrefectureCityName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LHW</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_airport_name")]
                [Validation(Required=false)]
                public string ArrAirportName { get; set; }

                [NameInMap("arr_city_ad_code")]
                [Validation(Required=false)]
                public string ArrCityAdCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LHW</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                [NameInMap("arr_terminal")]
                [Validation(Required=false)]
                public string ArrTerminal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>V</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin_level")]
                [Validation(Required=false)]
                public string CabinLevel { get; set; }

                [NameInMap("dep_airport_city_county")]
                [Validation(Required=false)]
                public FlightOrderQueryResponseBodyModuleFlightInfoListDepAirportCityCounty DepAirportCityCounty { get; set; }
                public class FlightOrderQueryResponseBodyModuleFlightInfoListDepAirportCityCounty : TeaModel {
                    [NameInMap("adcode")]
                    [Validation(Required=false)]
                    public string Adcode { get; set; }

                    [NameInMap("airport_city_code")]
                    [Validation(Required=false)]
                    public string AirportCityCode { get; set; }

                    [NameInMap("airport_city_name")]
                    [Validation(Required=false)]
                    public string AirportCityName { get; set; }

                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("airport_parent_city_name")]
                    [Validation(Required=false)]
                    public string AirportParentCityName { get; set; }

                    [NameInMap("county_city_adcode")]
                    [Validation(Required=false)]
                    public string CountyCityAdcode { get; set; }

                    [NameInMap("county_city_name")]
                    [Validation(Required=false)]
                    public string CountyCityName { get; set; }

                    [NameInMap("prefecture_city_adcode")]
                    [Validation(Required=false)]
                    public string PrefectureCityAdcode { get; set; }

                    [NameInMap("prefecture_city_name")]
                    [Validation(Required=false)]
                    public string PrefectureCityName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NGB</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_airport_name")]
                [Validation(Required=false)]
                public string DepAirportName { get; set; }

                [NameInMap("dep_city_ad_code")]
                [Validation(Required=false)]
                public string DepCityAdCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NGB</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                [NameInMap("dep_terminal")]
                [Validation(Required=false)]
                public string DepTerminal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>900</para>
                /// </summary>
                [NameInMap("flight_mile")]
                [Validation(Required=false)]
                public int? FlightMile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MU3849</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public List<string> StopCity { get; set; }

                [NameInMap("stop_city_info_list")]
                [Validation(Required=false)]
                public List<FlightOrderQueryResponseBodyModuleFlightInfoListStopCityInfoList> StopCityInfoList { get; set; }
                public class FlightOrderQueryResponseBodyModuleFlightInfoListStopCityInfoList : TeaModel {
                    [NameInMap("stop_airport_city_county")]
                    [Validation(Required=false)]
                    public FlightOrderQueryResponseBodyModuleFlightInfoListStopCityInfoListStopAirportCityCounty StopAirportCityCounty { get; set; }
                    public class FlightOrderQueryResponseBodyModuleFlightInfoListStopCityInfoListStopAirportCityCounty : TeaModel {
                        [NameInMap("adcode")]
                        [Validation(Required=false)]
                        public string Adcode { get; set; }

                        [NameInMap("airport_city_code")]
                        [Validation(Required=false)]
                        public string AirportCityCode { get; set; }

                        [NameInMap("airport_city_name")]
                        [Validation(Required=false)]
                        public string AirportCityName { get; set; }

                        [NameInMap("airport_code")]
                        [Validation(Required=false)]
                        public string AirportCode { get; set; }

                        [NameInMap("airport_name")]
                        [Validation(Required=false)]
                        public string AirportName { get; set; }

                        [NameInMap("airport_parent_city_name")]
                        [Validation(Required=false)]
                        public string AirportParentCityName { get; set; }

                        [NameInMap("county_city_adcode")]
                        [Validation(Required=false)]
                        public string CountyCityAdcode { get; set; }

                        [NameInMap("county_city_name")]
                        [Validation(Required=false)]
                        public string CountyCityName { get; set; }

                        [NameInMap("prefecture_city_adcode")]
                        [Validation(Required=false)]
                        public string PrefectureCityAdcode { get; set; }

                        [NameInMap("prefecture_city_name")]
                        [Validation(Required=false)]
                        public string PrefectureCityName { get; set; }

                    }

                    [NameInMap("stop_airport_code")]
                    [Validation(Required=false)]
                    public string StopAirportCode { get; set; }

                }

            }

            [NameInMap("flight_refund_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightRefundTicketInfoList> FlightRefundTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightRefundTicketInfoList : TeaModel {
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("arr_airport")]
                [Validation(Required=false)]
                public string ArrAirport { get; set; }

                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("company_refund_ticket_fee")]
                [Validation(Required=false)]
                public double? CompanyRefundTicketFee { get; set; }

                [NameInMap("dep_airport")]
                [Validation(Required=false)]
                public string DepAirport { get; set; }

                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                [NameInMap("out_apply_id")]
                [Validation(Required=false)]
                public string OutApplyId { get; set; }

                [NameInMap("personal_refund_ticket_fee")]
                [Validation(Required=false)]
                public double? PersonalRefundTicketFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>43667</para>
                /// </summary>
                [NameInMap("refund_order_id")]
                [Validation(Required=false)]
                public long? RefundOrderId { get; set; }

                [NameInMap("refund_reason")]
                [Validation(Required=false)]
                public string RefundReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("refund_ticket_fee")]
                [Validation(Required=false)]
                public double? RefundTicketFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("refund_type")]
                [Validation(Required=false)]
                public int? RefundType { get; set; }

                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>000-13232</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            [NameInMap("flight_ticket_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleFlightTicketInfoList> FlightTicketInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleFlightTicketInfoList : TeaModel {
                [NameInMap("arr_airport")]
                [Validation(Required=false)]
                public string ArrAirport { get; set; }

                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("build_price")]
                [Validation(Required=false)]
                public double? BuildPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("changed")]
                [Validation(Required=false)]
                public bool? Changed { get; set; }

                [NameInMap("dep_airport")]
                [Validation(Required=false)]
                public string DepAirport { get; set; }

                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public int? Discount { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("journey_index")]
                [Validation(Required=false)]
                public int? JourneyIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public double? OilPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                [NameInMap("personal_price")]
                [Validation(Required=false)]
                public double? PersonalPrice { get; set; }

                [NameInMap("segment_index")]
                [Validation(Required=false)]
                public int? SegmentIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("settle_price")]
                [Validation(Required=false)]
                public double? SettlePrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>000-123</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public double? TicketPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OPEN</para>
                /// </summary>
                [NameInMap("ticket_status")]
                [Validation(Required=false)]
                public string TicketStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ticket_status_code")]
                [Validation(Required=false)]
                public int? TicketStatusCode { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("insurance_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModuleInsuranceInfoList> InsuranceInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModuleInsuranceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>345-987-098</para>
                /// </summary>
                [NameInMap("insurance_no")]
                [Validation(Required=false)]
                public string InsuranceNo { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("invoice_info")]
            [Validation(Required=false)]
            public FlightOrderQueryResponseBodyModuleInvoiceInfo InvoiceInfo { get; set; }
            public class FlightOrderQueryResponseBodyModuleInvoiceInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>43316</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("order_base_info")]
            [Validation(Required=false)]
            public FlightOrderQueryResponseBodyModuleOrderBaseInfo OrderBaseInfo { get; set; }
            public class FlightOrderQueryResponseBodyModuleOrderBaseInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>175634</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("btrip_title")]
                [Validation(Required=false)]
                public string BtripTitle { get; set; }

                [NameInMap("contact_name")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                [NameInMap("corp_id")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("corp_name")]
                [Validation(Required=false)]
                public string CorpName { get; set; }

                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                [NameInMap("depart_name")]
                [Validation(Required=false)]
                public string DepartName { get; set; }

                [NameInMap("exceed_apply_id")]
                [Validation(Required=false)]
                public string ExceedApplyId { get; set; }

                [NameInMap("exceed_third_part_apply_id")]
                [Validation(Required=false)]
                public string ExceedThirdPartApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_modify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13628</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>146178</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("supplier")]
                [Validation(Required=false)]
                public string Supplier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-FLIGHT</para>
                /// </summary>
                [NameInMap("thirdpart_apply_id")]
                [Validation(Required=false)]
                public string ThirdpartApplyId { get; set; }

                [NameInMap("thirdpart_business_id")]
                [Validation(Required=false)]
                public string ThirdpartBusinessId { get; set; }

                [NameInMap("thirdpart_corp_id")]
                [Validation(Required=false)]
                public string ThirdpartCorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-FLIGHT</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("passenger_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModulePassengerInfoList> PassengerInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModulePassengerInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>13446</para>
                /// </summary>
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-3345</para>
                /// </summary>
                [NameInMap("cost_center_number")]
                [Validation(Required=false)]
                public string CostCenterNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-PROJECT</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>133576</para>
                /// </summary>
                [NameInMap("project_id")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS-THIRDPROJECT</para>
                /// </summary>
                [NameInMap("thirdpart_project_id")]
                [Validation(Required=false)]
                public string ThirdpartProjectId { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("user_type")]
                [Validation(Required=false)]
                public int? UserType { get; set; }

            }

            [NameInMap("price_info_list")]
            [Validation(Required=false)]
            public List<FlightOrderQueryResponseBodyModulePriceInfoList> PriceInfoList { get; set; }
            public class FlightOrderQueryResponseBodyModulePriceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("category_code")]
                [Validation(Required=false)]
                public int? CategoryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-07-20T10:40Z</para>
                /// </summary>
                [NameInMap("gmt_create")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("pay_type")]
                [Validation(Required=false)]
                public int? PayType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public double? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CS73290</para>
                /// </summary>
                [NameInMap("trade_id")]
                [Validation(Required=false)]
                public string TradeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
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
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
