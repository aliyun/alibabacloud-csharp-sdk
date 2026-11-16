// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoDetextJobRequest : TeaModel {
        /// <summary>
        /// <para>The user-level idempotency token. The token can be up to 40 characters in length. If the same user submits the request repeatedly with the same token, the original task is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>detext-client-20260820-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The input configuration JSON string. You must specify either VideoUrl or VideoMediaId, but not both.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoUrl&quot;:&quot;<a href="https://example.com/input.mp4%22%7D">https://example.com/input.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The text erasure parameters JSON string. TextTargets is used to detect and erase text. FullEraseTargets is used to inpaint entire regions. EraseAllText only controls text filtering and does not expand the region. For parameters, default behaviors, and combination examples, see the supplementary description of request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EraseAllText&quot;:true,&quot;TimeRanges&quot;:[[12,15]],&quot;TextTargets&quot;:[{&quot;Box&quot;:[0.1,0.8,0.8,0.15]}]}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The output configuration JSON string. You can use OssUri to specify an OSS directory or an MP4 file path. The path cannot contain query parameters or fragments. If a directory is specified, detext.mp4 is automatically appended. If the path ends with .mp4 and has no trailing slash, it is used directly as the destination file. If OssUri is not specified, a signed URL for the processing result is returned in the query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OssUri&quot;:&quot;oss://example-bucket/video-detext/job-001/&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The custom data JSON string used for pass-through in final state notifications. For Message Service (MNS) callbacks, use NotifyAddress to specify the queue name prefixed with yike-callback, and use NotifyMnsEndpoint to specify the MNS endpoint of the same account. For HTTP or HTTPS callbacks, use NotifyAddress to specify the complete URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;yike-callback-example&quot;,&quot;NotifyMnsEndpoint&quot;:&quot;http://<AccountId>.mns.cn-shanghai.aliyuncs.com/&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
