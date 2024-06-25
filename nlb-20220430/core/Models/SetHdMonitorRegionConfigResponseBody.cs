// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class SetHdMonitorRegionConfigResponseBody : TeaModel {
        [NameInMap("LogProject")]
        [Validation(Required=false)]
        public string LogProject { get; set; }

        [NameInMap("MetricStore")]
        [Validation(Required=false)]
        public string MetricStore { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
