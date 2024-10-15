// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyInvoiceTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-01</para>
        /// </summary>
        [NameInMap("bill_date")]
        [Validation(Required=false)]
        public string BillDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("invoice_task_list")]
        [Validation(Required=false)]
        public List<ApplyInvoiceTaskRequestInvoiceTaskList> InvoiceTaskList { get; set; }
        public class ApplyInvoiceTaskRequestInvoiceTaskList : TeaModel {
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("invoice_third_part_id")]
            [Validation(Required=false)]
            public string InvoiceThirdPartId { get; set; }

            [NameInMap("invoice_type")]
            [Validation(Required=false)]
            public int? InvoiceType { get; set; }

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

    }

}
