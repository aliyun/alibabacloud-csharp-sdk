// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStreamsOnlineListRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Specify the time in the UTC format. Example: 2016-06-30T19:00:00Z.</para>
        /// </description></item>
        /// <item><description><para>The time range between EndTime and StartTime cannot exceed 30 days.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-30T19:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The sorting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>stream_name_desc: sorts by stream name in descending order.</para>
        /// </description></item>
        /// <item><description><para>stream_name_asc: sorts by stream name in ascending order.</para>
        /// </description></item>
        /// <item><description><para>publish_time_desc: sorts by ingest time in descending order.</para>
        /// </description></item>
        /// <item><description><para>publish_time_asc (default): sorts by ingest time in ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>publish_time_asc</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 3000.</para>
        /// <para>Valid values: 1 to 3000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a fuzzy match for the stream name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>fuzzy: fuzzy match</para>
        /// </description></item>
        /// <item><description><para>strict: exact match</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The start of the time range to query.</para>
        /// <remarks>
        /// <para>Specify the time in the UTC format. Example: 2016-06-29T19:00:00Z.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T19:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The stream name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxStream</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The stream type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>all (default): all streams</para>
        /// </description></item>
        /// <item><description><para>raw: raw streams</para>
        /// </description></item>
        /// <item><description><para>trans: transcoded streams</para>
        /// </description></item>
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
