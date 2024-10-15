// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightCreateOrderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("arr_airport_code")]
        [Validation(Required=false)]
        public string ArrAirportCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("arr_city_code")]
        [Validation(Required=false)]
        public string ArrCityCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("auto_pay")]
        [Validation(Required=false)]
        public int? AutoPay { get; set; }

        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("buyer_unique_key")]
        [Validation(Required=false)]
        public string BuyerUniqueKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public FlightCreateOrderRequestContactInfo ContactInfo { get; set; }
        public class FlightCreateOrderRequestContactInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>******@alibaba-inc.com</para>
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
            /// <para>12312345211</para>
            /// </summary>
            [NameInMap("contact_phone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PEK</para>
        /// </summary>
        [NameInMap("dep_airport_code")]
        [Validation(Required=false)]
        public string DepAirportCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("dep_city_code")]
        [Validation(Required=false)]
        public string DepCityCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-00-00 00:00:00</para>
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        [NameInMap("order_attr")]
        [Validation(Required=false)]
        public Dictionary<string, object> OrderAttr { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000_1_0</para>
        /// </summary>
        [NameInMap("order_params")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7fb731deeb4510b86c17e8c8c25740_11</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        [NameInMap("receipt_address")]
        [Validation(Required=false)]
        public string ReceiptAddress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("receipt_target")]
        [Validation(Required=false)]
        public int? ReceiptTarget { get; set; }

        [NameInMap("receipt_title")]
        [Validation(Required=false)]
        public string ReceiptTitle { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("traveler_info_list")]
        [Validation(Required=false)]
        public List<FlightCreateOrderRequestTravelerInfoList> TravelerInfoList { get; set; }
        public class FlightCreateOrderRequestTravelerInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2000-00-00</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            [NameInMap("cert_nation")]
            [Validation(Required=false)]
            public string CertNation { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1262651555151</para>
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
            public string CertType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000-00-00</para>
            /// </summary>
            [NameInMap("cert_valid_date")]
            [Validation(Required=false)]
            public string CertValidDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>国籍</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国大陆</para>
            /// </summary>
            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            /// <summary>
            /// <para>国籍二字码</para>
            /// 
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
            /// <para>1234</para>
            /// </summary>
            [NameInMap("out_user_id")]
            [Validation(Required=false)]
            public string OutUserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12341231232</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("sex")]
            [Validation(Required=false)]
            public int? Sex { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("trip_type")]
        [Validation(Required=false)]
        public int? TripType { get; set; }

    }

}
