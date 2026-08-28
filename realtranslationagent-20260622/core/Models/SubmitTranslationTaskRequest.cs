// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class SubmitTranslationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The API key that identifies the identity of the member account. You can obtain this from the RuiYiBao console.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("APIKey")]
        [Validation(Required=false)]
        public string APIKey { get; set; }

        /// <summary>
        /// <para>The translation task ID of a previously submitted translation task. Pass in this parameter when resubmitting a translation task.</para>
        /// <list type="bullet">
        /// <item><description>You must pass in either this parameter or TaskId.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>f9c35b0453b</para>
        /// </summary>
        [NameInMap("BaseTaskId")]
        [Validation(Required=false)]
        public string BaseTaskId { get; set; }

        /// <summary>
        /// <para>The translation configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;SourceLanguage&quot;: &quot;zh&quot;,
        ///         &quot;TargetLanguage&quot;: &quot;en&quot;,
        ///         &quot;Style&quot;: &quot;minimal&quot;,
        ///         &quot;Font&quot;: &quot;Arial&quot;
        ///     }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public SubmitTranslationTaskRequestConfig Config { get; set; }
        public class SubmitTranslationTaskRequestConfig : TeaModel {
            [NameInMap("Agent")]
            [Validation(Required=false)]
            public string Agent { get; set; }

            /// <summary>
            /// <para>The agent ID passed to the Agent Console platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-11111111</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The font.</para>
            /// <list type="bullet">
            /// <item><description>For new tasks, obtain this from UploadTranslationFile.</description></item>
            /// <item><description>For retranslation of historical tasks, obtain this from GetTranslationTask.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Arial</para>
            /// </summary>
            [NameInMap("Font")]
            [Validation(Required=false)]
            public string Font { get; set; }

            /// <summary>
            /// <para>The language of the source file.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("SourceLanguage")]
            [Validation(Required=false)]
            public string SourceLanguage { get; set; }

            /// <summary>
            /// <para>The translation style. Takes effect only when the translation file is a PPT file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>minimal</para>
            /// </summary>
            [NameInMap("Style")]
            [Validation(Required=false)]
            public string Style { get; set; }

            /// <summary>
            /// <para>The target language.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("TargetLanguage")]
            [Validation(Required=false)]
            public string TargetLanguage { get; set; }

        }

        /// <summary>
        /// <para>The custom terms.</para>
        /// <remarks>
        /// <para>Notice: Custom terms are for reference only. Actual translation results may differ. Refer to the final output for the definitive result.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;SourceTerm&quot;:&quot;dog&quot;, &quot;TargetTerm&quot;:&quot;dog&quot;}]</para>
        /// </summary>
        [NameInMap("CustomTerms")]
        [Validation(Required=false)]
        public List<SubmitTranslationTaskRequestCustomTerms> CustomTerms { get; set; }
        public class SubmitTranslationTaskRequestCustomTerms : TeaModel {
            /// <summary>
            /// <para>The source term.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dog</para>
            /// </summary>
            [NameInMap("SourceTerm")]
            [Validation(Required=false)]
            public string SourceTerm { get; set; }

            /// <summary>
            /// <para>The target term.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dog</para>
            /// </summary>
            [NameInMap("TargetTerm")]
            [Validation(Required=false)]
            public string TargetTerm { get; set; }

        }

        /// <summary>
        /// <para>The translation task ID.</para>
        /// <list type="bullet">
        /// <item><description>Obtained from the TaskId returned by UploadTranslationFile.</description></item>
        /// <item><description>You must pass in either this parameter or BaseTaskId.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>f9c35b0453b</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
