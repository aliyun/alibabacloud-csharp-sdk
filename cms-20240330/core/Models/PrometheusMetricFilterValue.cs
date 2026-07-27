// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PrometheusMetricFilterValue : TeaModel {
        [NameInMap("dim")]
        [Validation(Required=false)]
        public string Dim { get; set; }

        [NameInMap("opt")]
        [Validation(Required=false)]
        public string Opt { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
