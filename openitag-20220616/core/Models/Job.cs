// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class Job : TeaModel {
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public SimpleUser Creator { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public JobJobResult JobResult { get; set; }
        public class JobJobResult : TeaModel {
            [NameInMap("ResultLink")]
            [Validation(Required=false)]
            public string ResultLink { get; set; }

        }

        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
