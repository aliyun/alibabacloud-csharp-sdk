// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class PullRequestFilter : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>feature-.*</para>
        /// </summary>
        [NameInMap("sourceBranch")]
        [Validation(Required=false)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("targetBranch")]
        [Validation(Required=false)]
        public string TargetBranch { get; set; }

        [NameInMap("types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
