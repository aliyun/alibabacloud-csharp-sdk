// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class DiduiAreaDeductionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The floor display area inference result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DiduiAreaDeductionResponseBodyData Data { get; set; }
        public class DiduiAreaDeductionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of downstream call attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Attempts")]
            [Validation(Required=false)]
            public int? Attempts { get; set; }

            /// <summary>
            /// <para>The workflow error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The downstream HTTP status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("HttpStatus")]
            [Validation(Required=false)]
            public int? HttpStatus { get; set; }

            /// <summary>
            /// <para>The downstream call latency, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("LatencyMs")]
            [Validation(Required=false)]
            public long? LatencyMs { get; set; }

            /// <summary>
            /// <para>The workflow description message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The model request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model_req_id_xx</para>
            /// </summary>
            [NameInMap("ModelRequestId")]
            [Validation(Required=false)]
            public string ModelRequestId { get; set; }

            /// <summary>
            /// <para>The business request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>643913D2-063F-599C-B3DF-B8D415CE171F</para>
            /// </summary>
            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            /// <summary>
            /// <para>The area calculation result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public DiduiAreaDeductionResponseBodyDataResult Result { get; set; }
            public class DiduiAreaDeductionResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The stage 4 area label.</para>
                /// </summary>
                [NameInMap("Stage4AreaLabel")]
                [Validation(Required=false)]
                public DiduiAreaDeductionResponseBodyDataResultStage4AreaLabel Stage4AreaLabel { get; set; }
                public class DiduiAreaDeductionResponseBodyDataResultStage4AreaLabel : TeaModel {
                    /// <summary>
                    /// <para>The floor display area, in square meters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.5334</para>
                    /// </summary>
                    [NameInMap("AreaM2")]
                    [Validation(Required=false)]
                    public double? AreaM2 { get; set; }

                    /// <summary>
                    /// <para>The left edge length, in meters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.025</para>
                    /// </summary>
                    [NameInMap("LeftEdgeM")]
                    [Validation(Required=false)]
                    public double? LeftEdgeM { get; set; }

                    /// <summary>
                    /// <para>The right edge length, in meters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.419</para>
                    /// </summary>
                    [NameInMap("RightEdgeM")]
                    [Validation(Required=false)]
                    public double? RightEdgeM { get; set; }

                }

            }

            /// <summary>
            /// <para>The workflow status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The workflow business status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The usage information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
