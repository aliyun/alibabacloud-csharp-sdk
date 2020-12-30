// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class ListDashboardDetailsFlowsRequest : TeaModel {
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("TraceIds")]
        [Validation(Required=false)]
        public string TraceIds { get; set; }

        [NameInMap("SceneIds")]
        [Validation(Required=false)]
        public string SceneIds { get; set; }

        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

    }

}
