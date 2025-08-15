// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateDisasterRecoveryPlanRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic consumer progress synchronization.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when you set <c>syncCheckpointEnabled</c> to true.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoSyncCheckpoint")]
        [Validation(Required=false)]
        public bool? AutoSyncCheckpoint { get; set; }

        /// <summary>
        /// <para>The instances involved in the Global Replicator task. After you create a Global Replicator task, you cannot change the instances involved in the task. You can change only the message attribute and authentication type of the task.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<UpdateDisasterRecoveryPlanRequestInstances> Instances { get; set; }
        public class UpdateDisasterRecoveryPlanRequestInstances : TeaModel {
            /// <summary>
            /// <para>The authentication type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NO_AUTH: no authentication</description></item>
            /// <item><description>ACL_AUTH: access control list (ACL)-based authentication</description></item>
            /// </list>
            /// <!---->
            /// 
            /// <list type="bullet">
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO_AUTH</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>The consumer group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GID_DS_XXX_YYY</para>
            /// </summary>
            [NameInMap("consumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The instance endpoint. This parameter is required only if you set instanceType to EXTERNAL_ROCKETMQ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("endpointUrl")]
            [Validation(Required=false)]
            public string EndpointUrl { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-83l3r0xxxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE: primary instance</description></item>
            /// <item><description>Passive: secondary instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("instanceRole")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALIYUN_ROCKETMQ: ApsaraMQ for RocketMQ instance</description></item>
            /// <item><description>EXTERNAL_ROCKETMQ: open source RocketMQ cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN_ROCKETMQ</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The message attribute. When you synchronize a message to the destination cluster, the system automatically adds the attribute to the message for SQL-based filtering.</para>
            /// </summary>
            [NameInMap("messageProperty")]
            [Validation(Required=false)]
            public UpdateDisasterRecoveryPlanRequestInstancesMessageProperty MessageProperty { get; set; }
            public class UpdateDisasterRecoveryPlanRequestInstancesMessageProperty : TeaModel {
                /// <summary>
                /// <para>The attribute key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("propertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// <para>The attribute value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbb</para>
                /// </summary>
                [NameInMap("propertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

            }

            /// <summary>
            /// <para>The network type. This parameter is required only if you set instanceType to EXTERNAL_ROCKETMQ. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP_INTERNET: Internet over TCP</description></item>
            /// <item><description>TCP_VPC: virtual private cloud (VPC) over TCP.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP_INTERNET</para>
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The password used for authentication. This parameter is required only if you set authType to ACL_AUTH.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The ID of the region where the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the security group to which the instance belongs. This parameter is required only if you set instanceType to EXTERNAL_ROCKETMQ and networkType to TCP_VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp17hpmgz9******</para>
            /// </summary>
            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The username used for authentication. This parameter is required only if you set authType to ACL_AUTH.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch with which the instance is associated. This parameter is required only if you set instanceType to EXTERNAL_ROCKETMQ and networkType to TCP_VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6gwtbn6etadpv******</para>
            /// </summary>
            [NameInMap("vSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC with which the instance is associated. This parameter is required only if you set instanceType to EXTERNAL_ROCKETMQ and networkType to TCP_VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9qt50xhtj9krb******</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The description of the Global Replicator task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("planDesc")]
        [Validation(Required=false)]
        public string PlanDesc { get; set; }

        /// <summary>
        /// <para>The name of the Global Replicator task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The type of the Global Replicator task. After you create a Global Replicator task, you cannot change the type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACTIVE_PASSIVE: one-way backup</description></item>
        /// <item><description>ACTIVE_ACTIVE: two-way backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE_PASSIVE</para>
        /// </summary>
        [NameInMap("planType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable consumer progress synchronization.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("syncCheckpointEnabled")]
        [Validation(Required=false)]
        public bool? SyncCheckpointEnabled { get; set; }

    }

}
