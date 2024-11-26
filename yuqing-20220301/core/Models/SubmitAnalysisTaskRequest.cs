// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yuqing20220301.Models
{
    public class SubmitAnalysisTaskRequest : TeaModel {
        [NameInMap("analyseType")]
        [Validation(Required=false)]
        public string AnalyseType { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("searchCondition")]
        [Validation(Required=false)]
        public SearchCondition SearchCondition { get; set; }

        [NameInMap("teamHashId")]
        [Validation(Required=false)]
        public string TeamHashId { get; set; }

    }

}
