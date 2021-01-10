// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class StopCasLoadbalanceListenerRequest : TeaModel {
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public long? ListenerPort { get; set; }

        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
