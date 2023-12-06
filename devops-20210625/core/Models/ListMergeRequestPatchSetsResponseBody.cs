// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListMergeRequestPatchSetsResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListMergeRequestPatchSetsResponseBodyResult> Result { get; set; }
        public class ListMergeRequestPatchSetsResponseBodyResult : TeaModel {
            [NameInMap("commitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("patchSetBizId")]
            [Validation(Required=false)]
            public string PatchSetBizId { get; set; }

            [NameInMap("patchSetName")]
            [Validation(Required=false)]
            public string PatchSetName { get; set; }

            [NameInMap("patchSetNo")]
            [Validation(Required=false)]
            public long? PatchSetNo { get; set; }

            [NameInMap("relatedMergeItemType")]
            [Validation(Required=false)]
            public string RelatedMergeItemType { get; set; }

            [NameInMap("shortCommitId")]
            [Validation(Required=false)]
            public string ShortCommitId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
