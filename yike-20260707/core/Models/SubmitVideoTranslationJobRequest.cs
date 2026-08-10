// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class SubmitVideoTranslationJobRequest : TeaModel {
        /// <summary>
        /// <para>The user-level idempotency key.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>3e761e9d11edba640c42a1b7</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The job description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The input configuration JSON string:</para>
        /// <list type="bullet">
        /// <item><description>Video</description></item>
        /// <item><description>Audio</description></item>
        /// <item><description>Subtitle</description></item>
        /// </list>
        /// <para><notice>Currently, only OSS addresses under the calling account are supported as input.</notice></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Video&quot;:&quot;oss://bucket/path/input.mp4&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The job parameters JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SourceLanguage&quot;:&quot;zh&quot;,&quot;TargetLanguage&quot;:&quot;en&quot;,&quot;NeedDetext&quot;:false,&quot;NeedVisualTranslate&quot;:false}</para>
        /// </summary>
        [NameInMap("JobParameters")]
        [Validation(Required=false)]
        public string JobParameters { get; set; }

        /// <summary>
        /// <para>The job type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SubtitleTranslate</description></item>
        /// <item><description>VoiceTranslate</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VoiceTranslate</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The output configuration JSON string. The OssUri value must be a folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OssUri&quot;:&quot;oss://bucket/output/&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>If not specified, the service generates a default title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom user data JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
