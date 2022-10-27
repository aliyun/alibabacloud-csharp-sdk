// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Mem")]
            [Validation(Required=false)]
            public int? Mem { get; set; }

            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

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

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
