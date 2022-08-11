// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyInstancesResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<DescribePolicyInstancesResponseBody> Body { get; set; }
        public class DescribePolicyInstancesResponseBody : TeaModel {
            [NameInMap("ali_uid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("policy_name")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("policy_category")]
            [Validation(Required=false)]
            public string PolicyCategory { get; set; }

            [NameInMap("policy_description")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            [NameInMap("policy_parameters")]
            [Validation(Required=false)]
            public string PolicyParameters { get; set; }

            [NameInMap("policy_severity")]
            [Validation(Required=false)]
            public string PolicySeverity { get; set; }

            [NameInMap("policy_scope")]
            [Validation(Required=false)]
            public string PolicyScope { get; set; }

            [NameInMap("policy_action")]
            [Validation(Required=false)]
            public string PolicyAction { get; set; }

        }

    }

}
