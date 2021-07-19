// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInstanceStateReportsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("StateReports")]
        [Validation(Required=false)]
        public List<ListInstanceStateReportsResponseBodyStateReports> StateReports { get; set; }
        public class ListInstanceStateReportsResponseBodyStateReports : TeaModel {
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

            [NameInMap("ReportInfo")]
            [Validation(Required=false)]
            public string ReportInfo { get; set; }

            [NameInMap("SuccessApplyTime")]
            [Validation(Required=false)]
            public string SuccessApplyTime { get; set; }

            [NameInMap("StateConfigurationId")]
            [Validation(Required=false)]
            public string StateConfigurationId { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("ReportTime")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

        }

    }

}
