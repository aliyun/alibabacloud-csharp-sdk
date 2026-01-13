// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListRecallManagementTableVersionsResponseBody : TeaModel {
        [NameInMap("RecallManagementTableVersions")]
        [Validation(Required=false)]
        public List<ListRecallManagementTableVersionsResponseBodyRecallManagementTableVersions> RecallManagementTableVersions { get; set; }
        public class ListRecallManagementTableVersionsResponseBodyRecallManagementTableVersions : TeaModel {
            [NameInMap("DataVersion")]
            [Validation(Required=false)]
            public string DataVersion { get; set; }

            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            [NameInMap("PublishEndTime")]
            [Validation(Required=false)]
            public string PublishEndTime { get; set; }

            [NameInMap("PublishStartTime")]
            [Validation(Required=false)]
            public string PublishStartTime { get; set; }

            [NameInMap("RecallManagementTableVersionId")]
            [Validation(Required=false)]
            public string RecallManagementTableVersionId { get; set; }

            [NameInMap("SourceTableDataSize")]
            [Validation(Required=false)]
            public long? SourceTableDataSize { get; set; }

            [NameInMap("SourceTableRowCount")]
            [Validation(Required=false)]
            public long? SourceTableRowCount { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
