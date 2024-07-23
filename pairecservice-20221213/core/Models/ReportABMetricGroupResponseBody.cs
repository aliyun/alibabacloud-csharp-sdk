// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ReportABMetricGroupResponseBody : TeaModel {
        [NameInMap("ExperimentReport")]
        [Validation(Required=false)]
        public Dictionary<string, ExperimentReportValue> ExperimentReport { get; set; }

        [NameInMap("GroupDimension")]
        [Validation(Required=false)]
        public List<string> GroupDimension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>59CE7EC6-F268-5D71-9215-32922CC50D72</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
