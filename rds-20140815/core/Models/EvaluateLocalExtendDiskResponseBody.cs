// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class EvaluateLocalExtendDiskResponseBody : TeaModel {
        /// <summary>
        /// Specifies whether to query the virtual IP addresses of only healthy CDN POPs. Valid values:
        /// 
        /// *   **on**: healthy CDN edge nodes.
        /// *   **off**: all CDN edge nodes.
        /// </summary>
        [NameInMap("Available")]
        [Validation(Required=false)]
        public string Available { get; set; }

        /// <summary>
        /// The ID of the RDS instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The data migration method of the instance. This parameter is available only for instances that are created in dedicated clusters. Valid values:
        /// 
        /// *   **0** (default): The system preferentially upgrades or downgrades the instance without a migration. If the resources on the host on which the instance resides are insufficient, the system migrates the instance to another suitable host.
        /// *   **1**: The system upgrades or downgrades the instance without a migration. If the upgrade or downgrade is not supported, the system reports an error.
        /// *   **2**: The system migrates the data of the instance from the host on which the instance resides to another host. You must also specify **DedicatedHostGroupId**, **TargetDedicatedHostIdForMaster**, and **TargetDedicatedHostIdForSlave**. If you set DBInstanceTransType to 2, you cannot migrate the data of the instance to the host on which the instance resides. If you migrate the data of the instance to the host on which the instance resides, the migration fails.
        /// </summary>
        [NameInMap("DBInstanceTransType")]
        [Validation(Required=false)]
        public string DBInstanceTransType { get; set; }

        /// <summary>
        /// Local Disk Restrictions.
        /// </summary>
        [NameInMap("LocalUpgradeDiskLimit")]
        [Validation(Required=false)]
        public long? LocalUpgradeDiskLimit { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
