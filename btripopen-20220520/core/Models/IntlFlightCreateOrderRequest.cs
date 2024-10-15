// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightCreateOrderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>fcoid_deb6372db8194f1c94c23bc4fadc508d</para>
        /// </summary>
        [NameInMap("async_create_order_key")]
        [Validation(Required=false)]
        public string AsyncCreateOrderKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("async_create_order_mode")]
        [Validation(Required=false)]
        public bool? AsyncCreateOrderMode { get; set; }

        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public IntlFlightCreateOrderRequestContactInfo ContactInfo { get; set; }
        public class IntlFlightCreateOrderRequestContactInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:XXX@aliyun.com">XXX@aliyun.com</a></para>
            /// </summary>
            [NameInMap("contact_email")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13812341234</para>
            /// </summary>
            [NameInMap("contact_phone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("send_msg_to_passenger")]
            [Validation(Required=false)]
            public bool? SendMsgToPassenger { get; set; }

        }

        [NameInMap("cost_center")]
        [Validation(Required=false)]
        public IntlFlightCreateOrderRequestCostCenter CostCenter { get; set; }
        public class IntlFlightCreateOrderRequestCostCenter : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cost_center_name")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>312434</para>
            /// </summary>
            [NameInMap("cost_center_number")]
            [Validation(Required=false)]
            public string CostCenterNumber { get; set; }

        }

        [NameInMap("extra_info")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtraInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>open12k0lclldfdc7v10E2HaRrOr00</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>chinese</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>56319a175bdf4b1898190bd7edb603b5_0</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F11380075736888770560</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public List<IntlFlightCreateOrderRequestPassengerList> PassengerList { get; set; }
        public class IntlFlightCreateOrderRequestPassengerList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-01-01</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100/12131231</para>
            /// </summary>
            [NameInMap("cascade_dept_mask")]
            [Validation(Required=false)]
            public string CascadeDeptMask { get; set; }

            [NameInMap("cascade_dept_name")]
            [Validation(Required=false)]
            public string CascadeDeptName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cert_info")]
            [Validation(Required=false)]
            public IntlFlightCreateOrderRequestPassengerListCertInfo CertInfo { get; set; }
            public class IntlFlightCreateOrderRequestPassengerListCertInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("cert_nation")]
                [Validation(Required=false)]
                public string CertNation { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>H123456</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public int? CertType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2030-01-01</para>
                /// </summary>
                [NameInMap("cert_valid_date")]
                [Validation(Required=false)]
                public string CertValidDate { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG/SAN</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("cost_center_name")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>312434</para>
            /// </summary>
            [NameInMap("cost_center_number")]
            [Validation(Required=false)]
            public string CostCenterNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12131231</para>
            /// </summary>
            [NameInMap("dept_id")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("dept_name")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public int? Gender { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10001313</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public string InvoiceId { get; set; }

            [NameInMap("invoice_title")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ZNW0525</para>
            /// </summary>
            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>086</para>
            /// </summary>
            [NameInMap("mobile_country_code")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("nationality_code")]
            [Validation(Required=false)]
            public string NationalityCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("passenger_type")]
            [Validation(Required=false)]
            public int? PassengerType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18012341234</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10123143</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            [NameInMap("subsidiary_cert_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightCreateOrderRequestPassengerListSubsidiaryCertInfoList> SubsidiaryCertInfoList { get; set; }
            public class IntlFlightCreateOrderRequestPassengerListSubsidiaryCertInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("cert_nation")]
                [Validation(Required=false)]
                public string CertNation { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>H123456</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public int? CertType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2030-01-01</para>
                /// </summary>
                [NameInMap("cert_valid_date")]
                [Validation(Required=false)]
                public string CertValidDate { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZHANG/SAN</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13123123212</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("user_type")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fcoid_deb6372db8194f1c94c23bc4fadc508d</para>
        /// </summary>
        [NameInMap("render_key")]
        [Validation(Required=false)]
        public string RenderKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120000</para>
        /// </summary>
        [NameInMap("total_price_cent")]
        [Validation(Required=false)]
        public long? TotalPriceCent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12341234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
