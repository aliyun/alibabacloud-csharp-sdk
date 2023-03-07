// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class SearchMultiAccountResourcesResponseBody : TeaModel {
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<SearchMultiAccountResourcesResponseBodyFilters> Filters { get; set; }
        public class SearchMultiAccountResourcesResponseBodyFilters : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<SearchMultiAccountResourcesResponseBodyResources> Resources { get; set; }
        public class SearchMultiAccountResourcesResponseBodyResources : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("IpAddresses")]
            [Validation(Required=false)]
            public List<string> IpAddresses { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<SearchMultiAccountResourcesResponseBodyResourcesTags> Tags { get; set; }
            public class SearchMultiAccountResourcesResponseBodyResourcesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
