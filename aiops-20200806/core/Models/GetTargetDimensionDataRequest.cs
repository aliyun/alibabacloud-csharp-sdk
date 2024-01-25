// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class GetTargetDimensionDataRequest : TeaModel {
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        [NameInMap("Flag")]
        [Validation(Required=false)]
        public string Flag { get; set; }

        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("LabelValue")]
        [Validation(Required=false)]
        public string LabelValue { get; set; }

        [NameInMap("MetricId")]
        [Validation(Required=false)]
        public string MetricId { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
