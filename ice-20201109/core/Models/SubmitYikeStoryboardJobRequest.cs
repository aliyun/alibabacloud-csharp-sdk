// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitYikeStoryboardJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4:3</para>
        /// </summary>
        [NameInMap("AspectRatio")]
        [Validation(Required=false)]
        public string AspectRatio { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://test.oss-cn-shanghai.aliyuncs.com/test.mp4">http://test.oss-cn-shanghai.aliyuncs.com/test.mp4</a></para>
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;AudioEnable&quot;: false
        /// }</para>
        /// </summary>
        [NameInMap("ModelParams")]
        [Validation(Required=false)]
        public string ModelParams { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sys_YoungGracefulWoman</para>
        /// </summary>
        [NameInMap("NarrationVoiceId")]
        [Validation(Required=false)]
        public string NarrationVoiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>720P</para>
        /// </summary>
        [NameInMap("Resolution")]
        [Validation(Required=false)]
        public string Resolution { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>multi</para>
        /// </summary>
        [NameInMap("ShotPromptMode")]
        [Validation(Required=false)]
        public string ShotPromptMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>firstPersonNarration</para>
        /// </summary>
        [NameInMap("ShotSplitMode")]
        [Validation(Required=false)]
        public string ShotSplitMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Novel</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RealisticPhotography</para>
        /// </summary>
        [NameInMap("StyleId")]
        [Validation(Required=false)]
        public string StyleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-title</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;NotifyAddress&quot;: &quot;<a href="https://www.callback.com">https://www.callback.com</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wan2.6-r2v-flash</para>
        /// </summary>
        [NameInMap("VideoModel")]
        [Validation(Required=false)]
        public string VideoModel { get; set; }

    }

}
