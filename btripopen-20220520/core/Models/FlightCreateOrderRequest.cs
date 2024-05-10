// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightCreateOrderRequest : TeaModel {
        [NameInMap("arr_airport_code")]
        [Validation(Required=false)]
        public string ArrAirportCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("arr_city_code")]
        [Validation(Required=false)]
        public string ArrCityCode { get; set; }

        [NameInMap("auto_pay")]
        [Validation(Required=false)]
        public int? AutoPay { get; set; }

        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("buyer_unique_key")]
        [Validation(Required=false)]
        public string BuyerUniqueKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public FlightCreateOrderRequestContactInfo ContactInfo { get; set; }
        public class FlightCreateOrderRequestContactInfo : TeaModel {
            [NameInMap("contact_email")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("contact_phone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

        }

        [NameInMap("dep_airport_code")]
        [Validation(Required=false)]
        public string DepAirportCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dep_city_code")]
        [Validation(Required=false)]
        public string DepCityCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        [NameInMap("order_attr")]
        [Validation(Required=false)]
        public Dictionary<string, object> OrderAttr { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("order_params")]
        [Validation(Required=false)]
        public string OrderParams { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        [NameInMap("receipt_address")]
        [Validation(Required=false)]
        public string ReceiptAddress { get; set; }

        [NameInMap("receipt_target")]
        [Validation(Required=false)]
        public int? ReceiptTarget { get; set; }

        [NameInMap("receipt_title")]
        [Validation(Required=false)]
        public string ReceiptTitle { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("traveler_info_list")]
        [Validation(Required=false)]
        public List<FlightCreateOrderRequestTravelerInfoList> TravelerInfoList { get; set; }
        public class FlightCreateOrderRequestTravelerInfoList : TeaModel {
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            [NameInMap("cert_nation")]
            [Validation(Required=false)]
            public string CertNation { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cert_no")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cert_type")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            [NameInMap("cert_valid_date")]
            [Validation(Required=false)]
            public string CertValidDate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 国籍
            /// </summary>
            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            /// <summary>
            /// 国籍二字码
            /// </summary>
            [NameInMap("nationality_code")]
            [Validation(Required=false)]
            public string NationalityCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("out_user_id")]
            [Validation(Required=false)]
            public string OutUserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("sex")]
            [Validation(Required=false)]
            public int? Sex { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("trip_type")]
        [Validation(Required=false)]
        public int? TripType { get; set; }

    }

}
