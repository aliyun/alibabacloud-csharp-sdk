// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of tenants.
        /// </summary>
        [NameInMap("Tenants")]
        [Validation(Required=false)]
        public List<DescribeTenantsResponseBodyTenants> Tenants { get; set; }
        public class DescribeTenantsResponseBodyTenants : TeaModel {
            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

            /// <summary>
            /// The total number of CPU cores of the tenant.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The time when the tenant was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The data replica distribution mode of the tenant.   
            /// 
            /// - For the high availability version, N-N-N indicates the three-zone mode, and N-N indicates the dual-zone or single-zone mode.
            /// - For the basic version, N indicates the single-zone mode. 
            /// 
            /// > <br>N represents the number of nodes in a single zone.
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// The deployment type of the tenant. <br>
            /// - multiple: multi-IDC deployment
            /// - single: single-IDC deployment
            /// - dual: dual-IDC deployment
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// The description of the tenant.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The total memory size of the tenant, in GB.
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// The primary zone of the tenant.
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            /// <summary>
            /// The status of the tenant.  <br>
            /// - PENDING_CREATE: The tenant is being created.
            /// - RESTORE: The tenant is being recovered.
            /// - ONLINE: The tenant is running.
            /// - SPEC_MODIFYING: The specification of the tenant is being modified.
            /// ALLOCATING_INTERNET_ADDRESS: An Internet address is being allocated.
            /// PENDING_OFFLINE_INTERNET_ADDRESS: The Internet address is being disabled.
            /// - PRIMARY_ZONE_MODIFYING: The tenant is switching to a new primary zone.
            /// - PARAMETER_MODIFYING: Parameters are being modified.
            /// - WHITE_LIST_MODIFYING: The whitelist is being modified.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// The tenant mode.   
            /// Valid values:   
            /// Oracle
            /// MySQL
            /// </summary>
            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

            /// <summary>
            /// The name of the tenant.
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// The number of CPU cores in each resource unit of the tenant.
            /// </summary>
            [NameInMap("UnitCpu")]
            [Validation(Required=false)]
            public int? UnitCpu { get; set; }

            /// <summary>
            /// The memory size of each resource unit of the tenant, in GB.
            /// </summary>
            [NameInMap("UnitMem")]
            [Validation(Required=false)]
            public int? UnitMem { get; set; }

            /// <summary>
            /// The number of resource units in the tenant.
            /// </summary>
            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public int? UnitNum { get; set; }

            /// <summary>
            /// The number of used disks of the tenant.
            /// </summary>
            [NameInMap("UsedDiskSize")]
            [Validation(Required=false)]
            public double? UsedDiskSize { get; set; }

            /// <summary>
            /// The ID of the VPC.   <br>If no suitable VPC is available, create a VPC as prompted. For more information, see "What is a VPC".
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The total number of tenants in the specified OceanBase cluster.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
