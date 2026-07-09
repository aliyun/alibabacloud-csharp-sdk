// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MetricSetTriggerSimpleExpression : TeaModel {
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
