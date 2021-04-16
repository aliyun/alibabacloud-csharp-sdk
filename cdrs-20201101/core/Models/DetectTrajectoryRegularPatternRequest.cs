// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class DetectTrajectoryRegularPatternRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("IdType")]
        [Validation(Required=false)]
        public string IdType { get; set; }

        [NameInMap("IdValue")]
        [Validation(Required=false)]
        public string IdValue { get; set; }

        [NameInMap("PredictDate")]
        [Validation(Required=false)]
        public string PredictDate { get; set; }

    }

}
