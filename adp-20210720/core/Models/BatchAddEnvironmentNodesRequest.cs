// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class BatchAddEnvironmentNodesRequest : TeaModel {
        [NameInMap("instanceList")]
        [Validation(Required=false)]
        public List<InstanceInfo> InstanceList { get; set; }

        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

    }

}
