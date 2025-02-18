// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ManualModerationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>imageManualCheck</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;url&quot;: &quot;<a href="https://talesofai.oss-cn-shanghai.aliyuncs.com/xxx.mp4">https://talesofai.oss-cn-shanghai.aliyuncs.com/xxx.mp4</a>&quot;, &quot;dataId&quot;: &quot;data1234&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
