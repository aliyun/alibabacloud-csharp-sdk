// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class LanguageDetectRequest : TeaModel {
        /// <summary>
        /// <para>Optional. Set this parameter to query (case-insensitive) to use the new model. If this parameter is not specified or an invalid value is passed, the default value common (general language detection) is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>query</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The source text to be identified. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample text</para>
        /// </summary>
        [NameInMap("SourceText")]
        [Validation(Required=false)]
        public string SourceText { get; set; }

    }

}
