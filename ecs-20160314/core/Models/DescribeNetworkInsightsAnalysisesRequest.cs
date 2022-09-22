// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeNetworkInsightsAnalysisesRequest : TeaModel {
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NetworkInsightsAnalysisId")]
        [Validation(Required=false)]
        public List<string> NetworkInsightsAnalysisId { get; set; }

        [NameInMap("NetworkInsightsPathId")]
        [Validation(Required=false)]
        public string NetworkInsightsPathId { get; set; }

        [NameInMap("NetworkPathFound")]
        [Validation(Required=false)]
        public string NetworkPathFound { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
