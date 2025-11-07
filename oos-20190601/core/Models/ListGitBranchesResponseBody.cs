// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListGitBranchesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("GitBranches")]
        [Validation(Required=false)]
        public List<ListGitBranchesResponseBodyGitBranches> GitBranches { get; set; }
        public class ListGitBranchesResponseBodyGitBranches : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DBA6E6C8-F75D-41DE-AFF5-1FA03F551CA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
