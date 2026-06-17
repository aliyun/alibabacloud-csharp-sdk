// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpgradeDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the cache storage for Serverless Pro instances. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is required only for Serverless Pro instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("CacheStorageSize")]
        [Validation(Required=false)]
        public string CacheStorageSize { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("DBInstanceGroupCount")]
        [Validation(Required=false)]
        public string DBInstanceGroupCount { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances in the specified region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-rj***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The specifications of segment nodes. For supported node specifications, see <a href="https://help.aliyun.com/document_detail/35406.html">Instance types</a>.</para>
        /// <remarks>
        /// <para>This parameter is available only for instances in storage-elastic mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4C16G</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>The number of master nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MasterNodeNum")]
        [Validation(Required=false)]
        public string MasterNodeNum { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query available region IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. To obtain the resource group ID, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>pl0</b>: PL0.</para>
        /// </description></item>
        /// <item><description><para><b>pl1</b>: PL1.</para>
        /// </description></item>
        /// <item><description><para><b>pl2</b>: PL2.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pl1</para>
        /// </summary>
        [NameInMap("SegDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SegDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The number of segment nodes. The supported number of nodes varies based on the instance resource type and edition:</para>
        /// <list type="bullet">
        /// <item><description><para>Instances in storage-elastic mode (High-availability Edition): 4 to 512, in increments of 4.</para>
        /// </description></item>
        /// <item><description><para>Instances in storage-elastic mode (High-performance Edition): 2 to 512, in increments of 2.</para>
        /// </description></item>
        /// <item><description><para>Instances in Serverless manual-scheduling mode: 2 to 512, in increments of 2.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public string SegNodeNum { get; set; }

        /// <summary>
        /// <para>The new disk storage type. You can only upgrade to an ESSD cloud disk. To do so, set this parameter to <b>cloud_essd</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("SegStorageType")]
        [Validation(Required=false)]
        public string SegStorageType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>For an instance in Serverless automatic-scheduling mode, this parameter specifies the computing resource threshold. The value must be a multiple of 8 in the range of 8 to 32. Unit: ACU. Default value: 32.</para>
        /// </description></item>
        /// <item><description><para>For a Serverless Pro instance, this parameter specifies the reserved computing resources. Valid values range from 16 to 1,024. Unit: ACU. Default value: 16. Increment rules:</para>
        /// <list type="bullet">
        /// <item><description><para>16 to 32: in increments of 4.</para>
        /// </description></item>
        /// <item><description><para>32 to 64: in increments of 8.</para>
        /// </description></item>
        /// <item><description><para>64 to 128: in increments of 16.</para>
        /// </description></item>
        /// <item><description><para>128 to 256: in increments of 32.</para>
        /// </description></item>
        /// <item><description><para>Greater than 256: in increments of 64.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only for instances in Serverless automatic-scheduling mode and Serverless Pro instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("ServerlessResource")]
        [Validation(Required=false)]
        public string ServerlessResource { get; set; }

        /// <summary>
        /// <para>The storage capacity of each segment node. Unit: GB. The value must be a multiple of 50 in the range of 50 to &lt;props=&quot;china&quot;&gt;8,000&lt;props=&quot;intl&quot;&gt;6,000.</para>
        /// <remarks>
        /// <para>This parameter is available only for instances in storage-elastic mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

        /// <summary>
        /// <para>The type of specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): Changes the number of segment nodes. The SegNodeNum parameter is required, and other parameters are ignored.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Changes the specifications and storage capacity of segment nodes. The InstanceSpec parameter is required. The StorageSize parameter is optional. If specified, its value must be greater than or equal to the current storage capacity of the instance.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Changes the number of master nodes. The MasterNodeNum parameter is required, and other parameters are ignored.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Changes the disk storage type and performance level. The SegDiskPerformanceLevel and SegStorageType parameters are required, and other parameters are ignored.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Support for scaling computing resources varies by instance resource type. For more information, see <a href="https://help.aliyun.com/document_detail/50956.html">Usage notes</a>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you select a change type, only the parameters associated with that type take effect; other parameters are ignored. For example, if you set <b>UpgradeType</b> to 0 and specify parameters to change both the number of segment nodes and the number of master nodes, only the parameters for changing the number of segment nodes take effect.</para>
        /// </description></item>
        /// <item><description><para>You can change the number of master nodes only on the Alibaba Cloud China site.</para>
        /// </description></item>
        /// <item><description><para>You can change the disk storage type only from ultra disk to ESSD cloud disk.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public long? UpgradeType { get; set; }

    }

}
