// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveRecordFilesResponseBody : TeaModel {
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ListLiveRecordFilesResponseBodyFiles> Files { get; set; }
        public class ListLiveRecordFilesResponseBodyFiles : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            [NameInMap("RecordOutput")]
            [Validation(Required=false)]
            public string RecordOutput { get; set; }

            [NameInMap("RecordUrl")]
            [Validation(Required=false)]
            public string RecordUrl { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("StreamUrl")]
            [Validation(Required=false)]
            public string StreamUrl { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
