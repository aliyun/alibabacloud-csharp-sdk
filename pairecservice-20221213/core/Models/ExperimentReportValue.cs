/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ExperimentReportValue : TeaModel {
        [NameInMap("Baseline")]
        [Validation(Required=false)]
        public bool? Baseline { get; set; }

        [NameInMap("MetricResults")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> MetricResults { get; set; }

    }

}
