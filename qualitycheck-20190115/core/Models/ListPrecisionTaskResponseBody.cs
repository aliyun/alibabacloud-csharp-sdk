// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListPrecisionTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPrecisionTaskResponseBodyData Data { get; set; }
        public class ListPrecisionTaskResponseBodyData : TeaModel {
            [NameInMap("PrecisionTask")]
            [Validation(Required=false)]
            public List<ListPrecisionTaskResponseBodyDataPrecisionTask> PrecisionTask { get; set; }
            public class ListPrecisionTaskResponseBodyDataPrecisionTask : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DataSetId")]
                [Validation(Required=false)]
                public long? DataSetId { get; set; }

                [NameInMap("DataSetName")]
                [Validation(Required=false)]
                public string DataSetName { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("IncorrectWords")]
                [Validation(Required=false)]
                public int? IncorrectWords { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Precisions")]
                [Validation(Required=false)]
                public ListPrecisionTaskResponseBodyDataPrecisionTaskPrecisions Precisions { get; set; }
                public class ListPrecisionTaskResponseBodyDataPrecisionTaskPrecisions : TeaModel {
                    [NameInMap("Precision")]
                    [Validation(Required=false)]
                    public List<ListPrecisionTaskResponseBodyDataPrecisionTaskPrecisionsPrecision> Precision { get; set; }
                    public class ListPrecisionTaskResponseBodyDataPrecisionTaskPrecisionsPrecision : TeaModel {
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        [NameInMap("ModelId")]
                        [Validation(Required=false)]
                        public long? ModelId { get; set; }

                        [NameInMap("ModelName")]
                        [Validation(Required=false)]
                        public string ModelName { get; set; }

                        [NameInMap("Precision")]
                        [Validation(Required=false)]
                        public float? Precision { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                    }

                }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public int? Source { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("VerifiedCount")]
                [Validation(Required=false)]
                public int? VerifiedCount { get; set; }

            }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
