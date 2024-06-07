// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetMetricsRequest : TeaModel {
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
