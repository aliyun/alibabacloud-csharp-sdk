// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsPublishListRequest : TeaModel {
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
        /// <para>The ingest domain or main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time range specified by the StartTime and EndTime parameters cannot exceed 30 days.</para>
        /// <para>Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-22T08:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The sorting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>stream_name_desc</b>: sorts the entries in descending order by stream name.</description></item>
        /// <item><description><b>stream_name_asc</b>: sorts the entries in ascending order by stream name.</description></item>
        /// <item><description><b>publish_time_desc</b>: sorts the entries in descending order by stream ingest time.</description></item>
        /// <item><description><b>publish_time_asc</b> (default): sorts the entries in ascending order by stream ingest time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>publish_time_desc</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 3000</b>. Default value: <b>2000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The mode in which stream names are matched. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>fuzzy</b> (default): fuzzy match</description></item>
        /// <item><description><b>strict</b>: exact match</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-21T08:00:00Z</para>
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
        /// <para>The type of the streams to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>An empty value****: source streams</description></item>
        /// <item><description><b>all</b>: all streams</description></item>
        /// <item><description><b>trans</b>: transcoded streams</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

    }

}
