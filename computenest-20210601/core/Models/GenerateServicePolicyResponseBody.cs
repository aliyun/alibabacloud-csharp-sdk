// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GenerateServicePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The policies that are missing.</para>
        /// </summary>
        [NameInMap("MissingPolicy")]
        [Validation(Required=false)]
        public List<GenerateServicePolicyResponseBodyMissingPolicy> MissingPolicy { get; set; }
        public class GenerateServicePolicyResponseBodyMissingPolicy : TeaModel {
            /// <summary>
            /// <para>Operations on specific resources.</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public List<string> Action { get; set; }

            /// <summary>
            /// <para>The specific objects authorized. An asterisk (*) denotes all resources.</para>
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
            /// <para>The name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// <para>The RAM policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{Statement&quot;: [{ &quot;Action&quot;: [&quot;oos:<em>&quot;], &quot;Effect&quot;: &quot;Allow&quot;, &quot;Resource&quot;: &quot;</em>&quot;},{ &quot;Action&quot;: [&quot;ecs:DescribeInstances&quot;], &quot;Effect&quot;: &quot;Allow&quot;, &quot;Resource&quot;: &quot;<em>&quot;},{ &quot;Action&quot;: [&quot;ecs:RunInstance&quot;], &quot;Effect&quot;: &quot;Allow&quot;, &quot;Resource&quot;: &quot;</em>&quot;}], &quot;Version&quot;: &quot;1&quot;}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5040BE9E-8DA2-5C9D-9B70-0EE6027A14BC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
