// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSceneDefensePoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed configurations of the scenario-specific policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeSceneDefensePoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribeSceneDefensePoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The execution status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: not executed or execution completed.</description></item>
            /// <item><description><b>0</b>: being executed.</description></item>
            /// <item><description><b>-1</b>: execution failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Done")]
            [Validation(Required=false)]
            public int? Done { get; set; }

            /// <summary>
            /// <para>The time when the policy stops taking effect. The value is a timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586016000000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testpolicy</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of protected objects in the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ObjectCount")]
            [Validation(Required=false)]
            public int? ObjectCount { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>321a-fd31-df51-****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The runtime rules of the policy.</para>
            /// </summary>
            [NameInMap("RuntimePolicies")]
            [Validation(Required=false)]
            public List<DescribeSceneDefensePoliciesResponseBodyPoliciesRuntimePolicies> RuntimePolicies { get; set; }
            public class DescribeSceneDefensePoliciesResponseBodyPoliciesRuntimePolicies : TeaModel {
                /// <summary>
                /// <para>The protection rule when the policy takes effect.</para>
                /// <para>If <b>PolicyType</b> is <b>1</b>, the value is <b>{&quot;cc_rule_enable&quot;: false }</b>, which indicates that frequency control is disabled.</para>
                /// <para>If <b>PolicyType</b> is <b>2</b>, the value is <b>{&quot;ai_rule_enable&quot;: 0}</b>, which indicates that AI-based intelligent analysis is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cc_rule_enable&quot;: false }</para>
                /// </summary>
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// <para>The type of protection feature change triggered when the policy takes effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: frequency control feature change.</description></item>
                /// <item><description><b>2</b>: AI-based intelligent analysis feature change.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public int? PolicyType { get; set; }

                /// <summary>
                /// <para>The runtime status of the policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: not delivered or policy restored successfully.</description></item>
                /// <item><description><b>1</b>: active (policy takes effect).</description></item>
                /// <item><description><b>2</b>: being restored (policy restoration).</description></item>
                /// <item><description><b>3</b>: policy took effect successfully.</description></item>
                /// <item><description><b>4</b>: policy failed to take effect.</description></item>
                /// <item><description><b>5</b>: policy restoration failed.</description></item>
                /// <item><description><b>6</b>: the configuration of the object associated with the policy does not exist (may have been deleted).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The protection rule before the policy takes effect.</para>
                /// <para>If <b>PolicyType</b> is <b>1</b>, the value is <b>{&quot;cc_rule_enable&quot;: true}</b>, which indicates that frequency control is enabled.</para>
                /// <para>If <b>PolicyType</b> is <b>2</b>, the value is <b>{&quot;ai_rule_enable&quot;: 1}</b>, which indicates that AI-based intelligent analysis is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cc_rule_enable&quot;: true}</para>
                /// </summary>
                [NameInMap("oldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

            }

            /// <summary>
            /// <para>The time when the policy starts to take effect. The value is a timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1585670400000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled.</description></item>
            /// <item><description><b>1</b>: pending activation.</description></item>
            /// <item><description><b>2</b>: active.</description></item>
            /// <item><description><b>3</b>: expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The templatetype used by the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>promotion</b>: Important Activity template.</description></item>
            /// <item><description><b>bypass</b>: full forwarding template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>promotion</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F65DF043-E0EB-4796-9467-23DDCDF92C1D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
