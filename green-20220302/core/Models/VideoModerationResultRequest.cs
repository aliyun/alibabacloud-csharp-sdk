// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VideoModerationResultRequest : TeaModel {
        /// <summary>
        /// <para>The type of the moderation service.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>liveStreamDetection: live stream moderation</description></item>
        /// <item><description>videoDetection: video file moderation</description></item>
        /// <item><description>liveStreamDetection_cb: live stream moderation_For regions outside the Chinese mainland</description></item>
        /// <item><description>videoDetection_cb: video file moderation_For regions outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>videoDetection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameters required by the moderation service. The ID of the task that you want to query. You can specify one task ID at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;taskId\&quot;:\&quot;au_f_8PoWiZKoLbczp5HRn69VdT-1y8@U5\&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
