// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeNetworkInsightsAnalysisesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NetworkInsightsAnalysisSets")]
        [Validation(Required=false)]
        public DescribeNetworkInsightsAnalysisesResponseBodyNetworkInsightsAnalysisSets NetworkInsightsAnalysisSets { get; set; }
        public class DescribeNetworkInsightsAnalysisesResponseBodyNetworkInsightsAnalysisSets : TeaModel {
            [NameInMap("NetworkInsightsAnalysisSet")]
            [Validation(Required=false)]
            public List<DescribeNetworkInsightsAnalysisesResponseBodyNetworkInsightsAnalysisSetsNetworkInsightsAnalysisSet> NetworkInsightsAnalysisSet { get; set; }
            public class DescribeNetworkInsightsAnalysisesResponseBodyNetworkInsightsAnalysisSetsNetworkInsightsAnalysisSet : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("NetworkInsightsAnalysisId")]
                [Validation(Required=false)]
                public string NetworkInsightsAnalysisId { get; set; }

                [NameInMap("NetworkInsightsPathId")]
                [Validation(Required=false)]
                public string NetworkInsightsPathId { get; set; }

                [NameInMap("NetworkPathFound")]
                [Validation(Required=false)]
                public string NetworkPathFound { get; set; }

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
