// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class TimedPoolConfig : TeaModel {
        [NameInMap("effectiveEndDate")]
        [Validation(Required=false)]
        public string EffectiveEndDate { get; set; }

        [NameInMap("effectiveStartDate")]
        [Validation(Required=false)]
        public string EffectiveStartDate { get; set; }

        [NameInMap("elasticIntervals")]
        [Validation(Required=false)]
        public List<ElasticInterval> ElasticIntervals { get; set; }

        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
