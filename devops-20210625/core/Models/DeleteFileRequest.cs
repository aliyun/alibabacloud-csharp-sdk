// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class DeleteFileRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("branchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("commitMessage")]
        [Validation(Required=false)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("filePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
