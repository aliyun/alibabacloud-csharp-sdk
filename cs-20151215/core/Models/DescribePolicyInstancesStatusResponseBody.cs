// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyInstancesStatusResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The number of policy instances deployed at different governance levels in the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;high&quot;: 11,     &quot;medium&quot;: 1  }</para>
        /// </summary>
        [NameInMap("instances_severity_count")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstancesSeverityCount { get; set; }

        /// <summary>
        /// <para>The list of policy instance counts by policy type.</para>
        /// </summary>
        [NameInMap("policy_instances")]
        [Validation(Required=false)]
        public List<DescribePolicyInstancesStatusResponseBodyPolicyInstances> PolicyInstances { get; set; }
        public class DescribePolicyInstancesStatusResponseBodyPolicyInstances : Darabonba.Model {
            /// <summary>
            /// <para>The policy type. For more information about supported policy types and their descriptions, see <a href="https://help.aliyun.com/document_detail/359819.html">Container security policy rules</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>compliance</para>
            /// </summary>
            [NameInMap("policy_category")]
            [Validation(Required=false)]
            public string PolicyCategory { get; set; }

            /// <summary>
            /// <para>The policy description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Restricts use of the cluster-admin role.</para>
            /// </summary>
            [NameInMap("policy_description")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// <para>The number of deployed policy instances. If this field is empty, no policy instances of this type are deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("policy_instances_count")]
            [Validation(Required=false)]
            public long? PolicyInstancesCount { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACKRestrictRoleBindings</para>
            /// </summary>
            [NameInMap("policy_name")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The policy governance level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("policy_severity")]
            [Validation(Required=false)]
            public string PolicySeverity { get; set; }

        }

    }

}

