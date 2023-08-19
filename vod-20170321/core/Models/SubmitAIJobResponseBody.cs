// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIJobResponseBody : TeaModel {
        /// <summary>
        /// The information about the AI jobs.
        /// </summary>
        [NameInMap("AIJobList")]
        [Validation(Required=false)]
        public SubmitAIJobResponseBodyAIJobList AIJobList { get; set; }
        public class SubmitAIJobResponseBodyAIJobList : TeaModel {
            [NameInMap("AIJob")]
            [Validation(Required=false)]
            public List<SubmitAIJobResponseBodyAIJobListAIJob> AIJob { get; set; }
            public class SubmitAIJobResponseBodyAIJobListAIJob : TeaModel {
                /// <summary>
                /// The ID of the AI job.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The ID of the video.
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// The type of the AI job. Valid values:
                /// 
                /// *   **AIMediaDNA**: The media fingerprinting job.
                /// *   **AIVideoTag**: The smart tagging job.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
