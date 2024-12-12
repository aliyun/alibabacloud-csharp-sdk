// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveRecordFilesRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The maximum time range to query is four days. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-22T08:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of job IDs.</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public List<string> JobIds { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 5 to 30. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The format of the recording file. Valid values:</para>
        /// <para>M3U8, FLV, and MP4</para>
        /// 
        /// <b>Example:</b>
        /// <para>m3u8</para>
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public string RecordFormat { get; set; }

        /// <summary>
        /// <para>The sorting order of the index files by creation time. Valid values:</para>
        /// <para>asc: The query results are displayed in ascending order. This is the default value.</para>
        /// <para>desc: The query results are displayed in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-21T08:00:01Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
