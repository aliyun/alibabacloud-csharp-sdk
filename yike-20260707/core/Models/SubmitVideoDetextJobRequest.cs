// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoDetextJobRequest : TeaModel {
        /// <summary>
        /// <para>The user-level idempotency token. The token can be up to 40 characters in length. If the same user submits a request with the same token, the original task is returned.</para>
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
        /// <para>{&quot;VideoMediaId&quot;:&quot;media-video-001&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The text erasure parameter JSON string. This parameter can contain EraseAllText, TimeRanges, TextTargets, FullEraseTargets, and Config.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EraseAllText&quot;:false,&quot;TextTargets&quot;:[{&quot;Box&quot;:[0.1,0.8,0.8,0.15],&quot;TimeRanges&quot;:[[0,30]]}]}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The output configuration JSON string. You can use OssUri to specify the customer\&quot;s OSS bucket. If a directory is specified, the output file is named detext.mp4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OssUri&quot;:&quot;oss://example-bucket/video-detext/job-001/&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The custom user data JSON string. This parameter can contain the asynchronous notification address NotifyAddress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;mns://account.mns.cn-shanghai.aliyuncs.com/queues/detext-result&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
