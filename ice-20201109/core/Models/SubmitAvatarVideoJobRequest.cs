// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAvatarVideoJobRequest : TeaModel {
        /// <summary>
        /// <para>The task description. Max length: 128 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The avatar configurations, including the avatar ID, voice, and speech rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AvatarId&quot;:&quot;yunqiao&quot;}</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The input configurations of the video rendering task for an avatar. You can specify text, the Object Storage Service (OSS) URL of an audio file, or the ID of a media asset. The audio file must be in the MP3 or WAV format.</para>
        /// <remarks>
        /// <para>Notice: The text must be at least five characters in length.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Text&quot;: &quot;To be, or not to be, that is the question.&quot;}</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>The output configurations, including the destination URL for the rendered video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MediaURL&quot;:&quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/xxx.mp4%22%7D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/xxx.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>The task name. Max length: 128 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>A user-defined JSON string for passing custom business information, such as environment details or task metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;user&quot;:&quot;data&quot;,&quot;env&quot;:&quot;prod&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
