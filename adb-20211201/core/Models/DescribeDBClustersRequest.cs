// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClustersRequest : TeaModel {
        /// <summary>
        /// <para>The cluster description.</para>
        /// <list type="bullet">
        /// <item><description><para>Cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </description></item>
        /// <item><description><para>The description must be 2 to 256 characters long.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>If you omit this parameter, the operation returns information about all clusters in the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// <para>The cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Preparing</b>: The cluster is preparing.</para>
        /// </description></item>
        /// <item><description><para><b>Creating</b>: The cluster is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The cluster is running.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: The cluster is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>Restoring</b>: The cluster is being restored from a backup.</para>
        /// </description></item>
        /// <item><description><para><b>ClassChanging</b>: The cluster specifications are changing.</para>
        /// </description></item>
        /// <item><description><para><b>NetAddressCreating</b>: A network connection is being created for the cluster.</para>
        /// </description></item>
        /// <item><description><para><b>NetAddressDeleting</b>: The network connection of the cluster is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>NetAddressModifying</b>: The network connection of the cluster is being modified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// <para>The cluster version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>3.0</b>: Data Warehouse edition.</para>
        /// </description></item>
        /// <item><description><para><b>5.0</b> (default): Includes the Lakehouse, Enterprise, and Basic editions.</para>
        /// </description></item>
        /// <item><description><para><b>All</b>: All editions, including the Data Warehouse, Lakehouse, Enterprise, and Basic editions.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>EnterpriseVersion</b>: Enterprise edition.</para>
        /// </description></item>
        /// <item><description><para><b>BasicVersion</b>: Basic edition.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you omit this parameter, the operation returns clusters of all product versions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BasicVersion</para>
        /// </summary>
        [NameInMap("ProductVersion")]
        [Validation(Required=false)]
        public string ProductVersion { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the IDs of available regions.</para>
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
        /// <para>The ID of the resource group. If you omit this parameter, the operation returns information about clusters in all resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-4690g37929****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags to filter clusters by.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDBClustersRequestTag> Tag { get; set; }
        public class DescribeDBClustersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
