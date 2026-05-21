// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class SearchMultiAccountResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<SearchMultiAccountResourcesResponseBodyFilters> Filters { get; set; }
        public class SearchMultiAccountResourcesResponseBodyFilters : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Equals</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The values of the filter condition.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFA806B9-7F36-55AB-8B7A-D680C2C5EE57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<SearchMultiAccountResourcesResponseBodyResources> Resources { get; set; }
        public class SearchMultiAccountResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The ID of the management account or member of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151266687691****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The time when the resource was created.</para>
            /// <remarks>
            /// <para> Whether this parameter is returned is determined by the Alibaba Cloud service to which the resource belongs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-30T09:20:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the resource expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-14T14:35:45Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The attributes of the IP address.</para>
            /// </summary>
            [NameInMap("IpAddressAttributes")]
            [Validation(Required=false)]
            public List<SearchMultiAccountResourcesResponseBodyResourcesIpAddressAttributes> IpAddressAttributes { get; set; }
            public class SearchMultiAccountResourcesResponseBodyResourcesIpAddressAttributes : TeaModel {
                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.2</para>
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// <para>The network type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Public</b>: the Internet</description></item>
                /// <item><description><b>Private</b>: internal network</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Public</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ipv4</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The IP addresses.</para>
            /// <remarks>
            /// <para> Whether this parameter is returned is determined by the Alibaba Cloud service to which the resource belongs.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("IpAddresses")]
            [Validation(Required=false)]
            public List<string> IpAddresses { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
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
            /// <para>rg-acfmzawhxxc****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp11lbh452fr8940s****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::VPC::RouteTable</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<SearchMultiAccountResourcesResponseBodyResourcesTags> Tags { get; set; }
            public class SearchMultiAccountResourcesResponseBodyResourcesTags : TeaModel {
                /// <summary>
                /// <para>The key of tag N.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag N.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The zone ID.</para>
            /// <remarks>
            /// <para> Whether this parameter is returned is determined by the Alibaba Cloud service to which the resource belongs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The search scope.</para>
        /// <list type="bullet">
        /// <item><description>ID of a resource directory: Resources within the management account and all members of the resource directory are searched.</description></item>
        /// <item><description>ID of the Root folder: Resources within all members in the Root folder and the subfolders of the Root folder are searched.</description></item>
        /// <item><description>ID of a folder: Resources within all members in the folder are searched.</description></item>
        /// <item><description>ID of a member: Resources within the member are searched.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rd-r4****</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
