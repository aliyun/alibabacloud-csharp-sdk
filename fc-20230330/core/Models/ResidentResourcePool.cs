// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ResidentResourcePool : TeaModel {
        /// <summary>
        /// <para>The real-time allocation status of the resource pool, including the specific allocation details for each function.</para>
        /// </summary>
        [NameInMap("allocationStatus")]
        [Validation(Required=false)]
        public ResidentResourceAllocationStatus AllocationStatus { get; set; }

        [NameInMap("associatedPoolId")]
        [Validation(Required=false)]
        public string AssociatedPoolId { get; set; }

        /// <summary>
        /// <para>The resource property field that represents the creation time.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The expiration time of the resource pool.</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The last modification time, including operations such as scaling, renewal, and renaming.</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("poolType")]
        [Validation(Required=false)]
        public string PoolType { get; set; }

        [NameInMap("residentResourcePoolId")]
        [Validation(Required=false)]
        public string ResidentResourcePoolId { get; set; }

        /// <summary>
        /// <para>The resource property field that represents the resource name.</para>
        /// </summary>
        [NameInMap("residentResourcePoolName")]
        [Validation(Required=false)]
        public string ResidentResourcePoolName { get; set; }

        /// <summary>
        /// <para>The overall specifications of the resource pool.</para>
        /// </summary>
        [NameInMap("resourcePoolCapacity")]
        [Validation(Required=false)]
        public ResidentResourceCapacity ResourcePoolCapacity { get; set; }

        [NameInMap("resourcePoolConfig")]
        [Validation(Required=false)]
        public ResidentResourceCapacity ResourcePoolConfig { get; set; }

        [NameInMap("timedConfig")]
        [Validation(Required=false)]
        public TimedPoolConfig TimedConfig { get; set; }

    }

}
