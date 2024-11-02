// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescriberPython3ScriptLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D22D8A0C-6E86-57B2-A142-929184122AB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The operational logs of the Python3 script.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;logs&quot;: [
        ///         {
        ///             &quot;message&quot;: &quot;function input is {}&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("RunResult")]
        [Validation(Required=false)]
        public string RunResult { get; set; }

    }

}
