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

                [NameInMap("DelayTime")]
                [Validation(Required=false)]
                public int? DelayTime { get; set; }

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

        /// <summary>
        /// <para>The sorting order of recording configurations by creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5056369B-D337-499E-B8B7-B761BD37B08A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of recording configurations that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
