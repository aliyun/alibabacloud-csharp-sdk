// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplatePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GenerateTemplatePolicyResponseBodyPolicy Policy { get; set; }
        public class GenerateTemplatePolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>The statements that are contained in the policy.</para>
            /// </summary>
            [NameInMap("Statement")]
            [Validation(Required=false)]
            public List<GenerateTemplatePolicyResponseBodyPolicyStatement> Statement { get; set; }
            public class GenerateTemplatePolicyResponseBodyPolicyStatement : TeaModel {
                /// <summary>
                /// <para>The operations that are performed on the specified resource.</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public List<string> Action { get; set; }

                /// <summary>
                /// <para>The condition that is required for the policy to take effect.</para>
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
                /// <para>The effect of the statement. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Allow</description></item>
                /// <item><description>Deny</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Allow</para>
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>The objects that the statement covers. An asterisk (\*) indicates all resources.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
