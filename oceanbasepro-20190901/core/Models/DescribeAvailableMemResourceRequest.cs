// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableMemResourceRequest : TeaModel {
        /// <summary>
        /// The number of CPU cores.
        /// </summary>
        [NameInMap("CpuNum")]
        [Validation(Required=false)]
        public long? CpuNum { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The number of resource distribution nodes in the tenant.   
        /// The number is determined by the deployment mode of the cluster. If the cluster is deployed in 2-2-2 mode, the maximum number of resource distribution nodes is 2.
        /// </summary>
        [NameInMap("UnitNum")]
        [Validation(Required=false)]
        public long? UnitNum { get; set; }

    }

}
