// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteMonitoringAgentProcessRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The process ID.
        /// 
        /// > You must configure either `ProcessId` or `ProcessName`.
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// The process name.
        /// 
        /// > You must configure either `ProcessId` or `ProcessName`.
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
