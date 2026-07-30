// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightItineraryScanQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data returned by the server. An empty value is returned if no result is found or an exception occurs.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightItineraryScanQueryResponseBodyModule Module { get; set; }
        public class FlightItineraryScanQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The paginated results.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<FlightItineraryScanQueryResponseBodyModuleItems> Items { get; set; }
            public class FlightItineraryScanQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <para>The sales agent code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SIA25608336893</para>
                /// </summary>
                [NameInMap("agent_code")]
                [Validation(Required=false)]
                public string AgentCode { get; set; }

                /// <summary>
                /// <para>The approval number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BH-507119434047594496</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The billing date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-01</para>
                /// </summary>
                [NameInMap("bill_date")]
                [Validation(Required=false)]
                public string BillDate { get; set; }

                /// <summary>
                /// <para>The invoice color type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("blue_or_red")]
                [Validation(Required=false)]
                public int? BlueOrRed { get; set; }

                /// <summary>
                /// <para>The infrastructure fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("build")]
                [Validation(Required=false)]
                public string Build { get; set; }

                /// <summary>
                /// <para>The cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试成本中心</para>
                /// </summary>
                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <para>The department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试公司-测试部门</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <para>The flight itinerary details.</para>
                /// </summary>
                [NameInMap("flights")]
                [Validation(Required=false)]
                public List<FlightItineraryScanQueryResponseBodyModuleItemsFlights> Flights { get; set; }
                public class FlightItineraryScanQueryResponseBodyModuleItemsFlights : TeaModel {
                    /// <summary>
                    /// <para>The arrival station.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>西安咸阳</para>
                    /// </summary>
                    [NameInMap("arrival_station")]
                    [Validation(Required=false)]
                    public string ArrivalStation { get; set; }

                    /// <summary>
                    /// <para>The cabin class.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>M</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// <para>The carrier.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>东航</para>
                    /// </summary>
                    [NameInMap("carrier")]
                    [Validation(Required=false)]
                    public string Carrier { get; set; }

                    /// <summary>
                    /// <para>The departure station.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>长春</para>
                    /// </summary>
                    [NameInMap("departure_station")]
                    [Validation(Required=false)]
                    public string DepartureStation { get; set; }

                    /// <summary>
                    /// <para>The flight date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-11-18</para>
                    /// </summary>
                    [NameInMap("flight_date")]
                    [Validation(Required=false)]
                    public string FlightDate { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MU2271</para>
                    /// </summary>
                    [NameInMap("flight_number")]
                    [Validation(Required=false)]
                    public string FlightNumber { get; set; }

                    /// <summary>
                    /// <para>The flight time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18:25</para>
                    /// </summary>
                    [NameInMap("flight_time")]
                    [Validation(Required=false)]
                    public string FlightTime { get; set; }

                    /// <summary>
                    /// <para>The free baggage allowance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20K</para>
                    /// </summary>
                    [NameInMap("free_baggage_allowance")]
                    [Validation(Required=false)]
                    public string FreeBaggageAllowance { get; set; }

                    /// <summary>
                    /// <para>The row number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public string Index { get; set; }

                    /// <summary>
                    /// <para>The ticket class.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>M</para>
                    /// </summary>
                    [NameInMap("seat_class")]
                    [Validation(Required=false)]
                    public string SeatClass { get; set; }

                    /// <summary>
                    /// <para>The ticket validity start date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-01-01</para>
                    /// </summary>
                    [NameInMap("valid_from_date")]
                    [Validation(Required=false)]
                    public string ValidFromDate { get; set; }

                    /// <summary>
                    /// <para>The ticket validity end date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-01-01</para>
                    /// </summary>
                    [NameInMap("valid_to_date")]
                    [Validation(Required=false)]
                    public string ValidToDate { get; set; }

                }

                /// <summary>
                /// <para>The fuel surcharge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("fuel_surcharge")]
                [Validation(Required=false)]
                public string FuelSurcharge { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The insurance fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("insurance")]
                [Validation(Required=false)]
                public string Insurance { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试发票抬头</para>
                /// </summary>
                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <para>The receipt type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                /// <summary>
                /// <para>The issuing company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>有限公司</para>
                /// </summary>
                [NameInMap("issue_company")]
                [Validation(Required=false)]
                public string IssueCompany { get; set; }

                /// <summary>
                /// <para>The issue date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-28</para>
                /// </summary>
                [NameInMap("issue_date")]
                [Validation(Required=false)]
                public string IssueDate { get; set; }

                /// <summary>
                /// <para>The itinerary number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6666666666</para>
                /// </summary>
                [NameInMap("itinerary_num")]
                [Validation(Required=false)]
                public string ItineraryNum { get; set; }

                /// <summary>
                /// <para>The URL for obtaining the electronic itinerary receipt in OFD format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("ofd_oss_url")]
                [Validation(Required=false)]
                public string OfdOssUrl { get; set; }

                /// <summary>
                /// <para>The business travel order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4801105714092</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <para>The URL for obtaining the paper itinerary receipt in image format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("oss_url")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                /// <summary>
                /// <para>The other taxes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("other_taxes")]
                [Validation(Required=false)]
                public string OtherTaxes { get; set; }

                /// <summary>
                /// <para>The passenger name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("passenger_name")]
                [Validation(Required=false)]
                public string PassengerName { get; set; }

                /// <summary>
                /// <para>The URL for obtaining the electronic itinerary receipt in PDF format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("pdf_oss_url")]
                [Validation(Required=false)]
                public string PdfOssUrl { get; set; }

                /// <summary>
                /// <para>The project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试项目</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The prompt message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>西安始发国际在T3国内在13</para>
                /// </summary>
                [NameInMap("prompt_message")]
                [Validation(Required=false)]
                public string PromptMessage { get; set; }

                /// <summary>
                /// <para>The purchaser name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试购方名称</para>
                /// </summary>
                [NameInMap("purchaser_name")]
                [Validation(Required=false)]
                public string PurchaserName { get; set; }

                /// <summary>
                /// <para>The purchaser tax number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>91441111111111111S</para>
                /// </summary>
                [NameInMap("purchaser_tax_no")]
                [Validation(Required=false)]
                public string PurchaserTaxNo { get; set; }

                /// <summary>
                /// <para>The purchaser type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("purchaser_type")]
                [Validation(Required=false)]
                public int? PurchaserType { get; set; }

                /// <summary>
                /// <para>The tax amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>108.17</para>
                /// </summary>
                [NameInMap("tax_amount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                /// <summary>
                /// <para>The tax rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// <para>The ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>784-1111111111</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>The ticket price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1190</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public string TicketPrice { get; set; }

                /// <summary>
                /// <para>The total amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1360</para>
                /// </summary>
                [NameInMap("total_price")]
                [Validation(Required=false)]
                public string TotalPrice { get; set; }

                /// <summary>
                /// <para>The validation code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9817</para>
                /// </summary>
                [NameInMap("validation_code")]
                [Validation(Required=false)]
                public string ValidationCode { get; set; }

                /// <summary>
                /// <para>The URL for obtaining the electronic itinerary receipt in XML format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("xml_oss_url")]
                [Validation(Required=false)]
                public string XmlOssUrl { get; set; }

            }

            /// <summary>
            /// <para>The page number of the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_no")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The page size of the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("total_page")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
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
