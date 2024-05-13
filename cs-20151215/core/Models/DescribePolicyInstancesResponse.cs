// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyInstancesResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribePolicyInstancesResponseBody> Body { get; set; }
        public class DescribePolicyInstancesResponseBody : TeaModel {
            /// <summary>
            /// The UID of the Alibaba Cloud account that is used to deploy the policy instance.
            /// </summary>
            [NameInMap("ali_uid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the policy instance.
            /// </summary>
            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("policy_name")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The type of policy.
            /// </summary>
            [NameInMap("policy_category")]
            [Validation(Required=false)]
            public string PolicyCategory { get; set; }

            /// <summary>
            /// The description of the policy template.
            /// </summary>
            [NameInMap("policy_description")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// The parameters of the policy instance.
            /// </summary>
            [NameInMap("policy_parameters")]
            [Validation(Required=false)]
            public string PolicyParameters { get; set; }

            /// <summary>
            /// The severity level of the policy instance.
            /// </summary>
            [NameInMap("policy_severity")]
            [Validation(Required=false)]
            public string PolicySeverity { get; set; }

            /// <summary>
            /// The applicable scope of the policy instance.
            /// 
            /// A value of \\* indicates all namespaces in the cluster. This is the default value.
            /// 
            /// Multiple namespaces are separated by commas (,).
            /// </summary>
            [NameInMap("policy_scope")]
            [Validation(Required=false)]
            public string PolicyScope { get; set; }

            /// <summary>
            /// The action of the policy. Valid values:
            /// 
            /// *   `deny`: Deployments that match the policy are denied.
            /// *   `warn`: Alerts are generated for deployments that match the policy.
            /// </summary>
            [NameInMap("policy_action")]
            [Validation(Required=false)]
            public string PolicyAction { get; set; }

        }

    }

}
