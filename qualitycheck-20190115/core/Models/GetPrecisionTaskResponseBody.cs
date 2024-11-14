// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetPrecisionTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPrecisionTaskResponseBodyData Data { get; set; }
        public class GetPrecisionTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1212</para>
            /// </summary>
            [NameInMap("DataSetId")]
            [Validation(Required=false)]
            public long? DataSetId { get; set; }

            [NameInMap("DataSetName")]
            [Validation(Required=false)]
            public string DataSetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3423</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("IncorrectWords")]
            [Validation(Required=false)]
            public int? IncorrectWords { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Precisions")]
            [Validation(Required=false)]
            public GetPrecisionTaskResponseBodyDataPrecisions Precisions { get; set; }
            public class GetPrecisionTaskResponseBodyDataPrecisions : TeaModel {
                [NameInMap("Precision")]
                [Validation(Required=false)]
                public List<GetPrecisionTaskResponseBodyDataPrecisionsPrecision> Precision { get; set; }
                public class GetPrecisionTaskResponseBodyDataPrecisionsPrecision : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2311</para>
                    /// </summary>
                    [NameInMap("ModelId")]
                    [Validation(Required=false)]
                    public long? ModelId { get; set; }

                    [NameInMap("ModelName")]
                    [Validation(Required=false)]
                    public string ModelName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.98</para>
                    /// </summary>
                    [NameInMap("Precision")]
                    [Validation(Required=false)]
                    public float? Precision { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>593A04C0-E6E9-4CDC-8C99-B120C******</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public int? Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7C1DEF5F-2C18-4D36-99C6-8C27*****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-03-10 20:26:29</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("VerifiedCount")]
            [Validation(Required=false)]
            public int? VerifiedCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24F4CE647</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
