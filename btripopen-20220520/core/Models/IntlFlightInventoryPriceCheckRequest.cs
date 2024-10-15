// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightInventoryPriceCheckRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ZJTD</para>
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
        /// <para>102000</para>
        /// </summary>
        [NameInMap("order_price")]
        [Validation(Required=false)]
        public long? OrderPrice { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22111acaf9ea47c09ed0db6abc45be2d_0</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public List<IntlFlightInventoryPriceCheckRequestPassengerList> PassengerList { get; set; }
        public class IntlFlightInventoryPriceCheckRequestPassengerList : TeaModel {
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
            /// <para>100/1001</para>
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
            public IntlFlightInventoryPriceCheckRequestPassengerListCertInfo CertInfo { get; set; }
            public class IntlFlightInventoryPriceCheckRequestPassengerListCertInfo : TeaModel {
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
                /// <para>2033-01-09</para>
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
            /// <para>100231</para>
            /// </summary>
            [NameInMap("cost_center_number")]
            [Validation(Required=false)]
            public string CostCenterNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
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
            /// <para>L5000924</para>
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
            public List<IntlFlightInventoryPriceCheckRequestPassengerListSubsidiaryCertInfoList> SubsidiaryCertInfoList { get; set; }
            public class IntlFlightInventoryPriceCheckRequestPassengerListSubsidiaryCertInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("cert_nation")]
                [Validation(Required=false)]
                public string CertNation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>H123456</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public int? CertType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2033-01-09</para>
                /// </summary>
                [NameInMap("cert_valid_date")]
                [Validation(Required=false)]
                public string CertValidDate { get; set; }

                /// <summary>
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
            /// <para>10001</para>
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
        /// <para>12412341234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
