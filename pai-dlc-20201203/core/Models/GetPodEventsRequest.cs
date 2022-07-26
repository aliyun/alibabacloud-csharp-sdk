// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetPodEventsRequest : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("MaxEventsNum")]
        [Validation(Required=false)]
        public int? MaxEventsNum { get; set; }

        [NameInMap("PodUid")]
        [Validation(Required=false)]
        public string PodUid { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
