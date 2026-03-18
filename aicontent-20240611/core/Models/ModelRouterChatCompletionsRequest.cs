// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterChatCompletionsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;stream&quot;: true,
        ///     &quot;messages&quot;: [
        ///       {
        ///         &quot;role&quot;: &quot;user&quot;,
        ///         &quot;content&quot;: &quot;1+1&quot;
        ///       }
        ///     ],
        ///     &quot;model_id&quot;: 15,
        ///     &quot;stream_options&quot;: {
        ///       &quot;include_usage&quot;: true
        ///     }
        ///   }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public object Body { get; set; }

    }

}
