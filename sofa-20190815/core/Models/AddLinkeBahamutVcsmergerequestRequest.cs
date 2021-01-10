// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeBahamutVcsmergerequestRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AssigneeId")]
        [Validation(Required=false)]
        public string AssigneeId { get; set; }

        [NameInMap("AssigneeUserName")]
        [Validation(Required=false)]
        public string AssigneeUserName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IterationUnitId")]
        [Validation(Required=false)]
        public string IterationUnitId { get; set; }

        [NameInMap("NeedReview")]
        [Validation(Required=false)]
        public bool? NeedReview { get; set; }

        [NameInMap("ReviewersThreshold")]
        [Validation(Required=false)]
        public long? ReviewersThreshold { get; set; }

        [NameInMap("ReviewRules")]
        [Validation(Required=false)]
        public string ReviewRules { get; set; }

        [NameInMap("ShouldRemoveSourceBranch")]
        [Validation(Required=false)]
        public bool? ShouldRemoveSourceBranch { get; set; }

        [NameInMap("SourceBranch")]
        [Validation(Required=false)]
        public string SourceBranch { get; set; }

        [NameInMap("SquashMerge")]
        [Validation(Required=false)]
        public bool? SquashMerge { get; set; }

        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        [NameInMap("TargetBranch")]
        [Validation(Required=false)]
        public string TargetBranch { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("ReviewersRepeatList")]
        [Validation(Required=false)]
        public List<string> ReviewersRepeatList { get; set; }

        [NameInMap("WorkItemsRepeatList")]
        [Validation(Required=false)]
        public List<string> WorkItemsRepeatList { get; set; }

    }

}
