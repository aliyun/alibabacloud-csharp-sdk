// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveRecordTemplatesResponseBody : TeaModel {
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
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The list of recording templates.</para>
        /// </summary>
        [NameInMap("RecordTemplateList")]
        [Validation(Required=false)]
        public List<ListLiveRecordTemplatesResponseBodyRecordTemplateList> RecordTemplateList { get; set; }
        public class ListLiveRecordTemplatesResponseBodyRecordTemplateList : TeaModel {
            /// <summary>
            /// <para>The time when the job was created.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T02:48:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the template was last modified.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T03:26:36Z</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of recording formats.</para>
            /// </summary>
            [NameInMap("RecordFormatList")]
            [Validation(Required=false)]
            public List<ListLiveRecordTemplatesResponseBodyRecordTemplateListRecordFormatList> RecordFormatList { get; set; }
            public class ListLiveRecordTemplatesResponseBodyRecordTemplateListRecordFormatList : TeaModel {
                /// <summary>
                /// <para>The duration of the recording cycle. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21600</para>
                /// </summary>
                [NameInMap("CycleDuration")]
                [Validation(Required=false)]
                public int? CycleDuration { get; set; }

                /// <summary>
                /// <para>The output file format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m3u8</para>
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The name of the recording file that is stored in Object Storage Service (OSS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>record/{JobId}/{Sequence}<em>{EscapedStartTime}</em>{EscapedEndTime}</para>
                /// </summary>
                [NameInMap("OssObjectPrefix")]
                [Validation(Required=false)]
                public string OssObjectPrefix { get; set; }

                /// <summary>
                /// <para>The duration of a single segment. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("SliceDuration")]
                [Validation(Required=false)]
                public int? SliceDuration { get; set; }

                /// <summary>
                /// <para>The name of the TS segment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>record/{JobId}/{UnixTimestamp}_{Sequence}</para>
                /// </summary>
                [NameInMap("SliceOssObjectPrefix")]
                [Validation(Required=false)]
                public string SliceOssObjectPrefix { get; set; }

            }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69e1f9fe-1e97-11ed-ba64-0c42a1b73d66</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The type of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA98A0C-7870-15FE-B96F-8880BB600A2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sorting order. By default, the query results are sorted by creation time in descending order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: sorts the query results in ascending order.</description></item>
        /// <item><description>desc: sorts the query results in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
