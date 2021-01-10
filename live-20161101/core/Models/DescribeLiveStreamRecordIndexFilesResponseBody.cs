// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamRecordIndexFilesResponseBody : TeaModel {
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RecordIndexInfoList")]
        [Validation(Required=false)]
        public DescribeLiveStreamRecordIndexFilesResponseBodyRecordIndexInfoList RecordIndexInfoList { get; set; }
        public class DescribeLiveStreamRecordIndexFilesResponseBodyRecordIndexInfoList : TeaModel {
            [NameInMap("RecordIndexInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamRecordIndexFilesResponseBodyRecordIndexInfoListRecordIndexInfo> RecordIndexInfo { get; set; }
            public class DescribeLiveStreamRecordIndexFilesResponseBodyRecordIndexInfoListRecordIndexInfo : TeaModel {
                public string StreamName { get; set; }
                public string RecordUrl { get; set; }
                public string RecordId { get; set; }
                public string CreateTime { get; set; }
                public int? Height { get; set; }
                public string OssBucket { get; set; }
                public string DomainName { get; set; }
                public string EndTime { get; set; }
                public string OssObject { get; set; }
                public string StartTime { get; set; }
                public string AppName { get; set; }
                public int? Width { get; set; }
                public float? Duration { get; set; }
                public string OssEndpoint { get; set; }
            }
        };

    }

}
