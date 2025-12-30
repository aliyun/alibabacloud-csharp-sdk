// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The E-HPC Util version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.31</para>
        /// </summary>
        [NameInMap("ClientVersion")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard</description></item>
        /// <item><description>Serverless</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ClusterCategory")]
        [Validation(Required=false)]
        public string ClusterCategory { get; set; }

        /// <summary>
        /// <para>The time when the cluster was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-06T12:43:01.000Z</para>
        /// </summary>
        [NameInMap("ClusterCreateTime")]
        [Validation(Required=false)]
        public string ClusterCreateTime { get; set; }

        /// <summary>
        /// <para>The post-processing script of the cluster.</para>
        /// </summary>
        [NameInMap("ClusterCustomConfiguration")]
        [Validation(Required=false)]
        public GetClusterResponseBodyClusterCustomConfiguration ClusterCustomConfiguration { get; set; }
        public class GetClusterResponseBodyClusterCustomConfiguration : TeaModel {
            /// <summary>
            /// <para>The arguments that are used to run the script after the scrip is installed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>E-HPC cn-hangzhou</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            /// <summary>
            /// <para>The URL that is used to download the post-processing script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http://*****</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        /// <summary>
        /// <para>The cluster ID.</para>
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
        /// <item><description>Integrated: The cluster is deployed on a public cloud.</description></item>
        /// <item><description>Hybrid: The cluster is deployed on a hybrid cloud.</description></item>
        /// <item><description>Custom: The cluster is a custom cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Integrated</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>The time when the cluster was last modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-06T12:43:01.000Z</para>
        /// </summary>
        [NameInMap("ClusterModifyTime")]
        [Validation(Required=false)]
        public string ClusterModifyTime { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slurm22.05.8-cluster-20240614</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The cluster state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>uninit: The cluster is being installed.</description></item>
        /// <item><description>creating: The cluster is being created.</description></item>
        /// <item><description>initing: The cluster is being initialized.</description></item>
        /// <item><description>running: The cluster is running.</description></item>
        /// <item><description>exception: The cluster has run into an exception.</description></item>
        /// <item><description>raleasing: The cluster is being released.</description></item>
        /// <item><description>stopping: The cluster is being stopped.</description></item>
        /// <item><description>stopped: The cluster is stopped.</description></item>
        /// <item><description>pending: The cluster is waiting to be configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public string ClusterStatus { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch used by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1p2uugqsjppno******</para>
        /// </summary>
        [NameInMap("ClusterVSwitchId")]
        [Validation(Required=false)]
        public string ClusterVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) used by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6u3lk1pjy28eg*****</para>
        /// </summary>
        [NameInMap("ClusterVpcId")]
        [Validation(Required=false)]
        public string ClusterVpcId { get; set; }

        /// <summary>
        /// <para>Indicates whether deletion protection is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteProtection")]
        [Validation(Required=false)]
        public string DeleteProtection { get; set; }

        /// <summary>
        /// <para>The E-HPC version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.0</para>
        /// </summary>
        [NameInMap("EhpcVersion")]
        [Validation(Required=false)]
        public string EhpcVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic scale-in is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleIn")]
        [Validation(Required=false)]
        public bool? EnableScaleIn { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic scale-out is enabled for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleOut")]
        [Validation(Required=false)]
        public bool? EnableScaleOut { get; set; }

        /// <summary>
        /// <para>The interval at which the cluster is automatically scaled out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("GrowInterval")]
        [Validation(Required=false)]
        public int? GrowInterval { get; set; }

        /// <summary>
        /// <para>The idle duration of the compute nodes allowed by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IdleInterval")]
        [Validation(Required=false)]
        public int? IdleInterval { get; set; }

        /// <summary>
        /// <para>The management node configurations.</para>
        /// </summary>
        [NameInMap("Manager")]
        [Validation(Required=false)]
        public GetClusterResponseBodyManager Manager { get; set; }
        public class GetClusterResponseBodyManager : TeaModel {
            /// <summary>
            /// <para>The configurations of the domain name resolution service.</para>
            /// </summary>
            [NameInMap("DNS")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerDNS DNS { get; set; }
            public class GetClusterResponseBodyManagerDNS : TeaModel {
                /// <summary>
                /// <para>The state of the domain name resolution service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>uninit: The service is being installed.</description></item>
                /// <item><description>initing: The service is being initialized.</description></item>
                /// <item><description>running: The service is running.</description></item>
                /// <item><description>exception: The service has run into an exception.</description></item>
                /// <item><description>releasing: The service is being released.</description></item>
                /// <item><description>stopped: The service is stopped.</description></item>
                /// <item><description>pending: The service is waiting to be configured.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The resolution type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nis</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version of the resolution service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The information about the domain account service.</para>
            /// </summary>
            [NameInMap("DirectoryService")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerDirectoryService DirectoryService { get; set; }
            public class GetClusterResponseBodyManagerDirectoryService : TeaModel {
                /// <summary>
                /// <para>The state of the domain account service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>uninit: The service is being installed.</description></item>
                /// <item><description>initing: The service is being initialized.</description></item>
                /// <item><description>running: The service is running.</description></item>
                /// <item><description>exception: The service has run into an exception.</description></item>
                /// <item><description>releasing: The service is being released.</description></item>
                /// <item><description>stopped: The service is stopped.</description></item>
                /// <item><description>pending: The service is waiting to be configured.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the domain account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nis</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version of the domain account service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.31</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The configurations of the management node.</para>
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
                /// <para>The expiration time of the management node.</para>
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
                /// <para>The instance billing method of the management node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PostPaid: pay-as-you-go</description></item>
                /// <item><description>PrePaid: subscription</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The instance ID of the management node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1a170jgea1vl******</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance type of the management node.</para>
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
            /// <para>The information about the scheduler.</para>
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public GetClusterResponseBodyManagerScheduler Scheduler { get; set; }
            public class GetClusterResponseBodyManagerScheduler : TeaModel {
                /// <summary>
                /// <para>The scheduler state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>uninit: The scheduler is being installed.</description></item>
                /// <item><description>initing: The scheduler is being initialized.</description></item>
                /// <item><description>running: The scheduler is running.</description></item>
                /// <item><description>exception: The scheduler has run into an exception.</description></item>
                /// <item><description>releasing: The scheduler is being released.</description></item>
                /// <item><description>stopped: The scheduler is stopped.</description></item>
                /// <item><description>pending: The scheduler is waiting to be configured.</description></item>
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
                /// <item><description>SLURM</description></item>
                /// <item><description>PBS</description></item>
                /// <item><description>OPENGRIDSCHEDULER</description></item>
                /// <item><description>LSF_PLUGIN</description></item>
                /// <item><description>PBS_PLUGIN</description></item>
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
        /// <para>The maximum total number of vCPUs that can be used by all compute nodes managed by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MaxCoreCount")]
        [Validation(Required=false)]
        public string MaxCoreCount { get; set; }

        /// <summary>
        /// <para>The maximum number of compute nodes that the cluster can manage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public string MaxCount { get; set; }

        /// <summary>
        /// <para>The monitoring details of the cluster.</para>
        /// </summary>
        [NameInMap("MonitorSpec")]
        [Validation(Required=false)]
        public GetClusterResponseBodyMonitorSpec MonitorSpec { get; set; }
        public class GetClusterResponseBodyMonitorSpec : TeaModel {
            /// <summary>
            /// <para>Indicates whether the monitoring component of compute nodes is enabled for the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
        /// <para>The scheduler specifications of the cluster.</para>
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
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
