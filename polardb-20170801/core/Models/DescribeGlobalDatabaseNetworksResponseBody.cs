// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGlobalDatabaseNetworksResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the GDNs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeGlobalDatabaseNetworksResponseBodyItems> Items { get; set; }
        public class DescribeGlobalDatabaseNetworksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the GDN was created. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-03-23T05:46:54Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Details about clusters in the GDN.</para>
            /// </summary>
            [NameInMap("DBClusters")]
            [Validation(Required=false)]
            public List<DescribeGlobalDatabaseNetworksResponseBodyItemsDBClusters> DBClusters { get; set; }
            public class DescribeGlobalDatabaseNetworksResponseBodyItemsDBClusters : TeaModel {
                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-****************</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The region ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The role of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Primary</b>: the primary cluster</description></item>
                /// <item><description><b>standby</b>: the secondary cluster</description></item>
                /// </list>
                /// <remarks>
                /// <para>A GDN consists of one primary cluster and up to four secondary clusters. For more information, see <a href="https://help.aliyun.com/document_detail/160381.html">GDN</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>primary</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>The type of the database engine. Only <b>MySQL</b> is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The version of the database engine. Only the <b>8.0</b> version is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.0</para>
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// <para>The description of the GDN. The description must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description>It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
            /// <item><description>It must start with a letter.</description></item>
            /// <item><description>It can contain letters, digits, underscores (_), and hyphens (-).</description></item>
            /// <item><description>It must be 2 to 126 characters in length.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GDNDescription")]
            [Validation(Required=false)]
            public string GDNDescription { get; set; }

            /// <summary>
            /// <para>The ID of the GDN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gdn-****************</para>
            /// </summary>
            [NameInMap("GDNId")]
            [Validation(Required=false)]
            public string GDNId { get; set; }

            /// <summary>
            /// <para>The status of the GDN. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The GDN is being created.</description></item>
            /// <item><description><b>active</b>: The GDN is running.</description></item>
            /// <item><description><b>deleting</b>: The GDN is being deleted.</description></item>
            /// <item><description><b>locked</b>: The GDN is locked. If the GDN is locked, you cannot perform operations on clusters in the GDN.</description></item>
            /// <item><description><b>removing_member</b>: The secondary cluster is being removed from the GDN.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("GDNStatus")]
            [Validation(Required=false)]
            public string GDNStatus { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public DescribeGlobalDatabaseNetworksResponseBodyItemsLabels Labels { get; set; }
            public class DescribeGlobalDatabaseNetworksResponseBodyItemsLabels : TeaModel {
                [NameInMap("GDNVersion")]
                [Validation(Required=false)]
                public string GDNVersion { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69A85BAF-1089-4CDF-A82F-0A140F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
