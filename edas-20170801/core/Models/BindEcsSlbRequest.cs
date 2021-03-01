// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class BindEcsSlbRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        [NameInMap("DeployGroupId")]
        [Validation(Required=false)]
        public string DeployGroupId { get; set; }

        [NameInMap("VServerGroupName")]
        [Validation(Required=false)]
        public string VServerGroupName { get; set; }

        [NameInMap("ListenerHealthCheckUrl")]
        [Validation(Required=false)]
        public string ListenerHealthCheckUrl { get; set; }

        [NameInMap("VForwardingUrlRule")]
        [Validation(Required=false)]
        public string VForwardingUrlRule { get; set; }

    }

}
