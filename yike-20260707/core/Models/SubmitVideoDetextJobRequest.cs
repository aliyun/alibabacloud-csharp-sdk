// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoDetextJobRequest : TeaModel {
        /// <summary>
        /// <para>The user-level idempotency token. Maximum length: 40 characters. If the same user submits a request with the same token, the original task is returned.</para>
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
        /// <para>The text erasure parameter JSON string. This string can contain EraseAllText, TimeRanges, TextTargets, FullEraseTargets, and Config.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EraseAllText&quot;:false,&quot;TextTargets&quot;:[{&quot;Box&quot;:[0.1,0.8,0.8,0.15],&quot;TimeRanges&quot;:[[0,30]]}]}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The output configuration JSON string. OssUri specifies an OSS directory or MP4 file path and cannot contain query parameters or fragments. For directory paths, detext.mp4 is automatically appended. Paths ending with .mp4 without a trailing / are used directly as the target file. If not specified, a signed URL of the processing result is returned in the query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OssUri&quot;:&quot;oss://example-bucket/video-detext/job-001/&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The custom data JSON string for pass-through in desired state notifications. For MNS callbacks, use NotifyAddress to specify a queue name prefixed with yike-callback, and use NotifyMnsEndpoint to specify an MNS endpoint under the same account. For HTTP(S) callbacks, use NotifyAddress to specify the full URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;yike-callback-example&quot;,&quot;NotifyMnsEndpoint&quot;:&quot;http://<AccountId>.mns.cn-shanghai.aliyuncs.com/&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
