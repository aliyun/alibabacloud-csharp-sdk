// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ConfigHealthCheckRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("ForwardProtocol")]
        [Validation(Required=true)]
        public string ForwardProtocol { get; set; }

        [NameInMap("FrontendPort")]
        [Validation(Required=true)]
        public int? FrontendPort { get; set; }

        [NameInMap("HealthCheck")]
        [Validation(Required=true)]
        public string HealthCheck { get; set; }

    }

}
