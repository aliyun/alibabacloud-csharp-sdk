// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitAvatarVideoJobRequest : TeaModel {
        /// <summary>
        /// <para>The description of the job. The description can be up to 128 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configurations for the avatar job, such as the avatar ID, voice, and speech rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AvatarId&quot;:&quot;yunqiao&quot;}</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>Input can be text, an audio file from Object Storage Service (OSS), or a <a href="">media asset</a>. Only MP3 and WAV audio formats are supported.&gt;Notice:  The value of the <c>Text</c> parameter must contain at least five characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Text&quot;: &quot;To be or not to be, that is the question.&quot;}</para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <para>Specifies the output configuration, including the destination URL for the rendered video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MediaURL&quot;:&quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/xxx.mp4%22%7D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/xxx.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>The title of the job. The title can be up to 128 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>A user-defined JSON string for passing custom business information, such as environment details or job metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;user&quot;:&quot;data&quot;,&quot;env&quot;:&quot;prod&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
