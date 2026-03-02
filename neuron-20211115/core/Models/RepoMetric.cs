// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class RepoMetric : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>294</para>
        /// </summary>
        [NameInMap("codeLines")]
        [Validation(Required=false)]
        public long? CodeLines { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("commitCnt")]
        [Validation(Required=false)]
        public long? CommitCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("developerCnt")]
        [Validation(Required=false)]
        public long? DeveloperCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-05-03T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("refreshDate")]
        [Validation(Required=false)]
        public string RefreshDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>neuron/catalog.git</para>
        /// </summary>
        [NameInMap("repoShortUrl")]
        [Validation(Required=false)]
        public string RepoShortUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:git@gitlab.alibaba-inc.com">git@gitlab.alibaba-inc.com</a>:neuron/catalog.git</para>
        /// </summary>
        [NameInMap("repoUrl")]
        [Validation(Required=false)]
        public string RepoUrl { get; set; }

    }

}
