// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiPluginStatus : TeaModel {
        [NameInMap("errorLogs")]
        [Validation(Required=false)]
        public Dictionary<string, string> ErrorLogs { get; set; }

        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        [NameInMap("serviceHealthy")]
        [Validation(Required=false)]
        public bool? ServiceHealthy { get; set; }

    }

}
