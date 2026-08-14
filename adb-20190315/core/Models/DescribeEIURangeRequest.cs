// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeEIURangeRequest : TeaModel {
        /// <summary>
        /// <para>The specifications of the compute resources.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/469002.html">DescribeComputeResource</a> operation to query the specifications of compute resources.</para>
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
        /// <para>The ID of the Data Lakehouse Edition cluster.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter can be left empty when <b>Operation</b> is set to <b>Buy</b>.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when <b>Operation</b> is set to <b>Upgrade</b> or <b>Downgrade</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/129857.html">DescribeDBClusters</a> operation to query the ID of the Data Lakehouse Edition cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp16t5ci7r74s****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The cluster version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>3.0</b> (default): Data Lakehouse Edition.</para>
        /// </description></item>
        /// <item><description><para><b>5.0</b>: includes Data Lakehouse Edition, Enterprise Edition, and Basic Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Buy</b>: Purchase a cluster.</para>
        /// </description></item>
        /// <item><description><para><b>Modify</b>: Change the specifications of a cluster.</para>
        /// </description></item>
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
        /// <para>The edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>EnterpriseVersion</b>: Enterprise Edition.</para>
        /// </description></item>
        /// <item><description><para><b>BasicVersion</b>: Basic Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseVersion</para>
        /// </summary>
        [NameInMap("ProductVersion")]
        [Validation(Required=false)]
        public string ProductVersion { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/143074.html">DescribeRegions</a> operation to query the region ID of the cluster.</para>
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
        /// <para>The specifications of the storage resources. The default value is <b>8ACU</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>8ACU</b></para>
        /// </description></item>
        /// <item><description><para><b>12ACU</b></para>
        /// </description></item>
        /// <item><description><para><b>16ACU</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8ACU</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

        /// <summary>
        /// <para>The sub-operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Upgrade</b>: Upgrade a cluster.</para>
        /// </description></item>
        /// <item><description><para><b>Downgrade</b>: Downgrade a cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("SubOperation")]
        [Validation(Required=false)]
        public string SubOperation { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/612293.html">DescribeDBClusters</a> operation to query the zone ID of the cluster.</para>
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
