// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainTicketScanQueryResponseBody : TeaModel {
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
                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

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

                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("oss_url")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                [NameInMap("passenger")]
                [Validation(Required=false)]
                public string Passenger { get; set; }

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

                [NameInMap("serial_number")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("tax_amount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// 取票号
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// 车次
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

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
