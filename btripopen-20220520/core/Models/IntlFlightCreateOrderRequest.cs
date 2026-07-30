// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightCreateOrderRequest : TeaModel {
        /// <summary>
        /// <para>The key for asynchronous order creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcoid_deb6372db8194f1c94c23bc4fadc508d</para>
        /// </summary>
        [NameInMap("async_create_order_key")]
        [Validation(Required=false)]
        public string AsyncCreateOrderKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to use asynchronous order creation mode. If asynchronous order creation is used, only a key is returned before the result is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("async_create_order_mode")]
        [Validation(Required=false)]
        public bool? AsyncCreateOrderMode { get; set; }

        /// <summary>
        /// <para>The business travel user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZHANG/SAN</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>The contact information. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public IntlFlightCreateOrderRequestContactInfo ContactInfo { get; set; }
        public class IntlFlightCreateOrderRequestContactInfo : TeaModel {
            /// <summary>
            /// <para>The email address of the contact.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>j*********@example.com</para>
            /// </summary>
            [NameInMap("contact_email")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <para>The name of the contact.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The phone number of the contact.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18888888888</para>
            /// </summary>
            [NameInMap("contact_phone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

        }

        /// <summary>
        /// <para>The extended information. This parameter is optional and used to pass parameters for special requirements.</para>
        /// </summary>
        [NameInMap("extra_info")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtraInfo { get; set; }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The total price of the order including tax (excluding service fees). Unit: cents.</para>
        /// <remarks>
        /// <para>This parameter is optional. If specified, the system verifies whether the price is consistent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>102000</para>
        /// </summary>
        [NameInMap("order_price")]
        [Validation(Required=false)]
        public long? OrderPrice { get; set; }

        /// <summary>
        /// <para>The quoted product ID. This parameter is required.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>JP2024071800000002</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The list of passengers. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public List<IntlFlightCreateOrderRequestPassengerList> PassengerList { get; set; }
        public class IntlFlightCreateOrderRequestPassengerList : TeaModel {
            /// <summary>
            /// <para>The date of birth.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Format: yyyy-MM-dd</description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1998-12-28</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <para>The certificate information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cert_info")]
            [Validation(Required=false)]
            public IntlFlightCreateOrderRequestPassengerListCertInfo CertInfo { get; set; }
            public class IntlFlightCreateOrderRequestPassengerListCertInfo : TeaModel {
                /// <summary>
                /// <para>The certificate number.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>E1234567</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <para>The certificate type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public int? CertType { get; set; }

                /// <summary>
                /// <para>The certificate validity date. Format: yyyy-MM-dd.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2029-12-31</para>
                /// </summary>
                [NameInMap("cert_valid_date")]
                [Validation(Required=false)]
                public string CertValidDate { get; set; }

                /// <summary>
                /// <para>The place of issue.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中国大陆</para>
                /// </summary>
                [NameInMap("issue_place")]
                [Validation(Required=false)]
                public string IssuePlace { get; set; }

            }

            /// <summary>
            /// <para>The name of the passenger.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANG/SAN</para>
            /// </summary>
            [NameInMap("full_name")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            /// <summary>
            /// <para>The gender. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: male</description></item>
            /// <item><description>1: female</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public int? Gender { get; set; }

            /// <summary>
            /// <para>The employee ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L5000924</para>
            /// </summary>
            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            /// <summary>
            /// <para>The nationality name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国大陆</para>
            /// </summary>
            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            /// <summary>
            /// <para>The two-letter nationality code.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("nationality_code")]
            [Validation(Required=false)]
            public string NationalityCode { get; set; }

            /// <summary>
            /// <para>The contact phone number. Only Chinese mainland phone numbers with the +86 country code are supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13100008888</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The passenger type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Adult.</description></item>
            /// <item><description>1: Child.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The unique ID of the business travel user. This parameter is required.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12292812036903456</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The employee type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Internal employee.</description></item>
            /// <item><description>1: External employee.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("user_type")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

        /// <summary>
        /// <para>The key returned by seat and price verification. If this parameter is specified, seat and price verification is not performed again.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcoid_deb6372db8194f1c94c23bc4fadc508d</para>
        /// </summary>
        [NameInMap("render_key")]
        [Validation(Required=false)]
        public string RenderKey { get; set; }

    }

}
