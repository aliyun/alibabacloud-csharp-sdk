// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetDisasterRecoveryPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This parameter is returned only if the access is denied because the Resource Access Management (RAM) user does not have the required permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDisasterRecoveryPlanResponseBodyData Data { get; set; }
        public class GetDisasterRecoveryPlanResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Whether to enable automatic synchronization of consumption progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoSyncCheckpoint")]
            [Validation(Required=false)]
            public bool? AutoSyncCheckpoint { get; set; }

            /// <summary>
            /// <para>The time when the backup plan was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 20:05:50</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Additional Information</para>
            /// </summary>
            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtInfo { get; set; }

            /// <summary>
            /// <para>Instances involved in the backup plan</para>
            /// </summary>
            [NameInMap("instances")]
            [Validation(Required=false)]
            public List<GetDisasterRecoveryPlanResponseBodyDataInstances> Instances { get; set; }
            public class GetDisasterRecoveryPlanResponseBodyDataInstances : TeaModel {
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

                [NameInMap("consumerGroupId")]
                [Validation(Required=false)]
                public string ConsumerGroupId { get; set; }

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
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rmq-cn-gpz3qtcdxxx</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Instance role, either primary or secondary </para>
                /// <list type="bullet">
                /// <item><description>ACTIVE: Primary</description></item>
                /// <item><description>PASSIVE: Secondary</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
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
                public GetDisasterRecoveryPlanResponseBodyDataInstancesMessageProperty MessageProperty { get; set; }
                public class GetDisasterRecoveryPlanResponseBodyDataInstancesMessageProperty : TeaModel {
                    /// <summary>
                    /// <para>Property key</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("propertyKey")]
                    [Validation(Required=false)]
                    public string PropertyKey { get; set; }

                    /// <summary>
                    /// <para>Property value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("propertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                }

                /// <summary>
                /// <para>Network type, not required for instanceType of ALIYUN_ROCKETMQ, but required for EXTERNAL_ROCKETMQ Parameter values are as follows:</para>
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
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Security group ID, required only when the instanceType is EXTERNAL_ROCKETMQ and networkType is TCP_VPC.</para>
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
                /// <para>The ID of the switch associated with the instance, required only when the instanceType is EXTERNAL_ROCKETMQ and networkType is TCP_VPC.</para>
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
            /// <para>The describe of the global message backup plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("planDesc")]
            [Validation(Required=false)]
            public string PlanDesc { get; set; }

            /// <summary>
            /// <para>The ID of the global message backup plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1300000016</para>
            /// </summary>
            [NameInMap("planId")]
            [Validation(Required=false)]
            public long? PlanId { get; set; }

            /// <summary>
            /// <para>The name of the global message backup plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("planName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The status of the global message backup plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("planStatus")]
            [Validation(Required=false)]
            public string PlanStatus { get; set; }

            /// <summary>
            /// <para>The type of the global message backup plan.
            /// values are as follows:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE_PASSIVE: One-way backup</description></item>
            /// <item><description>ACTIVE_ACTIVE: Two-way backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE_PASSIVE</para>
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

            /// <summary>
            /// <para>The time when the backup plan was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-01 20:05:50</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7358418D-83BD-507A-8079-611C63E0xxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
