// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateMergeRequestRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("createFrom")]
        [Validation(Required=false)]
        public string CreateFrom { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("reviewerIds")]
        [Validation(Required=false)]
        public List<string> ReviewerIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sourceBranch")]
        [Validation(Required=false)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sourceProjectId")]
        [Validation(Required=false)]
        public long? SourceProjectId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetBranch")]
        [Validation(Required=false)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetProjectId")]
        [Validation(Required=false)]
        public long? TargetProjectId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("workItemIds")]
        [Validation(Required=false)]
        public string WorkItemIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
