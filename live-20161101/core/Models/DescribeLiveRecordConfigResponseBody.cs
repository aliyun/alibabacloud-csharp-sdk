// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of recording configurations.</para>
        /// </summary>
        [NameInMap("LiveAppRecordList")]
        [Validation(Required=false)]
        public DescribeLiveRecordConfigResponseBodyLiveAppRecordList LiveAppRecordList { get; set; }
        public class DescribeLiveRecordConfigResponseBodyLiveAppRecordList : TeaModel {
            [NameInMap("LiveAppRecord")]
            [Validation(Required=false)]
            public List<DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecord> LiveAppRecord { get; set; }
            public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecord : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The time when the recording configuration was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-05-20T09:33:38Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The maximum interruption duration of the live stream. If the actual interruption duration exceeds the threshold, a new recording is generated. Valid values: 15 to 21600. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180</para>
                /// </summary>
                [NameInMap("DelayTime")]
                [Validation(Required=false)]
                public int? DelayTime { get; set; }

                /// <summary>
                /// <para>The name of the main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The end time of the recording. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-11-08T03:49:18Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The configuration of on-demand recording. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: disables on-demand recording.</description></item>
                /// <item><description><b>1</b>: enables on-demand recording that is triggered by HTTP callbacks.</description></item>
                /// <item><description><b>2</b>: enables on-demand recording that is triggered by stream ingest parameters.</description></item>
                /// <item><description><b>7</b>: enables on-demand recording by calling the <a href="https://help.aliyun.com/document_detail/85907.html">RealTimeRecordCommand</a> operation to manually start or stop recording.</description></item>
                /// </list>
                /// <remarks>
                /// <para> If you set OnDemand to <b>1</b>, you must call the <a href="https://help.aliyun.com/document_detail/51831.html">AddLiveRecordNotifyConfig</a> operation to configure OnDemandUrl. Otherwise, the configuration of on-demand recording is invalid.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OnDemond")]
                [Validation(Required=false)]
                public int? OnDemond { get; set; }

                /// <summary>
                /// <para>The name of the Object Storage Service (OSS) bucket in which the recordings are stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveBucket****</para>
                /// </summary>
                [NameInMap("OssBucket")]
                [Validation(Required=false)]
                public string OssBucket { get; set; }

                /// <summary>
                /// <para>The endpoint of the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-oss-****.aliyuncs.com</para>
                /// </summary>
                [NameInMap("OssEndpoint")]
                [Validation(Required=false)]
                public string OssEndpoint { get; set; }

                /// <summary>
                /// <para>The recording formats of original streams.</para>
                /// </summary>
                [NameInMap("RecordFormatList")]
                [Validation(Required=false)]
                public DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatList RecordFormatList { get; set; }
                public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatList : TeaModel {
                    [NameInMap("RecordFormat")]
                    [Validation(Required=false)]
                    public List<DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatListRecordFormat> RecordFormat { get; set; }
                    public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordRecordFormatListRecordFormat : TeaModel {
                        /// <summary>
                        /// <para>The duration of a recording file. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3600</para>
                        /// </summary>
                        [NameInMap("CycleDuration")]
                        [Validation(Required=false)]
                        public int? CycleDuration { get; set; }

                        /// <summary>
                        /// <para>The format of recording files.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>M3U8</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <para>The naming format of a recording file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>record/{liveApp****}/{liveStream****}</para>
                        /// </summary>
                        [NameInMap("OssObjectPrefix")]
                        [Validation(Required=false)]
                        public string OssObjectPrefix { get; set; }

                        /// <summary>
                        /// <para>The duration of a segment file. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("SliceDuration")]
                        [Validation(Required=false)]
                        public int? SliceDuration { get; set; }

                        /// <summary>
                        /// <para>The naming format of a segment file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>record/{liveApp****}/{liveStream****}/{UnixTimestamp}</para>
                        /// </summary>
                        [NameInMap("SliceOssObjectPrefix")]
                        [Validation(Required=false)]
                        public string SliceOssObjectPrefix { get; set; }

                    }

                }

                /// <summary>
                /// <para>The start time of the recording. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-11-08T02:49:18Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveStream****</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The recording formats of transcoded streams.</para>
                /// </summary>
                [NameInMap("TranscodeRecordFormatList")]
                [Validation(Required=false)]
                public DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordTranscodeRecordFormatList TranscodeRecordFormatList { get; set; }
                public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordTranscodeRecordFormatList : TeaModel {
                    [NameInMap("RecordFormat")]
                    [Validation(Required=false)]
                    public List<DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordTranscodeRecordFormatListRecordFormat> RecordFormat { get; set; }
                    public class DescribeLiveRecordConfigResponseBodyLiveAppRecordListLiveAppRecordTranscodeRecordFormatListRecordFormat : TeaModel {
                        /// <summary>
                        /// <para>The duration of a recording file. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3600</para>
                        /// </summary>
                        [NameInMap("CycleDuration")]
                        [Validation(Required=false)]
                        public int? CycleDuration { get; set; }

                        /// <summary>
                        /// <para>The format of recording files.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>M3U8</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <para>The naming format of a recording file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>record/{liveApp****}/{liveStream****}</para>
                        /// </summary>
                        [NameInMap("OssObjectPrefix")]
                        [Validation(Required=false)]
                        public string OssObjectPrefix { get; set; }

                        /// <summary>
                        /// <para>The duration of a segment file. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("SliceDuration")]
                        [Validation(Required=false)]
                        public int? SliceDuration { get; set; }

                        /// <summary>
                        /// <para>The naming format of a segment file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>record/{liveApp****}/{liveStream****}/{UnixTimestamp}</para>
                        /// </summary>
                        [NameInMap("SliceOssObjectPrefix")]
                        [Validation(Required=false)]
                        public string SliceOssObjectPrefix { get; set; }

                    }

                }

                /// <summary>
                /// <para>The transcoding templates.</para>
                /// </summary>
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
