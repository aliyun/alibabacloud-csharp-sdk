// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListDisasterRecoveryPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This parameter is returned only if the access is denied due to the reason that the Resource Access Management (RAM) user does not have the required permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return result</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListDisasterRecoveryPlansResponseBodyData Data { get; set; }
        public class ListDisasterRecoveryPlansResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Paged data</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListDisasterRecoveryPlansResponseBodyDataList> List { get; set; }
            public class ListDisasterRecoveryPlansResponseBodyDataList : TeaModel {
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
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01 20:05:50</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Extended information</para>
                /// </summary>
                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public Dictionary<string, string> ExtInfo { get; set; }

                /// <summary>
                /// <para>Instances involved in the backup plan</para>
                /// </summary>
                [NameInMap("instances")]
                [Validation(Required=false)]
                public List<ListDisasterRecoveryPlansResponseBodyDataListInstances> Instances { get; set; }
                public class ListDisasterRecoveryPlansResponseBodyDataListInstances : TeaModel {
                    /// <summary>
                    /// <para>Authentication method</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NO_AUTH</para>
                    /// </summary>
                    [NameInMap("authType")]
                    [Validation(Required=false)]
                    public string AuthType { get; set; }

                    /// <summary>
                    /// <para>Endpoint URL</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("endpointUrl")]
                    [Validation(Required=false)]
                    public string EndpointUrl { get; set; }

                    /// <summary>
                    /// <para>Instance ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rmq-cn-ot93rbxxx</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>Instance role</para>
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
                    /// <para>Message property</para>
                    /// </summary>
                    [NameInMap("messageProperty")]
                    [Validation(Required=false)]
                    public ListDisasterRecoveryPlansResponseBodyDataListInstancesMessageProperty MessageProperty { get; set; }
                    public class ListDisasterRecoveryPlansResponseBodyDataListInstancesMessageProperty : TeaModel {
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
                    /// <para>Network type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TCP_INTERNET</para>
                    /// </summary>
                    [NameInMap("networkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    /// <summary>
                    /// <para>Authentication password</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    /// <summary>
                    /// <para>The region where the instance is located</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("regionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>Security group ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-bp17hpmgz9******</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>Authentication username</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                    /// <summary>
                    /// <para>VSwitch ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-uf6gwtbn6etadpv******</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>VPC ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp13docqysrgxtbxxxx</para>
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
                /// <para>Plan ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1300000016</para>
                /// </summary>
                [NameInMap("planId")]
                [Validation(Required=false)]
                public long? PlanId { get; set; }

                /// <summary>
                /// <para>Plan name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("planName")]
                [Validation(Required=false)]
                public string PlanName { get; set; }

                /// <summary>
                /// <para>Plan status:</para>
                /// <list type="bullet">
                /// <item><description>CREATED (Created)</description></item>
                /// <item><description>RUNNING (Running)</description></item>
                /// <item><description>DELETED (Deleted)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("planStatus")]
                [Validation(Required=false)]
                public string PlanStatus { get; set; }

                /// <summary>
                /// <para>Plan type:</para>
                /// <list type="bullet">
                /// <item><description>ACTIVE_PASSIVE (One-way backup)</description></item>
                /// <item><description>ACTIVE_ACTIVE (Two-way backup)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE_PASSIVE</para>
                /// </summary>
                [NameInMap("planType")]
                [Validation(Required=false)]
                public string PlanType { get; set; }

                /// <summary>
                /// <para>Sync checkpoint switch</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("syncCheckpointEnabled")]
                [Validation(Required=false)]
                public bool? SyncCheckpointEnabled { get; set; }

                /// <summary>
                /// <para>Update time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01 20:05:50</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>Current page number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Scroll request ID.
            /// Automatically generated by the system, subsequent paging requests need to include this result to continue paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B13D0B07-F24B-4790-88D8-D47A38063D00</para>
            /// </summary>
            [NameInMap("scrollId")]
            [Validation(Required=false)]
            public string ScrollId { get; set; }

            /// <summary>
            /// <para>Total number of records</para>
            /// 
            /// <b>Example:</b>
            /// <para>28</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Dynamic error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>Dynamic error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceId</para>
        /// </summary>
        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>855EF8E6-9C1D-5DE2-9E84-924E13Exxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the operation was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
