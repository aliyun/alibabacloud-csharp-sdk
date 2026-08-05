// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitYikeStoryboardJobRequest : TeaModel {
        /// <summary>
        /// <para>The aspect ratio of the output video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4:3</para>
        /// </summary>
        [NameInMap("AspectRatio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// <para>The execution mode for storyboard generation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>FullPipeline: full pipeline generation, which includes storyboard generation and shot video generation.</para>
        /// </description></item>
        /// <item><description><para>StoryboardOnly: generates only the storyboard.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullPipeline</para>
        /// </summary>
        [NameInMap("ExecMode")]
        [Validation(Required=false)]
        public string ExecMode { get; set; }

        /// <summary>
        /// <para>The OSS URL of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://test.oss-cn-shanghai.aliyuncs.com/test.mp4">http://test.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <para>The model feature parameters in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;AudioEnable&quot;: false
        /// }</para>
        /// </summary>
        [NameInMap("ModelParams")]
        [Validation(Required=false)]
        public string ModelParams { get; set; }

        /// <summary>
        /// <para>The narration voice ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sys_YoungGracefulWoman</para>
        /// </summary>
        [NameInMap("NarrationVoiceId")]
        [Validation(Required=false)]
        public string NarrationVoiceId { get; set; }

        /// <summary>
        /// <para>The resolution of the output video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720P</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <para>The storyboard shot generation mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>multi</para>
        /// </summary>
        [NameInMap("ShotPromptMode")]
        [Validation(Required=false)]
        public string ShotPromptMode { get; set; }

        /// <summary>
        /// <para>The shot split mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>firstPersonNarration</para>
        /// </summary>
        [NameInMap("ShotSplitMode")]
        [Validation(Required=false)]
        public string ShotSplitMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip failed shots. Default value: True.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("SkipFailureShot")]
        [Validation(Required=false)]
        public bool? SkipFailureShot { get; set; }

        /// <summary>
        /// <para>The source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Novel</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The storyboard style ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RealisticPhotography</para>
        /// </summary>
        [NameInMap("StyleId")]
        [Validation(Required=false)]
        public string StyleId { get; set; }

        /// <summary>
        /// <para>The task title. If not specified, a default title is automatically generated based on the date. The title cannot exceed 128 bytes in length and must be UTF-8 encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The custom settings in JSON format. Fields:</para>
        /// <list type="bullet">
        /// <item><description>NotifyAddress: the callback URL for task completion. MNS callbacks and HTTP callbacks are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;NotifyAddress&quot;: &quot;<a href="https://www.callback.com">https://www.callback.com</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The video model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wan2.6-r2v-flash</para>
        /// </summary>
        [NameInMap("VideoModel")]
        [Validation(Required=false)]
        public string VideoModel { get; set; }

    }

}
