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
        /// <para>The storyboard generation execution mode.</para>
        /// <list type="bullet">
        /// <item><description><para><c>FullPipeline</c>: Executes the full generation pipeline, including both storyboard creation and shot video generation.</para>
        /// </description></item>
        /// <item><description><para><c>StoryboardOnly</c>: Generates only the storyboard.</para>
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
        /// <para>The OSS address of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://test.oss-cn-shanghai.aliyuncs.com/test.mp4">http://test.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <para>Parameters for the model, in JSON format.</para>
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
        /// <para>Specifies whether to skip a failed shot. The default value is <c>true</c>.</para>
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
        /// <para>The job title. It must be a UTF-8 encoded string of up to 128 bytes. If you do not specify a title, the system generates a default one based on the date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>Custom settings in JSON format. This parameter can contain the following field:</para>
        /// <list type="bullet">
        /// <item><description>The <c>NotifyAddress</c> field specifies the callback URL that is invoked when the job is complete. Both MNS and HTTP callbacks are supported.</description></item>
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
