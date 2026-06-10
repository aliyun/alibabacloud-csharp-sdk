// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The E-HPC Util version used by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.31</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The cluster series. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard</para>
        /// </description></item>
        /// <item><description><para>Serverless</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ClusterCategory")]
        [Validation(Required=false)]
        public string ClusterCategory { get; set; }

        /// <summary>
        /// <para>The cluster creation time. The time follows the ISO 8601 standard and is in UTC+0. The format is yyyy-MM-ddTHH:mmZ. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-06T12:43:01.000Z</para>
        /// </summary>
        [NameInMap("ClusterCreateTime")]
        [Validation(Required=false)]
        public string ClusterCreateTime { get; set; }

        /// <summary>
        /// <para>The cluster post-processing script.</para>
        /// </summary>
        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public GetClusterResponseBodyClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
        public class GetClusterResponseBodyClusterCustomConfiguration : TeaModel {
            /// <summary>
            /// <para>The runtime parameters of the post-installation script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>E-HPC cn-hangzhou</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The download URL of the post-processing script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://*****</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        /// <summary>
        /// <para>The E-HPC cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The deployment type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Integrated: Public cloud</para>
        /// </description></item>
        /// <item><description><para>Hybrid: Hybrid cloud</para>
        /// </description></item>
        /// <item><description><para>Custom: Custom cluster</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Integrated</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>The cluster modification time. The time follows the ISO 8601 standard and is in UTC+0. The format is yyyy-MM-ddTHH:mmZ. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-06T12:43:01.000Z</para>
        /// </summary>
        [NameInMap("ClusterModifyTime")]
        [Validation(Required=false)]
        public string ClusterModifyTime { get; set; }

        /// <summary>
        /// <para>The E-HPC cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slurm22.05.8-cluster-20240614</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>uninit: Installing</para>
        /// </description></item>
        /// <item><description><para>creating: Creating</para>
        /// </description></item>
        /// <item><description><para>initing: Initializing</para>
        /// </description></item>
        /// <item><description><para>running: Running</para>
        /// </description></item>
        /// <item><description><para>exception: Abnormal</para>
        /// </description></item>
        /// <item><description><para>releasing: Releasing</para>
        /// </description></item>
        /// <item><description><para>stopping: Stopping</para>
        /// </description></item>
        /// <item><description><para>stopped: Stopped</para>
        /// </description></item>
        /// <item><description><para>pending: Pending configuration</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public string ClusterStatus { get; set; }

        /// <summary>
        /// <para>The virtual switch ID used by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1p2uugqsjppno******</para>
        /// </summary>
        [NameInMap("ClusterVSwitchId")]
        [Validation(Required=false)]
        public string ClusterVSwitchId { get; set; }

        /// <summary>
        /// <para>The Virtual Private Cloud (VPC) ID used by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6u3lk1pjy28eg*****</para>
        /// </summary>
        [NameInMap("ClusterVpcId")]
        [Validation(Required=false)]
        public string ClusterVpcId { get; set; }

        /// <summary>
        /// <para>Indicates whether delete protection is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable delete protection.</para>
        /// </description></item>
        /// <item><description><para>false: Do not enable delete protection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteProtection")]
        [Validation(Required=false)]
        public string DeleteProtection { get; set; }

        /// <summary>
        /// <para>The E-HPC product version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether auto scale-in is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable</para>
        /// </description></item>
        /// <item><description><para>false: Disable</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleIn")]
        [Validation(Required=false)]
        public bool? EnableScaleIn { get; set; }

        /// <summary>
        /// <para>Indicates whether auto scale-out is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable</para>
        /// </description></item>
        /// <item><description><para>false: Disable</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleOut")]
        [Validation(Required=false)]
        public bool? EnableScaleOut { get; set; }

        /// <summary>
        /// <para>The interval for cluster auto scale-out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GrowInterval")]
        [Validation(Required=false)]
        public int? GrowInterval { get; set; }

        /// <summary>
        /// <para>The idle time of the cluster\&quot;s compute nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IdleInterval")]
        [Validation(Required=false)]
        public int? IdleInterval { get; set; }

        /// <summary>
        /// <para>The cluster control plane node configuration.</para>
        /// </summary>
        [NameInMap("Manager")]
        [Validation(Required=false)]
        public GetClusterResponseBodyManager Manager { get; set; }
        public class GetClusterResponseBodyManager : TeaModel {
            /// <summary>
            /// <para>The domain name resolution service configuration.</para>
            /// </summary>
            [NameInMap("DNS")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerDNS DNS { get; set; }
            public class GetClusterResponseBodyManagerDNS : TeaModel {
                /// <summary>
                /// <para>The domain name resolution service status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>uninit: Installing</para>
                /// </description></item>
                /// <item><description><para>initing: Initializing</para>
                /// </description></item>
                /// <item><description><para>running: Running</para>
                /// </description></item>
                /// <item><description><para>exception: Abnormal</para>
                /// </description></item>
                /// <item><description><para>releasing: Releasing</para>
                /// </description></item>
                /// <item><description><para>stopped: Stopped</para>
                /// </description></item>
                /// <item><description><para>pending: Pending configuration</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The domain name resolution type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nis</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The domain name resolution version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The domain account service information.</para>
            /// </summary>
            [NameInMap("DirectoryService")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerDirectoryService DirectoryService { get; set; }
            public class GetClusterResponseBodyManagerDirectoryService : TeaModel {
                /// <summary>
                /// <para>The domain account service status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>uninit: Installing</para>
                /// </description></item>
                /// <item><description><para>initing: Initializing</para>
                /// </description></item>
                /// <item><description><para>running: Running</para>
                /// </description></item>
                /// <item><description><para>exception: Abnormal</para>
                /// </description></item>
                /// <item><description><para>releasing: Releasing</para>
                /// </description></item>
                /// <item><description><para>stopped: Stopped</para>
                /// </description></item>
                /// <item><description><para>pending: Pending configuration</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The domain account type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nis</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The domain account version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The control plane node configuration.</para>
            /// </summary>
            [NameInMap("ManagerNode")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerManagerNode ManagerNode { get; set; }
            public class GetClusterResponseBodyManagerManagerNode : TeaModel {
                [NameInMap("AutoRenew")]
                [Validation(Required=false)]
                public bool? AutoRenew { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("AutoRenewPeriod")]
                [Validation(Required=false)]
                public long? AutoRenewPeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("EnableHt")]
                [Validation(Required=false)]
                public bool? EnableHt { get; set; }

                /// <summary>
                /// <para>The expiration time of the control plane node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2099-12-31T15:59Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun_2_1903_x64_20G_alibase_20200324.vhd</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The billing method of the control plane node instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>PostPaid: Pay-as-you-go</para>
                /// </description></item>
                /// <item><description><para>PrePaid: Subscription</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The control plane node instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1a170jgea1vl******</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The control plane node instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6.4xlarge</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SpotPriceLimit")]
                [Validation(Required=false)]
                public float? SpotPriceLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                [NameInMap("SystemDisk")]
                [Validation(Required=false)]
                public GetClusterResponseBodyManagerManagerNodeSystemDisk SystemDisk { get; set; }
                public class GetClusterResponseBodyManagerManagerNodeSystemDisk : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cloud_ssd</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PL0</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                }

            }

            /// <summary>
            /// <para>The scheduler service information.</para>
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerScheduler Scheduler { get; set; }
            public class GetClusterResponseBodyManagerScheduler : TeaModel {
                /// <summary>
                /// <para>The scheduler service status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>uninit: Installing</para>
                /// </description></item>
                /// <item><description><para>initing: Initializing</para>
                /// </description></item>
                /// <item><description><para>running: Running</para>
                /// </description></item>
                /// <item><description><para>exception: Abnormal</para>
                /// </description></item>
                /// <item><description><para>releasing: Releasing</para>
                /// </description></item>
                /// <item><description><para>stopped: Stopped</para>
                /// </description></item>
                /// <item><description><para>pending: Pending configuration</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The scheduler type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>SLURM</para>
                /// </description></item>
                /// <item><description><para>PBS</para>
                /// </description></item>
                /// <item><description><para>OPENGRIDSCHEDULER</para>
                /// </description></item>
                /// <item><description><para>LSF_PLUGIN</para>
                /// </description></item>
                /// <item><description><para>PBS_PLUGIN</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SLURM</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The scheduler version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22.05.8</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of cores of compute nodes the cluster can manage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxCoreCount")]
        [Validation(Required=false)]
        public string MaxCoreCount { get; set; }

        /// <summary>
        /// <para>The number of compute nodes the cluster can manage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public string MaxCount { get; set; }

        /// <summary>
        /// <para>The cluster monitoring details.</para>
        /// </summary>
        [NameInMap("MonitorSpec")]
        [Validation(Required=false)]
        public GetClusterResponseBodyMonitorSpec MonitorSpec { get; set; }
        public class GetClusterResponseBodyMonitorSpec : TeaModel {
            /// <summary>
            /// <para>Indicates whether the monitoring component for compute nodes is enabled for the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable</para>
            /// </description></item>
            /// <item><description><para>false: Disable</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableComputeLoadMonitor")]
            [Validation(Required=false)]
            public bool? EnableComputeLoadMonitor { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The cluster scheduling details.</para>
        /// </summary>
        [NameInMap("SchedulerSpec")]
        [Validation(Required=false)]
        public GetClusterResponseBodySchedulerSpec SchedulerSpec { get; set; }
        public class GetClusterResponseBodySchedulerSpec : TeaModel {
            [NameInMap("EnablePowerSaving")]
            [Validation(Required=false)]
            public bool? EnablePowerSaving { get; set; }

            /// <summary>
            /// <para>Indicates whether the topology awareness feature is enabled for the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enable</para>
            /// </description></item>
            /// <item><description><para>false: Disable</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableTopologyAwareness")]
            [Validation(Required=false)]
            public bool? EnableTopologyAwareness { get; set; }

        }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-f8z9vb2zaezpkr69a21k</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}
