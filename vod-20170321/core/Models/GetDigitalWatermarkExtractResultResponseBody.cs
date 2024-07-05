// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDigitalWatermarkExtractResultResponseBody : TeaModel {
        /// <summary>
        /// The details of the watermark extraction job.
        /// </summary>
        [NameInMap("AiExtractResultList")]
        [Validation(Required=false)]
        public List<GetDigitalWatermarkExtractResultResponseBodyAiExtractResultList> AiExtractResultList { get; set; }
        public class GetDigitalWatermarkExtractResultResponseBodyAiExtractResultList : TeaModel {
            /// <summary>
            /// The time when the watermark extraction job was created.
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
            /// The ID of the watermark extraction job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The time when the watermark extraction job was last updated.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The status of the watermark extraction job. Valid values:
            /// 
            /// *   **Success**
            /// *   **Failed**
            /// *   **Processing**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The extracted watermark content.
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
