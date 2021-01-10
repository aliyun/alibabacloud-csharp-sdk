// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeProjectpullrequestconfigRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("MergeMethod")]
        [Validation(Required=false)]
        public string MergeMethod { get; set; }

        [NameInMap("OnlyAllChecksSucceed")]
        [Validation(Required=false)]
        public string OnlyAllChecksSucceed { get; set; }

        [NameInMap("OnlyAllDiscussionsResolved")]
        [Validation(Required=false)]
        public string OnlyAllDiscussionsResolved { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

        [NameInMap("ReviewRequired")]
        [Validation(Required=false)]
        public string ReviewRequired { get; set; }

        [NameInMap("ShouldRemoveSourceBranch")]
        [Validation(Required=false)]
        public string ShouldRemoveSourceBranch { get; set; }

        [NameInMap("SquashMerge")]
        [Validation(Required=false)]
        public string SquashMerge { get; set; }

        [NameInMap("WorkitemFinishWhenMerge")]
        [Validation(Required=false)]
        public string WorkitemFinishWhenMerge { get; set; }

        [NameInMap("WorkitemRequired")]
        [Validation(Required=false)]
        public string WorkitemRequired { get; set; }

    }

}
