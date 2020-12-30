// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoBuildRecordLogResponseBody : TeaModel {
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("BuildRecordLogs")]
        [Validation(Required=false)]
        public List<ListRepoBuildRecordLogResponseBodyBuildRecordLogs> BuildRecordLogs { get; set; }
        public class ListRepoBuildRecordLogResponseBodyBuildRecordLogs : TeaModel {
            [NameInMap("LineNumber")]
            [Validation(Required=false)]
            public int? LineNumber { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("BuildStage")]
            [Validation(Required=false)]
            public string BuildStage { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
