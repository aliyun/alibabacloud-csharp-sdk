// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribePolicyInstancesStatusResponseBody : TeaModel {
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public DescribePolicyInstancesStatusResponseBodyPolicies Policies { get; set; }
        public class DescribePolicyInstancesStatusResponseBodyPolicies : TeaModel {
            [NameInMap("PolicyInstances")]
            [Validation(Required=false)]
            public List<DescribePolicyInstancesStatusResponseBodyPoliciesPolicyInstances> PolicyInstances { get; set; }
            public class DescribePolicyInstancesStatusResponseBodyPoliciesPolicyInstances : TeaModel {
                [NameInMap("PolicyCategory")]
                [Validation(Required=false)]
                public string PolicyCategory { get; set; }

                [NameInMap("PolicyClusters")]
                [Validation(Required=false)]
                public List<DescribePolicyInstancesStatusResponseBodyPoliciesPolicyInstancesPolicyClusters> PolicyClusters { get; set; }
                public class DescribePolicyInstancesStatusResponseBodyPoliciesPolicyInstancesPolicyClusters : TeaModel {
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("PolicyDescription")]
                [Validation(Required=false)]
                public string PolicyDescription { get; set; }

                [NameInMap("PolicyInstancesCount")]
                [Validation(Required=false)]
                public long? PolicyInstancesCount { get; set; }

                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                [NameInMap("PolicySeverity")]
                [Validation(Required=false)]
                public string PolicySeverity { get; set; }

            }

            [NameInMap("SeverityInfo")]
            [Validation(Required=false)]
            public List<DescribePolicyInstancesStatusResponseBodyPoliciesSeverityInfo> SeverityInfo { get; set; }
            public class DescribePolicyInstancesStatusResponseBodyPoliciesSeverityInfo : TeaModel {
                [NameInMap("SeverityCount")]
                [Validation(Required=false)]
                public string SeverityCount { get; set; }

                [NameInMap("SeverityType")]
                [Validation(Required=false)]
                public string SeverityType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
