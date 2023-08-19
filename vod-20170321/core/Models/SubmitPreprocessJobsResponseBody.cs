// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitPreprocessJobsResponseBody : TeaModel {
        /// <summary>
        /// The job information.
        /// </summary>
        [NameInMap("PreprocessJobs")]
        [Validation(Required=false)]
        public SubmitPreprocessJobsResponseBodyPreprocessJobs PreprocessJobs { get; set; }
        public class SubmitPreprocessJobsResponseBodyPreprocessJobs : TeaModel {
            [NameInMap("PreprocessJob")]
            [Validation(Required=false)]
            public List<SubmitPreprocessJobsResponseBodyPreprocessJobsPreprocessJob> PreprocessJob { get; set; }
            public class SubmitPreprocessJobsResponseBodyPreprocessJobsPreprocessJob : TeaModel {
                /// <summary>
                /// The ID of the job.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

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
