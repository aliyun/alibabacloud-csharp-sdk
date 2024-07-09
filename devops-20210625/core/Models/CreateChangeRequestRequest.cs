// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateChangeRequestRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appCodeRepoSn")]
        [Validation(Required=false)]
        public string AppCodeRepoSn { get; set; }

        [NameInMap("autoDeleteBranchWhenEnd")]
        [Validation(Required=false)]
        public bool? AutoDeleteBranchWhenEnd { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("branchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        [NameInMap("createBranch")]
        [Validation(Required=false)]
        public bool? CreateBranch { get; set; }

        [NameInMap("ownerAccountId")]
        [Validation(Required=false)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ownerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
