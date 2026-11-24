// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextCorrectRequest : TeaModel {
        /// <summary>
        /// <para>The language code of the source text. This parameter is required. You can set this parameter to auto for automatic language detection. 14 languages are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The text to be corrected. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Empfelung</para>
        /// </summary>
        [NameInMap("SourceText")]
        [Validation(Required=false)]
        public string SourceText { get; set; }

    }

}
