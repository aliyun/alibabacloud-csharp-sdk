// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplatePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The access policy information.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GenerateTemplatePolicyResponseBodyPolicy Policy { get; set; }
        public class GenerateTemplatePolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>The access policy statement details.</para>
            /// </summary>
            [NameInMap("Statement")]
            [Validation(Required=false)]
            public List<GenerateTemplatePolicyResponseBodyPolicyStatement> Statement { get; set; }
            public class GenerateTemplatePolicyResponseBodyPolicyStatement : TeaModel {
                /// <summary>
                /// <para>The operation on the specific resource.</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public List<string> Action { get; set; }

                /// <summary>
                /// <para>The condition for the authorization to take effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;StringEquals&quot;: {
                ///         &quot;acs:Service&quot;: &quot;fc.aliyuncs.com&quot;
                ///     }
                /// }</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public Dictionary<string, object> Condition { get; set; }

                /// <summary>
                /// <para>The authorization effect. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description><para>Allow: Allowed.  </para>
                /// </description></item>
                /// <item><description><para>Deny: Denied.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Allow</para>
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The specific resource that is authorized. An asterisk (*) indicates all resources.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

            }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The policy function configurations.</para>
        /// </summary>
        [NameInMap("PolicyFunctions")]
        [Validation(Required=false)]
        public List<GenerateTemplatePolicyResponseBodyPolicyFunctions> PolicyFunctions { get; set; }
        public class GenerateTemplatePolicyResponseBodyPolicyFunctions : TeaModel {
            /// <summary>
            /// <para>The action in the policy function.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The policy function list.</para>
            /// </summary>
            [NameInMap("ActionPolicyFunctions")]
            [Validation(Required=false)]
            public List<GenerateTemplatePolicyResponseBodyPolicyFunctionsActionPolicyFunctions> ActionPolicyFunctions { get; set; }
            public class GenerateTemplatePolicyResponseBodyPolicyFunctionsActionPolicyFunctions : TeaModel {
                /// <summary>
                /// <para>The policy function list.</para>
                /// </summary>
                [NameInMap("Functions")]
                [Validation(Required=false)]
                public List<GenerateTemplatePolicyResponseBodyPolicyFunctionsActionPolicyFunctionsFunctions> Functions { get; set; }
                public class GenerateTemplatePolicyResponseBodyPolicyFunctionsActionPolicyFunctionsFunctions : TeaModel {
                    /// <summary>
                    /// <para>The function in the policy function.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>notContains</para>
                    /// </summary>
                    [NameInMap("Function")]
                    [Validation(Required=false)]
                    public string Function { get; set; }

                    /// <summary>
                    /// <para>The operation type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CreateStack</para>
                    /// </summary>
                    [NameInMap("OperationType")]
                    [Validation(Required=false)]
                    public string OperationType { get; set; }

                    /// <summary>
                    /// <para>The list of related properties.</para>
                    /// </summary>
                    [NameInMap("RelatedProperties")]
                    [Validation(Required=false)]
                    public List<string> RelatedProperties { get; set; }

                    /// <summary>
                    /// <para>The requirement level of the function.</para>
                    /// </summary>
                    [NameInMap("RequirementLevel")]
                    [Validation(Required=false)]
                    public string RequirementLevel { get; set; }

                }

                /// <summary>
                /// <para>The logical resource ID of the policy function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SLBLoadBalancer_00001</para>
                /// </summary>
                [NameInMap("LogicalResourceId")]
                [Validation(Required=false)]
                public string LogicalResourceId { get; set; }

                /// <summary>
                /// <para>The resource type associated with the policy function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stack</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The requirement level of the policy function.</para>
            /// </summary>
            [NameInMap("RequirementLevel")]
            [Validation(Required=false)]
            public string RequirementLevel { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
