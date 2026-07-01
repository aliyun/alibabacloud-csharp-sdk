// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaBasicInfosRequest : TeaModel {
        /// <summary>
        /// <para>The authentication expiration time, in seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>Minimum value: 1.</para>
        /// </description></item>
        /// <item><description><para>Maximum value: 86400.</para>
        /// </description></item>
        /// <item><description><para>Default value: 3600.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>The business type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>subtitles</c>: subtitles</para>
        /// </description></item>
        /// <item><description><para><c>watermark</c>: watermark</para>
        /// </description></item>
        /// <item><description><para><c>opening</c>: opening</para>
        /// </description></item>
        /// <item><description><para><c>ending</c>: ending</para>
        /// </description></item>
        /// <item><description><para><c>general</c>: General</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>opening</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The end time of the query range, based on the creation time (<c>utcCreated</c>).</para>
        /// <list type="bullet">
        /// <item><description><para>The query returns results created at or before this time (inclusive).</para>
        /// </description></item>
        /// <item><description><para>The time must be in UTC and comply with the ISO 8601 standard. The format is <c>YYYY-MM-DD\\&quot;T\\&quot;HH:mm:ss\\&quot;Z\\&quot;</c>. For example, <c>2017-01-11T12:00:00Z</c> corresponds to 20:00:00 on January 11, 2017 (UTC+8).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-20T13:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Set to <c>true</c> to include basic file information in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeFileBasicInfo")]
        [Validation(Required=false)]
        public bool? IncludeFileBasicInfo { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// <para>Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The media ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>019b82e24b37a1c2958dec38</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The media type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>image</c>: image</para>
        /// </description></item>
        /// <item><description><para><c>video</c>: video</para>
        /// </description></item>
        /// <item><description><para><c>audio</c>: audio</para>
        /// </description></item>
        /// <item><description><para><c>text</c>: text</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The pagination token used to retrieve the next page of results. An empty value indicates that all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pSa1SQ0wCe5pzVrQ6mWZEw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order for results based on the creation time (<c>utcCreated</c>). The default is descending. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>desc</c>: Descending order</para>
        /// </description></item>
        /// <item><description><para><c>asc</c>: Ascending order</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>oss</c>: OSS</para>
        /// </description></item>
        /// <item><description><para><c>vod</c>: video on demand</para>
        /// </description></item>
        /// <item><description><para><c>live</c>: live streaming</para>
        /// </description></item>
        /// <item><description><para><c>general</c>: Other sources (default).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The start time of the query range, based on the creation time (<c>utcCreated</c>).</para>
        /// <list type="bullet">
        /// <item><description><para>The query returns results created after this time (exclusive).</para>
        /// </description></item>
        /// <item><description><para>The time must be in UTC and comply with the ISO 8601 standard. The format is <c>YYYY-MM-DD\\&quot;T\\&quot;HH:mm:ss\\&quot;Z\\&quot;</c>. For example, <c>2017-01-11T12:00:00Z</c> corresponds to 20:00:00 on January 11, 2017 (UTC+8).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-20T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The media status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Init</c>: The source file is not ready.</para>
        /// </description></item>
        /// <item><description><para><c>Preparing</c>: The source file is being prepared. For example, it is being uploaded or composited.</para>
        /// </description></item>
        /// <item><description><para><c>PrepareFail</c>: The source file failed to prepare. This may occur, for example, if the system fails to retrieve information about the source file.</para>
        /// </description></item>
        /// <item><description><para><c>Normal</c>: The source file is ready.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
