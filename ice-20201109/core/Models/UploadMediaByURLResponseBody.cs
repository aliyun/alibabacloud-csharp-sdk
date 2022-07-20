// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UploadMediaByURLResponseBody : TeaModel {
        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UploadJobs")]
        [Validation(Required=false)]
        public List<UploadMediaByURLResponseBodyUploadJobs> UploadJobs { get; set; }
        public class UploadMediaByURLResponseBodyUploadJobs : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("SourceURL")]
            [Validation(Required=false)]
            public string SourceURL { get; set; }

        }

    }

}
