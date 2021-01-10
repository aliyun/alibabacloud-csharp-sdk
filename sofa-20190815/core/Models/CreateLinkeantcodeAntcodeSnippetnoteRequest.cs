// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeantcodeAntcodeSnippetnoteRequest : TeaModel {
        [NameInMap("DiscussionId")]
        [Validation(Required=false)]
        public string DiscussionId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IsAward")]
        [Validation(Required=false)]
        public string IsAward { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
