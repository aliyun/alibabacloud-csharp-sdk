// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeEIURangeRequest : TeaModel {
        /// <summary>
        /// <para>The specifications of computing resources.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/469002.html">DescribeComputeResource</a> operation to query the specifications of computing resources.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;RealValue&quot;: &quot;32Core128GBNEW&quot;,
        ///       &quot;DisplayValue&quot;: &quot;32Core128GB&quot;
        ///     }</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.</para>
        /// <list type="bullet">
        /// <item><description>This parameter can be left empty when <b>Operation</b> is set to <b>Buy</b>.</description></item>
        /// <item><description>This parameter must be specified when <b>Operation</b> is set to <b>Upgrade</b> or <b>Downgrade</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp16t5ci7r74s****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The version of the AnalyticDB for MySQL Data Warehouse Edition cluster. Set the value to <b>3.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// <para>The type of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Buy</b>: purchases a cluster.</description></item>
        /// <item><description><b>Modify</b>: changes configurations of a cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Buy</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-4690g37929****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The specifications of storage resources. Default value: <b>8ACU</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>8ACU</b></description></item>
        /// <item><description><b>12ACU</b></description></item>
        /// <item><description><b>16ACU</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8ACU</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

        /// <summary>
        /// <para>The type of the sub-operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Upgrade</b>: upgrades a cluster.</description></item>
        /// <item><description><b>Downgrade</b>: downgrades a cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("SubOperation")]
        [Validation(Required=false)]
        public string SubOperation { get; set; }

        /// <summary>
        /// <para>The zone ID of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/612293.html">DescribeRegions</a> operation to query the most recent zone list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
