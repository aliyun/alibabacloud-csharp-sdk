// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpgradeDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The Serverless cache storage capacity. Unit: GB.</para>
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
        /// <para>This parameter is deprecated. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. You do not need to specify this parameter.</para>
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
        /// <para>The specifications of segment nodes. For information about supported node specifications, see <a href="https://help.aliyun.com/document_detail/35406.html">Instance specifications</a>.</para>
        /// <remarks>
        /// <para>This parameter is supported only for elastic storage mode instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4C16G</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. You do not need to specify this parameter.</para>
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
        /// <para>This parameter is deprecated. You do not need to specify this parameter.</para>
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
        /// <para>The ID of the resource group to which the instance belongs. For information about how to obtain the resource group ID, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pl0</b>: PL0.</description></item>
        /// <item><description><b>pl1</b>: PL1.</description></item>
        /// <item><description><b>pl2</b>: PL2.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pl1</para>
        /// </summary>
        [NameInMap("SegDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SegDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The number of segment nodes. The supported number of nodes varies based on the instance resource type and instance edition:</para>
        /// <list type="bullet">
        /// <item><description>Elastic storage mode, High-availability Edition: Valid values: 4 to 512. The value must be a multiple of 4.</description></item>
        /// <item><description>Elastic storage mode, &lt;props=&quot;china&quot;&gt;Basic Edition (formerly High-performance Edition)&lt;props=&quot;intl&quot;&gt;High-performance Edition: Valid values: 2 to 512. The value must be a multiple of 2.</description></item>
        /// <item><description>Serverless manual scheduling mode: Valid values: 2 to 512. The value must be a multiple of 2.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public string SegNodeNum { get; set; }

        /// <summary>
        /// <para>The cloud disk storage type after the change. Currently, only ESSD cloud disks are supported. Set the value to <b>cloud_essd</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("SegStorageType")]
        [Validation(Required=false)]
        public string SegStorageType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>Serverless instances:
        /// The compute resource threshold. Valid values: 8 to 32. The value must be a multiple of 8. Unit: ACU. Default value: 32.</para>
        /// </description></item>
        /// <item><description><para>Serverless Pro instances: The reserved compute resources. Valid values: 16 to 1024. Unit: ACU. Default value: 16. The step size varies based on the value range:</para>
        /// <list type="bullet">
        /// <item><description>16 to 32: step size of 4.</description></item>
        /// <item><description>32 to 64: step size of 8.</description></item>
        /// <item><description>64 to 128: step size of 16.</description></item>
        /// <item><description>128 to 256: step size of 32.</description></item>
        /// <item><description>Greater than 256: step size of 64.<remarks>
        /// <para>This parameter is required only for Serverless automatic scheduling mode and Serverless Pro instances.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("ServerlessResource")]
        [Validation(Required=false)]
        public string ServerlessResource { get; set; }

        /// <summary>
        /// <para>The storage capacity of segment nodes. Unit: GB. Valid values: 50 to &lt;props=&quot;china&quot;&gt;8000&lt;props=&quot;intl&quot;&gt;6000. The value must be a multiple of 50.</para>
        /// <remarks>
        /// <para>This parameter is supported only for elastic storage mode instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

        /// <summary>
        /// <para>The type of the specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): Changes the number of segment nodes. SegNodeNum is required. Other parameters do not take effect.</description></item>
        /// <item><description><b>1</b>: Changes the segment node specifications and instance storage capacity. InstanceSpec is required. StorageSize is optional and must be greater than or equal to the current instance storage capacity.</description></item>
        /// <item><description><b>2</b>: Changes the number of master nodes. MasterNodeNum is required. Other parameters do not take effect.</description></item>
        /// <item><description><b>3</b>: Changes the cloud disk storage type and performance level (PL). SegDiskPerformanceLevel and SegStorageType are required. Other parameters do not take effect.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Different instance resource types support different Upgrade/Downgrade operations for compute nodes. For more information, see <a href="https://help.aliyun.com/document_detail/50956.html">Precautions</a>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>After you select a specification change type, only the corresponding parameters take effect. Other parameters do not take effect. For example, if <b>UpgradeType</b> is set to 0 and you specify both the number of segment nodes and the number of master nodes, only the number of segment nodes is changed.</description></item>
        /// <item><description>Changing the number of master nodes is supported only on the China site (aliyun.com).</description></item>
        /// <item><description>You can change the cloud disk storage type only from standard SSD to ESSD cloud disk.</description></item>
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
