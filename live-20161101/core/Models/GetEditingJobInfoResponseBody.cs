// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetEditingJobInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53200b81-b761-4c10-842a-a0726d97****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The video clip task information. This includes:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OutputVodId</b>: The ID of the output video-on-demand file.</para>
        /// </description></item>
        /// <item><description><para><b>TaskStatus</b>: The status of the video clip task. (-1: failed. 0: task initialized. 1: clipping in progress. 2: uploading. 3: task succeeded.)</para>
        /// </description></item>
        /// <item><description><para><b>StorageLocation</b>: The video-on-demand storage address.</para>
        /// </description></item>
        /// <item><description><para><b>FileName</b>: The name of the clipped file.</para>
        /// </description></item>
        /// <item><description><para><b>ShowId</b>: The show ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;EditingTasksInfo&quot;: {     &quot;OutputVodId&quot;: &quot;3e34733b40b9a96ccf5c1ff6f69****&quot;,     &quot;TaskStatus&quot;: 1,     &quot;StorageInfo&quot;: {       &quot;StorageLocation&quot;: &quot;<em><b>bucket</b></em>&quot;,       &quot;FileName&quot;: &quot;EditFile****&quot;     },     &quot;ShowId&quot;: &quot;42200b81-b761-4c10-842a-a0726d97****&quot;   },</para>
        /// </summary>
        [NameInMap("EditingTasksInfo")]
        [Validation(Required=false)]
        public string EditingTasksInfo { get; set; }

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
