// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateCommentRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("commentType")]
        [Validation(Required=false)]
        public string CommentType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("draft")]
        [Validation(Required=false)]
        public bool? Draft { get; set; }

        [NameInMap("filePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("lineNumber")]
        [Validation(Required=false)]
        public int? LineNumber { get; set; }

        [NameInMap("parentCommentBizId")]
        [Validation(Required=false)]
        public string ParentCommentBizId { get; set; }

        [NameInMap("patchSetBizId")]
        [Validation(Required=false)]
        public string PatchSetBizId { get; set; }

        [NameInMap("resolved")]
        [Validation(Required=false)]
        public bool? Resolved { get; set; }

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
