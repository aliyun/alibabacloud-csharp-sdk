// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class ManualModerationRequest : TeaModel {
        /// <summary>
        /// <para>Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imageManualCheck</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>Parameters required by the moderation service, in JSON string format.</para>
        /// <list type="bullet">
        /// <item><description>url: The URL of the object to be inspected. Make sure the URL is accessible through the public network.</description></item>
        /// <item><description>dataId: Optional. The data ID corresponding to the object being inspected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;url&quot;: &quot;<a href="https://talesofai.oss-cn-shanghai.aliyuncs.com/xxx.mp4">https://talesofai.oss-cn-shanghai.aliyuncs.com/xxx.mp4</a>&quot;, &quot;dataId&quot;: &quot;data1234&quot;}</para>
        /// </summary>
        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

    }

}
