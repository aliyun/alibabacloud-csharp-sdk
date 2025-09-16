// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ClusterStage : TeaModel {
        [NameInMap("CurrentStage")]
        [Validation(Required=false)]
        public int? CurrentStage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TotalStageWithWeight")]
        [Validation(Required=false)]
        public List<StageWithWeight> TotalStageWithWeight { get; set; }

    }

}
