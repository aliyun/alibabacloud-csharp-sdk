// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetPodLogsResponseBody : TeaModel {
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<string> Logs { get; set; }

        [NameInMap("PodId")]
        [Validation(Required=false)]
        public string PodId { get; set; }

        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
