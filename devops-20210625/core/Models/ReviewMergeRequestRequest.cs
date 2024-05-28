// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ReviewMergeRequestRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("draftCommentIds")]
        [Validation(Required=false)]
        public List<string> DraftCommentIds { get; set; }

        [NameInMap("reviewComment")]
        [Validation(Required=false)]
        public string ReviewComment { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("reviewOpinion")]
        [Validation(Required=false)]
        public string ReviewOpinion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
