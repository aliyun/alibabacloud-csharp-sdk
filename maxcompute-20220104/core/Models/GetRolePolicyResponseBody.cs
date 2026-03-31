// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetRolePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;Statement&quot;: [
        ///             {
        ///                   &quot;Action&quot;: [
        ///                         &quot;odps:<em>&quot;
        ///                   ],
        ///                   &quot;Effect&quot;: &quot;Allow&quot;,
        ///                   &quot;Resource&quot;: [
        ///                         &quot;acs:odps:</em>:projects/{projectname}/authorization/packages&quot;
        ///                   ]
        ///             }
        ///       ],
        ///       &quot;Version&quot;: &quot;1&quot;
        /// }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1eeed16675342848904412e08dd</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
