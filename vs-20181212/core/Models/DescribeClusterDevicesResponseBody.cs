// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeClusterDevicesResponseBody : TeaModel {
        [NameInMap("Devices")]
        [Validation(Required=false)]
        public List<DescribeClusterDevicesResponseBodyDevices> Devices { get; set; }
        public class DescribeClusterDevicesResponseBodyDevices : TeaModel {
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("AutoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EdgeNodeName")]
            [Validation(Required=false)]
            public string EdgeNodeName { get; set; }

            [NameInMap("HostRom")]
            [Validation(Required=false)]
            public string HostRom { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("IpInfos")]
            [Validation(Required=false)]
            public List<DescribeClusterDevicesResponseBodyDevicesIpInfos> IpInfos { get; set; }
            public class DescribeClusterDevicesResponseBodyDevicesIpInfos : TeaModel {
                [NameInMap("ExternalIp")]
                [Validation(Required=false)]
                public string ExternalIp { get; set; }

                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                [NameInMap("InternalIp")]
                [Validation(Required=false)]
                public string InternalIp { get; set; }

                [NameInMap("InternalPort")]
                [Validation(Required=false)]
                public string InternalPort { get; set; }

                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                [NameInMap("NatType")]
                [Validation(Required=false)]
                public string NatType { get; set; }

            }

            [NameInMap("MacAddress")]
            [Validation(Required=false)]
            public string MacAddress { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public string PlatformType { get; set; }

            [NameInMap("PodInfos")]
            [Validation(Required=false)]
            public List<DescribeClusterDevicesResponseBodyDevicesPodInfos> PodInfos { get; set; }
            public class DescribeClusterDevicesResponseBodyDevicesPodInfos : TeaModel {
                [NameInMap("Network")]
                [Validation(Required=false)]
                public List<DescribeClusterDevicesResponseBodyDevicesPodInfosNetwork> Network { get; set; }
                public class DescribeClusterDevicesResponseBodyDevicesPodInfosNetwork : TeaModel {
                    [NameInMap("ContainerPorts")]
                    [Validation(Required=false)]
                    public string ContainerPorts { get; set; }

                    [NameInMap("ExternalIp")]
                    [Validation(Required=false)]
                    public string ExternalIp { get; set; }

                    [NameInMap("ExternalIsp")]
                    [Validation(Required=false)]
                    public string ExternalIsp { get; set; }

                    [NameInMap("ExternalPorts")]
                    [Validation(Required=false)]
                    public string ExternalPorts { get; set; }

                    [NameInMap("OutgoingIp")]
                    [Validation(Required=false)]
                    public string OutgoingIp { get; set; }

                    [NameInMap("OutgoingIsp")]
                    [Validation(Required=false)]
                    public string OutgoingIsp { get; set; }

                }

                [NameInMap("PodId")]
                [Validation(Required=false)]
                public string PodId { get; set; }

                [NameInMap("PodIp")]
                [Validation(Required=false)]
                public string PodIp { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
