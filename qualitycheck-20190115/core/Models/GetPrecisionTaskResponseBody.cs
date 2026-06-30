// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetPrecisionTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates that the request was successful. Other values indicate that the request failed. Use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPrecisionTaskResponseBodyData Data { get; set; }
        public class GetPrecisionTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>If the source is a dataset, this is the dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1212</para>
            /// </summary>
            [NameInMap("DataSetId")]
            [Validation(Required=false)]
            public long? DataSetId { get; set; }

            /// <summary>
            /// <para>If the source is a dataset, this is the dataset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>数据集名称</para>
            /// </summary>
            [NameInMap("DataSetName")]
            [Validation(Required=false)]
            public string DataSetName { get; set; }

            /// <summary>
            /// <para>The total duration of the audio recording.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3423</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>The number of incorrectly transcribed words.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("IncorrectWords")]
            [Validation(Required=false)]
            public int? IncorrectWords { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>任务名称</para>
            /// </summary>
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

            /// <summary>
            /// <para>The source of the file. Possible values: 3: Dataset. 0: Call center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public int? Source { get; set; }

            /// <summary>
            /// <para>The task status. Possible values: 0: Transcribing. 1: Transcription complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7C1DEF5F-2C18-4D36-99C6-8C27*****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The total number of files in the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The time when the task was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-03-10 20:26:29</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The total number of verified files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("VerifiedCount")]
            [Validation(Required=false)]
            public int? VerifiedCount { get; set; }

        }

        /// <summary>
        /// <para>If the request fails, this field provides the error details. If the request is successful, the value is \<c>successful\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24F4CE647</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of \<c>true\\</c> indicates success. A value of \<c>false\\</c> or \<c>null\\</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
