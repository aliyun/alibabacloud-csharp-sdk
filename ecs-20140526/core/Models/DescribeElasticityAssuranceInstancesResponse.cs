// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssuranceInstancesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=true)]
        public int? MaxResults { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("ElasticityAssuranceItem")]
        [Validation(Required=true)]
        public DescribeElasticityAssuranceInstancesResponseElasticityAssuranceItem ElasticityAssuranceItem { get; set; }
        public class DescribeElasticityAssuranceInstancesResponseElasticityAssuranceItem : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=true)]
            public List<DescribeElasticityAssuranceInstancesResponseElasticityAssuranceItemInstanceIdSet> InstanceIdSet { get; set; }
            public class DescribeElasticityAssuranceInstancesResponseElasticityAssuranceItemInstanceIdSet : TeaModel {
                public string InstanceId { get; set; }
            }
        };

    }

}
