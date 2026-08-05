// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class EditShowAndReplaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The task information, which contains:</para>
        /// <list type="bullet">
        /// <item><description><para><b>vodId</b>: the video-on-demand file ID.</para>
        /// </description></item>
        /// <item><description><para><b>mediaid</b>: the media file ID.</para>
        /// </description></item>
        /// <item><description><para><b>jobId</b>: the task ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{         &quot;vodId&quot;: &quot;3e34733b40b9a96ccf5c1ff6f69****&quot;,         &quot;mediaid&quot;: &quot;eb1861d2c9a842340e989dd56****&quot;,         &quot;jobId&quot;: &quot;7d2fbc380b0e08e55fe98733764****&quot;     }</para>
        /// </summary>
        [NameInMap("JobInfo")]
        [Validation(Required=false)]
        public string JobInfo { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
