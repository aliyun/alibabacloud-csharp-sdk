// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitASRJobRequest : TeaModel {
        /// <summary>
        /// <para>The job description. The maximum length is 128 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The duration of the segment to transcribe.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:10</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The configuration for speech-to-text conversion:</para>
        /// <list type="bullet">
        /// <item><description>HotwordLibraryIdList: A list of custom vocabulary IDs. Only one custom vocabulary ID is currently supported. Future releases will support multiple IDs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;HotwordLibraryIdList&quot;: &quot;<b><b><b>2609a14f54a0636b7e16</b></b></b>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        /// <summary>
        /// <para>The input configuration. Specify either an OSS URL or a media ID from the media library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4 or <b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("InputFile")]
        [Validation(Required=false)]
        public string InputFile { get; set; }

        /// <summary>
        /// <para>The start time of the segment to be transcribed from the media file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The job title. The maximum length is 128 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>User-defined settings in JSON format. Use this to pass business-related data, such as the operating environment or other job details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;user&quot;: &quot;data&quot;,
        ///       &quot;env&quot;: &quot;prod&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
