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
            /// <para>策略实例实施者UID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>16298168****</para>
            /// </summary>
            [NameInMap("ali_uid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>目标集群ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>c8155823d057948c69a****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>规则实例名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>no-env-var-secrets-****</para>
            /// </summary>
            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>策略治理规则名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACKPSPCapabilities</para>
            /// </summary>
            [NameInMap("policy_name")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>策略类型名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-general</para>
            /// </summary>
            [NameInMap("policy_category")]
            [Validation(Required=false)]
            public string PolicyCategory { get; set; }

            /// <summary>
            /// <para>规则模板描述。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Restricts secrets used in pod envs</para>
            /// </summary>
            [NameInMap("policy_description")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// <para>当前规则实例的配置参数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;restrictedNamespaces&quot;: [ &quot;test&quot; ]</para>
            /// </summary>
            [NameInMap("policy_parameters")]
            [Validation(Required=false)]
            public string PolicyParameters { get; set; }

            /// <summary>
            /// <para>规则实例治理等级。</para>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("policy_severity")]
            [Validation(Required=false)]
            public string PolicySeverity { get; set; }

            /// <summary>
            /// <para>策略实例实施范围：</para>
            /// <para>默认&quot;*&quot;代表集群所有命名空间。</para>
            /// <para>否则返回作用Namespaces名称，多个Namespaces以逗号（,）分隔。</para>
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
            /// <para>规则治理动作，取值：</para>
            /// <list type="bullet">
            /// <item><description><para><c>deny</c>：拦截违规部署。</para>
            /// </description></item>
            /// <item><description><para><c>warn</c>：告警。</para>
            /// </description></item>
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
            /// <para>创建时间（已废弃，请勿使用）。</para>
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
            /// <para>更新时间（已废弃，请勿使用）。</para>
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
            /// <para>资源ID（已废弃，请勿使用）。</para>
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
            /// <para>集群中处理违规计数（已废弃，请勿使用）。</para>
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
            /// <para>删除状态（已废弃，请勿使用）。</para>
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
