// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The additional optional ingress network information.</para>
        /// </summary>
        [NameInMap("AdditionalIngresses")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceResponseBodyAdditionalIngresses> AdditionalIngresses { get; set; }
        public class DescribeRenderingInstanceResponseBodyAdditionalIngresses : TeaModel {
            /// <summary>
            /// <para>The domain name or IP address of the cloud application service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.66.165.213</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The ISP code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cmcc</description></item>
            /// <item><description>unicom</description></item>
            /// <item><description>telecom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cmcc</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The port mappings.</para>
            /// </summary>
            [NameInMap("PortMappings")]
            [Validation(Required=false)]
            public List<DescribeRenderingInstanceResponseBodyAdditionalIngressesPortMappings> PortMappings { get; set; }
            public class DescribeRenderingInstanceResponseBodyAdditionalIngressesPortMappings : TeaModel {
                /// <summary>
                /// <para>The external port or port range, such as 22. If a port range is specified, separate the start and end ports with a forward slash (/), such as 10/20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12500/12519</para>
                /// </summary>
                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                /// <summary>
                /// <para>The internal port or port range. The internal ports correspond to the external ports one by one. If a port range is specified, separate the start and end ports with a forward slash (/), such as 10/20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11120/11139</para>
                /// </summary>
                [NameInMap("InternalPort")]
                [Validation(Required=false)]
                public string InternalPort { get; set; }

            }

        }

        /// <summary>
        /// <para>The instance configuration.</para>
        /// </summary>
        [NameInMap("ConfigInfo")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyConfigInfo ConfigInfo { get; set; }
        public class DescribeRenderingInstanceResponseBodyConfigInfo : TeaModel {
            /// <summary>
            /// <para>The list of configured physical device simulation modules.</para>
            /// </summary>
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public List<DescribeRenderingInstanceResponseBodyConfigInfoConfiguration> Configuration { get; set; }
            public class DescribeRenderingInstanceResponseBodyConfigInfoConfiguration : TeaModel {
                /// <summary>
                /// <para>The attributes.</para>
                /// </summary>
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<DescribeRenderingInstanceResponseBodyConfigInfoConfigurationAttributes> Attributes { get; set; }
                public class DescribeRenderingInstanceResponseBodyConfigInfoConfigurationAttributes : TeaModel {
                    /// <summary>
                    /// <para>The attribute name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lon</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The attribute value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public object Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the physical device simulation module. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ctl: control module</description></item>
                /// <item><description>prop: property module</description></item>
                /// <item><description>location: location module</description></item>
                /// <item><description>battery: battery module</description></item>
                /// <item><description>network: network module</description></item>
                /// <item><description>bluetooth: Bluetooth module</description></item>
                /// <item><description>sim: SIM card module</description></item>
                /// <item><description>display: display module</description></item>
                /// <item><description>system: basic module</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>location</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

            }

            /// <summary>
            /// <para>The outbound and inbound bandwidth throttling. Unit: Mbit/s.</para>
            /// </summary>
            [NameInMap("NetworkConfig")]
            [Validation(Required=false)]
            public DescribeRenderingInstanceResponseBodyConfigInfoNetworkConfig NetworkConfig { get; set; }
            public class DescribeRenderingInstanceResponseBodyConfigInfoNetworkConfig : TeaModel {
                /// <summary>
                /// <para>The bandwidth application status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>waiting: taking effect</description></item>
                /// <item><description>success: taken effect</description></item>
                /// <item><description>failed: failed to take effect</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("BandwidthStatus")]
                [Validation(Required=false)]
                public string BandwidthStatus { get; set; }

                /// <summary>
                /// <para>The maximum outbound bandwidth limit. Unit: Mbit/s. A value of 0 indicates that no bandwidth limit is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxEgressBandwidth")]
                [Validation(Required=false)]
                public int? MaxEgressBandwidth { get; set; }

                /// <summary>
                /// <para>The maximum inbound bandwidth limit. Unit: Mbit/s. A value of 0 indicates that no bandwidth limit is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxIngressBandwidth")]
                [Validation(Required=false)]
                public int? MaxIngressBandwidth { get; set; }

                /// <summary>
                /// <para>The update time. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-17T09:54:35Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The instance creation time. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-07T02:27:06Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The egress IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.8.8</para>
        /// </summary>
        [NameInMap("EgressIp")]
        [Validation(Required=false)]
        public string EgressIp { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2029-03-28T16:00Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>The domain name or access IP address of the cloud application service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-xxx.ecr.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The instance billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestInstance</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The internal IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.1.17.32</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <para>The ISP code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cmcc</description></item>
        /// <item><description>unicom</description></item>
        /// <item><description>telecom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The port mappings.</para>
        /// </summary>
        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceResponseBodyPortMappings> PortMappings { get; set; }
        public class DescribeRenderingInstanceResponseBodyPortMappings : TeaModel {
            /// <summary>
            /// <para>The external port or port range, such as 22. If a port range is specified, separate the start and end ports with a forward slash (/), such as 10/20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10013/10020</para>
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// <para>The internal port or port range. The internal ports correspond to the external ports one by one. If a port range is specified, separate the start and end ports with a forward slash (/), such as 10/20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49008/49015</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

        }

        /// <summary>
        /// <para>The cloud application service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>The instance type of the cloud application service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crs.cp.l1</para>
        /// </summary>
        [NameInMap("RenderingSpec")]
        [Validation(Required=false)]
        public string RenderingSpec { get; set; }

        /// <summary>
        /// <para>The instance operation status.</para>
        /// </summary>
        [NameInMap("RenderingStatus")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyRenderingStatus RenderingStatus { get; set; }
        public class DescribeRenderingInstanceResponseBodyRenderingStatus : TeaModel {
            /// <summary>
            /// <para>The status description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Working</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the latest instance operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MigrateLocalData</para>
            /// </summary>
            [NameInMap("LatestAction")]
            [Validation(Required=false)]
            public string LatestAction { get; set; }

            /// <summary>
            /// <para>The instance operation status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Preparing: initializing</description></item>
            /// <item><description>Rebooting: restarting</description></item>
            /// <item><description>Resetting: resetting</description></item>
            /// <item><description>Working: working. This is a final state.</description></item>
            /// <item><description>Failure: operation failed. This is a final state.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Working</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource attributes of the cloud application service instance.</para>
        /// </summary>
        [NameInMap("ResourceAttributes")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyResourceAttributes ResourceAttributes { get; set; }
        public class DescribeRenderingInstanceResponseBodyResourceAttributes : TeaModel {
            /// <summary>
            /// <para>The streaming service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ON: enabled</description></item>
            /// <item><description>OFF: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("EdgeMediaService")]
            [Validation(Required=false)]
            public string EdgeMediaService { get; set; }

            /// <summary>
            /// <para>The inbound access configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ON: enabled. The resource can be accessed from external networks.</description></item>
            /// <item><description>OFF: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("InAccess")]
            [Validation(Required=false)]
            public string InAccess { get; set; }

            /// <summary>
            /// <para>The outbound access configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ON: enabled. The resource can access the Internet.</description></item>
            /// <item><description>OFF: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("OutAccess")]
            [Validation(Required=false)]
            public string OutAccess { get; set; }

            /// <summary>
            /// <para>The resource zone. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Private</description></item>
            /// <item><description>Public</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

        /// <summary>
        /// <para>The compute resource status information.</para>
        /// </summary>
        [NameInMap("ResourceStatus")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyResourceStatus ResourceStatus { get; set; }
        public class DescribeRenderingInstanceResponseBodyResourceStatus : TeaModel {
            /// <summary>
            /// <para>The running state of the compute resource. Valid values:</para>
            /// <ol>
            /// <item><description>running: The edge instance status is normal.</description></item>
            /// <item><description>operating: The edge instance is under maintenance.</description></item>
            /// <item><description>error: An edge anomaly is detected.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The storage capacity of the cloud application service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public int? StorageSize { get; set; }

        /// <summary>
        /// <para>The system information, including the resolution.</para>
        /// </summary>
        [NameInMap("SystemInfo")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodySystemInfo SystemInfo { get; set; }
        public class DescribeRenderingInstanceResponseBodySystemInfo : TeaModel {
            /// <summary>
            /// <para>The refresh rate of the instance, in Hz.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Frequency")]
            [Validation(Required=false)]
            public int? Frequency { get; set; }

            /// <summary>
            /// <para>The resolution. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1920*864</para>
            /// </description></item>
            /// <item><description><para>1080*1920</para>
            /// </description></item>
            /// <item><description><para>1920*1080</para>
            /// </description></item>
            /// <item><description><para>720*1280</para>
            /// </description></item>
            /// <item><description><para>2400*1080</para>
            /// </description></item>
            /// <item><description><para>1080*2400</para>
            /// </description></item>
            /// <item><description><para>1280*720</para>
            /// </description></item>
            /// <item><description><para>864*1920</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1920*1080</para>
            /// </summary>
            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

        }

    }

}
