// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeantcodeAntcodeProjectsidpullrequestspullrequestidcommentsRequest : TeaModel {
        [NameInMap("CommitId")]
        [Validation(Required=false)]
        public string CommitId { get; set; }

        [NameInMap("DiffId")]
        [Validation(Required=false)]
        public string DiffId { get; set; }

        [NameInMap("DiscussionId")]
        [Validation(Required=false)]
        public string DiscussionId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("LeftLineNum")]
        [Validation(Required=false)]
        public string LeftLineNum { get; set; }

        [NameInMap("LineCode")]
        [Validation(Required=false)]
        public string LineCode { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("PullRequestId")]
        [Validation(Required=false)]
        public string PullRequestId { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

        [NameInMap("RightLineNum")]
        [Validation(Required=false)]
        public string RightLineNum { get; set; }

        [NameInMap("StartSha")]
        [Validation(Required=false)]
        public string StartSha { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("LabelsRepeatList")]
        [Validation(Required=false)]
        public List<string> LabelsRepeatList { get; set; }

        [NameInMap("PathRepeatList")]
        [Validation(Required=false)]
        public List<string> PathRepeatList { get; set; }

    }

}
