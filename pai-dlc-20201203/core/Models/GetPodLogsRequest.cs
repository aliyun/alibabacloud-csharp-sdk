// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetPodLogsRequest : TeaModel {
        [NameInMap("DownloadToFile")]
        [Validation(Required=false)]
        public bool? DownloadToFile { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("MaxLines")]
        [Validation(Required=false)]
        public int? MaxLines { get; set; }

        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
