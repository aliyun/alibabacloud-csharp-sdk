// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class SubmitTranslationTaskShrinkRequest : TeaModel {
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
        public string ConfigShrink { get; set; }

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
        public string CustomTermsShrink { get; set; }

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
