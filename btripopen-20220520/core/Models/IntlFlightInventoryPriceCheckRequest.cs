// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightInventoryPriceCheckRequest : TeaModel {
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
        /// <b>Example:</b>
        /// <para>ZHANG/SAN</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZJTD</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cert_info")]
            [Validation(Required=false)]
            public IntlFlightInventoryPriceCheckRequestPassengerListCertInfo CertInfo { get; set; }
            public class IntlFlightInventoryPriceCheckRequestPassengerListCertInfo : TeaModel {
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
            /// <para>18012341234</para>
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

    }

}
