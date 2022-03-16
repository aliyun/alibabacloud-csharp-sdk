// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ClusterStatusLogtailStatusRecordValue : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("LogtailDetailStatus")]
        [Validation(Required=false)]
        public string LogtailDetailStatus { get; set; }

        [NameInMap("AccessLogDashboards")]
        [Validation(Required=false)]
        public List<ClusterStatusLogtailStatusRecordValueAccessLogDashboards> AccessLogDashboards { get; set; }
        public class ClusterStatusLogtailStatusRecordValueAccessLogDashboards : TeaModel {
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
