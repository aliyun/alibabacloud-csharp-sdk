// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class LogRunMetricsRequest : TeaModel {
        /// <summary>
        /// <para>The metrics.</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<RunMetric> Metrics { get; set; }

    }

}
