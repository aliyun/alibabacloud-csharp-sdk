// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamRecordContentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RecordContentInfoList")]
        [Validation(Required=false)]
        public DescribeLiveStreamRecordContentResponseBodyRecordContentInfoList RecordContentInfoList { get; set; }
        public class DescribeLiveStreamRecordContentResponseBodyRecordContentInfoList : TeaModel {
            [NameInMap("RecordContentInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamRecordContentResponseBodyRecordContentInfoListRecordContentInfo> RecordContentInfo { get; set; }
            public class DescribeLiveStreamRecordContentResponseBodyRecordContentInfoListRecordContentInfo : TeaModel {
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public float? Duration { get; set; }
                public string OssBucket { get; set; }
                public string OssObjectPrefix { get; set; }
                public string OssEndpoint { get; set; }
            }
        };

    }

}
