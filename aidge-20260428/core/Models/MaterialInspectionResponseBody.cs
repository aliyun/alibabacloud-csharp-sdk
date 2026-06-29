// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MaterialInspectionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public MaterialInspectionResponseBodyData Data { get; set; }
        public class MaterialInspectionResponseBodyData : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public MaterialInspectionResponseBodyDataResult Result { get; set; }
            public class MaterialInspectionResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1项规则：1 PASS，所有检测项合规</para>
                /// </summary>
                [NameInMap("Evidence")]
                [Validation(Required=false)]
                public string Evidence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PASS</para>
                /// </summary>
                [NameInMap("OverallResult")]
                [Validation(Required=false)]
                public string OverallResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>req-001</para>
                /// </summary>
                [NameInMap("ReqId")]
                [Validation(Required=false)]
                public string ReqId { get; set; }

                [NameInMap("Steps")]
                [Validation(Required=false)]
                public List<MaterialInspectionResponseBodyDataResultSteps> Steps { get; set; }
                public class MaterialInspectionResponseBodyDataResultSteps : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PASS</para>
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("StepId")]
                    [Validation(Required=false)]
                    public string StepId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Stamp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
