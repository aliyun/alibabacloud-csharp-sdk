// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyListingSearchV2Request : TeaModel {
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public List<int?> CabinClass { get; set; }

        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public List<string> DepDate { get; set; }

        [NameInMap("interface_caller_is_support_retry")]
        [Validation(Required=false)]
        public bool? InterfaceCallerIsSupportRetry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1017002195370467138</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1017002195370467137</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public List<FlightModifyListingSearchV2RequestPassengerSegmentRelations> PassengerSegmentRelations { get; set; }
        public class FlightModifyListingSearchV2RequestPassengerSegmentRelations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3243028</para>
            /// </summary>
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public string PassengerId { get; set; }

            [NameInMap("segment_id_list")]
            [Validation(Required=false)]
            public List<string> SegmentIdList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        [NameInMap("search_retry_token")]
        [Validation(Required=false)]
        public string SearchRetryToken { get; set; }

        [NameInMap("selected_segments")]
        [Validation(Required=false)]
        public List<FlightModifyListingSearchV2RequestSelectedSegments> SelectedSegments { get; set; }
        public class FlightModifyListingSearchV2RequestSelectedSegments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>XIL</para>
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BJS</para>
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-09-17 18:15:00</para>
            /// </summary>
            [NameInMap("dep_date_time")]
            [Validation(Required=false)]
            public string DepDateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("journey_seq")]
            [Validation(Required=false)]
            public int? JourneySeq { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CA8625</para>
            /// </summary>
            [NameInMap("marketing_flight_no")]
            [Validation(Required=false)]
            public string MarketingFlightNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MU8625</para>
            /// </summary>
            [NameInMap("operating_flight_no")]
            [Validation(Required=false)]
            public string OperatingFlightNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("segment_seq")]
            [Validation(Required=false)]
            public int? SegmentSeq { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a2ffebfe733742aab5c491d960ba3d59</para>
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("voluntary")]
        [Validation(Required=false)]
        public bool? Voluntary { get; set; }

    }

}
