// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalGuardAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The moderation service type. Valid values: <c>audio_security_check</c> and <c>video_security_check</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audio_security_check</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The parameter set required for the moderation service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;url&quot;: &quot;<a href="https://testxxx.oss-cn-shanghai.aliyuncs.com/xxx.mp4">https://testxxx.oss-cn-shanghai.aliyuncs.com/xxx.mp4</a>&quot;, &quot;dataId&quot;: &quot;data1234&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
