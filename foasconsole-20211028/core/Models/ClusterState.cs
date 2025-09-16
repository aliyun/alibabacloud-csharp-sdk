// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ClusterState : TeaModel {
        [NameInMap("ClusterStage")]
        [Validation(Required=false)]
        public ClusterStage ClusterStage { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

    }

}
