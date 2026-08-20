// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20260603.Models
{
    public class GetModelDeploymentSpecResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;containers&quot;: [
        ///       {
        ///         &quot;image&quot;: &quot;eas-registry-vpc.cn-hangzhou.cr.aliyuncs.com/pai-eas/sglang:v0.5.17&quot;,
        ///         &quot;port&quot;: 8000,
        ///         &quot;script&quot;: &quot;python -m sglang.launch_server ***  --port 8000&quot;
        ///       }
        ///     ],
        ///     &quot;metadata&quot;: {
        ///       &quot;cpu&quot;: 248,
        ///       &quot;disk&quot;: 850,
        ///       &quot;gpu&quot;: 8,
        ///       &quot;instance&quot;: 1,
        ///       &quot;memory&quot;: 2744000,
        ///       &quot;shm_size&quot;: 512
        ///     }
        ///   }</para>
        /// </summary>
        [NameInMap("InferenceSpec")]
        [Validation(Required=false)]
        public Dictionary<string, object> InferenceSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B6B54325-C98C-5937-87A3-2F96C07652EC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
