// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDeviceServiceResponseBody : TeaModel {
        /// <summary>
        /// The basic properties of the application.
        /// </summary>
        [NameInMap("AppMetaData")]
        [Validation(Required=false)]
        public DescribeDeviceServiceResponseBodyAppMetaData AppMetaData { get; set; }
        public class DescribeDeviceServiceResponseBodyAppMetaData : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The stable version number of the application.
            /// </summary>
            [NameInMap("AppStableVersion")]
            [Validation(Required=false)]
            public string AppStableVersion { get; set; }

            /// <summary>
            /// The type of the application. The value is of the enumeration type. Valid values:
            /// 
            /// *   Common
            /// *   Scheduler
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// The name of the application cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The time when the application was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the application.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// The status information of the application.
        /// </summary>
        [NameInMap("AppStatus")]
        [Validation(Required=false)]
        public DescribeDeviceServiceResponseBodyAppStatus AppStatus { get; set; }
        public class DescribeDeviceServiceResponseBodyAppStatus : TeaModel {
            /// <summary>
            /// The status of the application. The value is of the enumeration type. Valid values:
            /// 
            /// Three intermediate states:
            /// 
            /// *   CREATING
            /// *   UPDATING
            /// *   DELETING
            /// 
            /// Four final states:
            /// 
            /// *   CREATE_FAILED
            /// *   UPDATE_FAILED
            /// *   DELETE_FAILED
            /// *   RUNNING
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// The description of the application status.
            /// </summary>
            [NameInMap("StatusDescrip")]
            [Validation(Required=false)]
            public string StatusDescrip { get; set; }

            /// <summary>
            /// The time when the status was last updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the devices.
        /// </summary>
        [NameInMap("ResourceDetailInfos")]
        [Validation(Required=false)]
        public List<DescribeDeviceServiceResponseBodyResourceDetailInfos> ResourceDetailInfos { get; set; }
        public class DescribeDeviceServiceResponseBodyResourceDetailInfos : TeaModel {
            /// <summary>
            /// The name of the device.
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// The ID of the cloud device.
            /// </summary>
            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }

            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The Internet service provider (ISP).
            /// </summary>
            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            /// <summary>
            /// The ID of the image.
            /// </summary>
            [NameInMap("ImageID")]
            [Validation(Required=false)]
            public string ImageID { get; set; }

            /// <summary>
            /// The media access control (MAC) address of the device.
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// The ID of the ENS node.
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// The server name of the ENS node.
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// The status of the device.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the device.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The information about the instances.
        /// </summary>
        [NameInMap("ResourceInfos")]
        [Validation(Required=false)]
        public List<DescribeDeviceServiceResponseBodyResourceInfos> ResourceInfos { get; set; }
        public class DescribeDeviceServiceResponseBodyResourceInfos : TeaModel {
            /// <summary>
            /// The version of the application.
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// The area code.
            /// </summary>
            [NameInMap("AreaCode")]
            [Validation(Required=false)]
            public string AreaCode { get; set; }

            /// <summary>
            /// The region name.
            /// </summary>
            [NameInMap("AreaName")]
            [Validation(Required=false)]
            public string AreaName { get; set; }

            /// <summary>
            /// The time when the application was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The information about the devices.
            /// </summary>
            [NameInMap("DeviceInfos")]
            [Validation(Required=false)]
            public List<DescribeDeviceServiceResponseBodyResourceInfosDeviceInfos> DeviceInfos { get; set; }
            public class DescribeDeviceServiceResponseBodyResourceInfosDeviceInfos : TeaModel {
                /// <summary>
                /// The name of the device.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The network information.
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public List<DescribeDeviceServiceResponseBodyResourceInfosDeviceInfosNetwork> Network { get; set; }
                public class DescribeDeviceServiceResponseBodyResourceInfosDeviceInfosNetwork : TeaModel {
                    /// <summary>
                    /// The port of the container.
                    /// </summary>
                    [NameInMap("ContainerPorts")]
                    [Validation(Required=false)]
                    public string ContainerPorts { get; set; }

                    /// <summary>
                    /// The public IP address.
                    /// </summary>
                    [NameInMap("ExternalIp")]
                    [Validation(Required=false)]
                    public string ExternalIp { get; set; }

                    /// <summary>
                    /// The port range.
                    /// </summary>
                    [NameInMap("HostPorts")]
                    [Validation(Required=false)]
                    public string HostPorts { get; set; }

                    /// <summary>
                    /// The protocol of the gateway. The value is of the enumeration type. Valid values:
                    /// 
                    /// *   TCP
                    /// *   UDP
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// The status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The status of the instance.
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// The internal IP addresses.
            /// </summary>
            [NameInMap("InternalIps")]
            [Validation(Required=false)]
            public List<DescribeDeviceServiceResponseBodyResourceInfosInternalIps> InternalIps { get; set; }
            public class DescribeDeviceServiceResponseBodyResourceInfosInternalIps : TeaModel {
                /// <summary>
                /// The internal IP address.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// The public IP addresses.
            /// </summary>
            [NameInMap("PublicIps")]
            [Validation(Required=false)]
            public List<DescribeDeviceServiceResponseBodyResourceInfosPublicIps> PublicIps { get; set; }
            public class DescribeDeviceServiceResponseBodyResourceInfosPublicIps : TeaModel {
                /// <summary>
                /// The public IP address.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// The ID of the region.
            /// </summary>
            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            /// <summary>
            /// The ID of the ENS node.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The name of the region.
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

    }

}
