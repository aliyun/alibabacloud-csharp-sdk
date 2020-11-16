// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordConfigResponse : TeaModel {
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

        [NameInMap("LiveAppRecordList")]
        [Validation(Required=true)]
        public DescribeLiveRecordConfigResponseLiveAppRecordList LiveAppRecordList { get; set; }
        public class DescribeLiveRecordConfigResponseLiveAppRecordList : TeaModel {
            [NameInMap("LiveAppRecord")]
            [Validation(Required=true)]
            public List<DescribeLiveRecordConfigResponseLiveAppRecordListLiveAppRecord> LiveAppRecord { get; set; }
            public class DescribeLiveRecordConfigResponseLiveAppRecordListLiveAppRecord : TeaModel {
                public string DomainName { get; set; }
                public string AppName { get; set; }
                public string StreamName { get; set; }
                public string OssEndpoint { get; set; }
                public string OssBucket { get; set; }
                public string CreateTime { get; set; }
                public string StartTime { get; set; }
                public string EndTime { get; set; }
                public int? OnDemond { get; set; }
                public DescribeLiveRecordConfigResponseLiveAppRecordListLiveAppRecordRecordFormatList RecordFormatList { get; set; }
                public class DescribeLiveRecordConfigResponseLiveAppRecordListLiveAppRecordRecordFormatList : TeaModel {
                    [NameInMap("RecordFormat")]
                    [Validation(Required=true)]
                    public List<DescribeLiveRecordConfigResponseLiveAppRecordListLiveAppRecordRecordFormatListRecordFormat> RecordFormat { get; set; }
                    public class DescribeLiveRecordConfigResponseLiveAppRecordListLiveAppRecordRecordFormatListRecordFormat : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=true)]
                        public string Format { get; set; }

                        [NameInMap("OssObjectPrefix")]
                        [Validation(Required=true)]
                        public string OssObjectPrefix { get; set; }

                        [NameInMap("SliceOssObjectPrefix")]
                        [Validation(Required=true)]
                        public string SliceOssObjectPrefix { get; set; }

                        [NameInMap("CycleDuration")]
                        [Validation(Required=true)]
                        public int? CycleDuration { get; set; }

                    }

                }
            }
        };

    }

}
