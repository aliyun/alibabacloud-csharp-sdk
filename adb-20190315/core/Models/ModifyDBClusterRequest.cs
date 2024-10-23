// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The computing resources of the cluster. You can call the <a href="https://help.aliyun.com/document_detail/190632.html">DescribeAvailableResource</a> operation to query the computing resources that are available within a region.</para>
        /// <remarks>
        /// <para>This parameter must be specified when Mode is set to Flexible.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>32Core128GBNEW</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// <para>The edition of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cluster</b>: reserved mode for Cluster Edition.</description></item>
        /// <item><description><b>MixedStorage</b>: elastic mode for Cluster Edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set DBClusterCategory to Cluster, you must set Mode to Reserver. If you set DBClusterCategory to MixedStorage, you must set Mode to Flexible. Otherwise, you fail to change the specifications of the cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MixedStorage</para>
        /// </summary>
        [NameInMap("DBClusterCategory")]
        [Validation(Required=false)]
        public string DBClusterCategory { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1u8c0mgfg58****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The node specifications of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>C8</b></description></item>
        /// <item><description><b>C32</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter must be specified when Mode is set to Reserver.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>C32</para>
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// <para>The number of node groups. Valid values: 1 to 200.</para>
        /// <remarks>
        /// <para>This parameter must be specified when Mode is set to Reserver.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBNodeGroupCount")]
        [Validation(Required=false)]
        public string DBNodeGroupCount { get; set; }

        /// <summary>
        /// <para>The storage capacity per node. Unit: GB.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when DBClusterClass is set to C8: 100 to 2000.</description></item>
        /// <item><description>Valid values when DBClusterClass is set to C32: 100 to 8000.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter must be specified when Mode is set to Reserver.</para>
        /// </description></item>
        /// <item><description><para>The storage capacity less than 1,000 GB increases in 100 GB increments. The storage capacity greater than 1,000 GB increases in 1,000 GB increments.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("DBNodeStorage")]
        [Validation(Required=false)]
        public string DBNodeStorage { get; set; }

        /// <summary>
        /// <para>The enhanced SSD (ESSD) performance level of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0</description></item>
        /// <item><description>PL1</description></item>
        /// <item><description>PL2</description></item>
        /// <item><description>PL3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("DiskPerformanceLevel")]
        [Validation(Required=false)]
        public string DiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The number of EIUs. The number of EIUs that you can purchase varies based on the single-node EIU specifications.</para>
        /// <list type="bullet">
        /// <item><description>If the single-node EIU specifications are 8 cores and 64 GB, you can purchase up to 32 EIUs.</description></item>
        /// <item><description>If the single-node EIU specifications are 12 cores and 96 GB, you can purchase up to 16 EIUs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ElasticIOResource")]
        [Validation(Required=false)]
        public int? ElasticIOResource { get; set; }

        /// <summary>
        /// <para>The single-node specifications of an elastic I/O unit (EIU). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>8Core64GB</b>: If you set the parameter to <b>8Core64GB</b>, the specifications of an EIU are 24 cores and 192 GB memory.</description></item>
        /// <item><description><b>12Core96GB</b>: If you set the parameter to <b>12Core96GB</b>, the specifications of an EIU are 36 cores and 288 GB memory.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only when your cluster meets the following requirements:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The cluster is in elastic mode.</para>
        /// </description></item>
        /// <item><description><para>If the cluster resides in the China (Guangzhou), China (Shenzhen), China (Hangzhou), China (Shanghai), China (Qingdao), China (Beijing), or China (Zhangjiakou) region, the cluster has 16 cores and 64 GB memory or higher specifications.</para>
        /// </description></item>
        /// <item><description><para>If the cluster resides in another region, the cluster has 32 cores and 128 GB memory or higher specifications.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8Core64GB</para>
        /// </summary>
        [NameInMap("ElasticIOResourceSize")]
        [Validation(Required=false)]
        public string ElasticIOResourceSize { get; set; }

        /// <summary>
        /// <para>N/A</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ExecutorCount")]
        [Validation(Required=false)]
        public string ExecutorCount { get; set; }

        /// <summary>
        /// <para>The mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Reserver</b>: the reserved mode.</description></item>
        /// <item><description><b>Flexible</b>: the elastic mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Flexible</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The change type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Upgrade</b></description></item>
        /// <item><description><b>Downgrade</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster. You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>N/A</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

    }

}
