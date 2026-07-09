// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MetricSetTriggerCompositeExpression : TeaModel {
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<MetricSetTriggerSimpleExpression> Conditions { get; set; }

        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

    }

}
