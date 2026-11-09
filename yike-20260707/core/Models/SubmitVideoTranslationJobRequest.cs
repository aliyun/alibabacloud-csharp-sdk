// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoTranslationJobRequest : TeaModel {
        /// <summary>
        /// <para>The user-level idempotency token, which can be up to 40 characters in length. If the same user submits the request repeatedly with the same token, the original task is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vt-client-20260820-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The job description, which is used to record the business purpose or processing requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Translate the Chinese product introduction video into English</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The input configuration JSON string. You must specify either Video or VideoMediaId, but not both. You can specify at most one of Audio and AudioMediaId. Subtitle is optional.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoMediaId&quot;:&quot;media-video-001&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The job parameters JSON string. It must include at least SourceLanguage and TargetLanguage. You can also configure primary subtitle erasure, voice translation, on-screen text translation, and final editing.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SourceLanguage&quot;:&quot;zh&quot;,&quot;TargetLanguage&quot;:&quot;en&quot;,&quot;NeedDetext&quot;:false,&quot;NeedVisualTranslate&quot;:false}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The job type. SubtitleTranslate indicates subtitle translation, and VoiceTranslate indicates voice translation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VoiceTranslate</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The output configuration JSON string. OssUri is the optional customer OSS output directory. If OssUri is not specified, a signed URL for the service-owned output is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OssUri&quot;:&quot;oss://example-bucket/video-translation/output/&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The job title. If not specified, the service generates a default title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>English translation of product introduction video</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user-defined data JSON string. When specifying an MNS queue to receive asynchronous notifications, set <c>NotifyAddress</c> to the pure queue name starting with <c>yike-callback-</c> instead of the full queue URL. You can optionally set <c>NotifyMnsEndpoint</c> to the MNS endpoint of the task account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;yike-callback-test&quot;,&quot;NotifyMnsEndpoint&quot;:&quot;<a href="https://1234567890123456.mns.cn-shanghai.aliyuncs.com%22%7D">https://1234567890123456.mns.cn-shanghai.aliyuncs.com&quot;}</a></para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
