// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSceneDefensePoliciesResponseBody : TeaModel {
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeSceneDefensePoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribeSceneDefensePoliciesResponseBodyPolicies : TeaModel {
            [NameInMap("Done")]
            [Validation(Required=false)]
            public int? Done { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ObjectCount")]
            [Validation(Required=false)]
            public int? ObjectCount { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("RuntimePolicies")]
            [Validation(Required=false)]
            public List<DescribeSceneDefensePoliciesResponseBodyPoliciesRuntimePolicies> RuntimePolicies { get; set; }
            public class DescribeSceneDefensePoliciesResponseBodyPoliciesRuntimePolicies : TeaModel {
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public int? PolicyType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("oldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

            }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
