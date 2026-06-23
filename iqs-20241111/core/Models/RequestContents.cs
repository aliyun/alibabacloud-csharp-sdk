// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class RequestContents : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the main text. Default value: false.</para>
        /// </summary>
        [NameInMap("mainText")]
        [Validation(Required=false)]
        public bool? MainText { get; set; }

        /// <summary>
        /// <para>Specifies whether to return markdown. Default value: false.</para>
        /// </summary>
        [NameInMap("markdownText")]
        [Validation(Required=false)]
        public bool? MarkdownText { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Rerank and return the RerankScore. Default value: true.</para>
        /// </summary>
        [NameInMap("rerankScore")]
        [Validation(Required=false)]
        public bool? RerankScore { get; set; }

        [NameInMap("richMainBody")]
        [Validation(Required=false)]
        public bool? RichMainBody { get; set; }

        /// <summary>
        /// <para>Specifies whether to return an enhanced summary. Default value: false. The summary feature is billed separately.</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public bool? Summary { get; set; }

    }

}
