// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class FeedbackAlertAlgorithmRequest : TeaModel {
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        [NameInMap("AlgorithmAccurateDescribe")]
        [Validation(Required=false)]
        public string AlgorithmAccurateDescribe { get; set; }

        [NameInMap("AlgorithmAccurateState")]
        [Validation(Required=false)]
        public int? AlgorithmAccurateState { get; set; }

        [NameInMap("FeedbackType")]
        [Validation(Required=false)]
        public int? FeedbackType { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}
