// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringSimpleEscalationEntry : TeaModel {
        [NameInMap("comparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        [NameInMap("preCondition")]
        [Validation(Required=false)]
        public string PreCondition { get; set; }

        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        [NameInMap("threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
