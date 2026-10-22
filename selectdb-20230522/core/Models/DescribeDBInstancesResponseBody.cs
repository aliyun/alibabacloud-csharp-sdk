// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instance details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesResponseBodyItems> Items { get; set; }
        public class DescribeDBInstancesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The instance edition. Default value: basic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Postpaid</b>: pay-as-you-go</description></item>
            /// <item><description><b>Prepaid</b>: subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The total number of clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public int? ClusterCount { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-7213cjv****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The deployment mode of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>multi_az: zone-redundant</description></item>
            /// <item><description>single_az: locally redundant</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>single_az</para>
            /// </summary>
            [NameInMap("DeployScheme")]
            [Validation(Required=false)]
            public string DeployScheme { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>New instance test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The minor engine version of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.0.4</para>
            /// </summary>
            [NameInMap("EngineMinorVersion")]
            [Validation(Required=false)]
            public string EngineMinorVersion { get; set; }

            /// <summary>
            /// <para>The database engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.4</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The expiration time of the cluster, in ISO 8601 format with time zone information.</para>
            /// <remarks>
            /// <para>This parameter is returned only for <b>Prepaid</b> (subscription) clusters. For <b>Postpaid</b> (pay-as-you-go) clusters, an empty value is returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-29T03:47:05Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The list of FE clusters.</para>
            /// </summary>
            [NameInMap("FEClusterList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsFEClusterList> FEClusterList { get; set; }
            public class DescribeDBInstancesResponseBodyItemsFEClusterList : TeaModel {
                /// <summary>
                /// <para>The name of the FE cluster.</para>
                /// </summary>
                [NameInMap("DbClusterId")]
                [Validation(Required=false)]
                public string DbClusterId { get; set; }

                /// <summary>
                /// <para>The number of nodes in the FE cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public long? NodeCount { get; set; }

                /// <summary>
                /// <para>The number of CPU cores per node in the FE cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SingleNodeCpuCores")]
                [Validation(Required=false)]
                public long? SingleNodeCpuCores { get; set; }

                /// <summary>
                /// <para>The memory per node in the FE cluster. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SingleNodeMemoryInGB")]
                [Validation(Required=false)]
                public long? SingleNodeMemoryInGB { get; set; }

                /// <summary>
                /// <para>The status of the FE cluster.</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The time when the task was created (GMT).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-12T04:14Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the task was modified (GMT).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-12T19:05Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The instance usage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("InstanceUsedType")]
            [Validation(Required=false)]
            public string InstanceUsedType { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The instance is deleted.</description></item>
            /// <item><description><b>fasle</b>: The instance is not deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <para>The lock mode of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public long? LockMode { get; set; }

            /// <summary>
            /// <para>The reason why the instance is locked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nolock</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>The end timestamp of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter. Not returned</para>
            /// </summary>
            [NameInMap("MaintainEndTimeStr")]
            [Validation(Required=false)]
            public string MaintainEndTimeStr { get; set; }

            /// <summary>
            /// <para>A reserved parameter that is not currently returned. The time format does not apply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter. Not returned</para>
            /// </summary>
            [NameInMap("MaintainEndtime")]
            [Validation(Required=false)]
            public string MaintainEndtime { get; set; }

            /// <summary>
            /// <para>The start timestamp of the maintenance window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter. Not returned</para>
            /// </summary>
            [NameInMap("MaintainStartTimeStr")]
            [Validation(Required=false)]
            public string MaintainStartTimeStr { get; set; }

            /// <summary>
            /// <para>A reserved parameter that is not currently returned. The time format does not apply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter. Not returned</para>
            /// </summary>
            [NameInMap("MaintainStarttime")]
            [Validation(Required=false)]
            public string MaintainStarttime { get; set; }

            /// <summary>
            /// <para>The multi-zone configuration.</para>
            /// </summary>
            [NameInMap("MultiZone")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsMultiZone> MultiZone { get; set; }
            public class DescribeDBInstancesResponseBodyItemsMultiZone : TeaModel {
                /// <summary>
                /// <para>The list of vSwitch IDs.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-k</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The instance storage size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ObjectStoreSize")]
            [Validation(Required=false)]
            public long? ObjectStoreSize { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter. Not returned</para>
            /// </summary>
            [NameInMap("ParentInstance")]
            [Validation(Required=false)]
            public string ParentInstance { get; set; }

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
            /// <para>The CPU resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ResourceCpu")]
            [Validation(Required=false)]
            public long? ResourceCpu { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter. Not returned</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The memory resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("ResourceMemory")]
            [Validation(Required=false)]
            public long? ResourceMemory { get; set; }

            /// <summary>
            /// <para>The maximum number of RDS capacity units (RCUs) in the automatic scaling range of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public long? ScaleMax { get; set; }

            /// <summary>
            /// <para>The minimum number of RDS capacity units (RCUs) in the automatic scaling range of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public long? ScaleMin { get; set; }

            /// <summary>
            /// <para>The redundant field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Null</para>
            /// </summary>
            [NameInMap("ScaleReplica")]
            [Validation(Required=false)]
            public long? ScaleReplica { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is a serverless instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Serverless")]
            [Validation(Required=false)]
            public bool? Serverless { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CREATING</b>: Creating.</para>
            /// </description></item>
            /// <item><description><para><b>ACTIVATION</b>: Running.</para>
            /// </description></item>
            /// <item><description><para><b>RESOURCE_CHANGING</b>: Changing specifications.</para>
            /// </description></item>
            /// <item><description><para><b>ORDER_PREPARING</b>: Confirming the order.</para>
            /// </description></item>
            /// <item><description><para><b>READONLY_RESOURCE_CHANGING</b>: Changing resources (the instance is locked for writing).</para>
            /// </description></item>
            /// <item><description><para><b>DELETING</b>: Deleting.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATION</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public long? StorageSize { get; set; }

            /// <summary>
            /// <para>The instance storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>The instance tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyItemsTags> Tags { get; set; }
            public class DescribeDBInstancesResponseBodyItemsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Prometheus monitoring cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter. Not returned</para>
            /// </summary>
            [NameInMap("TenantClusterId")]
            [Validation(Required=false)]
            public string TenantClusterId { get; set; }

            /// <summary>
            /// <para>The access token for Prometheus monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter. Not returned</para>
            /// </summary>
            [NameInMap("TenantToken")]
            [Validation(Required=false)]
            public string TenantToken { get; set; }

            /// <summary>
            /// <para>The user account label for Prometheus monitoring.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Reserved parameter. Not returned</para>
            /// </summary>
            [NameInMap("TenantUserId")]
            [Validation(Required=false)]
            public string TenantUserId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp175iuvg8nxqraf2****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1gzt31twhlo0sa5****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not returned</para>
            /// </summary>
            [NameInMap("connectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b> (default)</description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC854513-E85E-54F3-9842-B9CCD3308CDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
