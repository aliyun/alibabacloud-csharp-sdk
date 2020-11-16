// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamRecordIndexFilesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=true)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Order")]
        [Validation(Required=true)]
        public string Order { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=true)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=true)]
        public int? TotalPage { get; set; }

        [NameInMap("RecordIndexInfoList")]
        [Validation(Required=true)]
        public DescribeLiveStreamRecordIndexFilesResponseRecordIndexInfoList RecordIndexInfoList { get; set; }
        public class DescribeLiveStreamRecordIndexFilesResponseRecordIndexInfoList : TeaModel {
            [NameInMap("RecordIndexInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamRecordIndexFilesResponseRecordIndexInfoListRecordIndexInfo> RecordIndexInfo { get; set; }
            public class DescribeLiveStreamRecordIndexFilesResponseRecordIndexInfoListRecordIndexInfo : TeaModel {
                public string RecordId { get; set; }
                public string RecordUrl { get; set; }
                public string DomainName { get; set; }
                public string AppName { get; set; }
                public string StreamName { get; set; }
                public string OssBucket { get; set; }
                public string OssEndpoint { get; set; }
                public string OssObject { get; set; }
                public string StartTime { get; set; }
                public string EndTime { get; set; }
                public float? Duration { get; set; }
                public int? Height { get; set; }
                public int? Width { get; set; }
                public string CreateTime { get; set; }
            }
        };

    }

}
