// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MaterialInspectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is not returned for successful calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The material display detection result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MaterialInspectionResponseBodyData Data { get; set; }
        public class MaterialInspectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The inspection result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public MaterialInspectionResponseBodyDataResult Result { get; set; }
            public class MaterialInspectionResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The natural language summary, such as &quot;1 rule: 1 PASS, all inspection items are compliant.&quot;</para>
                /// 
                /// <b>Example:</b>
                /// <para>1项规则：1 PASS，所有检测项合规</para>
                /// </summary>
                [NameInMap("Evidence")]
                [Validation(Required=false)]
                public string Evidence { get; set; }

                /// <summary>
                /// <para>The overall result. Valid values: PASS and FAIL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PASS</para>
                /// </summary>
                [NameInMap("OverallResult")]
                [Validation(Required=false)]
                public string OverallResult { get; set; }

                /// <summary>
                /// <para>The request ID returned as-is from the input.</para>
                /// 
                /// <b>Example:</b>
                /// <para>req-001</para>
                /// </summary>
                [NameInMap("ReqId")]
                [Validation(Required=false)]
                public string ReqId { get; set; }

                /// <summary>
                /// <para>The list of detection steps.</para>
                /// </summary>
                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<MaterialInspectionResponseBodyDataResultSteps> Steps { get; set; }
                public class MaterialInspectionResponseBodyDataResultSteps : TeaModel {
                    /// <summary>
                    /// <para>The step result. Valid values: PASS, FAIL, and UNABLE_TO_JUDGE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PASS</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <para>The step ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("StepId")]
                    [Validation(Required=false)]
                    public string StepId { get; set; }

                }

                /// <summary>
                /// <para>The detection type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Stamp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The usage information. The key is the usage metric name and the value is the count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned for successful calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
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
        /// <para>Indicates whether the call was successful. Valid values: true: The call was successful. false: The call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
