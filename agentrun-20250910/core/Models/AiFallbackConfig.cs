// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AiFallbackConfig : TeaModel {
        [NameInMap("serviceConfigs")]
        [Validation(Required=false)]
        public List<AiFallbackServiceConfig> ServiceConfigs { get; set; }

    }

}
