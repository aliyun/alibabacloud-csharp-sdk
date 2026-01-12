// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class StartupDependency : TeaModel {
        [NameInMap("MinReplicas")]
        [Validation(Required=false)]
        public string MinReplicas { get; set; }

        [NameInMap("OnPhase")]
        [Validation(Required=false)]
        public string OnPhase { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
