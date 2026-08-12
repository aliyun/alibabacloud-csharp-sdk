// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeNodeGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission verification failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,     &quot;AuthPrincipalOwnerId&quot;: &quot;xxx&quot;,     &quot;EncodedDiagnosticMessage&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalType&quot;: &quot;xxx&quot;,     &quot;AuthPrincipalDisplayName&quot;: &quot;xxx&quot;,     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,     &quot;AuthAction&quot;: &quot;sr:xxx&quot;   }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeNodeGroupsResponseBodyData> Data { get; set; }
        public class DescribeNodeGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: The account is in a normal state.</description></item>
            /// <item><description>OVERDUE: The account has an overdue payment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OVERDUE</para>
            /// </summary>
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            /// <summary>
            /// <para>The compute group architecture. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>onEci: Deployed on Elastic Container Instance (ECI).</description></item>
            /// <item><description>onECS: Deployed on Elastic Compute Service (ECS).</description></item>
            /// <item><description>onBareMetal: Deployed on a bare metal resource pool.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>onEci</para>
            /// </summary>
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            /// <summary>
            /// <para>The creation time of the compute group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742179008000</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>The instance ID associated with the bill. For default compute groups (FE compute group and default BE compute group), this value is the instance ID. Otherwise, it is the compute group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-96f3bc7f04b2****</para>
            /// </summary>
            [NameInMap("BillingInstanceId")]
            [Validation(Required=false)]
            public string BillingInstanceId { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emapreduce_starrockspost_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The compute group type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FE</description></item>
            /// <item><description>BE</description></item>
            /// <item><description>CN</description></item>
            /// <item><description>OBSERVER</description></item>
            /// <item><description>AGENT</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FE</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// <para>The number of CUs. A CU (Compute Unit) is the basic metering unit of the service. 1 CU = 1 CPU core + 4 GiB memory. When SpecType is memory-enhanced instance family, 1 CU = 1 CPU core + 8 GiB memory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public int? Cu { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the default compute group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultGroup")]
            [Validation(Required=false)]
            public bool? DefaultGroup { get; set; }

            /// <summary>
            /// <para>The compute group description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ETL compute group</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The number of disks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DiskNumber")]
            [Validation(Required=false)]
            public int? DiskNumber { get; set; }

            /// <summary>
            /// <para>The number of elastic nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ElasticNodeNumber")]
            [Validation(Required=false)]
            public int? ElasticNodeNumber { get; set; }

            /// <summary>
            /// <para>Indicates whether public network access is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnablePublicNetwork")]
            [Validation(Required=false)]
            public bool? EnablePublicNetwork { get; set; }

            /// <summary>
            /// <para>The compute group endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>be-c-79b0bb9f58ef****-internal.starrocks.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The expiration time of the compute group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742179008000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The HTTP port of the compute group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8030</para>
            /// </summary>
            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public int? HttpPort { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-96f3bc7f04b2****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The local SSD instance type of the node group. This value is meaningful only when the deployment is based on ECS instances and SpecType is local SSD or large-scale storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>local_ssd_4_4xlarge</para>
            /// </summary>
            [NameInMap("LocalStorageInstanceType")]
            [Validation(Required=false)]
            public string LocalStorageInstanceType { get; set; }

            /// <summary>
            /// <para>The ratio of memory size to the number of CUs. The value is 8 when SpecType is memory-enhanced instance family, and 4 for other specification types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("MemoryCpuRatio")]
            [Validation(Required=false)]
            public int? MemoryCpuRatio { get; set; }

            /// <summary>
            /// <para>The compute group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-5e2ba600fee3****</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>The compute group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng_1</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <para>The information about nodes in the compute group.</para>
            /// </summary>
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeNodeGroupsResponseBodyDataNodeInfo> NodeInfo { get; set; }
            public class DescribeNodeGroupsResponseBodyDataNodeInfo : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-e1733d44-0</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

            /// <summary>
            /// <para>The billing type:</para>
            /// <ol>
            /// <item><description>Subscription (prePaid).</description></item>
            /// <item><description>Pay-as-you-go (postPaid).</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>prePaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The public network address. This field has a value only when EnablePublicNetwork is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe-c-79b0bb9f58ef****.starrocks.aliyuncs.com</para>
            /// </summary>
            [NameInMap("PublicAddress")]
            [Validation(Required=false)]
            public string PublicAddress { get; set; }

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
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ResidentNodeNumber")]
            [Validation(Required=false)]
            public int? ResidentNodeNumber { get; set; }

            /// <summary>
            /// <para>The duration that the compute group has been running. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("RunningTime")]
            [Validation(Required=false)]
            public long? RunningTime { get; set; }

            /// <summary>
            /// <para>The compute group specification type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: Standard.</description></item>
            /// <item><description>localSSD: Local SSD.</description></item>
            /// <item><description>bigData: Large-scale storage.</description></item>
            /// <item><description>ramEnhanced: Memory-enhanced instance family.</description></item>
            /// <item><description>networkEnhanced: Network-enhanced.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("SpecType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>The compute group status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>UNPAID: Unpaid.</description></item>
            /// <item><description>PAID: Paid.</description></item>
            /// <item><description>CREATING_FAILED: Creation failed.</description></item>
            /// <item><description>CREATING: Being created.</description></item>
            /// <item><description>RUNNING: Running.</description></item>
            /// <item><description>MODIFYING_CONFIG: Configuration being modified.</description></item>
            /// <item><description>MODIFYING_TIMEZONE: Time zone being modified.</description></item>
            /// <item><description>ELASTIC_SCALING_OUT: Elastic scale-out in progress.</description></item>
            /// <item><description>ELASTIC_SCALING_IN: Elastic scale-in in progress.</description></item>
            /// <item><description>SCALING_OUT: Scale-out in progress.</description></item>
            /// <item><description>RESTARTING: Restarting.</description></item>
            /// <item><description>SCALING_IN: Scale-in in progress.</description></item>
            /// <item><description>SCALING_UP: Upgrading specifications.</description></item>
            /// <item><description>SCALING_DOWN: Downgrading specifications.</description></item>
            /// <item><description>UPGRADING: Upgrading.</description></item>
            /// <item><description>ENABLE_PUBLIC_NETWORK: Enabling public network access.</description></item>
            /// <item><description>DISABLE_PUBLIC_NETWORK: Disabling public network access.</description></item>
            /// <item><description>SWITCH_AZ: Switching zone.</description></item>
            /// <item><description>DISABLE: Disabled.</description></item>
            /// <item><description>DELETING: Being deleted.</description></item>
            /// <item><description>DELETED: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The performance level (PL) of the cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pl0: Maximum random read/write IOPS of 10,000 per disk.</description></item>
            /// <item><description>pl1: Maximum random read/write IOPS of 50,000 per disk.</description></item>
            /// <item><description>pl2: Maximum random read/write IOPS of 100,000 per disk.</description></item>
            /// <item><description>pl3: Maximum random read/write IOPS of 1,000,000 per disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pl1</para>
            /// </summary>
            [NameInMap("StoragePerformanceLevel")]
            [Validation(Required=false)]
            public string StoragePerformanceLevel { get; set; }

            /// <summary>
            /// <para>The storage size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeNodeGroupsResponseBodyDataTags> Tags { get; set; }
            public class DescribeNodeGroupsResponseBodyDataTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The target number of elastic nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TargetElasticNodeNumber")]
            [Validation(Required=false)]
            public int? TargetElasticNodeNumber { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F285E0EC-E928-5E0B-B2C3-7F3FE42F2BE5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
