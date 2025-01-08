// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class GetContentDetectResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContentDetectResultResponseBodyData Data { get; set; }
        public class GetContentDetectResultResponseBodyData : TeaModel {
            [NameInMap("DetectResultList")]
            [Validation(Required=false)]
            public List<GetContentDetectResultResponseBodyDataDetectResultList> DetectResultList { get; set; }
            public class GetContentDetectResultResponseBodyDataDetectResultList : TeaModel {
                [NameInMap("RiskInfo")]
                [Validation(Required=false)]
                public string RiskInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskResult")]
                [Validation(Required=false)]
                public int? RiskResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ProcessedCount")]
            [Validation(Required=false)]
            public int? ProcessedCount { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
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
