// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssuranceInstancesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public DescribeElasticityAssuranceInstancesRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class DescribeElasticityAssuranceInstancesRequestPrivatePoolOptions : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=true)]
            public string Id { get; set; }
        };

    }

}
