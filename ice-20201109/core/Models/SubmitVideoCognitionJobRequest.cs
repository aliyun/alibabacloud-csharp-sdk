// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitVideoCognitionJobRequest : TeaModel {
        /// <summary>
        /// <para>The input media object.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitVideoCognitionJobRequestInput Input { get; set; }
        public class SubmitVideoCognitionJobRequestInput : TeaModel {
            /// <summary>
            /// <para>If <c>Type</c> is <c>OSS</c>, specify the Object Storage Service (OSS) URL of the media file. Example: <c>OSS://test-bucket/video/202208/test.mp4</c></para>
            /// <para>If <c>Type</c> is <c>Media</c>, specify the media ID. Example: <c>c5c62d8f0361337cab312dce8e77dc6d</c></para>
            /// <para>If <c>Type</c> is <c>URL</c>, specify the HTTP URL of the media file. Example: <c>https://zc-test.oss-cn-shanghai.aliyuncs.com/test/unknowFace.mp4</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>c5c62d8f03613************c6d</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the input media. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>OSS</c></para>
            /// </description></item>
            /// <item><description><para><c>Media</c></para>
            /// </description></item>
            /// <item><description><para><c>URL</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Media</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>A JSON string containing additional parameters for operators such as natural language processing, shot detection, custom tagging, and action recognition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;nlpParams&quot;: {
        ///         &quot;sourceLanguage&quot;: &quot;cn&quot;,
        ///         &quot;diarizationEnabled&quot;: true,
        ///         &quot;speakerCount&quot;: 2,
        ///         &quot;summarizationEnabled&quot;: true,
        ///         &quot;summarizationTypes&quot;: &quot;Paragraph,Conversational,QuestionsAnswering,MindMap&quot;,
        ///         &quot;translationEnabled&quot;: true,
        ///         &quot;targetLanguages&quot;: &quot;en&quot;,
        ///         &quot;autoChaptersEnabled&quot;: true,
        ///         &quot;meetingAssistanceEnabled&quot;: true
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The template configuration.</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The ID of the template that specifies the analysis algorithms to use. For more information about managing templates, see <a href="https://help.aliyun.com/zh/ims/developer-reference/api-ice-2020-11-09-createcustomtemplate?spm=a2c4g.11186623.help-menu-193643.d_5_0_3_3_0_0.17b66afamjKySv">Create Custom Template</a> and <a href="https://help.aliyun.com/zh/ims/user-guide/smart-tagging-template?spm=a2c4g.11186623.0.i15">AI-powered tagging template</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc00***************</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The title of the video. The title can contain Chinese characters, English letters, digits, and hyphens (-). The title cannot start with a special character and must not exceed 256 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-title-****</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user-defined data. The service returns this data unmodified in the callback notification. This parameter cannot exceed 1,024 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:1}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
