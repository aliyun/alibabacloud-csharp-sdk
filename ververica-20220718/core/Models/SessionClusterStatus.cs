// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SessionClusterStatus : TeaModel {
        [NameInMap("currentSessionClusterStatus")]
        [Validation(Required=false)]
        public string CurrentSessionClusterStatus { get; set; }

        [NameInMap("failure")]
        [Validation(Required=false)]
        public SessionClusterFailureInfo Failure { get; set; }

        [NameInMap("running")]
        [Validation(Required=false)]
        public SessionClusterRunningInfo Running { get; set; }

    }

}
