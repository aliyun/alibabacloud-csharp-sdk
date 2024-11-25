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
            /// <para>The UID of the Alibaba Cloud account that is used to deploy the policy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16298168****</para>
            /// </summary>
            [NameInMap("ali_uid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c8155823d057948c69a****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the policy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>no-env-var-secrets-****</para>
            /// </summary>
            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACKPSPCapabilities</para>
            /// </summary>
            [NameInMap("policy_name")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The type of policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-general</para>
            /// </summary>
            [NameInMap("policy_category")]
            [Validation(Required=false)]
            public string PolicyCategory { get; set; }

            /// <summary>
            /// <para>The description of the policy template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Restricts secrets used in pod envs</para>
            /// </summary>
            [NameInMap("policy_description")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// <para>The parameters of the policy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;restrictedNamespaces&quot;: [ &quot;test&quot; ]</para>
            /// </summary>
            [NameInMap("policy_parameters")]
            [Validation(Required=false)]
            public string PolicyParameters { get; set; }

            /// <summary>
            /// <para>The severity level of the policy instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("policy_severity")]
            [Validation(Required=false)]
            public string PolicySeverity { get; set; }

            /// <summary>
            /// <para>The applicable scope of the policy instance.</para>
            /// <para>A value of \* indicates all namespaces in the cluster. This is the default value.</para>
            /// <para>Multiple namespaces are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("policy_scope")]
            [Validation(Required=false)]
            public string PolicyScope { get; set; }

            /// <summary>
            /// <para>The action of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>deny</c>: Deployments that match the policy are denied.</description></item>
            /// <item><description><c>warn</c>: Alerts are generated for deployments that match the policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>deny</para>
            /// </summary>
            [NameInMap("policy_action")]
            [Validation(Required=false)]
            public string PolicyAction { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Creation time (deprecated, do not use).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-29T18:09:12+08:00</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            [Obsolete]
            public string Created { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Update time (deprecated, do not use).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-29T18:09:12+08:00</para>
            /// </summary>
            [NameInMap("Updated")]
            [Validation(Required=false)]
            [Obsolete]
            public string Updated { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Resource ID (deprecated, do not use).</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456***</para>
            /// </summary>
            [NameInMap("resource_id")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResourceId { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Violation count processing in the cluster (deprecated, do not use).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("total_violations")]
            [Validation(Required=false)]
            [Obsolete]
            public long? TotalViolations { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>Deletion status (deprecated, do not use).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("is_deleted")]
            [Validation(Required=false)]
            [Obsolete]
            public long? IsDeleted { get; set; }

        }

    }

}
