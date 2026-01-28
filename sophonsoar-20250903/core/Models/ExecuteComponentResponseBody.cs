// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class ExecuteComponentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10B92EE1-4597-593B-A131-7A17D25EF5C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
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
