// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobsResponseBody : TeaModel {
        [NameInMap("FeatureConsistencyCheckJobs")]
        [Validation(Required=false)]
        public List<ListFeatureConsistencyCheckJobsResponseBodyFeatureConsistencyCheckJobs> FeatureConsistencyCheckJobs { get; set; }
        public class ListFeatureConsistencyCheckJobsResponseBodyFeatureConsistencyCheckJobs : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("FeatureConsistencyCheckJobConfigId")]
            [Validation(Required=false)]
            public string FeatureConsistencyCheckJobConfigId { get; set; }

            [NameInMap("FeatureConsistencyCheckJobConfigName")]
            [Validation(Required=false)]
            public string FeatureConsistencyCheckJobConfigName { get; set; }

            [NameInMap("FeatureConsistencyCheckJobId")]
            [Validation(Required=false)]
            public string FeatureConsistencyCheckJobId { get; set; }

            [NameInMap("GmtEndTime")]
            [Validation(Required=false)]
            public string GmtEndTime { get; set; }

            [NameInMap("GmtStartTime")]
            [Validation(Required=false)]
            public string GmtStartTime { get; set; }

            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<string> Logs { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
