// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class Hotword : TeaModel {
        /// <summary>
        /// <para>The language of the hotword text. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>For structured media analysis and ASR: zh: Chinese en: English</description></item>
        /// <item><description>For video translation: Supports 53 languages.</description></item>
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The text of the hotword.</para>
        /// <list type="bullet">
        /// <item><description>For structured media analysis and ASR:</description></item>
        /// <item><description><list type="bullet">
        /// <item><description>Chinese: Up to 15 characters.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>English: Up to 10 words, separated by spaces.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description>Mixed: Each letter is counted as one character (following the Chinese limit).</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>For video translation: Up to 100 characters.</description></item>
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Predefined translation results for the hotword.</description></item>
        /// <item><description>This field is only used in translation-related scenarios.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("TranspositionResultList")]
        [Validation(Required=false)]
        public List<TranspositionResult> TranspositionResultList { get; set; }

        /// <summary>
        /// <para>The weight of the hotword.</para>
        /// <ol>
        /// <item><description>Valid values: [-6,5].</description></item>
        /// <item><description>A positive value increases the likelihood of the word being recognized, while a negative value decreases the likelihood.</description></item>
        /// <item><description>A value of -6 specifies that recognition of this word should be minimized.</description></item>
        /// <item><description>Recommended value: 2.</description></item>
        /// <item><description>If the desired effect is not achieved, you can increase the weight. However, excessively high weights may negatively impact the recognition accuracy of other words.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
