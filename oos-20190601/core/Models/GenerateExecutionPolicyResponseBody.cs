// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GenerateExecutionPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The policies that are missing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Action\&quot;: [\&quot;ecs:DescribeInvocationResults\&quot;, \&quot;ecs:DescribeInstances\&quot;, \&quot;ecs:RunCommand\&quot;, \&quot;ecs:DescribeInvocations\&quot;], \&quot;ServiceName\&quot;: \&quot;ecs\&quot;, \&quot;Resources\&quot;: \&quot;*\&quot;}]</para>
        /// </summary>
        [NameInMap("MissingPolicy")]
        [Validation(Required=false)]
        public string MissingPolicy { get; set; }

        /// <summary>
        /// <para>The RAM policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
