// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeProjectreviewconfigRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

        [NameInMap("RulesType")]
        [Validation(Required=false)]
        public string RulesType { get; set; }

        [NameInMap("SubmitterCanReview")]
        [Validation(Required=false)]
        public string SubmitterCanReview { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

        [NameInMap("ThresholdClear")]
        [Validation(Required=false)]
        public string ThresholdClear { get; set; }

    }

}
