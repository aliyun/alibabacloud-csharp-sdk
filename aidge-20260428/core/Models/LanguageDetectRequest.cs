// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class LanguageDetectRequest : TeaModel {
        /// <summary>
        /// <para>The detection scenario. Default value: common. If you are using a search phrase scenario, set this parameter to query. If an incorrect value is passed or the parameter is not specified, the common general identification is used. Note: pass query in lowercase.</para>
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
