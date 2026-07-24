// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class AncillarySuggestResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data returned for a successful request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AncillarySuggestResponseBodyData Data { get; set; }
        public class AncillarySuggestResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The mapping between flights and ancillary products.</para>
            /// </summary>
            [NameInMap("seg_ancillary_map_list")]
            [Validation(Required=false)]
            public List<AncillarySuggestResponseBodyDataSegAncillaryMapList> SegAncillaryMapList { get; set; }
            public class AncillarySuggestResponseBodyDataSegAncillaryMapList : TeaModel {
                /// <summary>
                /// <para>The ancillary product.</para>
                /// </summary>
                [NameInMap("ancillary")]
                [Validation(Required=false)]
                public AncillarySuggestResponseBodyDataSegAncillaryMapListAncillary Ancillary { get; set; }
                public class AncillarySuggestResponseBodyDataSegAncillaryMapListAncillary : TeaModel {
                    /// <summary>
                    /// <para>The ancillary product ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eJwz8DeySEo0NjQ01TU3TU</para>
                    /// </summary>
                    [NameInMap("ancillary_id")]
                    [Validation(Required=false)]
                    public string AncillaryId { get; set; }

                    /// <summary>
                    /// <para>The ancillary product type. Currently supported value: 4 (paid baggage).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("ancillary_type")]
                    [Validation(Required=false)]
                    public int? AncillaryType { get; set; }

                    /// <summary>
                    /// <para>The baggage ancillary details.</para>
                    /// </summary>
                    [NameInMap("baggage_ancillary")]
                    [Validation(Required=false)]
                    public AncillarySuggestResponseBodyDataSegAncillaryMapListAncillaryBaggageAncillary BaggageAncillary { get; set; }
                    public class AncillarySuggestResponseBodyDataSegAncillaryMapListAncillaryBaggageAncillary : TeaModel {
                        /// <summary>
                        /// <para>The number of baggage pieces. Valid values: 3, 2, 1, 0, and -2. A value of -2 indicates weight-based calculation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("baggage_amount")]
                        [Validation(Required=false)]
                        public int? BaggageAmount { get; set; }

                        /// <summary>
                        /// <para>The baggage weight, ranging from 0 to 50. If isAllWeight is set to true, this value represents the total weight of all pieces.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("baggage_weight")]
                        [Validation(Required=false)]
                        public int? BaggageWeight { get; set; }

                        /// <summary>
                        /// <para>The unit of baggage weight.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>KG</para>
                        /// </summary>
                        [NameInMap("baggage_weight_unit")]
                        [Validation(Required=false)]
                        public string BaggageWeightUnit { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the weight represents the total weight of all baggage pieces.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("is_all_weight")]
                        [Validation(Required=false)]
                        public bool? IsAllWeight { get; set; }

                        /// <summary>
                        /// <para>The total price.</para>
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
                /// <para>The list of segment IDs. These segments share the same ancillary product.</para>
                /// </summary>
                [NameInMap("segment_id_list")]
                [Validation(Required=false)]
                public List<string> SegmentIdList { get; set; }

            }

            /// <summary>
            /// <para>The solution_id of the flight.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eJwz8DeySEo0NjQ01TU3TU7TNTFINNO1SE5O0jVKM0hKNjEwTElLNYwz0A32cNT1dfPVNTIwMjYwNjRQ8/A3NLI01Q0Ic0cRBwBVFxJJ</para>
            /// </summary>
            [NameInMap("solution_id")]
            [Validation(Required=false)]
            public string SolutionId { get; set; }

        }

        /// <summary>
        /// <para>The business error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The data returned with the error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value is always 200 for successful requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
