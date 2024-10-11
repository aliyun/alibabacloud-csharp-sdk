// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the transcoding task. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Obtain the value of TranscodeTaskId from the response to the <a href="https://help.aliyun.com/document_detail/68570.html">SubmitTranscodeJobs</a> operation.</description></item>
        /// <item><description>Obtain the value of TranscodeTaskId from the response to the <a href="https://help.aliyun.com/document_detail/109120.html">ListTranscodeTask</a> operation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b1b65ab107e14*****3dbb900f6c1fe0</para>
        /// </summary>
        [NameInMap("TranscodeTaskId")]
        [Validation(Required=false)]
        public string TranscodeTaskId { get; set; }

    }

}
