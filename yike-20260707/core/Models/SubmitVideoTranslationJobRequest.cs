// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoTranslationJobRequest : TeaModel {
        /// <summary>
        /// <para>The user-level idempotency token, up to 40 characters. If the same user submits a request with the same token, the original job is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vt-client-20260820-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The job description, used to record business purposes or processing requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Translate a Chinese product introduction video into English</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The input configuration JSON string. You must specify either Video or VideoMediaId, but not both. You can specify at most one of Audio or AudioMediaId. Subtitle is optional.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VideoMediaId&quot;:&quot;media-video-001&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The job parameters JSON string. It must contain at least SourceLanguage and TargetLanguage. You can also configure main subtitle erasure, voice translation, on-screen text translation, and final editing.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SourceLanguage&quot;:&quot;zh&quot;,&quot;TargetLanguage&quot;:&quot;en&quot;,&quot;NeedDetext&quot;:false,&quot;NeedVisualTranslate&quot;:false}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The job type. SubtitleTranslate indicates subtitle translation. VoiceTranslate indicates voice translation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VoiceTranslate</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The output configuration JSON string. OssUri is an optional customer OSS output directory. If not specified, a signed URL of the service-owned artifact is returned.</para>
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
        /// <para>Product introduction video English translation</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom user data JSON string. It can contain the asynchronous notification address NotifyAddress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NotifyAddress&quot;:&quot;mns://account.mns.cn-shanghai.aliyuncs.com/queues/video-translation-result&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
