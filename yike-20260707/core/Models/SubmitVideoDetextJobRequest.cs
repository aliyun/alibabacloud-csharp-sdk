// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoDetextJobRequest : TeaModel {
        /// <summary>
        /// <para>The user-level idempotency token. Maximum length: 40 characters. If the same user submits a request with the same token, the original job is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>detext-client-20260820-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The input configuration JSON string. You must provide exactly one of VideoUrl or VideoMediaId.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoUrl&quot;:&quot;<a href="https://example.com/input.mp4%22%7D">https://example.com/input.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The text removal parameters JSON string. TextTargets detects and removes text within specified regions. FullEraseTargets repairs entire rectangular regions regardless of text detection. EraseAllText controls only text filtering and does not expand the removal region. For parameter details, default behavior, and combination examples, see the supplementary request parameter description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EraseAllText&quot;:true,&quot;TimeRanges&quot;:[[12,15]],&quot;TextTargets&quot;:[{&quot;Box&quot;:[0.1,0.8,0.8,0.15]}]}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The output configuration JSON string. OssUri specifies an OSS directory or MP4 file path in the format oss://bucket/path. It cannot contain query parameters or fragments. A directory path automatically appends detext.mp4. A path ending in .mp4 without a trailing slash is used directly as the target file. If not specified, a signed URL for the result is returned in the query response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OssUri&quot;:&quot;oss://example-bucket/video-detext/job-001/&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The custom data JSON string used for pass-through in desired-state notifications. For MNS callbacks, use NotifyAddress to specify a queue name prefixed with yike-callback, and use NotifyMnsEndpoint to specify the MNS endpoint of the same account. For HTTP(S) callbacks, use NotifyAddress to specify the full URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;yike-callback-example&quot;,&quot;NotifyMnsEndpoint&quot;:&quot;http://<AccountId>.mns.cn-shanghai.aliyuncs.com/&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
