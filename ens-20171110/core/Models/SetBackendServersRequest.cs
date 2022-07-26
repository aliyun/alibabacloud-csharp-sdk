// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetBackendServersRequest : TeaModel {
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<SetBackendServersRequestBackendServers> BackendServers { get; set; }
        public class SetBackendServersRequestBackendServers : TeaModel {
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
