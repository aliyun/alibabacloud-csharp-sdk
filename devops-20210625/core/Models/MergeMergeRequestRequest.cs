// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class MergeMergeRequestRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("mergeMessage")]
        [Validation(Required=false)]
        public string MergeMessage { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mergeType")]
        [Validation(Required=false)]
        public string MergeType { get; set; }

        [NameInMap("removeSourceBranch")]
        [Validation(Required=false)]
        public bool? RemoveSourceBranch { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
