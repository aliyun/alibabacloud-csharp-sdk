// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobScoreReportsResponseBody : TeaModel {
        [NameInMap("DataPath")]
        [Validation(Required=false)]
        public string DataPath { get; set; }

        [NameInMap("OssPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        [NameInMap("ReportsOfScoreDiff")]
        [Validation(Required=false)]
        public List<ListFeatureConsistencyCheckJobScoreReportsResponseBodyReportsOfScoreDiff> ReportsOfScoreDiff { get; set; }
        public class ListFeatureConsistencyCheckJobScoreReportsResponseBodyReportsOfScoreDiff : TeaModel {
            [NameInMap("LogItemId")]
            [Validation(Required=false)]
            public string LogItemId { get; set; }

            [NameInMap("LogRequestId")]
            [Validation(Required=false)]
            public string LogRequestId { get; set; }

            [NameInMap("LogUserId")]
            [Validation(Required=false)]
            public string LogUserId { get; set; }

            [NameInMap("ScoreDiff")]
            [Validation(Required=false)]
            public string ScoreDiff { get; set; }

            [NameInMap("ScoreDiffDetail")]
            [Validation(Required=false)]
            public string ScoreDiffDetail { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
