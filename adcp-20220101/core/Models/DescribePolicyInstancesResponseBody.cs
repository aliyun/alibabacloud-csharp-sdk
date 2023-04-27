// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribePolicyInstancesResponseBody : TeaModel {
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribePolicyInstancesResponseBodyPolicies> Policies { get; set; }
        public class DescribePolicyInstancesResponseBodyPolicies : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("PolicyAction")]
            [Validation(Required=false)]
            public string PolicyAction { get; set; }

            [NameInMap("PolicyCategory")]
            [Validation(Required=false)]
            public string PolicyCategory { get; set; }

            [NameInMap("PolicyDescription")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("PolicyParameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> PolicyParameters { get; set; }

            [NameInMap("PolicyScope")]
            [Validation(Required=false)]
            public string PolicyScope { get; set; }

            [NameInMap("PolicySeverity")]
            [Validation(Required=false)]
            public string PolicySeverity { get; set; }

            [NameInMap("TotalViolations")]
            [Validation(Required=false)]
            public long? TotalViolations { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
