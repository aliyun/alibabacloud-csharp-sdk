// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateDisasterRecoveryPlanRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic consumer automatic synchronization.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when consumer automatic synchronization is enabled. That is, the <c>syncCheckpointEnabled</c> field is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoSyncCheckpoint")]
        [Validation(Required=false)]
        public bool? AutoSyncCheckpoint { get; set; }

        /// <summary>
        /// <para>The instances involved in the backup plan. This parameter is required.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<CreateDisasterRecoveryPlanRequestInstances> Instances { get; set; }
        public class CreateDisasterRecoveryPlanRequestInstances : TeaModel {
            /// <summary>
            /// <para>The authentication method. This parameter is not required if instanceType is set to ALIYUN_ROCKETMQ and the instance version is 4.0. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NO_AUTH: no authentication</description></item>
            /// <item><description>ACL_AUTH: ACL authentication</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACL_AUTH</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The ID of the consumer group, which is used to pull messages from the source instance.
            /// <notice>This parameter is required for self-managed instances. For Alibaba Cloud instances, this parameter is automatically generated.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_DS_XXX_YYY</para>
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The endpoint URL. This parameter is not required if instanceType is set to ALIYUN_ROCKETMQ. This parameter is required if instanceType is set to EXTERNAL_ROCKETMQ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("endpointUrl")]
            [Validation(Required=false)]
            public string EndpointUrl { get; set; }

            /// <summary>
            /// <para>The instance ID. This parameter is not required if instanceType is set to EXTERNAL_ROCKETMQ. This parameter is required if instanceType is set to ALIYUN_ROCKETMQ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-******</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The role of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE: primary</description></item>
            /// <item><description>PASSIVE: secondary</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASSIVE</para>
            /// </summary>
            [NameInMap("instanceRole")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// <para>The type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALIYUN_ROCKETMQ: Alibaba Cloud instance</description></item>
            /// <item><description>EXTERNAL_ROCKETMQ: external instance, open-source instance, or open-source cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN_ROCKETMQ</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The message filtering property. When a message is synchronized to the destination cluster, this property is automatically added to the message for SQL-based filtering during message consumption.</para>
            /// </summary>
            [NameInMap("messageProperty")]
            [Validation(Required=false)]
            public CreateDisasterRecoveryPlanRequestInstancesMessageProperty MessageProperty { get; set; }
            public class CreateDisasterRecoveryPlanRequestInstancesMessageProperty : TeaModel {
                /// <summary>
                /// <para>The key of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("propertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// <para>The value of the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbb</para>
                /// </summary>
                [NameInMap("propertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

            }

            /// <summary>
            /// <para>The network type. This parameter is not required if instanceType is set to ALIYUN_ROCKETMQ. This parameter is required if instanceType is set to EXTERNAL_ROCKETMQ. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP_INTERNET: TCP over the Internet</description></item>
            /// <item><description>TCP_VPC: TCP over a VPC</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP_INTERNET</para>
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The password for authentication. This parameter is required if authType is set to ACL_AUTH. This parameter is not required if instanceType is set to ALIYUN_ROCKETMQ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The region where the instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the security group. This parameter is required only if instanceType is set to EXTERNAL_ROCKETMQ and networkType is set to TCP_VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp17hpmgz9******</para>
            /// </summary>
            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The username for authentication. This parameter is required if authType is set to ACL_AUTH.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch with which the instance is associated. This parameter is required only if instanceType is set to EXTERNAL_ROCKETMQ and networkType is set to TCP_VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6gwtbn6etadpv******</para>
            /// </summary>
            [NameInMap("vSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC with which the instance is associated. This parameter is required only if instanceType is set to EXTERNAL_ROCKETMQ and networkType is set to TCP_VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9qt50xhtj9krb******</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The description of the plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("planDesc")]
        [Validation(Required=false)]
        public string PlanDesc { get; set; }

        /// <summary>
        /// <para>The name of the plan. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The type of the backup plan. This parameter is required. For more information, see <a href="https://help.aliyun.com/document_detail/2843187.html">Global Replicator</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACTIVE_PASSIVE: one-way backup</description></item>
        /// <item><description>ACTIVE_ACTIVE: two-way backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE_ACTIVE</para>
        /// </summary>
        [NameInMap("planType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable consumer offset synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("syncCheckpointEnabled")]
        [Validation(Required=false)]
        public bool? SyncCheckpointEnabled { get; set; }

    }

}
