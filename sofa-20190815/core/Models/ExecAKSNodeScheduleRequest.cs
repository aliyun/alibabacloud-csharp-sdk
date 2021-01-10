// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecAKSNodeScheduleRequest : TeaModel {
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<ExecAKSNodeScheduleRequestNodes> Nodes { get; set; }
        public class ExecAKSNodeScheduleRequestNodes : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

    }

}
