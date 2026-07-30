// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyListingSearchV2Request : TeaModel {
        /// <summary>
        /// <para>The cabin class. This parameter is deprecated. Currently only the lowest price is returned.</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public List<int?> CabinClass { get; set; }

        /// <summary>
        /// <para>The intended departure date for the flight change.</para>
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public List<string> DepDate { get; set; }

        /// <summary>
        /// <para>Specifies whether the caller supports retry.</para>
        /// <para>true: The caller supports retry. When the operation requires a retry, the response returns retry, searchRetryToken, and nextReqWaitTime.
        ///         Boolean retry (whether a retry is required)
        ///         String searchRetryToken (search retry token)
        ///         Integer nextReqWaitTime (retry time interval)
        ///         The caller must invoke the operation again based on the response and include the searchRetryToken parameter.</para>
        /// <para>false: The caller does not support retry. When the operation requires a retry, the system retries internally in a loop. Risk: excessive internal retries may cause this call to timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("interface_caller_is_support_retry")]
        [Validation(Required=false)]
        public bool? InterfaceCallerIsSupportRetry { get; set; }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The business travel order ID (sales order ID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467138</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467137</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The passenger-segment relations. Required at the passenger-segment level.</para>
        /// </summary>
        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public List<FlightModifyListingSearchV2RequestPassengerSegmentRelations> PassengerSegmentRelations { get; set; }
        public class FlightModifyListingSearchV2RequestPassengerSegmentRelations : TeaModel {
            /// <summary>
            /// <para>The passenger ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3243028</para>
            /// </summary>
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public string PassengerId { get; set; }

            /// <summary>
            /// <para>The list of segment IDs.</para>
            /// </summary>
            [NameInMap("segment_id_list")]
            [Validation(Required=false)]
            public List<string> SegmentIdList { get; set; }

        }

        /// <summary>
        /// <para>The search mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        /// <summary>
        /// <para>The search retry token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2c230080358295f99e03aa4e3ccf1bd</para>
        /// </summary>
        [NameInMap("search_retry_token")]
        [Validation(Required=false)]
        public string SearchRetryToken { get; set; }

        /// <summary>
        /// <para>The flight information that the user has selected during the search. For round trips: has a value when searching for the return leg. For multi-leg trips: has a value when searching for legs other than the first.</para>
        /// </summary>
        [NameInMap("selected_segments")]
        [Validation(Required=false)]
        public List<FlightModifyListingSearchV2RequestSelectedSegments> SelectedSegments { get; set; }
        public class FlightModifyListingSearchV2RequestSelectedSegments : TeaModel {
            /// <summary>
            /// <para>The arrival city three-letter code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XIL</para>
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <para>The departure city code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BJS</para>
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <para>The departure time, such as 2021-11-15 21:55.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-17 18:15:00</para>
            /// </summary>
            [NameInMap("dep_date_time")]
            [Validation(Required=false)]
            public string DepDateTime { get; set; }

            /// <summary>
            /// <para>The journey segment sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("journey_seq")]
            [Validation(Required=false)]
            public int? JourneySeq { get; set; }

            /// <summary>
            /// <para>The marketing airline flight number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CA8625</para>
            /// </summary>
            [NameInMap("marketing_flight_no")]
            [Validation(Required=false)]
            public string MarketingFlightNo { get; set; }

            /// <summary>
            /// <para>The operating airline two-letter code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MU8625</para>
            /// </summary>
            [NameInMap("operating_flight_no")]
            [Validation(Required=false)]
            public string OperatingFlightNo { get; set; }

            /// <summary>
            /// <para>The segment sequence number, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("segment_seq")]
            [Validation(Required=false)]
            public int? SegmentSeq { get; set; }

        }

        /// <summary>
        /// <para>The session ID. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2ffebfe733742aab5c491d960ba3d59</para>
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether the change is voluntary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("voluntary")]
        [Validation(Required=false)]
        public bool? Voluntary { get; set; }

    }

}
