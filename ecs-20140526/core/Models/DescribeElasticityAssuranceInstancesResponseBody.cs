// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssuranceInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details about the instances that match and use the elasticity assurance.
        /// </summary>
        [NameInMap("ElasticityAssuranceItem")]
        [Validation(Required=false)]
        public DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItem ElasticityAssuranceItem { get; set; }
        public class DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItem : TeaModel {
            [NameInMap("InstanceIdSet")]
            [Validation(Required=false)]
            public List<DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItemInstanceIdSet> InstanceIdSet { get; set; }
            public class DescribeElasticityAssuranceInstancesResponseBodyElasticityAssuranceItemInstanceIdSet : TeaModel {
                /// <summary>
                /// The instance ID
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
