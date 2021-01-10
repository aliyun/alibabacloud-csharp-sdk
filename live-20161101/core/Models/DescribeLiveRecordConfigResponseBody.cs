// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordConfigResponseBody : TeaModel {
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

        [NameInMap("LiveAppRecordList")]
        [Validation(Required=false)]
        public DescribeLiveRecordConfigResponseBodyLiveAppRecordList LiveAppRecordList { get; set; }
        public class DescribeLiveRecordConfigResponseBodyLiveAppRecordList : TeaModel {
            [NameInMap("LiveAppRecord")]
            [Validation(Required=false)]
            public List<DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecord> LiveAppRecord { get; set; }
            public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecord : TeaModel {
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public string AppName { get; set; }
                public string StreamName { get; set; }
                public string CreateTime { get; set; }
                public int? OnDemond { get; set; }
                public string OssBucket { get; set; }
                public DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatList RecordFormatList { get; set; }
                public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatList : TeaModel {
                    [NameInMap("RecordFormat")]
                    [Validation(Required=false)]
                    public List<DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatListRecordFormat> RecordFormat { get; set; }
                    public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatListRecordFormat : TeaModel {
                        [NameInMap("CycleDuration")]
                        [Validation(Required=false)]
                        public int? CycleDuration { get; set; }

                        [NameInMap("SliceOssObjectPrefix")]
                        [Validation(Required=false)]
                        public string SliceOssObjectPrefix { get; set; }

                        [NameInMap("OssObjectPrefix")]
                        [Validation(Required=false)]
                        public string OssObjectPrefix { get; set; }

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                }
                public string DomainName { get; set; }
                public string OssEndpoint { get; set; }
            }
        };

    }

}
