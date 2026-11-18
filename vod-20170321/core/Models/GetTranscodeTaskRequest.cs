// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTaskRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the transcoding jobs. You can specify up to 10 IDs. Separate multiple IDs with commas (,). You can obtain the IDs by using the following method:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/68570.html">SubmitTranscodeJobs</a> operation to initiate a transcoding task. The ID is the value of the JobId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>86c1925fba0****,7afb201e7fa****,2cc4997378****</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// <para>The transcoding task ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/68570.html">SubmitTranscodeJobs</a> operation to initiate a transcoding task. The ID is the value of the TranscodeTaskId response parameter.</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/109120.html">ListTranscodeTask</a> operation to query transcoding tasks. The ID is the value of the TranscodeTaskId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>b1b65ab107e14*****3dbb900f6c1fe0</para>
        /// </summary>
        [NameInMap("TranscodeTaskId")]
        [Validation(Required=false)]
        public string TranscodeTaskId { get; set; }

    }

}
