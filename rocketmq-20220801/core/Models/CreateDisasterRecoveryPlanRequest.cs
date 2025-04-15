// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateDisasterRecoveryPlanRequest : TeaModel {
        /// <summary>
        /// <para>Whether to enable automatic synchronization of consumption progress.</para>
        /// <remarks>
        /// <para>This is effective only when consumption progress synchronization is enabled, i.e., the value of <c>syncCheckpointEnabled</c> is true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoSyncCheckpoint")]
        [Validation(Required=false)]
        public bool? AutoSyncCheckpoint { get; set; }

        /// <summary>
        /// <para>Instances involved in the backup plan. Required</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<CreateDisasterRecoveryPlanRequestInstances> Instances { get; set; }
        public class CreateDisasterRecoveryPlanRequestInstances : TeaModel {
            /// <summary>
            /// <para>Authentication method. Not required for instanceType of ALIYUN_ROCKETMQ and version 4.0</para>
            /// <list type="bullet">
            /// <item><description>NO_AUTH: No authentication required</description></item>
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
            /// <para>Endpoint URL, not required for instanceType of ALIYUN_ROCKETMQ, but required for EXTERNAL_ROCKETMQ</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("endpointUrl")]
            [Validation(Required=false)]
            public string EndpointUrl { get; set; }

            /// <summary>
            /// <para>Instance ID, not required for instanceType of EXTERNAL_ROCKETMQ, but required for ALIYUN_ROCKETMQ</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq-cn-******</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instance role, either primary or secondary</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE: Primary</description></item>
            /// <item><description>PASSIVE: Secondary</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PASSIVE</para>
            /// </summary>
            [NameInMap("instanceRole")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// <para>Instance type</para>
            /// <list type="bullet">
            /// <item><description>ALIYUN_ROCKETMQ: Alibaba Cloud instance</description></item>
            /// <item><description>EXTERNAL_ROCKETMQ: External instance, open-source instance, open-source cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN_ROCKETMQ</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Message filtering properties. When messages are synchronized to the target cluster, this property will be automatically added for SQL filtering during message consumption.</para>
            /// </summary>
            [NameInMap("messageProperty")]
            [Validation(Required=false)]
            public CreateDisasterRecoveryPlanRequestInstancesMessageProperty MessageProperty { get; set; }
            public class CreateDisasterRecoveryPlanRequestInstancesMessageProperty : TeaModel {
                /// <summary>
                /// <para>Property key</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("propertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// <para>Property value</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbb</para>
                /// </summary>
                [NameInMap("propertyValue")]
                [Validation(Required=false)]
                public string PropertyValue { get; set; }

            }

            /// <summary>
            /// <para>Network type, not required for instanceType of ALIYUN_ROCKETMQ, but required for EXTERNAL_ROCKETMQ
            /// Parameter values are as follows:</para>
            /// <list type="bullet">
            /// <item><description>TCP_INTERNET: TCP public network</description></item>
            /// <item><description>TCP_VPC: TCP VPC (Virtual Private Cloud)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP_INTERNET</para>
            /// </summary>
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>Authentication password, required when authType is ACL_AUTH. Not required for instanceType of ALIYUN_ROCKETMQ</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>Region where the instance is located</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Security group ID, required only when the <c>instanceType</c> is EXTERNAL_ROCKETMQ and <c>networkType</c> is TCP_VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp17hpmgz9******</para>
            /// </summary>
            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>Authentication username, required when authType is ACL_AUTH</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            /// <summary>
            /// <para>The ID of the switch associated with the instance, required only when the <c>instanceType</c> is EXTERNAL_ROCKETMQ and <c>networkType</c> is TCP_VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6gwtbn6etadpv******</para>
            /// </summary>
            [NameInMap("vSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the private network associated with the created instance. The instanceType instance type is only EXTERNAL_ROCKETMQ. It is required when the networkType is TCP_VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9qt50xhtj9krb******</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>Plan description</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("planDesc")]
        [Validation(Required=false)]
        public string PlanDesc { get; set; }

        /// <summary>
        /// <para>Plan name, required</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("planName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>Backup plan type, required. Please refer to the <a href="https://help.aliyun.com/document_detail/2843187.html">documentation</a>.
        /// Parameter values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>ACTIVE_PASSIVE: One-way backup</description></item>
        /// <item><description>ACTIVE_ACTIVE: Two-way backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE_ACTIVE</para>
        /// </summary>
        [NameInMap("planType")]
        [Validation(Required=false)]
        public string PlanType { get; set; }

        /// <summary>
        /// <para>Switch for synchronizing consumption progress</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("syncCheckpointEnabled")]
        [Validation(Required=false)]
        public bool? SyncCheckpointEnabled { get; set; }

    }

}
