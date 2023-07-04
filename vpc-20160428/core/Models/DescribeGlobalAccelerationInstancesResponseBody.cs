// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeGlobalAccelerationInstancesResponseBody : TeaModel {
        /// <summary>
        /// The details of the GA instances.
        /// </summary>
        [NameInMap("GlobalAccelerationInstances")]
        [Validation(Required=false)]
        public DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstances GlobalAccelerationInstances { get; set; }
        public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstances : TeaModel {
            [NameInMap("GlobalAccelerationInstance")]
            [Validation(Required=false)]
            public List<DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstance> GlobalAccelerationInstance { get; set; }
            public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstance : TeaModel {
                /// <summary>
                /// The acceleration area of the GA instance.
                /// </summary>
                [NameInMap("AccelerationLocation")]
                [Validation(Required=false)]
                public string AccelerationLocation { get; set; }

                /// <summary>
                /// The details about the backend servers of the GA instance.
                /// </summary>
                [NameInMap("BackendServers")]
                [Validation(Required=false)]
                public DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstanceBackendServers BackendServers { get; set; }
                public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstanceBackendServers : TeaModel {
                    [NameInMap("BackendServer")]
                    [Validation(Required=false)]
                    public List<DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstanceBackendServersBackendServer> BackendServer { get; set; }
                    public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstanceBackendServersBackendServer : TeaModel {
                        /// <summary>
                        /// The region where the backend servers are deployed.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The ID of the backend server.
                        /// </summary>
                        [NameInMap("ServerId")]
                        [Validation(Required=false)]
                        public string ServerId { get; set; }

                        /// <summary>
                        /// The IP address of the backend server.
                        /// </summary>
                        [NameInMap("ServerIpAddress")]
                        [Validation(Required=false)]
                        public string ServerIpAddress { get; set; }

                        /// <summary>
                        /// The type of the backend server.
                        /// 
                        /// *   **EcsInstance**: Elastic Compute Service (ECS) instance
                        /// *   **SlbInstance**: Server Load Balancer (SLB) instance
                        /// </summary>
                        [NameInMap("ServerType")]
                        [Validation(Required=false)]
                        public string ServerType { get; set; }

                    }

                }

                /// <summary>
                /// The maximum bandwidth of the GA instance.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// The bandwidth type of the GA instance.
                /// 
                /// *   **Sharing**
                /// *   **Exclusive** (default)
                /// </summary>
                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }

                /// <summary>
                /// The billing method of the GA instance.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The time when the GA instance was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the GA instance.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the instance expires.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The ID of the GA instance.
                /// </summary>
                [NameInMap("GlobalAccelerationInstanceId")]
                [Validation(Required=false)]
                public string GlobalAccelerationInstanceId { get; set; }

                /// <summary>
                /// The billing method of the GA instance.
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// The public IP address of the dedicated GA instance.
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// The name of the GA instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The public IP address.
                /// </summary>
                [NameInMap("PublicIpAddresses")]
                [Validation(Required=false)]
                public DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstancePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstancePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddress")]
                    [Validation(Required=false)]
                    public List<DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstancePublicIpAddressesPublicIpAddress> PublicIpAddress { get; set; }
                    public class DescribeGlobalAccelerationInstancesResponseBodyGlobalAccelerationInstancesGlobalAccelerationInstancePublicIpAddressesPublicIpAddress : TeaModel {
                        /// <summary>
                        /// The ID of the public IP address of the GA instance.
                        /// </summary>
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        /// <summary>
                        /// The public IP address of the GA instance.
                        /// </summary>
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                    }

                }

                /// <summary>
                /// The region ID of the GA instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The service area of the GA instance.
                /// </summary>
                [NameInMap("ServiceLocation")]
                [Validation(Required=false)]
                public string ServiceLocation { get; set; }

                /// <summary>
                /// The status of the GA instance.
                /// 
                /// *   **Available**
                /// *   **Inuse**
                /// *   **Associating**
                /// *   **Unassociating**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
