// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRoutersResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68521297-5FA6-46CB-B4EB-658F1C68C8CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of transit routers.</para>
        /// </summary>
        [NameInMap("TransitRouters")]
        [Validation(Required=false)]
        public List<ListTransitRoutersResponseBodyTransitRouters> TransitRouters { get; set; }
        public class ListTransitRoutersResponseBodyTransitRouters : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the CEN instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1210123456123456</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The ID of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-j3jzhw1zpau2km****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The time when the transit router was created.</para>
            /// <para>The time follows the ISO8601 standard in the <c>YYYY-MM-DDThh:mmZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-15T09:39Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the region where the transit router is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the transit router. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The transit router is being created.</description></item>
            /// <item><description><b>Active</b>: The transit router is available.</description></item>
            /// <item><description><b>Modifying</b>: The transit router is being modified</description></item>
            /// <item><description><b>Deleting</b>: The transit router is being deleted.</description></item>
            /// <item><description><b>Upgrading</b>: The transit router is being upgraded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether multicast is enabled for the transit router. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled</description></item>
            /// <item><description><b>false</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportMulticast")]
            [Validation(Required=false)]
            public bool? SupportMulticast { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRoutersResponseBodyTransitRoutersTags> Tags { get; set; }
            public class ListTransitRoutersResponseBodyTransitRoutersTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TagKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TagValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The CIDR blocks of the transit router.</para>
            /// </summary>
            [NameInMap("TransitRouterCidrList")]
            [Validation(Required=false)]
            public List<ListTransitRoutersResponseBodyTransitRoutersTransitRouterCidrList> TransitRouterCidrList { get; set; }
            public class ListTransitRoutersResponseBodyTransitRoutersTransitRouterCidrList : TeaModel {
                /// <summary>
                /// <para>The CIDR block of the transit router.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.0/24</para>
                /// </summary>
                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                /// <summary>
                /// <para>The description of the CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CIDRdesc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CIDRname</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the system is allowed to automatically add a route to the route table of the transit router. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: yes</para>
                /// <para>A value of <b>true</b> indicates that after you create a private VPN connection and create a route learning correlation for the private VPC connection, the system automatically adds the following route to the route table of the transit router that is in route learning correlation with the private VPN connection: A blackhole route whose destination CIDR block is the CIDR block of the transit router. The CIDR block of the transit router refers to the CIDR block from which gateway IP addresses are allocated to IPsec-VPN connections. </para>
                /// <para>The blackhole route is advertised only to the route tables of virtual border routers (VBRs) that are connected to the transit router. </para>
                /// </description></item>
                /// <item><description><para><b>false</b>: no</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PublishCidrRoute")]
                [Validation(Required=false)]
                public bool? PublishCidrRoute { get; set; }

                /// <summary>
                /// <para>The ID of the CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cidr-46p5ceg21e8152****</para>
                /// </summary>
                [NameInMap("TransitRouterCidrId")]
                [Validation(Required=false)]
                public string TransitRouterCidrId { get; set; }

            }

            /// <summary>
            /// <para>The description of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdesc</para>
            /// </summary>
            [NameInMap("TransitRouterDescription")]
            [Validation(Required=false)]
            public string TransitRouterDescription { get; set; }

            /// <summary>
            /// <para>The ID of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-bp1su1ytdxtataupl****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// <para>The name of the transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testname</para>
            /// </summary>
            [NameInMap("TransitRouterName")]
            [Validation(Required=false)]
            public string TransitRouterName { get; set; }

            /// <summary>
            /// <para>The edition of the transit router. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enterprise</b>: Enhance Edition</description></item>
            /// <item><description><b>Basic</b>: Basic Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enterprise</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
