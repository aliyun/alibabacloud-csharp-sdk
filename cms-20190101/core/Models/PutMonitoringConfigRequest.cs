// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMonitoringConfigRequest : TeaModel {
        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("AutoInstall")]
        [Validation(Required=false)]
        public bool? AutoInstall { get; set; }

        /// <summary>
        /// Specifies whether to automatically install the CloudMonitor agent on new ECS instances. Valid values:
        /// 
        /// *   true (default): The CloudMonitor agent is automatically installed on new ECS instances.
        /// *   false: The CloudMonitor agent is not automatically installed on new ECS instances.
        /// </summary>
        [NameInMap("EnableInstallAgentNewECS")]
        [Validation(Required=false)]
        public bool? EnableInstallAgentNewECS { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
