// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class GetIndexDialysisListLineRequest : TeaModel {
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("CloudResourceId")]
        [Validation(Required=false)]
        public string CloudResourceId { get; set; }

        [NameInMap("CloudTypeName")]
        [Validation(Required=false)]
        public string CloudTypeName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("IndexCode")]
        [Validation(Required=false)]
        public string IndexCode { get; set; }

        [NameInMap("MetricExtend")]
        [Validation(Required=false)]
        public string MetricExtend { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

    }

}
