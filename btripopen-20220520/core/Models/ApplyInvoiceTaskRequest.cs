// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyInvoiceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The billing date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-01</para>
        /// </summary>
        [NameInMap("bill_date")]
        [Validation(Required=false)]
        public string BillDate { get; set; }

        /// <summary>
        /// <para>The adjusted invoice task list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("invoice_task_list")]
        [Validation(Required=false)]
        public List<ApplyInvoiceTaskRequestInvoiceTaskList> InvoiceTaskList { get; set; }
        public class ApplyInvoiceTaskRequestInvoiceTaskList : TeaModel {
            /// <summary>
            /// <para>The recipient name. All mailing information fields can be left empty, in which case the mailing address associated with the third-party invoice header ID is used. If any mailing information field is not empty, all other mailing information fields must also be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("contact")]
            [Validation(Required=false)]
            public string Contact { get; set; }

            /// <summary>
            /// <para>The recipient email address. All mailing information fields can be left empty, in which case the mailing address associated with the third-party invoice header ID is used. If any mailing information field is not empty, all other mailing information fields must also be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>接收电子发票的电子邮箱地址</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The general invoice amount for domestic flights.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("flight_invoice_fee")]
            [Validation(Required=false)]
            public string FlightInvoiceFee { get; set; }

            /// <summary>
            /// <para>The invoice amount for Fu points.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.12</para>
            /// </summary>
            [NameInMap("fu_point_invoice_fee")]
            [Validation(Required=false)]
            public string FuPointInvoiceFee { get; set; }

            /// <summary>
            /// <para>The general invoice amount for hotels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("hotel_normal_invoice_fee")]
            [Validation(Required=false)]
            public string HotelNormalInvoiceFee { get; set; }

            /// <summary>
            /// <para>The special VAT invoice amount for hotels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("hotel_special_invoice_fee")]
            [Validation(Required=false)]
            public string HotelSpecialInvoiceFee { get; set; }

            /// <summary>
            /// <para>The general invoice amount for international/Hong Kong, Macao, Taiwan (China) vehicle services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ie_vehicle_normal_invoice_fee")]
            [Validation(Required=false)]
            public string IeVehicleNormalInvoiceFee { get; set; }

            /// <summary>
            /// <para>The general invoice amount for international flights.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("international_flight_invoice_fee")]
            [Validation(Required=false)]
            public string InternationalFlightInvoiceFee { get; set; }

            /// <summary>
            /// <para>The general invoice amount for international hotels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("international_hotel_invoice_fee")]
            [Validation(Required=false)]
            public string InternationalHotelInvoiceFee { get; set; }

            /// <summary>
            /// <para>The third-party invoice header ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("invoice_third_part_id")]
            [Validation(Required=false)]
            public string InvoiceThirdPartId { get; set; }

            /// <summary>
            /// <para>The invoice type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: general VAT invoice.</description></item>
            /// <item><description>2: special VAT invoice. Use this value only when a special VAT invoice header needs to issue a general invoice. Not required for other scenarios. Contact customer service for configuration before using this field.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("invoice_type")]
            [Validation(Required=false)]
            public int? InvoiceType { get; set; }

            /// <summary>
            /// <para>The detailed mailing address. All mailing information fields can be left empty, in which case the mailing address associated with the third-party invoice header ID is used. If any mailing information field is not empty, all other mailing information fields must also be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>余杭区仓前街道XX路1号XX大厦101</para>
            /// </summary>
            [NameInMap("mail_address")]
            [Validation(Required=false)]
            public string MailAddress { get; set; }

            /// <summary>
            /// <para>The city of the mailing address. All mailing information fields can be left empty, in which case the mailing address associated with the third-party invoice header ID is used. If any mailing information field is not empty, all other mailing information fields must also be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州市</para>
            /// </summary>
            [NameInMap("mail_city")]
            [Validation(Required=false)]
            public string MailCity { get; set; }

            /// <summary>
            /// <para>The full mailing address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江省杭州市余杭区仓前街道XX路1号XX大厦101</para>
            /// </summary>
            [NameInMap("mail_full_address")]
            [Validation(Required=false)]
            public string MailFullAddress { get; set; }

            /// <summary>
            /// <para>The province of the mailing address. All mailing information fields can be left empty, in which case the mailing address associated with the third-party invoice header ID is used. If any mailing information field is not empty, all other mailing information fields must also be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙江省</para>
            /// </summary>
            [NameInMap("mail_province")]
            [Validation(Required=false)]
            public string MailProvince { get; set; }

            /// <summary>
            /// <para>The general VAT invoice amount for meals (Alibaba Business Travel).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("meal_normal_invoice_fee")]
            [Validation(Required=false)]
            public string MealNormalInvoiceFee { get; set; }

            /// <summary>
            /// <para>The general VAT invoice amount for meals (Alibaba Business Travel Yuhang Branch).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("meal_tc7_normal_invoice_fee")]
            [Validation(Required=false)]
            public string MealTc7NormalInvoiceFee { get; set; }

            /// <summary>
            /// <para>The invoice amount for penalty fees.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("penalty_fee")]
            [Validation(Required=false)]
            public string PenaltyFee { get; set; }

            /// <summary>
            /// <para>The invoice remark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试备注</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The service fee invoice amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.02</para>
            /// </summary>
            [NameInMap("service_fee")]
            [Validation(Required=false)]
            public string ServiceFee { get; set; }

            /// <summary>
            /// <para>The recipient phone number. All mailing information fields can be left empty, in which case the mailing address associated with the third-party invoice header ID is used. If any mailing information field is not empty, all other mailing information fields must also be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            /// <summary>
            /// <para>The invoice amount for the train ticket acceleration package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("train_acceleration_package_invoice_fee")]
            [Validation(Required=false)]
            public string TrainAccelerationPackageInvoiceFee { get; set; }

            /// <summary>
            /// <para>The general invoice amount for train tickets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("train_invoice_fee")]
            [Validation(Required=false)]
            public string TrainInvoiceFee { get; set; }

            /// <summary>
            /// <para>The general invoice amount for vacation services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("vacation_normal_invoice_fee")]
            [Validation(Required=false)]
            public string VacationNormalInvoiceFee { get; set; }

            /// <summary>
            /// <para>The special VAT invoice amount for value-added services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("vas_mall_special_invoice_fee")]
            [Validation(Required=false)]
            public string VasMallSpecialInvoiceFee { get; set; }

            /// <summary>
            /// <para>The special VAT invoice amount for vehicle services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("vehicle_invoice_fee")]
            [Validation(Required=false)]
            public string VehicleInvoiceFee { get; set; }

            /// <summary>
            /// <para>The general invoice amount for domestic vehicle services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("vehicle_normal_invoice_fee")]
            [Validation(Required=false)]
            public string VehicleNormalInvoiceFee { get; set; }

        }

    }

}
