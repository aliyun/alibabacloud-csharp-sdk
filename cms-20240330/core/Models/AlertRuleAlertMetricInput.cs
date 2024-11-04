// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricInput : TeaModel {
        [NameInMap("filterValues")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricInputFilterValue> FilterValues { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("metricId")]
        [Validation(Required=false)]
        public string MetricId { get; set; }

        [NameInMap("paramValues")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricInputParamValue> ParamValues { get; set; }

    }

}
