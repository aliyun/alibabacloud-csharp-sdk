// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class TranspositionResult : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>你好</para>
        /// </summary>
        [NameInMap("TranslatedText")]
        [Validation(Required=false)]
        public string TranslatedText { get; set; }

    }

}
