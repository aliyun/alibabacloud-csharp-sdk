// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class RepoItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2034</para>
        /// </summary>
        [NameInMap("codeLines")]
        [Validation(Required=false)]
        public long? CodeLines { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://code.aone.alibaba-inc.com/yunmall/yunmall-custome">https://code.aone.alibaba-inc.com/yunmall/yunmall-custome</a></para>
        /// </summary>
        [NameInMap("gitProjectUrl")]
        [Validation(Required=false)]
        public string GitProjectUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中驿</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yunmall/product.git</para>
        /// </summary>
        [NameInMap("repoShortUrl")]
        [Validation(Required=false)]
        public string RepoShortUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:git@gitlab.alibaba-inc.com">git@gitlab.alibaba-inc.com</a>:yunmall/product.git</para>
        /// </summary>
        [NameInMap("repoUrl")]
        [Validation(Required=false)]
        public string RepoUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>类目</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

    }

}
