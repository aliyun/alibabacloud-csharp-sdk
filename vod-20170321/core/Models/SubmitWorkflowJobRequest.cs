// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitWorkflowJobRequest : TeaModel {
        [NameInMap("ExtraInputs")]
        [Validation(Required=false)]
        public string ExtraInputs { get; set; }

        /// <summary>
        /// <para>The media asset ID, which is the video ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For videos uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Assets</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/55407.html">Get the upload URL and credential for a video</a> operation to obtain the upload URL and credential, the video ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After a video is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">Search for media information</a> operation to query the video ID. The video ID is the value of the VideoId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>058b39e75269da42b08f00459****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The workflow ID. You can log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Processing Configuration</b> &gt; <b>Workflow Management</b> to view the ID.</para>
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
