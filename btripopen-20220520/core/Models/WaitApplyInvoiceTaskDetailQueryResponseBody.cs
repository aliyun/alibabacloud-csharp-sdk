// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class WaitApplyInvoiceTaskDetailQueryResponseBody : TeaModel {
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
        public List<WaitApplyInvoiceTaskDetailQueryResponseBodyModule> Module { get; set; }
        public class WaitApplyInvoiceTaskDetailQueryResponseBodyModule : TeaModel {
            [NameInMap("contact")]
            [Validation(Required=false)]
            public string Contact { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("flight_invoice_fee")]
            [Validation(Required=false)]
            public string FlightInvoiceFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3.12</para>
            /// </summary>
            [NameInMap("fu_point_invoice_fee")]
            [Validation(Required=false)]
            public string FuPointInvoiceFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("hotel_normal_invoice_fee")]
            [Validation(Required=false)]
            public string HotelNormalInvoiceFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("hotel_special_invoice_fee")]
            [Validation(Required=false)]
            public string HotelSpecialInvoiceFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("international_flight_invoice_fee")]
            [Validation(Required=false)]
            public string InternationalFlightInvoiceFee { get; set; }

            [NameInMap("international_hotel_invoice_fee")]
            [Validation(Required=false)]
            public string InternationalHotelInvoiceFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
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

            [NameInMap("meal_normal_invoice_fee")]
            [Validation(Required=false)]
            public string MealNormalInvoiceFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("penalty_fee")]
            [Validation(Required=false)]
            public string PenaltyFee { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.02</para>
            /// </summary>
            [NameInMap("service_fee")]
            [Validation(Required=false)]
            public string ServiceFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            [NameInMap("train_acceleration_package_invoice_fee")]
            [Validation(Required=false)]
            public string TrainAccelerationPackageInvoiceFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("train_invoice_fee")]
            [Validation(Required=false)]
            public string TrainInvoiceFee { get; set; }

            [NameInMap("vacation_normal_invoice_fee")]
            [Validation(Required=false)]
            public string VacationNormalInvoiceFee { get; set; }

            [NameInMap("vas_mall_special_invoice_fee")]
            [Validation(Required=false)]
            public string VasMallSpecialInvoiceFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("vehicle_invoice_fee")]
            [Validation(Required=false)]
            public string VehicleInvoiceFee { get; set; }

            [NameInMap("vehicle_normal_invoice_fee")]
            [Validation(Required=false)]
            public string VehicleNormalInvoiceFee { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
