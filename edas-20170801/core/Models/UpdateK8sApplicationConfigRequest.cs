// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sApplicationConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can query the application ID by calling the ListApplication operation. For more information, see [ListApplication](~~423162~~).
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the cluster. You can query the cluster ID by calling the ListCluster operation. For more information, see [ListCluster](~~411844~~).
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The maximum number of CPU cores allowed for each application instance when the application is running. The value 0 indicates that no limit is set on CPU cores.
        /// </summary>
        [NameInMap("CpuLimit")]
        [Validation(Required=false)]
        public string CpuLimit { get; set; }

        /// <summary>
        /// The number of CPU cores requested for each application instance when the application is running. Unit: cores. We recommend that you set this parameter. The value 0 indicates that no limit is set on CPU cores.
        /// 
        /// > You must set this parameter together with the CpuLimit parameter. Make sure that the value of this parameter does not exceed that of the CpuLimit parameter.
        /// </summary>
        [NameInMap("CpuRequest")]
        [Validation(Required=false)]
        public string CpuRequest { get; set; }

        /// <summary>
        /// The maximum size of space required by ephemeral storage. Unit: GB. The value 0 indicates that no limit is set on the ephemeral storage space.
        /// </summary>
        [NameInMap("EphemeralStorageLimit")]
        [Validation(Required=false)]
        public string EphemeralStorageLimit { get; set; }

        /// <summary>
        /// The minimum size of space required by ephemeral storage. Unit: GB. The value 0 indicates that no limit is set on the ephemeral storage space.
        /// 
        /// > You must set this parameter together with the EphemeralStorageLimit parameter. Make sure that the value of this parameter does not exceed that of the EphemeralStorageLimit parameter.
        /// </summary>
        [NameInMap("EphemeralStorageRequest")]
        [Validation(Required=false)]
        public string EphemeralStorageRequest { get; set; }

        /// <summary>
        /// The maximum number of CPU cores allowed. The value 0 indicates that no limit is set on CPU cores.
        /// </summary>
        [NameInMap("McpuLimit")]
        [Validation(Required=false)]
        public string McpuLimit { get; set; }

        /// <summary>
        /// The minimum number of CPU cores required. Unit: cores. The value 0 indicates that no limit is set on CPU cores.
        /// 
        /// > You must set this parameter together with the CpuLimit parameter. Make sure that the value of this parameter does not exceed that of the CpuLimit parameter.
        /// </summary>
        [NameInMap("McpuRequest")]
        [Validation(Required=false)]
        public string McpuRequest { get; set; }

        /// <summary>
        /// The maximum size of memory allowed for each application instance when the application is running. Unit: MB. The value 0 indicates that no limit is set on the memory size.
        /// </summary>
        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public string MemoryLimit { get; set; }

        /// <summary>
        /// The size of memory requested for each application instance when the application is running. Unit: MB. We recommend that you set this parameter. If you do not want to apply for a memory quota, set this parameter to 0.
        /// 
        /// > You must set this parameter together with the MemoryLimit parameter. Make sure that the value of this parameter does not exceed that of the MemoryLimit parameter.
        /// </summary>
        [NameInMap("MemoryRequest")]
        [Validation(Required=false)]
        public string MemoryRequest { get; set; }

        /// <summary>
        /// The timeout period of the change process. Valid values: 1 to 1800. Default value: 600. Unit: seconds.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
