// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedQueryContext : TeaModel {
        /// <summary>
        /// <para>The search engine used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Generic</para>
        /// </summary>
        [NameInMap("engineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The initial request.</para>
        /// </summary>
        [NameInMap("originalQuery")]
        [Validation(Required=false)]
        public UnifiedOriginalQuery OriginalQuery { get; set; }

        /// <summary>
        /// <para>The rewritten result.</para>
        /// </summary>
        [NameInMap("rewrite")]
        [Validation(Required=false)]
        public UnifiedRewrite Rewrite { get; set; }

    }

}
