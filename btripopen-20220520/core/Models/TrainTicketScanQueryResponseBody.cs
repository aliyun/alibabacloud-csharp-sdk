// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainTicketScanQueryResponseBody : TeaModel {
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
        public TrainTicketScanQueryResponseBodyModule Module { get; set; }
        public class TrainTicketScanQueryResponseBodyModule : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<TrainTicketScanQueryResponseBodyModuleItems> Items { get; set; }
            public class TrainTicketScanQueryResponseBodyModuleItems : TeaModel {
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-12-01</para>
                /// </summary>
                [NameInMap("bill_date")]
                [Validation(Required=false)]
                public string BillDate { get; set; }

                [NameInMap("coach_name")]
                [Validation(Required=false)]
                public string CoachName { get; set; }

                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("dep_station")]
                [Validation(Required=false)]
                public string DepStation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-12 10:00:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>71</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3137168772101111000</para>
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

                [NameInMap("passenger")]
                [Validation(Required=false)]
                public string Passenger { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("seat")]
                [Validation(Required=false)]
                public string Seat { get; set; }

                [NameInMap("seat_no")]
                [Validation(Required=false)]
                public string SeatNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30671211200127U123456</para>
                /// </summary>
                [NameInMap("serial_number")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8.26</para>
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
                /// <para>取票号</para>
                /// 
                /// <b>Example:</b>
                /// <para>784-1111111111</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>车次</para>
                /// 
                /// <b>Example:</b>
                /// <para>G99</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

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
