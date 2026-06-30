// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SubmitYikeProjectExportJobRequest : TeaModel {
        /// <summary>
        /// <para>The export type of the editing project. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PureAudio: pure audio (the export result returns a pure audio file and a subtitle file).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PureAudio</para>
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// <para>The ID of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01a6adbbd181437eb5030d3d93e0182d</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The custom parameter in JSON string format. The callback result carries this parameter as-is (for example, newsKey).
        /// The system reserved field NotifyAddress specifies the callback URL. After the task is complete, a callback is sent to this URL. Example: {&quot;NotifyAddress&quot;: &quot;<a href="http://xxx.callback.url%22%7D">http://xxx.callback.url&quot;}</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;newsKey\&quot;:\&quot;NEWS_20260420_001\&quot;,\&quot;key1\&quot;:\&quot;value1\&quot;, \&quot;NotifyAddress\&quot;:\&quot;<a href="https://cms.example.com/callback/video-task%5C%5C%22%7D">https://cms.example.com/callback/video-task\\&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
