// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeGlobalAccelerationInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the GA instances.</para>
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
                /// <para>The acceleration area of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>china-mainland</para>
                /// </summary>
                [NameInMap("AccelerationLocation")]
                [Validation(Required=false)]
                public string AccelerationLocation { get; set; }

                /// <summary>
                /// <para>The details about the backend servers of the GA instance.</para>
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
                        /// <para>The region where the backend servers are deployed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-beijing</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The ID of the backend server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-2zeg83zvn5d4ed4y****</para>
                        /// </summary>
                        [NameInMap("ServerId")]
                        [Validation(Required=false)]
                        public string ServerId { get; set; }

                        /// <summary>
                        /// <para>The IP address of the backend server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>172.xx.xx.109</para>
                        /// </summary>
                        [NameInMap("ServerIpAddress")]
                        [Validation(Required=false)]
                        public string ServerIpAddress { get; set; }

                        /// <summary>
                        /// <para>The type of the backend server.</para>
                        /// <list type="bullet">
                        /// <item><description><b>EcsInstance</b>: Elastic Compute Service (ECS) instance</description></item>
                        /// <item><description><b>SlbInstance</b>: Server Load Balancer (SLB) instance</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EcsInstance</para>
                        /// </summary>
                        [NameInMap("ServerType")]
                        [Validation(Required=false)]
                        public string ServerType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The maximum bandwidth of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                /// <summary>
                /// <para>The bandwidth type of the GA instance.</para>
                /// <list type="bullet">
                /// <item><description><b>Sharing</b></description></item>
                /// <item><description><b>Exclusive</b> (default)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Exclusive</para>
                /// </summary>
                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }

                /// <summary>
                /// <para>The billing method of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The time when the GA instance was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-05T03:39:31Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>apiDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-08-05T16:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The ID of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ga-bp1x99kj7kl1ziw5x****</para>
                /// </summary>
                [NameInMap("GlobalAccelerationInstanceId")]
                [Validation(Required=false)]
                public string GlobalAccelerationInstanceId { get; set; }

                /// <summary>
                /// <para>The billing method of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PayByBandwidth</para>
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>The public IP address of the dedicated GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.xx.xx.99</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The name of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instanceName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The public IP address.</para>
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
                        /// <para>The ID of the public IP address of the GA instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eip-bp19yqraac4w3y0jd****</para>
                        /// </summary>
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        /// <summary>
                        /// <para>The public IP address of the GA instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12.xx.xx.78</para>
                        /// </summary>
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                    }

                }

                /// <summary>
                /// <para>The region ID of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The service area of the GA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>china-mainland</para>
                /// </summary>
                [NameInMap("ServiceLocation")]
                [Validation(Required=false)]
                public string ServiceLocation { get; set; }

                /// <summary>
                /// <para>The status of the GA instance.</para>
                /// <list type="bullet">
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>Inuse</b></description></item>
                /// <item><description><b>Associating</b></description></item>
                /// <item><description><b>Unassociating</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>InUse</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6B4EE38D-C75B-4E1F-844E-863A94430676</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
