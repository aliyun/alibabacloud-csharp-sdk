// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadMediaByURLResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about one or more upload jobs.
        /// </summary>
        [NameInMap("UploadJobs")]
        [Validation(Required=false)]
        public List<UploadMediaByURLResponseBodyUploadJobs> UploadJobs { get; set; }
        public class UploadMediaByURLResponseBodyUploadJobs : TeaModel {
            /// <summary>
            /// The ID of the upload job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The URL of the source file that is uploaded in the upload job.
            /// </summary>
            [NameInMap("SourceURL")]
            [Validation(Required=false)]
            public string SourceURL { get; set; }

        }

    }

}
