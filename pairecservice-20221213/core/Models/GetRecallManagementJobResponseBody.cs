// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetRecallManagementJobResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Log")]
        [Validation(Required=false)]
        public string Log { get; set; }

        [NameInMap("RecallManagementJobId")]
        [Validation(Required=false)]
        public string RecallManagementJobId { get; set; }

        [NameInMap("RecallManagerTableInfo")]
        [Validation(Required=false)]
        public GetRecallManagementJobResponseBodyRecallManagerTableInfo RecallManagerTableInfo { get; set; }
        public class GetRecallManagementJobResponseBodyRecallManagerTableInfo : TeaModel {
            [NameInMap("DataVersion")]
            [Validation(Required=false)]
            public string DataVersion { get; set; }

            [NameInMap("RecallManagerTableVersionId")]
            [Validation(Required=false)]
            public string RecallManagerTableVersionId { get; set; }

            [NameInMap("SourceTableDataSize")]
            [Validation(Required=false)]
            public string SourceTableDataSize { get; set; }

            [NameInMap("SourceTableRowCount")]
            [Validation(Required=false)]
            public string SourceTableRowCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
