// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VideoModerationResultRequest : TeaModel {
        /// <summary>
        /// <para>The ServiceCode for video moderation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>videoDetection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameter set required by the moderation service. taskId specifies the taskId of the moderation task to query. Only one taskId can be specified per request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;taskId&quot;:&quot;au_f_8PoWiZKoLbczp5HRn69VdT-1y8@U5&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
