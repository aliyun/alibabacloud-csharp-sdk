// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetClusterCloneMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of the cluster that you want to clone.</para>
        /// </summary>
        [NameInMap("ClusterCloneMeta")]
        [Validation(Required=false)]
        public GetClusterCloneMetaResponseBodyClusterCloneMeta ClusterCloneMeta { get; set; }
        public class GetClusterCloneMetaResponseBodyClusterCloneMeta : TeaModel {
            /// <summary>
            /// <para>The modified configuration items.</para>
            /// </summary>
            [NameInMap("ApplicationConfigs")]
            [Validation(Required=false)]
            public List<ApplicationConfig> ApplicationConfigs { get; set; }

            /// <summary>
            /// <para>The services deployed in the cluster.</para>
            /// </summary>
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<Application> Applications { get; set; }

            /// <summary>
            /// <para>The bootstrap actions. Number of elements in the array: 1 to 10.</para>
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
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emrtest</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STARTING</description></item>
            /// <item><description>START_FAILED</description></item>
            /// <item><description>BOOTSTRAPPING</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>TERMINATING</description></item>
            /// <item><description>TERMINATED</description></item>
            /// <item><description>TERMINATED_WITH_ERRORS</description></item>
            /// <item><description>TERMINATE_FAILED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("ClusterState")]
            [Validation(Required=false)]
            public string ClusterState { get; set; }

            /// <summary>
            /// <para>The cluster type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DATALAKE</description></item>
            /// <item><description>OLAP</description></item>
            /// <item><description>DATAFLOW</description></item>
            /// <item><description>DATASERVING</description></item>
            /// <item><description>CUSTOM</description></item>
            /// <item><description>HADOOP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATALAKE</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            [NameInMap("DeletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The deployment mode of master nodes in the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: regular mode.</description></item>
            /// <item><description>HA: high availability mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HA</para>
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// <para>The EMR service role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunEMRDefaultRole</para>
            /// </summary>
            [NameInMap("EmrDefaultRole")]
            [Validation(Required=false)]
            public string EmrDefaultRole { get; set; }

            /// <summary>
            /// <para>Indicates whether the service configurations of a Hadoop cluster that you made during cluster creation can be cloned. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>False</description></item>
            /// <item><description>True</description></item>
            /// </list>
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
            /// <para>The node groups. Number of elements in the array: 1 to 100.</para>
            /// </summary>
            [NameInMap("NodeGroups")]
            [Validation(Required=false)]
            public List<NodeGroup> NodeGroups { get; set; }

            /// <summary>
            /// <para>The billing method of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayAsYouGo</description></item>
            /// <item><description>Subscription</description></item>
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
            /// <para>The EMR version.</para>
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
            /// <para>The auto scaling policies of each node group in the cluster.</para>
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
                /// <para>The maximum and minimum number of nodes in the node group.</para>
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
                    /// <para>The maximum number of nodes that you can configure based on your business requirements.</para>
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
                /// <para>The ID of the auto scaling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asp-asduwe23znl***</para>
                /// </summary>
                [NameInMap("ScalingPolicyId")]
                [Validation(Required=false)]
                public string ScalingPolicyId { get; set; }

                /// <summary>
                /// <para>The type of the auto scaling policy.</para>
                /// </summary>
                [NameInMap("ScalingPolicyType")]
                [Validation(Required=false)]
                public string ScalingPolicyType { get; set; }

                /// <summary>
                /// <para>The list of auto scaling rules.</para>
                /// </summary>
                [NameInMap("ScalingRules")]
                [Validation(Required=false)]
                public List<GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPoliciesScalingRules> ScalingRules { get; set; }
                public class GetClusterCloneMetaResponseBodyClusterCloneMetaScalingPoliciesScalingRules : TeaModel {
                    /// <summary>
                    /// <para>The scaling type. This parameter is required. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>SCALE_OUT</description></item>
                    /// <item><description>SCALE_IN</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SCALE_OUT</para>
                    /// </summary>
                    [NameInMap("ActivityType")]
                    [Validation(Required=false)]
                    public string ActivityType { get; set; }

                    /// <summary>
                    /// <para>The adjustment value of the auto scaling rule. This parameter is required. The parameter value must be a positive integer, which indicates the number of instances to be added or removed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AdjustmentValue")]
                    [Validation(Required=false)]
                    public int? AdjustmentValue { get; set; }

                    /// <summary>
                    /// <para>The description of load-based scaling.</para>
                    /// </summary>
                    [NameInMap("MetricsTrigger")]
                    [Validation(Required=false)]
                    public MetricsTrigger MetricsTrigger { get; set; }

                    /// <summary>
                    /// <para>The name of the auto scaling rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>scaling-out-memory</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>The description of time-based scaling.</para>
                    /// </summary>
                    [NameInMap("TimeTrigger")]
                    [Validation(Required=false)]
                    public TimeTrigger TimeTrigger { get; set; }

                    /// <summary>
                    /// <para>The trigger mode of the auto scaling rule. This parameter is required. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>TIME_TRIGGER: time-based scaling.</description></item>
                    /// <item><description>METRICS_TRIGGER: load-based scaling.</description></item>
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
            /// <para>The security mode of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: regular mode. Kerberos is not enabled.</description></item>
            /// <item><description>KERBEROS: Kerberos mode. Kerberos is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("SecurityMode")]
            [Validation(Required=false)]
            public string SecurityMode { get; set; }

            /// <summary>
            /// <para>The subscription configurations.</para>
            /// </summary>
            [NameInMap("SubscriptionConfig")]
            [Validation(Required=false)]
            public SubscriptionConfig SubscriptionConfig { get; set; }

            /// <summary>
            /// <para>The tags.</para>
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
