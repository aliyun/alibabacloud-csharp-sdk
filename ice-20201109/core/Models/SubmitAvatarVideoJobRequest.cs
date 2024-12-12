// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAvatarVideoJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>测试描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;AvatarId&quot;:&quot;yunqiao&quot;}</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The input configurations of the video rendering job for an avatar. You can specify text, the Object Storage Service (OSS) URL of an audio file, or the ID of a media asset. The audio file must be in the MP3 or WAV format.</para>
        /// <remarks>
        /// <para> The text must be at least five words in length.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;MediaURL&quot;:&quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/xxx.mp4%22,%22Width%22:1920,%22Height%22:1080%7D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/xxx.mp4&quot;,&quot;Width&quot;:1920,&quot;Height&quot;:1080}</a></para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;user&quot;:&quot;data&quot;,&quot;env&quot;:&quot;prod&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
