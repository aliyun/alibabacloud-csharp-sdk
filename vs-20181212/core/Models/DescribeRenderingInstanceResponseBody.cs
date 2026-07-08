// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of optional ingress network information.</para>
        /// </summary>
        [NameInMap("AdditionalIngresses")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceResponseBodyAdditionalIngresses> AdditionalIngresses { get; set; }
        public class DescribeRenderingInstanceResponseBodyAdditionalIngresses : TeaModel {
            /// <summary>
            /// <para>The domain name or IP address of the rendering instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.66.165.213</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The ISP code. Valid values:</para>
            /// <ol>
            /// <item><description><para><c>cmcc</c></para>
            /// </description></item>
            /// <item><description><para><c>unicom</c></para>
            /// </description></item>
            /// <item><description><para><c>telecom</c></para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>cmcc</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>A list of port mappings.</para>
            /// </summary>
            [NameInMap("PortMappings")]
            [Validation(Required=false)]
            public List<DescribeRenderingInstanceResponseBodyAdditionalIngressesPortMappings> PortMappings { get; set; }
            public class DescribeRenderingInstanceResponseBodyAdditionalIngressesPortMappings : TeaModel {
                /// <summary>
                /// <para>The external port or port range, such as <c>22</c>. For a port range, use a forward slash (<c>/</c>) to separate the start and end ports, for example, <c>10/20</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12500/12519</para>
                /// </summary>
                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                /// <summary>
                /// <para>The internal port or port range. The ports correspond one-to-one with the external ports. For a port range, use a forward slash (<c>/</c>) to separate the start and end ports, for example, <c>10/20</c>.</para>
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
        /// <para>The configuration information of the rendering instance.</para>
        /// </summary>
        [NameInMap("ConfigInfo")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyConfigInfo ConfigInfo { get; set; }
        public class DescribeRenderingInstanceResponseBodyConfigInfo : TeaModel {
            /// <summary>
            /// <para>A list of configured physical device simulation modules.</para>
            /// </summary>
            [NameInMap("Configuration")]
            [Validation(Required=false)]
            public List<DescribeRenderingInstanceResponseBodyConfigInfoConfiguration> Configuration { get; set; }
            public class DescribeRenderingInstanceResponseBodyConfigInfoConfiguration : TeaModel {
                /// <summary>
                /// <para>A list of attributes.</para>
                /// </summary>
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<DescribeRenderingInstanceResponseBodyConfigInfoConfigurationAttributes> Attributes { get; set; }
                public class DescribeRenderingInstanceResponseBodyConfigInfoConfigurationAttributes : TeaModel {
                    /// <summary>
                    /// <para>The name of the attribute.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lon</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value of the attribute.</para>
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
                /// <ol>
                /// <item><description><para><c>ctl</c>: Control module</para>
                /// </description></item>
                /// <item><description><para><c>prop</c>: Property module</para>
                /// </description></item>
                /// <item><description><para><c>location</c>: Location module</para>
                /// </description></item>
                /// <item><description><para><c>battery</c>: Battery module</para>
                /// </description></item>
                /// <item><description><para><c>network</c>: Network module</para>
                /// </description></item>
                /// <item><description><para><c>bluetooth</c>: Bluetooth module</para>
                /// </description></item>
                /// <item><description><para><c>sim</c>: SIM card module</para>
                /// </description></item>
                /// <item><description><para><c>display</c>: Display module</para>
                /// </description></item>
                /// <item><description><para><c>system</c>: System module</para>
                /// </description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>location</para>
                /// </summary>
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

            }

            /// <summary>
            /// <para>Ingress and egress bandwidth limits, in Mbps.</para>
            /// </summary>
            [NameInMap("NetworkConfig")]
            [Validation(Required=false)]
            public DescribeRenderingInstanceResponseBodyConfigInfoNetworkConfig NetworkConfig { get; set; }
            public class DescribeRenderingInstanceResponseBodyConfigInfoNetworkConfig : TeaModel {
                /// <summary>
                /// <para>The status of the bandwidth configuration. Valid values:</para>
                /// <ol>
                /// <item><description><para><c>waiting</c>: The configuration is being applied.</para>
                /// </description></item>
                /// <item><description><para><c>success</c>: The configuration change is complete.</para>
                /// </description></item>
                /// <item><description><para><c>failed</c>: The configuration change failed.</para>
                /// </description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("BandwidthStatus")]
                [Validation(Required=false)]
                public string BandwidthStatus { get; set; }

                /// <summary>
                /// <para>The maximum egress bandwidth, in Mbps. A value of 0 indicates no limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxEgressBandwidth")]
                [Validation(Required=false)]
                public int? MaxEgressBandwidth { get; set; }

                /// <summary>
                /// <para>The maximum ingress bandwidth, in Mbps. A value of 0 indicates no limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxIngressBandwidth")]
                [Validation(Required=false)]
                public int? MaxIngressBandwidth { get; set; }

                /// <summary>
                /// <para>The time the configuration was last updated.</para>
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
        /// <para>The instance creation time, in UTC (ISO 8601).</para>
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
        /// <para>The domain name or access IP address of the rendering instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-xxx.ecr.aliyuncs.com</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The billing method of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

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
        /// <ol>
        /// <item><description><para><c>cmcc</c></para>
        /// </description></item>
        /// <item><description><para><c>unicom</c></para>
        /// </description></item>
        /// <item><description><para><c>telecom</c></para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>A list of port mappings.</para>
        /// </summary>
        [NameInMap("PortMappings")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceResponseBodyPortMappings> PortMappings { get; set; }
        public class DescribeRenderingInstanceResponseBodyPortMappings : TeaModel {
            /// <summary>
            /// <para>The external port or port range, such as <c>22</c>. For a port range, use a forward slash (<c>/</c>) to separate the start and end ports, for example, <c>10/20</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10013/10020</para>
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// <para>The internal port or port range. The ports correspond one-to-one with the external ports. For a port range, use a forward slash (<c>/</c>) to separate the start and end ports, for example, <c>10/20</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49008/49015</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

        }

        /// <summary>
        /// <para>The ID of the rendering instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>The specification of the rendering instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crs.cp.l1</para>
        /// </summary>
        [NameInMap("RenderingSpec")]
        [Validation(Required=false)]
        public string RenderingSpec { get; set; }

        /// <summary>
        /// <para>The operational status of the rendering instance.</para>
        /// </summary>
        [NameInMap("RenderingStatus")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyRenderingStatus RenderingStatus { get; set; }
        public class DescribeRenderingInstanceResponseBodyRenderingStatus : TeaModel {
            /// <summary>
            /// <para>Additional details about the current status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>工作中</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the last action performed on the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MigrateLocalData</para>
            /// </summary>
            [NameInMap("LatestAction")]
            [Validation(Required=false)]
            public string LatestAction { get; set; }

            /// <summary>
            /// <para>The operational status of the instance. Valid values:</para>
            /// <ol>
            /// <item><description><para><c>Preparing</c>: The instance is being initialized.</para>
            /// </description></item>
            /// <item><description><para><c>Rebooting</c>: The instance is rebooting.</para>
            /// </description></item>
            /// <item><description><para><c>Resetting</c>: The instance is being reset.</para>
            /// </description></item>
            /// <item><description><para><c>Working</c>: The instance is running normally. This is a terminal state.</para>
            /// </description></item>
            /// <item><description><para><c>Failure</c>: The instance has failed to start or operate. This is a terminal state.</para>
            /// </description></item>
            /// </ol>
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
        /// <para>The attributes of the rendering instance.</para>
        /// </summary>
        [NameInMap("ResourceAttributes")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyResourceAttributes ResourceAttributes { get; set; }
        public class DescribeRenderingInstanceResponseBodyResourceAttributes : TeaModel {
            /// <summary>
            /// <para>The configuration of the edge media service. Valid values:</para>
            /// <ol>
            /// <item><description><para><c>ON</c>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><c>OFF</c>: Disabled.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("EdgeMediaService")]
            [Validation(Required=false)]
            public string EdgeMediaService { get; set; }

            /// <summary>
            /// <para>The ingress network access configuration. Valid values:</para>
            /// <ol>
            /// <item><description><para><c>ON</c>: Enabled. The rendering instance can be accessed from the public internet.</para>
            /// </description></item>
            /// <item><description><para><c>OFF</c>: Disabled.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("InAccess")]
            [Validation(Required=false)]
            public string InAccess { get; set; }

            /// <summary>
            /// <para>The egress network access configuration. Valid values:</para>
            /// <ol>
            /// <item><description><para><c>ON</c>: Enabled. The rendering instance can access the public internet.</para>
            /// </description></item>
            /// <item><description><para><c>OFF</c>: Disabled.</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("OutAccess")]
            [Validation(Required=false)]
            public string OutAccess { get; set; }

            /// <summary>
            /// <para>The resource zone. Valid values: <c>Private</c> and <c>Public</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

        /// <summary>
        /// <para>The status of the underlying computing resource.</para>
        /// </summary>
        [NameInMap("ResourceStatus")]
        [Validation(Required=false)]
        public DescribeRenderingInstanceResponseBodyResourceStatus ResourceStatus { get; set; }
        public class DescribeRenderingInstanceResponseBodyResourceStatus : TeaModel {
            /// <summary>
            /// <para>The running status of the computing resource. Valid values:</para>
            /// <ol>
            /// <item><description><para><c>running</c>: The edge instance is running normally.</para>
            /// </description></item>
            /// <item><description><para><c>operating</c>: The edge instance is under maintenance.</para>
            /// </description></item>
            /// <item><description><para><c>error</c>: An exception is detected on the edge instance.</para>
            /// </description></item>
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
        /// <para>The storage capacity of the rendering instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public int? StorageSize { get; set; }

        /// <summary>
        /// <para>The system information of the rendering instance, such as its resolution.</para>
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
            /// <item><description><para><c>1920*864</c></para>
            /// </description></item>
            /// <item><description><para><c>1080*1920</c></para>
            /// </description></item>
            /// <item><description><para><c>1920*1080</c></para>
            /// </description></item>
            /// <item><description><para><c>720*1280</c></para>
            /// </description></item>
            /// <item><description><para><c>2400*1080</c></para>
            /// </description></item>
            /// <item><description><para><c>1080*2400</c></para>
            /// </description></item>
            /// <item><description><para><c>1280*720</c></para>
            /// </description></item>
            /// <item><description><para><c>864*1920</c></para>
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
