// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The dry run result.</para>
        /// </summary>
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public UpdateServiceResponseBodyDryRunResult DryRunResult { get; set; }
        public class UpdateServiceResponseBodyDryRunResult : TeaModel {
            /// <summary>
            /// <para>The required ram policy for deploying role.</para>
            /// </summary>
            [NameInMap("RolePolicy")]
            [Validation(Required=false)]
            public UpdateServiceResponseBodyDryRunResultRolePolicy RolePolicy { get; set; }
            public class UpdateServiceResponseBodyDryRunResultRolePolicy : TeaModel {
                /// <summary>
                /// <para>The missing  ram policy for deploying role.</para>
                /// </summary>
                [NameInMap("MissingPolicy")]
                [Validation(Required=false)]
                public List<UpdateServiceResponseBodyDryRunResultRolePolicyMissingPolicy> MissingPolicy { get; set; }
                public class UpdateServiceResponseBodyDryRunResultRolePolicyMissingPolicy : TeaModel {
                    /// <summary>
                    /// <para>The Actions.</para>
                    /// </summary>
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public List<string> Action { get; set; }

                    /// <summary>
                    /// <para>The responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public string Resource { get; set; }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs</para>
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                /// <summary>
                /// <para>The required ram policy for deploying role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;Statement&quot;: [{
                ///         &quot;Action&quot;: [&quot;oos:CancelExecutions&quot;, &quot;oos:DeleteExecutions&quot;, &quot;oos:GetTemplate&quot;, &quot;oos:ListExecutions&quot;, &quot;oos:ListTemplates&quot;, &quot;oos:NotifyExecution&quot;, &quot;oos:StartExecution&quot;],
                ///         &quot;Effect&quot;: &quot;Allow&quot;,
                ///         &quot;Resource&quot;: &quot;<em>&quot;
                ///     }, {
                ///         &quot;Action&quot;: [&quot;ram:PassRole&quot;],
                ///         &quot;Effect&quot;: &quot;Allow&quot;,
                ///         &quot;Resource&quot;: &quot;</em>&quot;
                ///     }, {
                ///         &quot;Action&quot;: [&quot;ros:CreateStack&quot;, &quot;ros:GetStack&quot;, &quot;ros:UpdateStack&quot;, &quot;ros:ListStackEvents&quot;, &quot;ros:ListStackResources&quot;, &quot;ros:ListStackResources&quot;, &quot;ros:DeleteStack&quot;, &quot;ram:GetRole&quot;],
                ///         &quot;Effect&quot;: &quot;Allow&quot;,
                ///         &quot;Resource&quot;: &quot;*&quot;
                ///     }],
                ///     &quot;Version&quot;: &quot;1&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

            }

        }

        /// <summary>
        /// <para>The hosted O\&amp;M configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF0F666F-FBBC-55C3-A368-C955DE7B4839</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
