// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalGuardAsyncResultRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>audio_security_check</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;url&quot;: &quot;<a href="https://xxx.mp4">https://xxx.mp4</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
