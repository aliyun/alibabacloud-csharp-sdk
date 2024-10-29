// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class AncillarySuggestResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Properly processed return data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AncillarySuggestResponseBodyData Data { get; set; }
        public class AncillarySuggestResponseBodyData : TeaModel {
            /// <summary>
            /// <para>ancillary detail list</para>
            /// </summary>
            [NameInMap("seg_ancillary_map_list")]
            [Validation(Required=false)]
            public List<AncillarySuggestResponseBodyDataSegAncillaryMapList> SegAncillaryMapList { get; set; }
            public class AncillarySuggestResponseBodyDataSegAncillaryMapList : TeaModel {
                /// <summary>
                /// <para>Ancillary product</para>
                /// </summary>
                [NameInMap("ancillary")]
                [Validation(Required=false)]
                public AncillarySuggestResponseBodyDataSegAncillaryMapListAncillary Ancillary { get; set; }
                public class AncillarySuggestResponseBodyDataSegAncillaryMapListAncillary : TeaModel {
                    /// <summary>
                    /// <para>Ancillary product ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eJwz8DeySEo0NjQ01TU3TU</para>
                    /// </summary>
                    [NameInMap("ancillary_id")]
                    [Validation(Required=false)]
                    public string AncillaryId { get; set; }

                    /// <summary>
                    /// <para>Ancillary product type. currently supports 4: paid luggage</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("ancillary_type")]
                    [Validation(Required=false)]
                    public int? AncillaryType { get; set; }

                    /// <summary>
                    /// <para>Baggage details</para>
                    /// </summary>
                    [NameInMap("baggage_ancillary")]
                    [Validation(Required=false)]
                    public AncillarySuggestResponseBodyDataSegAncillaryMapListAncillaryBaggageAncillary BaggageAncillary { get; set; }
                    public class AncillarySuggestResponseBodyDataSegAncillaryMapListAncillaryBaggageAncillary : TeaModel {
                        /// <summary>
                        /// <para>baggage quantity, values such as: 3, 2, 1, 0, -2.     -2 indicates weight-based</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("baggage_amount")]
                        [Validation(Required=false)]
                        public int? BaggageAmount { get; set; }

                        /// <summary>
                        /// <para>Baggage weight, 0-50. When isAllWeight=true, it represents the total weight of all baggages.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("baggage_weight")]
                        [Validation(Required=false)]
                        public int? BaggageWeight { get; set; }

                        /// <summary>
                        /// <para>Unit of baggage weight</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KG</para>
                        /// </summary>
                        [NameInMap("baggage_weight_unit")]
                        [Validation(Required=false)]
                        public string BaggageWeightUnit { get; set; }

                        /// <summary>
                        /// <para>Whether the weight is for all baggages</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("is_all_weight")]
                        [Validation(Required=false)]
                        public bool? IsAllWeight { get; set; }

                        /// <summary>
                        /// <para>Total price</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.0</para>
                        /// </summary>
                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public double? Price { get; set; }

                    }

                }

                /// <summary>
                /// <para>Segment ID list, these segments share the same ancillary</para>
                /// </summary>
                [NameInMap("segment_id_list")]
                [Validation(Required=false)]
                public List<string> SegmentIdList { get; set; }

            }

            /// <summary>
            /// <para>solution_id, equals to solution_id in request</para>
            /// 
            /// <b>Example:</b>
            /// <para>eJwz8DeySEo0NjQ01TU3TU7TNTFINNO1SE5O0jVKM0hKNjEwTElLNYwz0A32cNT1dfPVNTIwMjYwNjRQ8/A3NLI01Q0Ic0cRBwBVFxJJ</para>
            /// </summary>
            [NameInMap("solution_id")]
            [Validation(Required=false)]
            public string SolutionId { get; set; }

        }

        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Data carried in error handling</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>http request successful, status value is always 200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>true represents success, false represents failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
