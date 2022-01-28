// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDeviceServiceResponseBody : TeaModel {
        [NameInMap("AppMetaData")]
        [Validation(Required=false)]
        public DescribeDeviceServiceResponseBodyAppMetaData AppMetaData { get; set; }
        public class DescribeDeviceServiceResponseBodyAppMetaData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("AppStableVersion")]
            [Validation(Required=false)]
            public string AppStableVersion { get; set; }
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
        };

        [NameInMap("AppStatus")]
        [Validation(Required=false)]
        public DescribeDeviceServiceResponseBodyAppStatus AppStatus { get; set; }
        public class DescribeDeviceServiceResponseBodyAppStatus : TeaModel {
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }
            [NameInMap("StatusDescrip")]
            [Validation(Required=false)]
            public string StatusDescrip { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceDetailInfos")]
        [Validation(Required=false)]
        public List<DescribeDeviceServiceResponseBodyResourceDetailInfos> ResourceDetailInfos { get; set; }
        public class DescribeDeviceServiceResponseBodyResourceDetailInfos : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }

            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            [NameInMap("ImageID")]
            [Validation(Required=false)]
            public string ImageID { get; set; }

            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ResourceInfos")]
        [Validation(Required=false)]
        public List<DescribeDeviceServiceResponseBodyResourceInfos> ResourceInfos { get; set; }
        public class DescribeDeviceServiceResponseBodyResourceInfos : TeaModel {
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("AreaCode")]
            [Validation(Required=false)]
            public string AreaCode { get; set; }

            [NameInMap("AreaName")]
            [Validation(Required=false)]
            public string AreaName { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeviceInfos")]
            [Validation(Required=false)]
            public List<DescribeDeviceServiceResponseBodyResourceInfosDeviceInfos> DeviceInfos { get; set; }
            public class DescribeDeviceServiceResponseBodyResourceInfosDeviceInfos : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Network")]
                [Validation(Required=false)]
                public List<DescribeDeviceServiceResponseBodyResourceInfosDeviceInfosNetwork> Network { get; set; }
                public class DescribeDeviceServiceResponseBodyResourceInfosDeviceInfosNetwork : TeaModel {
                    [NameInMap("ContainerPorts")]
                    [Validation(Required=false)]
                    public string ContainerPorts { get; set; }

                    [NameInMap("ExternalIp")]
                    [Validation(Required=false)]
                    public string ExternalIp { get; set; }

                    [NameInMap("HostPorts")]
                    [Validation(Required=false)]
                    public string HostPorts { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("InternalIps")]
            [Validation(Required=false)]
            public List<DescribeDeviceServiceResponseBodyResourceInfosInternalIps> InternalIps { get; set; }
            public class DescribeDeviceServiceResponseBodyResourceInfosInternalIps : TeaModel {
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            [NameInMap("PublicIps")]
            [Validation(Required=false)]
            public List<DescribeDeviceServiceResponseBodyResourceInfosPublicIps> PublicIps { get; set; }
            public class DescribeDeviceServiceResponseBodyResourceInfosPublicIps : TeaModel {
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

    }

}
