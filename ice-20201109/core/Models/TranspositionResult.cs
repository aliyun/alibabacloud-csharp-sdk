// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class TranspositionResult : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description>The target language of the translation.</description></item>
        /// <item><description>This field is only used in translation-related scenarios.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The translated text corresponding to the matched hotwords. Maximum length: 100 characters.</description></item>
        /// <item><description>This field is only used in translation-related scenarios.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("TranslatedText")]
        [Validation(Required=false)]
        public string TranslatedText { get; set; }

    }

}
