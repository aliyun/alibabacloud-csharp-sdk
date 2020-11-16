// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamRecordContentResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RecordContentInfoList")]
        [Validation(Required=true)]
        public DescribeLiveStreamRecordContentResponseRecordContentInfoList RecordContentInfoList { get; set; }
        public class DescribeLiveStreamRecordContentResponseRecordContentInfoList : TeaModel {
            [NameInMap("RecordContentInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamRecordContentResponseRecordContentInfoListRecordContentInfo> RecordContentInfo { get; set; }
            public class DescribeLiveStreamRecordContentResponseRecordContentInfoListRecordContentInfo : TeaModel {
                public string OssEndpoint { get; set; }
                public string OssBucket { get; set; }
                public string OssObjectPrefix { get; set; }
                public string StartTime { get; set; }
                public string EndTime { get; set; }
                public float? Duration { get; set; }
            }
        };

    }

}
