// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitTranscodeJobsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The transcoding jobs.
        /// > This parameter is not returned for HLS packaging tasks. You must asynchronously receive the transcoding result.
        /// </summary>
        [NameInMap("TranscodeJobs")]
        [Validation(Required=false)]
        public SubmitTranscodeJobsResponseBodyTranscodeJobs TranscodeJobs { get; set; }
        public class SubmitTranscodeJobsResponseBodyTranscodeJobs : TeaModel {
            [NameInMap("TranscodeJob")]
            [Validation(Required=false)]
            public List<SubmitTranscodeJobsResponseBodyTranscodeJobsTranscodeJob> TranscodeJob { get; set; }
            public class SubmitTranscodeJobsResponseBodyTranscodeJobsTranscodeJob : TeaModel {
                /// <summary>
                /// The ID of the job.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the transcoding job that was submitted.
        /// </summary>
        [NameInMap("TranscodeTaskId")]
        [Validation(Required=false)]
        public string TranscodeTaskId { get; set; }

    }

}
