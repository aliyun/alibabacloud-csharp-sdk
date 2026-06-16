// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("regions")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegions> Regions { get; set; }
        public class DescribeRegionsResponseBodyRegions : TeaModel {
            [NameInMap("internetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            [NameInMap("localName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("vpcEndpoint")]
            [Validation(Required=false)]
            public string VpcEndpoint { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
