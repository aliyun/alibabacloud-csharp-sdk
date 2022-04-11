// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMediaRefreshJobsResponseBody : TeaModel {
        [NameInMap("MediaRefreshJobs")]
        [Validation(Required=false)]
        public List<GetMediaRefreshJobsResponseBodyMediaRefreshJobs> MediaRefreshJobs { get; set; }
        public class GetMediaRefreshJobsResponseBodyMediaRefreshJobs : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("FilterPolicy")]
            [Validation(Required=false)]
            public string FilterPolicy { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("MediaRefreshJobId")]
            [Validation(Required=false)]
            public string MediaRefreshJobId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SuccessPlayUrls")]
            [Validation(Required=false)]
            public string SuccessPlayUrls { get; set; }

            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public string TaskIds { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
