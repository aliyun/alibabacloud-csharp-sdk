// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
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
            /// The number of CPU cores in each resource unit of the tenant.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The search keyword.
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// The name of the tenant.   
            /// It must start with a letter or an underscore (_), and contain 2 to 20 characters, which can be uppercase letters, lowercase letters, digits, and underscores (_).  It cannot be set to sys.
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// Example 1
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The number of the page to return.   
            /// Start value: 1
            /// - Default value: 1
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            /// <summary>
            /// The return result of the request.
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
            /// You can call this operation to query the tenants in an OceanBase cluster.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// {
            ///     "TotalCount": 1,
            ///     "RequestId": "EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C",
            ///     "Tenants": [
            ///         {
            ///             "VpcId": "vpc-bp1d2q3mhg9i23ofi****",
            ///             "Status": "ONLINE",
            ///             "PrimaryZone": "cn-hangzhou-i",
            ///             "DeployType": "multiple",
            ///             "DeployMode": "1-1-1",
            ///             "CreateTime": "2021-09-17 15:52:17.0",
            ///             "TenantName": "pay_online",
            ///             "Mem": 20,
            ///             "Cpu": 10,
            ///             "Description": "PayCore business database",
            ///             "TenantMode": "Oracle",
            ///             "TenantId": "t33h8y08k****",
            ///             "UnitCpu": 5,
            ///             "UnitMem": 10,
            ///             "UnitNum": 2,
            ///             "UsedDiskSize": 10
            ///         }
            ///     ]
            /// }
            /// </summary>
            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

            /// <summary>
            /// The information of tenants.
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            [NameInMap("UnitCpu")]
            [Validation(Required=false)]
            public int? UnitCpu { get; set; }

            [NameInMap("UnitMem")]
            [Validation(Required=false)]
            public int? UnitMem { get; set; }

            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public int? UnitNum { get; set; }

            [NameInMap("UsedDiskSize")]
            [Validation(Required=false)]
            public double? UsedDiskSize { get; set; }

            /// <summary>
            /// The time when the tenant was created.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The total memory size of the tenant, in GB.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
