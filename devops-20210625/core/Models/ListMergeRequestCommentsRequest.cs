// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListMergeRequestCommentsRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("commentType")]
        [Validation(Required=false)]
        public string CommentType { get; set; }

        [NameInMap("filePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("patchSetBizIds")]
        [Validation(Required=false)]
        public List<string> PatchSetBizIds { get; set; }

        [NameInMap("resolved")]
        [Validation(Required=false)]
        public bool? Resolved { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("localId")]
        [Validation(Required=false)]
        public long? LocalId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("repositoryIdentity")]
        [Validation(Required=false)]
        public string RepositoryIdentity { get; set; }

    }

}
