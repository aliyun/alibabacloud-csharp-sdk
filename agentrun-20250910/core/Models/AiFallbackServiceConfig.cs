// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AiFallbackServiceConfig : TeaModel {
        [NameInMap("passThroughModelName")]
        [Validation(Required=false)]
        public bool? PassThroughModelName { get; set; }

        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("targetModelName")]
        [Validation(Required=false)]
        public string TargetModelName { get; set; }

    }

}
