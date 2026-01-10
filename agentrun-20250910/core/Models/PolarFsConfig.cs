// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class PolarFsConfig : TeaModel {
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public int? GroupId { get; set; }

        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<PolarFsMountConfig> MountPoints { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public int? UserId { get; set; }

    }

}
