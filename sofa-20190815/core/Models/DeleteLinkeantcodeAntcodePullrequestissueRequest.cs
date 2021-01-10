// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteLinkeantcodeAntcodePullrequestissueRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("PrId")]
        [Validation(Required=false)]
        public string PrId { get; set; }

        [NameInMap("PrIssueId")]
        [Validation(Required=false)]
        public string PrIssueId { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
