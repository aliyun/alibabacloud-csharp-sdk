// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordConfigResponseBody : TeaModel {
        [NameInMap("LiveAppRecordList")]
        [Validation(Required=false)]
        public DescribeLiveRecordConfigResponseBodyLiveAppRecordList LiveAppRecordList { get; set; }
        public class DescribeLiveRecordConfigResponseBodyLiveAppRecordList : TeaModel {
            [NameInMap("LiveAppRecord")]
            [Validation(Required=false)]
            public List<DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecord> LiveAppRecord { get; set; }
            public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecord : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("OnDemond")]
                [Validation(Required=false)]
                public int? OnDemond { get; set; }

                [NameInMap("OssBucket")]
                [Validation(Required=false)]
                public string OssBucket { get; set; }

                [NameInMap("OssEndpoint")]
                [Validation(Required=false)]
                public string OssEndpoint { get; set; }

                [NameInMap("RecordFormatList")]
                [Validation(Required=false)]
                public DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatList RecordFormatList { get; set; }
                public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatList : TeaModel {
                    [NameInMap("RecordFormat")]
                    [Validation(Required=false)]
                    public List<DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatListRecordFormat> RecordFormat { get; set; }
                    public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatListRecordFormat : TeaModel {
                        [NameInMap("CycleDuration")]
                        [Validation(Required=false)]
                        public int? CycleDuration { get; set; }

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("OssObjectPrefix")]
                        [Validation(Required=false)]
                        public string OssObjectPrefix { get; set; }

                        [NameInMap("SliceDuration")]
                        [Validation(Required=false)]
                        public int? SliceDuration { get; set; }

                        [NameInMap("SliceOssObjectPrefix")]
                        [Validation(Required=false)]
                        public string SliceOssObjectPrefix { get; set; }

                    }

                }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("TranscodeRecordFormatList")]
                [Validation(Required=false)]
                public DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordTranscodeRecordFormatList TranscodeRecordFormatList { get; set; }
                public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordTranscodeRecordFormatList : TeaModel {
                    [NameInMap("RecordFormat")]
                    [Validation(Required=false)]
                    public List<DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordTranscodeRecordFormatListRecordFormat> RecordFormat { get; set; }
                    public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordTranscodeRecordFormatListRecordFormat : TeaModel {
                        [NameInMap("CycleDuration")]
                        [Validation(Required=false)]
                        public int? CycleDuration { get; set; }

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("OssObjectPrefix")]
                        [Validation(Required=false)]
                        public string OssObjectPrefix { get; set; }

                        [NameInMap("SliceDuration")]
                        [Validation(Required=false)]
                        public int? SliceDuration { get; set; }

                        [NameInMap("SliceOssObjectPrefix")]
                        [Validation(Required=false)]
                        public string SliceOssObjectPrefix { get; set; }

                    }

                }

                [NameInMap("TranscodeTemplates")]
                [Validation(Required=false)]
                public DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordTranscodeTemplates TranscodeTemplates { get; set; }
                public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordTranscodeTemplates : TeaModel {
                    [NameInMap("Templates")]
                    [Validation(Required=false)]
                    public List<string> Templates { get; set; }

                }

            }

        }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
