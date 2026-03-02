// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ReposFork : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>global-mall</para>
        /// </summary>
        [NameInMap("gitGroup")]
        [Validation(Required=false)]
        public string GitGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-03T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isOrigin")]
        [Validation(Required=false)]
        public bool? IsOrigin { get; set; }

        [NameInMap("pbcRepoItems")]
        [Validation(Required=false)]
        public List<RepoItem> PbcRepoItems { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>商城国际版本</para>
        /// </summary>
        [NameInMap("usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
