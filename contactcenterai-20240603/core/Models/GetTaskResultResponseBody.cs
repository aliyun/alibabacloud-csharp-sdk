// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class GetTaskResultResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTaskResultResponseBodyData Data { get; set; }
        public class GetTaskResultResponseBodyData : TeaModel {
            [NameInMap("asrResult")]
            [Validation(Required=false)]
            public List<GetTaskResultResponseBodyDataAsrResult> AsrResult { get; set; }
            public class GetTaskResultResponseBodyDataAsrResult : TeaModel {
                [NameInMap("begin")]
                [Validation(Required=false)]
                public long? Begin { get; set; }

                [NameInMap("emotionValue")]
                [Validation(Required=false)]
                public int? EmotionValue { get; set; }

                [NameInMap("end")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("speechRate")]
                [Validation(Required=false)]
                public int? SpeechRate { get; set; }

                [NameInMap("words")]
                [Validation(Required=false)]
                public string Words { get; set; }

            }

            [NameInMap("taskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20240905-********-93E9-5D45-B4EF-045743A34071</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINISH</para>
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>968A8634-FA2C-5381-9B3E-C552DED7E8BF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
