// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSceneDefensePoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the configurations of the scenario-specific custom policy.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<DescribeSceneDefensePoliciesResponseBodyPolicies> Policies { get; set; }
        public class DescribeSceneDefensePoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The execution status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: not executed or execution completed</description></item>
            /// <item><description><b>0</b>: being executed</description></item>
            /// <item><description><b>-1</b>: execution failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Done")]
            [Validation(Required=false)]
            public int? Done { get; set; }

            /// <summary>
            /// <para>The time at which the policy expires. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1586016000000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The name of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testpolicy</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of objects that are protected by the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ObjectCount")]
            [Validation(Required=false)]
            public int? ObjectCount { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>321a-fd31-df51-****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The running rules of the policy.</para>
            /// </summary>
            [NameInMap("RuntimePolicies")]
            [Validation(Required=false)]
            public List<DescribeSceneDefensePoliciesResponseBodyPoliciesRuntimePolicies> RuntimePolicies { get; set; }
            public class DescribeSceneDefensePoliciesResponseBodyPoliciesRuntimePolicies : TeaModel {
                /// <summary>
                /// <para>The protection rule that is applied when the policy takes effect.</para>
                /// <para>If you set <b>PolicyType</b> to <b>1</b>, the value is <b>{&quot;cc_rule_enable&quot;: false }</b>. The value indicates that the Frequency Control policy is disabled.</para>
                /// <para>If you set <b>PolicyType</b> to <b>2</b>, the value is <b>{&quot;ai_rule_enable&quot;: 0}</b>. The value indicates that the Intelligent Protection policy is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cc_rule_enable&quot;: false }</para>
                /// </summary>
                [NameInMap("NewValue")]
                [Validation(Required=false)]
                public string NewValue { get; set; }

                /// <summary>
                /// <para>The protection policy whose status is changed when the policy takes effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: indicates that the Frequency Control policy is changed.</description></item>
                /// <item><description><b>2</b>: indicates that the Intelligent Protection policy is changed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public int? PolicyType { get; set; }

                /// <summary>
                /// <para>The running status of the policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The policy has not been issued or is restored.</description></item>
                /// <item><description><b>1</b>: The policy is pending.</description></item>
                /// <item><description><b>2</b>: The policy is being restored.</description></item>
                /// <item><description><b>3</b>: The policy takes effect.</description></item>
                /// <item><description><b>4</b>: The policy fails to take effect.</description></item>
                /// <item><description><b>5</b>:The policy fails to be restored.</description></item>
                /// <item><description><b>6</b>: The configurations of the protected objects for the policy does not exist because the configurations may be deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The protection rule that is applied before the policy takes effect.</para>
                /// <para>If you set <b>PolicyType</b> to <b>1</b>, the value is <b>{&quot;cc_rule_enable&quot;: true}</b>. The value indicates that the Frequency Control policy is enabled.</para>
                /// <para>If you set <b>PolicyType</b> to <b>2</b>, the value is <b>{&quot;ai_rule_enable&quot;: 1}</b>. The value indicates that the Intelligent Protection policy is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cc_rule_enable&quot;: true}</para>
                /// </summary>
                [NameInMap("oldValue")]
                [Validation(Required=false)]
                public string OldValue { get; set; }

            }

            /// <summary>
            /// <para>The time at which the policy takes effect. The value is a UNIX timestamp. Unit: milliseconds.</para>
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
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: pending enabling</description></item>
            /// <item><description><b>2</b>: enabled</description></item>
            /// <item><description><b>3</b>: expired</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of the template that is used to create the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>promotion</b>: the Important Activity template</description></item>
            /// <item><description><b>bypass</b>: the Forward All template</description></item>
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
        /// <para>The ID of the request.</para>
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
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
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
