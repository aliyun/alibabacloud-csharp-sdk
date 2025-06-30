// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightCreateOrderRequest : TeaModel {
        [NameInMap("async_create_order_key")]
        [Validation(Required=false)]
        public string AsyncCreateOrderKey { get; set; }

        [NameInMap("async_create_order_mode")]
        [Validation(Required=false)]
        public bool? AsyncCreateOrderMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZHANG/SAN</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public IntlFlightCreateOrderRequestContactInfo ContactInfo { get; set; }
        public class IntlFlightCreateOrderRequestContactInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
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
            /// </summary>
            [NameInMap("contact_phone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

        }

        [NameInMap("extra_info")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtraInfo { get; set; }

        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("order_price")]
        [Validation(Required=false)]
        public long? OrderPrice { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public List<IntlFlightCreateOrderRequestPassengerList> PassengerList { get; set; }
        public class IntlFlightCreateOrderRequestPassengerList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1998-12-28</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cert_info")]
            [Validation(Required=false)]
            public IntlFlightCreateOrderRequestPassengerListCertInfo CertInfo { get; set; }
            public class IntlFlightCreateOrderRequestPassengerListCertInfo : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>E1234567</para>
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
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2029-12-31</para>
                /// </summary>
                [NameInMap("cert_valid_date")]
                [Validation(Required=false)]
                public string CertValidDate { get; set; }

                /// <summary>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZHANG/SAN</para>
            /// </summary>
            [NameInMap("full_name")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public int? Gender { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>L5000924</para>
            /// </summary>
            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国大陆</para>
            /// </summary>
            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("nationality_code")]
            [Validation(Required=false)]
            public string NationalityCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13100008888</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12292812036903456</para>
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

        [NameInMap("render_key")]
        [Validation(Required=false)]
        public string RenderKey { get; set; }

    }

}
