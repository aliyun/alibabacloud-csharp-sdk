// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobFeatureReportsResponseBody : TeaModel {
        [NameInMap("DataPath")]
        [Validation(Required=false)]
        public string DataPath { get; set; }

        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        [NameInMap("ReportsOfFeatureDiff")]
        [Validation(Required=false)]
        public List<ListFeatureConsistencyCheckJobFeatureReportsResponseBodyReportsOfFeatureDiff> ReportsOfFeatureDiff { get; set; }
        public class ListFeatureConsistencyCheckJobFeatureReportsResponseBodyReportsOfFeatureDiff : TeaModel {
            [NameInMap("FeatureName")]
            [Validation(Required=false)]
            public string FeatureName { get; set; }

            [NameInMap("LogItemId")]
            [Validation(Required=false)]
            public string LogItemId { get; set; }

            [NameInMap("LogRequestId")]
            [Validation(Required=false)]
            public string LogRequestId { get; set; }

            [NameInMap("LogUserId")]
            [Validation(Required=false)]
            public string LogUserId { get; set; }

            [NameInMap("OfflineValue")]
            [Validation(Required=false)]
            public string OfflineValue { get; set; }

            [NameInMap("OnlineValue")]
            [Validation(Required=false)]
            public string OnlineValue { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
