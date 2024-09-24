// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveRecordFilesResponseBody : TeaModel {
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<ListLiveRecordFilesResponseBodyFiles> Files { get; set; }
        public class ListLiveRecordFilesResponseBodyFiles : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2016-05-27T09:40:56Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100.0</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2015-12-01T07:36:10Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>m3u8</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>640</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c4d7f0a4-b506-43f9-8de3-07732c3f****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>LiveRecordJob***</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c4d7f0a4-b506-43f9-8de3-07732c3f****</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{ &quot;Type&quot;: &quot;oss&quot;, &quot;Endpoint&quot;:&quot;oss-cn-shanghai.aliyuncs.com&quot;, &quot;Bucket&quot;: &quot;test-bucket&quot; }</para>
            /// </summary>
            [NameInMap("RecordOutput")]
            [Validation(Required=false)]
            public string RecordOutput { get; set; }

            [NameInMap("RecordUrl")]
            [Validation(Required=false)]
            public string RecordUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2015-12-01T07:36:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>LiveStream***</para>
            /// </summary>
            [NameInMap("StreamUrl")]
            [Validation(Required=false)]
            public string StreamUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>480</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DE24625C-7C0F-4020-8448-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
