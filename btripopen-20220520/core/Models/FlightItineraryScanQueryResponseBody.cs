// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightItineraryScanQueryResponseBody : TeaModel {
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
                /// 销售单位代号
                /// </summary>
                [NameInMap("agent_code")]
                [Validation(Required=false)]
                public string AgentCode { get; set; }

                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("bill_date")]
                [Validation(Required=false)]
                public string BillDate { get; set; }

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
                /// 机票行程明细
                /// </summary>
                [NameInMap("flights")]
                [Validation(Required=false)]
                public List<FlightItineraryScanQueryResponseBodyModuleItemsFlights> Flights { get; set; }
                public class FlightItineraryScanQueryResponseBodyModuleItemsFlights : TeaModel {
                    /// <summary>
                    /// 航班至
                    /// </summary>
                    [NameInMap("arrival_station")]
                    [Validation(Required=false)]
                    public string ArrivalStation { get; set; }

                    /// <summary>
                    /// 座位等级
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// 承运人
                    /// </summary>
                    [NameInMap("carrier")]
                    [Validation(Required=false)]
                    public string Carrier { get; set; }

                    /// <summary>
                    /// 航班从
                    /// </summary>
                    [NameInMap("departure_station")]
                    [Validation(Required=false)]
                    public string DepartureStation { get; set; }

                    /// <summary>
                    /// 日期
                    /// </summary>
                    [NameInMap("flight_date")]
                    [Validation(Required=false)]
                    public string FlightDate { get; set; }

                    /// <summary>
                    /// 航班号
                    /// </summary>
                    [NameInMap("flight_number")]
                    [Validation(Required=false)]
                    public string FlightNumber { get; set; }

                    /// <summary>
                    /// 时间
                    /// </summary>
                    [NameInMap("flight_time")]
                    [Validation(Required=false)]
                    public string FlightTime { get; set; }

                    /// <summary>
                    /// 免费行李
                    /// </summary>
                    [NameInMap("free_baggage_allowance")]
                    [Validation(Required=false)]
                    public string FreeBaggageAllowance { get; set; }

                    /// <summary>
                    /// 行号
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// 客票级别
                    /// </summary>
                    [NameInMap("seat_class")]
                    [Validation(Required=false)]
                    public string SeatClass { get; set; }

                    /// <summary>
                    /// 客票生效日期
                    /// </summary>
                    [NameInMap("valid_from_date")]
                    [Validation(Required=false)]
                    public string ValidFromDate { get; set; }

                    /// <summary>
                    /// 有效截止日期
                    /// </summary>
                    [NameInMap("valid_to_date")]
                    [Validation(Required=false)]
                    public string ValidToDate { get; set; }

                }

                [NameInMap("fuel_surcharge")]
                [Validation(Required=false)]
                public string FuelSurcharge { get; set; }

                /// <summary>
                /// UK
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("insurance")]
                [Validation(Required=false)]
                public string Insurance { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// 填开单位
                /// </summary>
                [NameInMap("issue_company")]
                [Validation(Required=false)]
                public string IssueCompany { get; set; }

                /// <summary>
                /// 填开日期
                /// </summary>
                [NameInMap("issue_date")]
                [Validation(Required=false)]
                public string IssueDate { get; set; }

                [NameInMap("itinerary_num")]
                [Validation(Required=false)]
                public string ItineraryNum { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

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
                /// 提示信息
                /// </summary>
                [NameInMap("prompt_message")]
                [Validation(Required=false)]
                public string PromptMessage { get; set; }

                [NameInMap("tax_amount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public string TicketPrice { get; set; }

                [NameInMap("total_price")]
                [Validation(Required=false)]
                public string TotalPrice { get; set; }

                /// <summary>
                /// 验证码
                /// </summary>
                [NameInMap("validation_code")]
                [Validation(Required=false)]
                public string ValidationCode { get; set; }

            }

            [NameInMap("page_no")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total_page")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            [NameInMap("total_size")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
