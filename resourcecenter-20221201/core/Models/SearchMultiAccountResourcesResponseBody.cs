// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class SearchMultiAccountResourcesResponseBody : TeaModel {
        /// <summary>
        /// The filter conditions.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<SearchMultiAccountResourcesResponseBodyFilters> Filters { get; set; }
        public class SearchMultiAccountResourcesResponseBodyFilters : TeaModel {
            /// <summary>
            /// The key of the filter condition.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The matching mode.
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// The values of the filter condition.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// The maximum number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<SearchMultiAccountResourcesResponseBodyResources> Resources { get; set; }
        public class SearchMultiAccountResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// The ID of the management account or member of the resource directory.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The time when the resource was created.
            /// 
            /// >  Whether this parameter is returned is determined by the Alibaba Cloud service to which the resource belongs.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the resource expires.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The attributes of the IP address.
            /// </summary>
            [NameInMap("IpAddressAttributes")]
            [Validation(Required=false)]
            public List<SearchMultiAccountResourcesResponseBodyResourcesIpAddressAttributes> IpAddressAttributes { get; set; }
            public class SearchMultiAccountResourcesResponseBodyResourcesIpAddressAttributes : TeaModel {
                /// <summary>
                /// The IP address.
                /// </summary>
                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                /// <summary>
                /// The network type. Valid values:
                /// 
                /// *   **Public**: the Internet
                /// *   **Private**: internal network
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The version.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The IP addresses.
            /// 
            /// >  Whether this parameter is returned is determined by the Alibaba Cloud service to which the resource belongs.
            /// </summary>
            [NameInMap("IpAddresses")]
            [Validation(Required=false)]
            public List<string> IpAddresses { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The resource ID.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The resource name.
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// The resource type.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<SearchMultiAccountResourcesResponseBodyResourcesTags> Tags { get; set; }
            public class SearchMultiAccountResourcesResponseBodyResourcesTags : TeaModel {
                /// <summary>
                /// The key of tag N.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of tag N.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The zone ID.
            /// 
            /// >  Whether this parameter is returned is determined by the Alibaba Cloud service to which the resource belongs.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The search scope.
        /// 
        /// *   ID of a resource directory: Resources within the management account and all members of the resource directory are searched.
        /// *   ID of the Root folder: Resources within all members in the Root folder and the subfolders of the Root folder are searched.
        /// *   ID of a folder: Resources within all members in the folder are searched.
        /// *   ID of a member: Resources within the member are searched.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
