// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GatewayLogConfig : TeaModel {
        [NameInMap("slsConfig")]
        [Validation(Required=false)]
        public GatewayLogConfigSlsConfig SlsConfig { get; set; }
        public class GatewayLogConfigSlsConfig : TeaModel {
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

    }

}
