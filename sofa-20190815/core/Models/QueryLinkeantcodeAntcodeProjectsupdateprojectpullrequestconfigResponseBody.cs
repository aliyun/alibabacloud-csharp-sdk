// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeProjectsupdateprojectpullrequestconfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("FfOnlyEnabled")]
        [Validation(Required=false)]
        public bool? FfOnlyEnabled { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("OnlyAllChecksSucceed")]
        [Validation(Required=false)]
        public bool? OnlyAllChecksSucceed { get; set; }

        [NameInMap("OnlyAllDiscussionsResolved")]
        [Validation(Required=false)]
        public bool? OnlyAllDiscussionsResolved { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("RebaseEnabled")]
        [Validation(Required=false)]
        public bool? RebaseEnabled { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ReviewRequired")]
        [Validation(Required=false)]
        public bool? ReviewRequired { get; set; }

        [NameInMap("ShouldRemoveSourceBranch")]
        [Validation(Required=false)]
        public bool? ShouldRemoveSourceBranch { get; set; }

        [NameInMap("SquashMerge")]
        [Validation(Required=false)]
        public bool? SquashMerge { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
