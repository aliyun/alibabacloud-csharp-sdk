// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeNetworkInsightsPathsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NetworkInsightsPathSets")]
        [Validation(Required=false)]
        public DescribeNetworkInsightsPathsResponseBodyNetworkInsightsPathSets NetworkInsightsPathSets { get; set; }
        public class DescribeNetworkInsightsPathsResponseBodyNetworkInsightsPathSets : TeaModel {
            [NameInMap("NetworkInsightsPathSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInsightsPathsResponseBodyNetworkInsightsPathSetsNetworkInsightsPathSet> NetworkInsightsPathSet { get; set; }
            public class DescribeNetworkInsightsPathsResponseBodyNetworkInsightsPathSetsNetworkInsightsPathSet : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Destination")]
                [Validation(Required=false)]
                public string Destination { get; set; }

                [NameInMap("DestinationPort")]
                [Validation(Required=false)]
                public string DestinationPort { get; set; }

                [NameInMap("DestinationType")]
                [Validation(Required=false)]
                public string DestinationType { get; set; }

                [NameInMap("NetworkInsightsPathId")]
                [Validation(Required=false)]
                public string NetworkInsightsPathId { get; set; }

                [NameInMap("NetworkInsightsPathName")]
                [Validation(Required=false)]
                public string NetworkInsightsPathName { get; set; }

                [NameInMap("NetworkPathFound")]
                [Validation(Required=false)]
                public string NetworkPathFound { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
