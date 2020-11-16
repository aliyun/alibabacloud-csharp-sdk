// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamRecordIndexFileResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RecordIndexInfo")]
        [Validation(Required=true)]
        public DescribeLiveStreamRecordIndexFileResponseRecordIndexInfo RecordIndexInfo { get; set; }
        public class DescribeLiveStreamRecordIndexFileResponseRecordIndexInfo : TeaModel {
            [NameInMap("RecordId")]
            [Validation(Required=true)]
            public string RecordId { get; set; }
            [NameInMap("RecordUrl")]
            [Validation(Required=true)]
            public string RecordUrl { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=true)]
            public string AppName { get; set; }
            [NameInMap("StreamName")]
            [Validation(Required=true)]
            public string StreamName { get; set; }
            [NameInMap("OssBucket")]
            [Validation(Required=true)]
            public string OssBucket { get; set; }
            [NameInMap("OssEndpoint")]
            [Validation(Required=true)]
            public string OssEndpoint { get; set; }
            [NameInMap("OssObject")]
            [Validation(Required=true)]
            public string OssObject { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=true)]
            public string StartTime { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=true)]
            public string EndTime { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=true)]
            public float? Duration { get; set; }
            [NameInMap("Height")]
            [Validation(Required=true)]
            public int? Height { get; set; }
            [NameInMap("Width")]
            [Validation(Required=true)]
            public int? Width { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }
        };

    }

}
