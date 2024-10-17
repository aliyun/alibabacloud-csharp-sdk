// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitVideoTranslationJobRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The client token.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The job description.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The configuration parameters of the video translation job.</description></item>
        /// <item><description>The value must be in the JSON format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SourceLanguage&quot;:&quot;zh&quot;,&quot;TargetLanguage&quot;:&quot;en&quot;,&quot;DetextArea&quot;:&quot;Auto&quot;}</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The input parameters of the video translation job.</description></item>
        /// <item><description>A video translation job takes a video or subtitle file as the input.</description></item>
        /// <item><description>The value must be in the JSON format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;:&quot;Video&quot;,&quot;Media&quot;:&quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/xxx.mp4%22%7D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/xxx.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The output parameters of the video translation job.</description></item>
        /// <item><description>A video translation job can generate a video or subtitle file as the output.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MediaURL&quot;: &quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/your-object.mp4%22%7D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/your-object.mp4&quot;}</a></para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The job title.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The user data.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
