// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RunPython3ScriptResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F210521C-D9BF-5264-8369-83EDDC617DB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution result of the Python3 script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;requestUuid&quot;: &quot;fe240b98-27b1-4a36-aec1-550b894318d9&quot;,
        ///     &quot;content&quot;: {
        ///         &quot;resultData&quot;: [],
        ///         &quot;success&quot;: true
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("RunResult")]
        [Validation(Required=false)]
        public string RunResult { get; set; }

    }

}
