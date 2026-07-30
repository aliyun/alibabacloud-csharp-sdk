// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyOtaSearchV2Request : TeaModel {
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
        /// <para>1017002195370467200</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467200</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The passenger-segment relations. Required at the passenger-segment level.</para>
        /// </summary>
        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public List<FlightModifyOtaSearchV2RequestPassengerSegmentRelations> PassengerSegmentRelations { get; set; }
        public class FlightModifyOtaSearchV2RequestPassengerSegmentRelations : TeaModel {
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
        /// <para>The flight information selected by the user during search. This parameter is required.</para>
        /// </summary>
        [NameInMap("selected_segments")]
        [Validation(Required=false)]
        public List<FlightModifyOtaSearchV2RequestSelectedSegments> SelectedSegments { get; set; }
        public class FlightModifyOtaSearchV2RequestSelectedSegments : TeaModel {
            /// <summary>
            /// <para>The arrival city three-letter code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BJS</para>
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <para>The departure city code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XIL</para>
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <para>The departure time, such as 2021-11-15 21:55.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-18 09:10:00</para>
            /// </summary>
            [NameInMap("dep_date_time")]
            [Validation(Required=false)]
            public string DepDateTime { get; set; }

            /// <summary>
            /// <para>The journey sequence number, starting from 0.</para>
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
            /// <para>CA1110</para>
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
            /// <para>The segment sequence number, starting from 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("segment_seq")]
            [Validation(Required=false)]
            public int? SegmentSeq { get; set; }

        }

        /// <summary>
        /// <para>The session ID. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>590f17eca9374f20ac7e8ed8a7db2f35</para>
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
