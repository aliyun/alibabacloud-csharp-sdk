// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitWorkflowJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media file. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD</a> console. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of the VideoId parameter when you call the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation to upload media files.</description></item>
        /// <item><description>Obtain the value of the VideoId parameter when you call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation after you upload media files.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>058b39e75269da42b08f00459****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The ID of the workflow. To view the ID of the workflow, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Processing</b> &gt; <b>Workflows</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34d577eade633860bdf1237****</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
