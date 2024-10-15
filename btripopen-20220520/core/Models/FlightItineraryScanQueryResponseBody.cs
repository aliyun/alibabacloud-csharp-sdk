// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightItineraryScanQueryResponseBody : TeaModel {
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

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightItineraryScanQueryResponseBodyModule Module { get; set; }
        public class FlightItineraryScanQueryResponseBodyModule : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<FlightItineraryScanQueryResponseBodyModuleItems> Items { get; set; }
            public class FlightItineraryScanQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <para>销售单位代号</para>
                /// 
                /// <b>Example:</b>
                /// <para>SIA25608336893</para>
                /// </summary>
                [NameInMap("agent_code")]
                [Validation(Required=false)]
                public string AgentCode { get; set; }

                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-12-01</para>
                /// </summary>
                [NameInMap("bill_date")]
                [Validation(Required=false)]
                public string BillDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("build")]
                [Validation(Required=false)]
                public string Build { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <para>机票行程明细</para>
                /// </summary>
                [NameInMap("flights")]
                [Validation(Required=false)]
                public List<FlightItineraryScanQueryResponseBodyModuleItemsFlights> Flights { get; set; }
                public class FlightItineraryScanQueryResponseBodyModuleItemsFlights : TeaModel {
                    /// <summary>
                    /// <para>航班至</para>
                    /// </summary>
                    [NameInMap("arrival_station")]
                    [Validation(Required=false)]
                    public string ArrivalStation { get; set; }

                    /// <summary>
                    /// <para>座位等级</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>M</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// <para>承运人</para>
                    /// </summary>
                    [NameInMap("carrier")]
                    [Validation(Required=false)]
                    public string Carrier { get; set; }

                    /// <summary>
                    /// <para>航班从</para>
                    /// </summary>
                    [NameInMap("departure_station")]
                    [Validation(Required=false)]
                    public string DepartureStation { get; set; }

                    /// <summary>
                    /// <para>日期</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-11-18</para>
                    /// </summary>
                    [NameInMap("flight_date")]
                    [Validation(Required=false)]
                    public string FlightDate { get; set; }

                    /// <summary>
                    /// <para>航班号</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU2271</para>
                    /// </summary>
                    [NameInMap("flight_number")]
                    [Validation(Required=false)]
                    public string FlightNumber { get; set; }

                    /// <summary>
                    /// <para>时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18:25</para>
                    /// </summary>
                    [NameInMap("flight_time")]
                    [Validation(Required=false)]
                    public string FlightTime { get; set; }

                    /// <summary>
                    /// <para>免费行李</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20K</para>
                    /// </summary>
                    [NameInMap("free_baggage_allowance")]
                    [Validation(Required=false)]
                    public string FreeBaggageAllowance { get; set; }

                    /// <summary>
                    /// <para>行号</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <para>客票级别</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>M</para>
                    /// </summary>
                    [NameInMap("seat_class")]
                    [Validation(Required=false)]
                    public string SeatClass { get; set; }

                    /// <summary>
                    /// <para>客票生效日期</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-01-01</para>
                    /// </summary>
                    [NameInMap("valid_from_date")]
                    [Validation(Required=false)]
                    public string ValidFromDate { get; set; }

                    /// <summary>
                    /// <para>有效截止日期</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-01-01</para>
                    /// </summary>
                    [NameInMap("valid_to_date")]
                    [Validation(Required=false)]
                    public string ValidToDate { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("fuel_surcharge")]
                [Validation(Required=false)]
                public string FuelSurcharge { get; set; }

                /// <summary>
                /// <para>UK</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("insurance")]
                [Validation(Required=false)]
                public string Insurance { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                /// <summary>
                /// <para>填开单位</para>
                /// </summary>
                [NameInMap("issue_company")]
                [Validation(Required=false)]
                public string IssueCompany { get; set; }

                /// <summary>
                /// <para>填开日期</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-28</para>
                /// </summary>
                [NameInMap("issue_date")]
                [Validation(Required=false)]
                public string IssueDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6666666666</para>
                /// </summary>
                [NameInMap("itinerary_num")]
                [Validation(Required=false)]
                public string ItineraryNum { get; set; }

                [NameInMap("ofd_oss_url")]
                [Validation(Required=false)]
                public string OfdOssUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4801105714092</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("oss_url")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>提示信息</para>
                /// </summary>
                [NameInMap("prompt_message")]
                [Validation(Required=false)]
                public string PromptMessage { get; set; }

                [NameInMap("purchaser_name")]
                [Validation(Required=false)]
                public string PurchaserName { get; set; }

                [NameInMap("purchaser_type")]
                [Validation(Required=false)]
                public int? PurchaserType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>108.17</para>
                /// </summary>
                [NameInMap("tax_amount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>784-1111111111</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1190</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public string TicketPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1360</para>
                /// </summary>
                [NameInMap("total_price")]
                [Validation(Required=false)]
                public string TotalPrice { get; set; }

                /// <summary>
                /// <para>验证码</para>
                /// 
                /// <b>Example:</b>
                /// <para>9817</para>
                /// </summary>
                [NameInMap("validation_code")]
                [Validation(Required=false)]
                public string ValidationCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_no")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("total_page")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("total_size")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
