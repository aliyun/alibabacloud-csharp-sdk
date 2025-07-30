// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The information returned.</para>
        /// </summary>
        [NameInMap("CanUpgradeVersions")]
        [Validation(Required=false)]
        public List<string> CanUpgradeVersions { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-14T03:00:42Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The information about each cluster returned.</para>
        /// </summary>
        [NameInMap("DBClusterList")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyDBClusterList> DBClusterList { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyDBClusterList : TeaModel {
            /// <summary>
            /// <para>The cache size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("CacheStorageSizeGB")]
            [Validation(Required=false)]
            public string CacheStorageSizeGB { get; set; }

            /// <summary>
            /// <para>The cache type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("CacheStorageType")]
            [Validation(Required=false)]
            public string CacheStorageType { get; set; }

            /// <summary>
            /// <para>The billing method of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
            /// <item><description><b>Prepaid</b>: subscription.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("ClusterBinding")]
            [Validation(Required=false)]
            public string ClusterBinding { get; set; }

            [NameInMap("ClusterNodeCount")]
            [Validation(Required=false)]
            public int? ClusterNodeCount { get; set; }

            [NameInMap("ClusterNodeType")]
            [Validation(Required=false)]
            public string ClusterNodeType { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public long? CpuCores { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-14T09:24:13Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The specifications of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>selectdb.xlarge</b>: 4 CPU cores and 32 GB of memory.</description></item>
            /// <item><description><b>selectdb.2xlarge</b>: 8 CPU cores and 64 GB of memory.</description></item>
            /// <item><description><b>selectdb.4xlarge</b>: 16 CPU cores and 128 GB of memory.</description></item>
            /// <item><description><b>selectdb.8xlarge</b>: 32 CPU cores and 256 GB of memory.</description></item>
            /// <item><description><b>selectdb.16xlarge</b>: 64 CPU cores and 512 GB of memory.</description></item>
            /// <item><description><b>selectdb.24xlarge</b>: 96 CPU cores and 768 GB of memory.</description></item>
            /// <item><description><b>selectdb.32xlarge</b>: 128 CPU cores and 1,024 GB of memory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb.2xlarge</para>
            /// </summary>
            [NameInMap("DbClusterClass")]
            [Validation(Required=false)]
            public string DbClusterClass { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>selectdb-cn-h033cjs****-be</para>
            /// </summary>
            [NameInMap("DbClusterId")]
            [Validation(Required=false)]
            public string DbClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("DbClusterName")]
            [Validation(Required=false)]
            public string DbClusterName { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test instance</para>
            /// </summary>
            [NameInMap("DbInstanceName")]
            [Validation(Required=false)]
            public string DbInstanceName { get; set; }

            /// <summary>
            /// <para>The memory size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The modified time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-02T16:35:44+08:00</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The performance level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public double? ScaleMax { get; set; }

            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public double? ScaleMin { get; set; }

            [NameInMap("ScalingRulesEnable")]
            [Validation(Required=false)]
            public bool? ScalingRulesEnable { get; set; }

            /// <summary>
            /// <para>The time when the cluster started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-14T09:24:13Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The state of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CREATING</b>: The cluster is being created.</description></item>
            /// <item><description><b>ACTIVATION</b>: The cluster is running.</description></item>
            /// <item><description><b>RESOURCE_CHANGING</b>: The resource configuration of the cluster is being changed.</description></item>
            /// <item><description><b>ORDER_PREPARING</b>: The order is being confirmed.</description></item>
            /// <item><description><b>READONLY_RESOURCE_CHANGING</b>: The resource configuration of the cluster is being changed and the cluster is write-locked.</description></item>
            /// <item><description><b>DELETING</b>: The cluster is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVATION</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubDomain")]
            [Validation(Required=false)]
            public string SubDomain { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DeployScheme")]
        [Validation(Required=false)]
        public string DeployScheme { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The database engine of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The minor kernel version number of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0.1</para>
        /// </summary>
        [NameInMap("EngineMinorVersion")]
        [Validation(Required=false)]
        public string EngineMinorVersion { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The time when the instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-17T00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The time when the instance was last modified, such as when you restarted the instance or applied for a public endpoint for the instance. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-17T09:58Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The lock mode of the instance. Set the value to <b>lock</b>, which specifies that the instance is locked when it automatically expires or has an overdue payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lock</para>
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
        /// <para>The end time of the instance maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1970-01-01T05:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndtime")]
        [Validation(Required=false)]
        public string MaintainEndtime { get; set; }

        /// <summary>
        /// <para>The start time of the instance maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1970-01-01T02:00Z</para>
        /// </summary>
        [NameInMap("MaintainStarttime")]
        [Validation(Required=false)]
        public string MaintainStarttime { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MultiZone")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyMultiZone> MultiZone { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyMultiZone : TeaModel {
            [NameInMap("AvailableIpCount")]
            [Validation(Required=false)]
            public long? AvailableIpCount { get; set; }

            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The storage capacity of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ObjectStoreSize")]
        [Validation(Required=false)]
        public long? ObjectStoreSize { get; set; }

        /// <summary>
        /// <para>The Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06758CAB-1204-5852-A471-29C87D5C1D0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of CPU cores of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("ResourceCpu")]
        [Validation(Required=false)]
        public long? ResourceCpu { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzbck4asz3dsa</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Serverless")]
        [Validation(Required=false)]
        public bool? Serverless { get; set; }

        /// <summary>
        /// <para>The state of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CREATING</b>: The instance is being created.</description></item>
        /// <item><description><b>ACTIVATION</b>: The instance is running.</description></item>
        /// <item><description><b>RESOURCE_CHANGING</b>: The resource configuration of the instance is being changed.</description></item>
        /// <item><description><b>ORDER_PREPARING</b>: The order is being confirmed.</description></item>
        /// <item><description><b>READONLY_RESOURCE_CHANGING</b>: The resource configuration of the instance is being changed and the instance is write-locked.</description></item>
        /// <item><description><b>DELETING</b>: The instance is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVATION</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The cache size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>The subdomain zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h-aliyun</para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// <para>The tags that are added to the instances. Each tag is a key-value pair that consists of two parts: TagKey and TagValue. Format: <c>{&quot;key1&quot;:&quot;value1&quot;}</c>.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceAttributeResponseBodyTags> Tags { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyTags : TeaModel {
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

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

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
        /// <para>The Zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
