// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightCreateOrderV2Request : TeaModel {
        /// <summary>
        /// <para>The asynchronous order creation key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>异步下单key</para>
        /// </summary>
        [NameInMap("async_create_order_key")]
        [Validation(Required=false)]
        public string AsyncCreateOrderKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to use asynchronous order creation mode. If asynchronous order creation is used, only a key is returned before the final result is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("async_create_order_mode")]
        [Validation(Required=false)]
        public bool? AsyncCreateOrderMode { get; set; }

        /// <summary>
        /// <para>The business travel user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali_00001</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The buyer name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>云妹</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>The contact information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public FlightCreateOrderV2RequestContactInfo ContactInfo { get; set; }
        public class FlightCreateOrderV2RequestContactInfo : TeaModel {
            /// <summary>
            /// <para>The contact email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:btrip@example.com">btrip@example.com</a></para>
            /// </summary>
            [NameInMap("contact_email")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云妹</para>
            /// </summary>
            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The contact phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131****8888</para>
            /// </summary>
            [NameInMap("contact_phone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            /// <summary>
            /// <para>Specifies whether to send an SMS notification to the passenger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("send_msg_to_passenger")]
            [Validation(Required=false)]
            public bool? SendMsgToPassenger { get; set; }

        }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州商旅渠道商</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The quote item ID. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7fb731deeb4510b86c17e8c8c25740_11</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>外部订单号</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The total price. Unit: cents.</para>
        /// <para>If this parameter is not specified, the price is calculated from the quote item.</para>
        /// <para>If this parameter is specified, the system verifies that the quote item price is not lower than the specified price to prevent malicious low-price submissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("total_price_cent")]
        [Validation(Required=false)]
        public long? TotalPriceCent { get; set; }

        /// <summary>
        /// <para>The list of passengers. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("travelers")]
        [Validation(Required=false)]
        public List<FlightCreateOrderV2RequestTravelers> Travelers { get; set; }
        public class FlightCreateOrderV2RequestTravelers : TeaModel {
            /// <summary>
            /// <para>The date of birth.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1991-01-01</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <para>The certificate issuing country.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("cert_nation")]
            [Validation(Required=false)]
            public string CertNation { get; set; }

            /// <summary>
            /// <para>The certificate number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110101********1234</para>
            /// </summary>
            [NameInMap("cert_no")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <para>The certificate type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("cert_type")]
            [Validation(Required=false)]
            public int? CertType { get; set; }

            /// <summary>
            /// <para>The certificate validity date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2099-03-12</para>
            /// </summary>
            [NameInMap("cert_valid_date")]
            [Validation(Required=false)]
            public string CertValidDate { get; set; }

            /// <summary>
            /// <para>The cost center name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>华北成本中心</para>
            /// </summary>
            [NameInMap("cost_center_name")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <para>The cost center number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cost_00001</para>
            /// </summary>
            [NameInMap("cost_center_number")]
            [Validation(Required=false)]
            public string CostCenterNumber { get; set; }

            /// <summary>
            /// <para>The department ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dept_00001</para>
            /// </summary>
            [NameInMap("dept_id")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// <para>The department name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>产品部</para>
            /// </summary>
            [NameInMap("dept_name")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <para>The gender.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public int? Gender { get; set; }

            /// <summary>
            /// <para>The invoice title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州大河发展有限公司</para>
            /// </summary>
            [NameInMap("invoice_title")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            /// <summary>
            /// <para>The nationality.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国</para>
            /// </summary>
            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            /// <summary>
            /// <para>The two-letter nationality code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("nationality_code")]
            [Validation(Required=false)]
            public string NationalityCode { get; set; }

            /// <summary>
            /// <para>The passenger name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>销售部测试</para>
            /// </summary>
            [NameInMap("passenger_name")]
            [Validation(Required=false)]
            public string PassengerName { get; set; }

            /// <summary>
            /// <para>The passenger type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("passenger_type")]
            [Validation(Required=false)]
            public int? PassengerType { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131****8888</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The project code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pro_0001</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>华北项目一</para>
            /// </summary>
            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <para>The tax number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R19235929348590</para>
            /// </summary>
            [NameInMap("tax_number")]
            [Validation(Required=false)]
            public string TaxNumber { get; set; }

            /// <summary>
            /// <para>The employee ID. This parameter is required for change search and refund pre-calculation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para><b>Deprecated</b>. The employee type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("user_type")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

    }

}
