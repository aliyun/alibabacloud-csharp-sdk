/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_oxs_cross20200701.Models
{
    public class LingJieApiInvokeCount : TeaModel {
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<LingJieApiInvokeCountMetrics> Metrics { get; set; }
        public class LingJieApiInvokeCountMetrics : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("Day")]
            [Validation(Required=false)]
            public string Day { get; set; }

            [NameInMap("Hour")]
            [Validation(Required=false)]
            public string Hour { get; set; }

        }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("StatisticsUnit")]
        [Validation(Required=false)]
        public string StatisticsUnit { get; set; }

        [NameInMap("TimeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

    }

}
