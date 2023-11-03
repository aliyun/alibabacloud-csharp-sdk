// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDigitalWatermarkExtractResultResponseBody : TeaModel {
        /// <summary>
        /// The information about the job.
        /// </summary>
        [NameInMap("AiExtractResultList")]
        [Validation(Required=false)]
        public List<GetDigitalWatermarkExtractResultResponseBodyAiExtractResultList> AiExtractResultList { get; set; }
        public class GetDigitalWatermarkExtractResultResponseBodyAiExtractResultList : TeaModel {
            /// <summary>
            /// The time when the job was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The ID of the job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The time when the job was modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The status of the job. Valid values:
            /// 
            /// *   **Success**
            /// *   **Failed**
            /// *   **Processing**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The extracted watermark text.
            /// </summary>
            [NameInMap("WaterMarkText")]
            [Validation(Required=false)]
            public string WaterMarkText { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
