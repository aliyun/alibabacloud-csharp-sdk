// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetClusterCloneMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The clone metadata of the cluster.</para>
        /// </summary>
        [NameInMap("ClusterCloneMeta")]
        [Validation(Required=false)]
        public GetClusterCloneMetaResponseBodyClusterCloneMeta ClusterCloneMeta { get; set; }
        public class GetClusterCloneMetaResponseBodyClusterCloneMeta : TeaModel {
            /// <summary>
            /// <para>The modified application configuration items.</para>
            /// </summary>
            [NameInMap("ApplicationConfigs")]
            [Validation(Required=false)]
            public List<ApplicationConfig> ApplicationConfigs { get; set; }

            /// <summary>
            /// <para>The cluster applications.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<Application> Applications { get; set; }

            /// <summary>
            /// <para>An array of bootstrap scripts. The number of array elements N can be from 1 to 10.</para>
            /// </summary>
            [NameInMap("BootstrapScripts")]
            [Validation(Required=false)]
            public List<Script> BootstrapScripts { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-b933c5aac7f7****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emrtest</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The state of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>STARTING: The cluster is starting.</para>
            /// </description></item>
            /// <item><description><para>START_FAILED: The cluster failed to start.</para>
            /// </description></item>
            /// <item><description><para>BOOTSTRAPPING: The cluster is performing bootstrap actions.</para>
            /// </description></item>
            /// <item><description><para>RUNNING: The cluster is running.</para>
            /// </description></item>
            /// <item><description><para>TERMINATING: The cluster is being terminated.</para>
            /// </description></item>
            /// <item><description><para>TERMINATED: The cluster is terminated.</para>
            /// </description></item>
            /// <item><description><para>TERMINATED_WITH_ERRORS: The cluster is terminated due to an exception.</para>
            /// </description></item>
            /// <item><description><para>TERMINATE_FAILED: The cluster failed to be terminated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("ClusterState")]
            [Validation(Required=false)]
            public string ClusterState { get; set; }

            /// <summary>
            /// <para>The type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DATALAKE: data lake.</para>
            /// </description></item>
            /// <item><description><para>OLAP: data analytics.</para>
            /// </description></item>
            /// <item><description><para>DATAFLOW: real-time data stream.</para>
            /// </description></item>
            /// <item><description><para>DATASERVING: data service.</para>
            /// </description></item>
            /// <item><description><para>CUSTOM: custom cluster.</para>
            /// </description></item>
            /// <item><description><para>HADOOP: Hadoop.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATALAKE</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            [NameInMap("CollationTimeZone")]
            [Validation(Required=false)]
            public CollationTimeZone CollationTimeZone { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled for the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Deletion protection is enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Deletion protection is disabled.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The deployment mode of applications in the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NORMAL: standard deployment.</para>
            /// </description></item>
            /// <item><description><para>HA: high-availability deployment.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HA</para>
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// <para>The EMR server role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunEMRDefaultRole</para>
            /// </summary>
            [NameInMap("EmrDefaultRole")]
            [Validation(Required=false)]
            public string EmrDefaultRole { get; set; }

            /// <summary>
            /// <para>Indicates whether the application configurations can be passed in when you clone a HADOOP cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>False: Not supported.</para>
            /// </description></item>
            /// <item><description><para>True: Supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("ExistCloneConfig")]
            [Validation(Required=false)]
            public bool? ExistCloneConfig { get; set; }

            /// <summary>
            /// <para>The node attributes.</para>
            /// </summary>
            [NameInMap("NodeAttributes")]
            [Validation(Required=false)]
            public NodeAttributes NodeAttributes { get; set; }

            /// <summary>
            /// <para>An array of node group configurations. The number of array elements N can be from 1 to 100.</para>
            /// </summary>
            [NameInMap("NodeGroups")]
            [Validation(Required=false)]
            public List<NodeGroup> NodeGroups { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PayAsYouGo: pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para>Subscription: subscription.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayAsYouGo</para>
            /// </summary>
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The EMR release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EMR-5.6.0</para>
            /// </summary>
            [NameInMap("ReleaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzabjyop****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The Auto Scaling policies for each node group in the cluster.</para>
            /// </summary>
            [NameInMap("ScalingPolicies")]
            [Validation(Required=false)]
            public List<GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPolicies> ScalingPolicies { get; set; }
            public class GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPolicies : TeaModel {
                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-b933c5aac8fe****</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The constraints on the maximum and minimum number of nodes in the node group.</para>
                /// </summary>
                [NameInMap("Constraints")]
                [Validation(Required=false)]
                public GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPoliciesConstraints Constraints { get; set; }
                public class GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPoliciesConstraints : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of nodes in the node group. Default value: 2000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("MaxCapacity")]
                    [Validation(Required=false)]
                    public int? MaxCapacity { get; set; }

                    /// <summary>
                    /// <para>The maximum number of pay-as-you-go instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("MaxOnDemandCapacity")]
                    [Validation(Required=false)]
                    public int? MaxOnDemandCapacity { get; set; }

                    /// <summary>
                    /// <para>The minimum number of nodes in the node group. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("MinCapacity")]
                    [Validation(Required=false)]
                    public int? MinCapacity { get; set; }

                }

                /// <summary>
                /// <para>The node group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ng-869471354ecd****</para>
                /// </summary>
                [NameInMap("NodeGroupId")]
                [Validation(Required=false)]
                public string NodeGroupId { get; set; }

                /// <summary>
                /// <para>The node group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>emr-etltask</para>
                /// </summary>
                [NameInMap("NodeGroupName")]
                [Validation(Required=false)]
                public string NodeGroupName { get; set; }

                /// <summary>
                /// <para>The scaling policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asp-asduwe23znl***</para>
                /// </summary>
                [NameInMap("ScalingPolicyId")]
                [Validation(Required=false)]
                public string ScalingPolicyId { get; set; }

                /// <summary>
                /// <para>The type of the elastic policy.</para>
                /// </summary>
                [NameInMap("ScalingPolicyType")]
                [Validation(Required=false)]
                public string ScalingPolicyType { get; set; }

                /// <summary>
                /// <para>The list of scaling rules.</para>
                /// </summary>
                [NameInMap("ScalingRules")]
                [Validation(Required=false)]
                public List<GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPoliciesScalingRules> ScalingRules { get; set; }
                public class GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPoliciesScalingRules : TeaModel {
                    /// <summary>
                    /// <para>The type of the scaling activity. This parameter is required. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>SCALE_OUT: scale-out.</para>
                    /// </description></item>
                    /// <item><description><para>SCALE_IN: scale-in.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SCALE_OUT</para>
                    /// </summary>
                    [NameInMap("ActivityType")]
                    [Validation(Required=false)]
                    public string ActivityType { get; set; }

                    /// <summary>
                    /// <para>The adjustment value. This parameter is required. It must be a positive integer. It specifies the number of instances to add or remove.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AdjustmentValue")]
                    [Validation(Required=false)]
                    public int? AdjustmentValue { get; set; }

                    /// <summary>
                    /// <para>The description of the metric-based scaling rule.</para>
                    /// </summary>
                    [NameInMap("MetricsTrigger")]
                    [Validation(Required=false)]
                    public MetricsTrigger MetricsTrigger { get; set; }

                    /// <summary>
                    /// <para>The name of the scaling rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>scaling-out-memory</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>The description of the time-based scaling rule.</para>
                    /// </summary>
                    [NameInMap("TimeTrigger")]
                    [Validation(Required=false)]
                    public TimeTrigger TimeTrigger { get; set; }

                    /// <summary>
                    /// <para>The type of the scaling rule. This parameter is required. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>TIME_TRIGGER: time-based scaling.</para>
                    /// </description></item>
                    /// <item><description><para>METRICS_TRIGGER: metric-based scaling.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TIME_TRIGGER</para>
                    /// </summary>
                    [NameInMap("TriggerType")]
                    [Validation(Required=false)]
                    public string TriggerType { get; set; }

                }

            }

            /// <summary>
            /// <para>The Kerberos security mode of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NORMAL: The Kerberos mode is disabled.</para>
            /// </description></item>
            /// <item><description><para>KERBEROS: The Kerberos mode is enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("SecurityMode")]
            [Validation(Required=false)]
            public string SecurityMode { get; set; }

            /// <summary>
            /// <para>The subscription configuration.</para>
            /// </summary>
            [NameInMap("SubscriptionConfig")]
            [Validation(Required=false)]
            public SubscriptionConfig SubscriptionConfig { get; set; }

            /// <summary>
            /// <para>The list of cluster tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
