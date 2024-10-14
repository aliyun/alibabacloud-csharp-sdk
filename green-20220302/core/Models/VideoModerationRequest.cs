// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class VideoModerationRequest : TeaModel {
        /// <summary>
        /// <para>The type of the moderation service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>videoDetection</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameters required by the moderation service. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;url\&quot;: \&quot;<a href="https://talesofai.oss-cn-shanghai.aliyuncs.com/xxx.mp4%5C%5C">https://talesofai.oss-cn-shanghai.aliyuncs.com/xxx.mp4\\</a>&quot;, \&quot;dataId\&quot;: \&quot;94db0b88-f521-11ed-806e-fae21c1f239c\&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
