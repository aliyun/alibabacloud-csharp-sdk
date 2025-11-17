// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitVideoCognitionJobRequest : TeaModel {
        /// <summary>
        /// <para>The media input object.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitVideoCognitionJobRequestInput Input { get; set; }
        public class SubmitVideoCognitionJobRequestInput : TeaModel {
            /// <summary>
            /// <para>If Type is set to OSS, specify an OSS path. Example: OSS://test-bucket/video/202208/test.mp4.</para>
            /// <para>If Type is set to Media, specify a media asset ID. Example: c5c62d8f0361337cab312dce8e77dc6d.</para>
            /// <para>If Type is set to URL, specify an HTTP URL. Example: <a href="https://zc-test.oss-cn-shanghai.aliyuncs.com/test/unknowFace.mp4">https://zc-test.oss-cn-shanghai.aliyuncs.com/test/unknowFace.mp4</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c5c62d8f03613************c6d</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of media input. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OSS</description></item>
            /// <item><description>Media</description></item>
            /// <item><description>URL</description></item>
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
        /// <para>Additional request parameters, provided as a JSON string. This is used to pass specific settings for various AI analysis modules, such as Natural Language Processing (NLP), shot segmentation, tagging, and action recognition.</para>
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

        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para>The ID of the template that specifies the analysis algorithms to be used. For details, see <a href="https://help.aliyun.com/zh/ims/developer-reference/api-ice-2020-11-09-createcustomtemplate?spm=a2c4g.11186623.help-menu-193643.d_5_0_3_3_0_0.17b66afamjKySv">CreateCustomTemplate</a> and <a href="https://help.aliyun.com/zh/ims/user-guide/smart-tagging-template?spm=a2c4g.11186623.0.i15">smart tagging template</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc00***************</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The video title. It supports letters, digits, and hyphens (-), and cannot start with a special character. Max length: 256 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-title-****</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The user-defined data that is passed through and returned as-is in the response. Max length: 1,024 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;test&quot;:1}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
