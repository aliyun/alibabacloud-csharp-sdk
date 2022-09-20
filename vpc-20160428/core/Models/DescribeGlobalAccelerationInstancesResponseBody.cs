// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeGlobalAccelerationInstancesResponseBody : TeaModel {
        [NameInMap("GlobalAccelerationInstances")]
        [Validation(Required=false)]
        public DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstances GlobalAccelerationInstances { get; set; }
        public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstances : TeaModel {
            [NameInMap("GlobalAccelerationInstance")]
            [Validation(Required=false)]
            public List<DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstance> GlobalAccelerationInstance { get; set; }
            public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstance : TeaModel {
                [NameInMap("AccelerationLocation")]
                [Validation(Required=false)]
                public string AccelerationLocation { get; set; }

                [NameInMap("BackendServers")]
                [Validation(Required=false)]
                public DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstanceBackendServers BackendServers { get; set; }
                public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstanceBackendServers : TeaModel {
                    [NameInMap("BackendServer")]
                    [Validation(Required=false)]
                    public List<DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstanceBackendServersBackendServer> BackendServer { get; set; }
                    public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstanceBackendServersBackendServer : TeaModel {
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("ServerId")]
                        [Validation(Required=false)]
                        public string ServerId { get; set; }

                        [NameInMap("ServerIpAddress")]
                        [Validation(Required=false)]
                        public string ServerIpAddress { get; set; }

                        [NameInMap("ServerType")]
                        [Validation(Required=false)]
                        public string ServerType { get; set; }

                    }

                }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("GlobalAccelerationInstanceId")]
                [Validation(Required=false)]
                public string GlobalAccelerationInstanceId { get; set; }

                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PublicIpAddresses")]
                [Validation(Required=false)]
                public DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstancePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstancePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=false)]
                    public List<DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstancePublicIpAddressesPublicIpAddress> PublicIpAddress { get; set; }
                    public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstancePublicIpAddressesPublicIpAddress : TeaModel {
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                    }

                }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ServiceLocation")]
                [Validation(Required=false)]
                public string ServiceLocation { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
