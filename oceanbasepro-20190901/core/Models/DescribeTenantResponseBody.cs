// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public DescribeTenantResponseBodyTenant Tenant { get; set; }
        public class DescribeTenantResponseBodyTenant : TeaModel {
            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            [NameInMap("ClogServiceStatus")]
            [Validation(Required=false)]
            public string ClogServiceStatus { get; set; }

            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

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

            [NameInMap("EnableClogService")]
            [Validation(Required=false)]
            public bool? EnableClogService { get; set; }

            [NameInMap("EnableInternetAddressService")]
            [Validation(Required=false)]
            public bool? EnableInternetAddressService { get; set; }

            [NameInMap("MasterIntranetAddressZone")]
            [Validation(Required=false)]
            public string MasterIntranetAddressZone { get; set; }

            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            [NameInMap("PrimaryZoneDeployType")]
            [Validation(Required=false)]
            public string PrimaryZoneDeployType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TenantConnections")]
            [Validation(Required=false)]
            public List<DescribeTenantResponseBodyTenantTenantConnections> TenantConnections { get; set; }
            public class DescribeTenantResponseBodyTenantTenantConnections : TeaModel {
                [NameInMap("ConnectionRole")]
                [Validation(Required=false)]
                public string ConnectionRole { get; set; }

                [NameInMap("ConnectionZones")]
                [Validation(Required=false)]
                public List<string> ConnectionZones { get; set; }

                [NameInMap("InternetAddress")]
                [Validation(Required=false)]
                public string InternetAddress { get; set; }

                [NameInMap("InternetAddressStatus")]
                [Validation(Required=false)]
                public string InternetAddressStatus { get; set; }

                [NameInMap("InternetPort")]
                [Validation(Required=false)]
                public int? InternetPort { get; set; }

                [NameInMap("IntranetAddress")]
                [Validation(Required=false)]
                public string IntranetAddress { get; set; }

                [NameInMap("IntranetAddressMasterZoneId")]
                [Validation(Required=false)]
                public string IntranetAddressMasterZoneId { get; set; }

                [NameInMap("IntranetAddressSlaveZoneId")]
                [Validation(Required=false)]
                public string IntranetAddressSlaveZoneId { get; set; }

                [NameInMap("IntranetAddressStatus")]
                [Validation(Required=false)]
                public string IntranetAddressStatus { get; set; }

                [NameInMap("IntranetPort")]
                [Validation(Required=false)]
                public int? IntranetPort { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            [NameInMap("TenantResource")]
            [Validation(Required=false)]
            public DescribeTenantResponseBodyTenantTenantResource TenantResource { get; set; }
            public class DescribeTenantResponseBodyTenantTenantResource : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceCpu Cpu { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceCpu : TeaModel {
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public float? TotalCpu { get; set; }

                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public float? UnitCpu { get; set; }

                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public float? UsedCpu { get; set; }

                }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceDiskSize DiskSize { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceDiskSize : TeaModel {
                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public float? UsedDiskSize { get; set; }

                }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceMemory Memory { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceMemory : TeaModel {
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public float? TotalMemory { get; set; }

                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public float? UnitMemory { get; set; }

                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public float? UsedMemory { get; set; }

                }

                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public int? UnitNum { get; set; }

            }

            [NameInMap("TenantZones")]
            [Validation(Required=false)]
            public List<DescribeTenantResponseBodyTenantTenantZones> TenantZones { get; set; }
            public class DescribeTenantResponseBodyTenantTenantZones : TeaModel {
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("TenantZoneId")]
                [Validation(Required=false)]
                public string TenantZoneId { get; set; }

                [NameInMap("TenantZoneRole")]
                [Validation(Required=false)]
                public string TenantZoneRole { get; set; }

            }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
