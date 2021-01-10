// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeantcodeAntcodeCreateprojectpullrequestRequest : TeaModel {
        [NameInMap("AssigneeId")]
        [Validation(Required=false)]
        public string AssigneeId { get; set; }

        [NameInMap("AutoMerge")]
        [Validation(Required=false)]
        public string AutoMerge { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

        [NameInMap("ReviewRequired")]
        [Validation(Required=false)]
        public string ReviewRequired { get; set; }

        [NameInMap("ReviewRules")]
        [Validation(Required=false)]
        public string ReviewRules { get; set; }

        [NameInMap("ShouldRemoveSourceBranch")]
        [Validation(Required=false)]
        public string ShouldRemoveSourceBranch { get; set; }

        [NameInMap("SourceBranch")]
        [Validation(Required=false)]
        public string SourceBranch { get; set; }

        [NameInMap("SquashMerge")]
        [Validation(Required=false)]
        public string SquashMerge { get; set; }

        [NameInMap("TargetBranch")]
        [Validation(Required=false)]
        public string TargetBranch { get; set; }

        [NameInMap("TargetProjectId")]
        [Validation(Required=false)]
        public string TargetProjectId { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("IssuesRepeatList")]
        [Validation(Required=false)]
        public List<string> IssuesRepeatList { get; set; }

        [NameInMap("LabelsRepeatList")]
        [Validation(Required=false)]
        public List<string> LabelsRepeatList { get; set; }

        [NameInMap("ReviewerIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> ReviewerIdsRepeatList { get; set; }

    }

}
