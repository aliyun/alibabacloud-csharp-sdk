// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDeviceServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic properties of the application.</para>
        /// </summary>
        [NameInMap("AppMetaData")]
        [Validation(Required=false)]
        public DescribeDeviceServiceResponseBodyAppMetaData AppMetaData { get; set; }
        public class DescribeDeviceServiceResponseBodyAppMetaData : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>97a32f2a-aa2c-436a-b19c-05b20d258618</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iotx-api-admin</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The stable version number of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("AppStableVersion")]
            [Validation(Required=false)]
            public string AppStableVersion { get; set; }

            /// <summary>
            /// <para>The type of the application. The value is of the enumeration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Common</description></item>
            /// <item><description>Scheduler</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Common</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>The name of the application cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>poc</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The time when the application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-03T03:42:11</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test application</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The status information of the application.</para>
        /// </summary>
        [NameInMap("AppStatus")]
        [Validation(Required=false)]
        public DescribeDeviceServiceResponseBodyAppStatus AppStatus { get; set; }
        public class DescribeDeviceServiceResponseBodyAppStatus : TeaModel {
            /// <summary>
            /// <para>The status of the application. The value is of the enumeration type. Valid values:</para>
            /// <para>Three intermediate states:</para>
            /// <list type="bullet">
            /// <item><description>CREATING</description></item>
            /// <item><description>UPDATING</description></item>
            /// <item><description>DELETING</description></item>
            /// </list>
            /// <para>Four final states:</para>
            /// <list type="bullet">
            /// <item><description>CREATE_FAILED</description></item>
            /// <item><description>UPDATE_FAILED</description></item>
            /// <item><description>DELETE_FAILED</description></item>
            /// <item><description>RUNNING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATING</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The description of the application status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Creating in progress</para>
            /// </summary>
            [NameInMap("StatusDescrip")]
            [Validation(Required=false)]
            public string StatusDescrip { get; set; }

            /// <summary>
            /// <para>The time when the status was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-26T05:04Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3A535110-3EE3-5EC5-B1ED-10B7067A1FC8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the devices.</para>
        /// </summary>
        [NameInMap("ResourceDetailInfos")]
        [Validation(Required=false)]
        public List<DescribeDeviceServiceResponseBodyResourceDetailInfos> ResourceDetailInfos { get; set; }
        public class DescribeDeviceServiceResponseBodyResourceDetailInfos : TeaModel {
            /// <summary>
            /// <para>The name of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5JhF100NEgdBcpNren32</para>
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <para>The ID of the cloud device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>h-uf6009zoaexs5pefypbo</para>
            /// </summary>
            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.27.219.219</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmcc</para>
            /// </summary>
            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-2ze40oyhjorpyw61k7be</para>
            /// </summary>
            [NameInMap("ImageID")]
            [Validation(Required=false)]
            public string ImageID { get; set; }

            /// <summary>
            /// <para>The media access control (MAC) address of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AA:BB:77:88:99:03</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>The ID of the ENS node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-jiaozuo-2</para>
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// <para>The server name of the ENS node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ens-nc2</para>
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// <para>The status of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ens.ac6.large</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The information about the instances.</para>
        /// </summary>
        [NameInMap("ResourceInfos")]
        [Validation(Required=false)]
        public List<DescribeDeviceServiceResponseBodyResourceInfos> ResourceInfos { get; set; }
        public class DescribeDeviceServiceResponseBodyResourceInfos : TeaModel {
            /// <summary>
            /// <para>The version of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>The area code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>410800</para>
            /// </summary>
            [NameInMap("AreaCode")]
            [Validation(Required=false)]
            public string AreaCode { get; set; }

            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jiaozuo City, Henan Province, Central China</para>
            /// </summary>
            [NameInMap("AreaName")]
            [Validation(Required=false)]
            public string AreaName { get; set; }

            /// <summary>
            /// <para>The time when the application was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-02T08:26Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The information about the devices.</para>
            /// </summary>
            [NameInMap("DeviceInfos")]
            [Validation(Required=false)]
            public List<DescribeDeviceServiceResponseBodyResourceInfosDeviceInfos> DeviceInfos { get; set; }
            public class DescribeDeviceServiceResponseBodyResourceInfosDeviceInfos : TeaModel {
                /// <summary>
                /// <para>The name of the device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-api</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The network information.</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public List<DescribeDeviceServiceResponseBodyResourceInfosDeviceInfosNetwork> Network { get; set; }
                public class DescribeDeviceServiceResponseBodyResourceInfosDeviceInfosNetwork : TeaModel {
                    /// <summary>
                    /// <para>The port of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000-10010</para>
                    /// </summary>
                    [NameInMap("ContainerPorts")]
                    [Validation(Required=false)]
                    public string ContainerPorts { get; set; }

                    /// <summary>
                    /// <para>The public IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>39.105.62.120</para>
                    /// </summary>
                    [NameInMap("ExternalIp")]
                    [Validation(Required=false)]
                    public string ExternalIp { get; set; }

                    /// <summary>
                    /// <para>The port range.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80-8080</para>
                    /// </summary>
                    [NameInMap("HostPorts")]
                    [Validation(Required=false)]
                    public string HostPorts { get; set; }

                    /// <summary>
                    /// <para>The protocol of the gateway. The value is of the enumeration type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>TCP</description></item>
                    /// <item><description>UDP</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-5s9boobrmh5000kv4jmi0oeai</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The internal IP addresses.</para>
            /// </summary>
            [NameInMap("InternalIps")]
            [Validation(Required=false)]
            public List<DescribeDeviceServiceResponseBodyResourceInfosInternalIps> InternalIps { get; set; }
            public class DescribeDeviceServiceResponseBodyResourceInfosInternalIps : TeaModel {
                /// <summary>
                /// <para>The internal IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.2.3</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <para>The public IP addresses.</para>
            /// </summary>
            [NameInMap("PublicIps")]
            [Validation(Required=false)]
            public List<DescribeDeviceServiceResponseBodyResourceInfosPublicIps> PublicIps { get; set; }
            public class DescribeDeviceServiceResponseBodyResourceInfosPublicIps : TeaModel {
                /// <summary>
                /// <para>The public IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122.13.173.137</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-jiaozuo-2</para>
            /// </summary>
            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            /// <summary>
            /// <para>The ID of the ENS node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-jiaozuo-2</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China Jiaozuo-2</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

    }

}
