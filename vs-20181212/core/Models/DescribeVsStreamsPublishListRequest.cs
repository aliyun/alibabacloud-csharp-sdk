// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStreamsPublishListRequest : TeaModel {
        /// <summary>
        /// <para>The application name of the live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Your domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Use UTC format. Example: 2016-06-30T19:00:00Z</para>
        /// </description></item>
        /// <item><description><para>The interval between EndTime and StartTime must not exceed 30 days.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-30T19:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>stream_name_desc (sort by stream name in descending order)</para>
        /// </description></item>
        /// <item><description><para>stream_name_asc (sort by stream name in ascending order)</para>
        /// </description></item>
        /// <item><description><para>publish_time_desc (sort by publish time in descending order)</para>
        /// </description></item>
        /// <item><description><para>publish_time_asc (sort by publish time in ascending order) (default)</para>
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
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 3000.<br>
        /// Valid values: 1 to 3000.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to use fuzzy matching for the stream name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>fuzzy (fuzzy match)</para>
        /// </description></item>
        /// <item><description><para>strict (exact match)</para>
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
        /// <para>The start time.</para>
        /// <remarks>
        /// <para>Use UTC format. Example: 2016-06-29T19:00:00Z</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-06-29T19:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The live stream name.</para>
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
        /// <item><description><para>all (all streams) (default)</para>
        /// </description></item>
        /// <item><description><para>raw (raw stream)</para>
        /// </description></item>
        /// <item><description><para>trans (transcoded stream)</para>
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
