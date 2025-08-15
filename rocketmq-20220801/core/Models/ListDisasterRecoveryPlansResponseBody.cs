// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListDisasterRecoveryPlansResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListDisasterRecoveryPlansResponseBodyData Data { get; set; }
        public class ListDisasterRecoveryPlansResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Global Replicator tasks.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListDisasterRecoveryPlansResponseBodyDataList> List { get; set; }
            public class ListDisasterRecoveryPlansResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic consumer progress synchronization is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoSyncCheckpoint")]
                [Validation(Required=false)]
                public bool? AutoSyncCheckpoint { get; set; }

                /// <summary>
                /// <para>The time when the query task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01 20:05:50</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The extended information.</para>
                /// </summary>
                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public Dictionary<string, string> ExtInfo { get; set; }

                /// <summary>
                /// <para>The instances involved in the Global Replicator task.</para>
                /// </summary>
                [NameInMap("instances")]
                [Validation(Required=false)]
                public List<ListDisasterRecoveryPlansResponseBodyDataListInstances> Instances { get; set; }
                public class ListDisasterRecoveryPlansResponseBodyDataListInstances : TeaModel {
                    /// <summary>
                    /// <para>The authentication type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NO_AUTH</para>
                    /// </summary>
                    [NameInMap("authType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    /// <summary>
                    /// <para>The ID of the consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GID_ui_xxx</para>
                    /// </summary>
                    [NameInMap("consumerGroupId")]
                    [Validation(Required=false)]
                    public string ConsumerGroupId { get; set; }

                    /// <summary>
                    /// <para>The endpoint.</para>
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
                    /// <para>rmq-cn-ot93rbxxx</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The instance role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACTIVE</para>
                    /// </summary>
                    [NameInMap("instanceRole")]
                    [Validation(Required=false)]
                    public string InstanceRole { get; set; }

                    /// <summary>
                    /// <para>The instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ALIYUN_ROCKETMQ</para>
                    /// </summary>
                    [NameInMap("instanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The message attribute.</para>
                    /// </summary>
                    [NameInMap("messageProperty")]
                    [Validation(Required=false)]
                    public ListDisasterRecoveryPlansResponseBodyDataListInstancesMessageProperty MessageProperty { get; set; }
                    public class ListDisasterRecoveryPlansResponseBodyDataListInstancesMessageProperty : TeaModel {
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
                    /// <para>The network type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP_INTERNET</para>
                    /// </summary>
                    [NameInMap("networkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    /// <summary>
                    /// <para>The password used for authentication.</para>
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
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-bp17hpmgz9******</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The username used for authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-uf6gwtbn6etadpv******</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The virtual private cloud (VPC) ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp13docqysrgxtbxxxx</para>
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
                /// <para>The ID of the Global Replicator task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1300000016</para>
                /// </summary>
                [NameInMap("planId")]
                [Validation(Required=false)]
                public long? PlanId { get; set; }

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
                /// <para>The status of the Global Replicator task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CREATED</description></item>
                /// <item><description>RUNNING</description></item>
                /// <item><description>DELETED</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("planStatus")]
                [Validation(Required=false)]
                public string PlanStatus { get; set; }

                /// <summary>
                /// <para>The type of the Global Replicator task. Valid values:</para>
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
                /// <para>Indicates whether consumer progress synchronization is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("syncCheckpointEnabled")]
                [Validation(Required=false)]
                public bool? SyncCheckpointEnabled { get; set; }

                /// <summary>
                /// <para>The time when the query task was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01 20:05:50</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The scroll ID of the request. The ID is automatically generated by the system. The result can be paginated only if this parameter is included in the pagination request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B13D0B07-F24B-4790-88D8-D47A38063D00</para>
            /// </summary>
            [NameInMap("scrollId")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
        /// <para>The returned dynamic error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The response code.</para>
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
        /// <para>855EF8E6-9C1D-5DE2-9E84-924E13Exxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the information about the service was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
