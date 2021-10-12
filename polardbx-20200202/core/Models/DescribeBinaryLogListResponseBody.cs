// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeBinaryLogListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

        [NameInMap("LogList")]
        [Validation(Required=false)]
        public List<DescribeBinaryLogListResponseBodyLogList> LogList { get; set; }
        public class DescribeBinaryLogListResponseBodyLogList : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("UploadHost")]
            [Validation(Required=false)]
            public string UploadHost { get; set; }

            [NameInMap("UploadStatus")]
            [Validation(Required=false)]
            public int? UploadStatus { get; set; }

            [NameInMap("DownloadLink")]
            [Validation(Required=false)]
            public string DownloadLink { get; set; }

            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            [NameInMap("LogSize")]
            [Validation(Required=false)]
            public long? LogSize { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("PurgeStatus")]
            [Validation(Required=false)]
            public int? PurgeStatus { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
