// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClustersRequest : TeaModel {
        /// <summary>
        /// <para>The description of the cluster.</para>
        /// <list type="bullet">
        /// <item><description>The description cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description must be 2 to 256 characters in length</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// <para>If you do not specify this parameter, the information about all clusters that reside in the region is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// <para>The state of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Preparing</b></description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description><b>Creating</b></description></item>
        /// <item><description><b>Running</b></description></item>
        /// <item><description><b>Deleting</b></description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description><b>Restoring</b></description></item>
        /// </list>
        /// <!---->
        /// 
        /// <list type="bullet">
        /// <item><description><b>ClassChanging</b></description></item>
        /// <item><description><b>NetAddressCreating</b></description></item>
        /// <item><description><b>NetAddressDeleting</b></description></item>
        /// <item><description><b>NetAddressModifying</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// <para>The database engine version of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>3.0: Data Warehouse Edition.</description></item>
        /// <item><description>5.0 (default): Data Lakehouse Edition, Enterprise Edition, and Basic Edition.</description></item>
        /// <item><description>All: Data Warehouse Edition, Data Lakehouse Edition, Enterprise Edition, and Basic Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("DBClusterVersion")]
        [Validation(Required=false)]
        public string DBClusterVersion { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

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
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The edition of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EnterpriseVersion: Enterprise Edition.</description></item>
        /// <item><description>BasicVersion: Basic Edition.</description></item>
        /// </list>
        /// <para>If you leave this parameter empty, the information about clusters of all editions is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BasicVersion</para>
        /// </summary>
        [NameInMap("ProductVersion")]
        [Validation(Required=false)]
        public string ProductVersion { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/454314.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The resource group ID. If you do not specify this parameter, the information about all resource groups in the cluster is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-4690g37929****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags that are added to the cluster.</para>
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
