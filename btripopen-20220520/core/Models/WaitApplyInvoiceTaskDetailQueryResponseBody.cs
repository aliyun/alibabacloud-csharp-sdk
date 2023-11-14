// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class WaitApplyInvoiceTaskDetailQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<WaitApplyInvoiceTaskDetailQueryResponseBodyModule> Module { get; set; }
        public class WaitApplyInvoiceTaskDetailQueryResponseBodyModule : TeaModel {
            [NameInMap("contact")]
            [Validation(Required=false)]
            public string Contact { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("flight_invoice_fee")]
            [Validation(Required=false)]
            public string FlightInvoiceFee { get; set; }

            [NameInMap("fu_point_invoice_fee")]
            [Validation(Required=false)]
            public string FuPointInvoiceFee { get; set; }

            [NameInMap("hotel_normal_invoice_fee")]
            [Validation(Required=false)]
            public string HotelNormalInvoiceFee { get; set; }

            [NameInMap("hotel_special_invoice_fee")]
            [Validation(Required=false)]
            public string HotelSpecialInvoiceFee { get; set; }

            [NameInMap("international_flight_invoice_fee")]
            [Validation(Required=false)]
            public string InternationalFlightInvoiceFee { get; set; }

            [NameInMap("international_hotel_invoice_fee")]
            [Validation(Required=false)]
            public string InternationalHotelInvoiceFee { get; set; }

            [NameInMap("invoice_third_part_id")]
            [Validation(Required=false)]
            public string InvoiceThirdPartId { get; set; }

            [NameInMap("invoice_title")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            [NameInMap("mail_address")]
            [Validation(Required=false)]
            public string MailAddress { get; set; }

            [NameInMap("mail_city")]
            [Validation(Required=false)]
            public string MailCity { get; set; }

            [NameInMap("mail_full_address")]
            [Validation(Required=false)]
            public string MailFullAddress { get; set; }

            [NameInMap("mail_province")]
            [Validation(Required=false)]
            public string MailProvince { get; set; }

            [NameInMap("penalty_fee")]
            [Validation(Required=false)]
            public string PenaltyFee { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("service_fee")]
            [Validation(Required=false)]
            public string ServiceFee { get; set; }

            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            [NameInMap("train_invoice_fee")]
            [Validation(Required=false)]
            public string TrainInvoiceFee { get; set; }

            [NameInMap("vehicle_invoice_fee")]
            [Validation(Required=false)]
            public string VehicleInvoiceFee { get; set; }

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
