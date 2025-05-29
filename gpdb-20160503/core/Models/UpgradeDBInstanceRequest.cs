// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UpgradeDBInstanceRequest : TeaModel {
        [NameInMap("CacheStorageSize")]
        [Validation(Required=false)]
        public string CacheStorageSize { get; set; }

        /// <summary>
        /// <para>This parameter is no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>This parameter is no longer used.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances within a region.</para>
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
        /// <para>The specifications of each compute node. For information about the supported specifications, see <a href="https://help.aliyun.com/document_detail/35406.html">Instance specifications</a>.</para>
        /// <remarks>
        /// <para>This parameter is available only for instances in elastic storage mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4C16G</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>This parameter is no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MasterNodeNum")]
        [Validation(Required=false)]
        public string MasterNodeNum { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. For information about how to obtain the ID of a resource group, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The performance level of Enterprise SSDs (ESSDs). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pl0</b></description></item>
        /// <item><description><b>pl1</b></description></item>
        /// <item><description><b>pl2</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pl1</para>
        /// </summary>
        [NameInMap("SegDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SegDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The number of compute nodes. The number of compute nodes varies based on the instance resource type and edition.</para>
        /// <list type="bullet">
        /// <item><description>Valid values for High-availability Edition instances in elastic storage mode: 4 to 512, in 4 increments.</description></item>
        /// <item><description>Valid values for High-performance Edition instances in elastic storage mode: 2 to 512, in 2 increments.</description></item>
        /// <item><description>Valid values for instances in manual Serverless mode: 2 to 512, in 2 increments.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public string SegNodeNum { get; set; }

        /// <summary>
        /// <para>The disk storage type of the instance after the change. The disk storage type can be changed only to ESSD. Set the value to <b>cloud_essd</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("SegStorageType")]
        [Validation(Required=false)]
        public string SegStorageType { get; set; }

        [NameInMap("ServerlessResource")]
        [Validation(Required=false)]
        public string ServerlessResource { get; set; }

        /// <summary>
        /// <para>The storage capacity of each compute node. Unit: GB. Valid values: 50 to 6000, in 50 increments.</para>
        /// <remarks>
        /// <para> This parameter is available only for instances in elastic storage mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

        /// <summary>
        /// <para>The type of the instance configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): changes the number of compute nodes.</description></item>
        /// <item><description><b>1</b>: changes the specifications and storage capacity of each compute node.</description></item>
        /// <item><description><b>2</b>: changes the number of coordinator nodes.</description></item>
        /// <item><description><b>3</b>: changes the disk storage type and ESSD performance level of the instance.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The supported changes to compute node configurations vary based on the instance resource type. For more information, see the &quot;Usage notes&quot; section of the <a href="https://help.aliyun.com/document_detail/50956.html">Change compute node configurations</a> topic.</para>
        /// </description></item>
        /// <item><description><para>After you specify a change type, only the corresponding parameters take effect. For example, if you set <b>UpgradeType</b> to 0, the parameter that is used to change the number of compute nodes takes effect, but the parameter that is used to change the number of coordinator nodes does not.</para>
        /// </description></item>
        /// <item><description><para>The number of coordinator nodes can be changed only on the China site (aliyun.com).</para>
        /// </description></item>
        /// <item><description><para>The disk storage type can be changed only from ultra disks to ESSDs.</para>
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
