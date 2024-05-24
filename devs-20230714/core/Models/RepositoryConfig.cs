// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class RepositoryConfig : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("branchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        [NameInMap("manifest")]
        [Validation(Required=false)]
        public string Manifest { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("repositoryName")]
        [Validation(Required=false)]
        public string RepositoryName { get; set; }

    }

}
