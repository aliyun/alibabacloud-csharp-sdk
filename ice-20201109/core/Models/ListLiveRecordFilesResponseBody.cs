// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveRecordFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of index files.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ListLiveRecordFilesResponseBodyFiles> Files { get; set; }
        public class ListLiveRecordFilesResponseBodyFiles : TeaModel {
            /// <summary>
            /// <para>The time when the file was created in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2016-05-27T09:40:56Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The recording length. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The end of the time range to query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-12-01T07:36:10Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The format of the recording file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The height of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>640</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <para>The ID of the recording job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c4d7f0a4-b506-43f9-8de3-07732c3f****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The name of the recording job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LiveRecordJob***</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The ID of the index file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c4d7f0a4-b506-43f9-8de3-07732c3f****</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// <para>The storage information about the recording file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;Type&quot;: &quot;oss&quot;, &quot;Endpoint&quot;:&quot;oss-cn-shanghai.aliyuncs.com&quot;, &quot;Bucket&quot;: &quot;test-bucket&quot; }</para>
            /// </summary>
            [NameInMap("RecordOutput")]
            [Validation(Required=false)]
            public string RecordOutput { get; set; }

            /// <summary>
            /// <para>The URL of the index file.</para>
            /// </summary>
            [NameInMap("RecordUrl")]
            [Validation(Required=false)]
            public string RecordUrl { get; set; }

            /// <summary>
            /// <para>The beginning of the time range to query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-12-01T07:36:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The name of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LiveStream***</para>
            /// </summary>
            [NameInMap("StreamUrl")]
            [Validation(Required=false)]
            public string StreamUrl { get; set; }

            /// <summary>
            /// <para>The width of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>480</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE24625C-7C0F-4020-8448-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sorting order of the index files by creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The total number of files that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
