// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadMediaByURLResponseBody : TeaModel {
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

            [NameInMap("SourceURL")]
            [Validation(Required=false)]
            public string SourceURL { get; set; }

        }

    }

}
