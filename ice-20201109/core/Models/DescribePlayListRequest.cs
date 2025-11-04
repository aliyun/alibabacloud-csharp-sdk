// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribePlayListRequest : TeaModel {
        /// <summary>
        /// <para>The beginning of the time range to query. By default, the system queries data of the current day.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1676170500011</para>
        /// </summary>
        [NameInMap("BeginTs")]
        [Validation(Required=false)]
        public string BeginTs { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time range cannot exceed 24 hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1682474405173</para>
        /// </summary>
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public string EndTs { get; set; }

        /// <summary>
        /// <para>The criteria by which the sorting is performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FirstFrameDuration</description></item>
        /// <item><description>PlayDuration</description></item>
        /// <item><description>VideoDuration</description></item>
        /// <item><description>StuckDuration</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FirstFrameDuration</para>
        /// </summary>
        [NameInMap("OrderName")]
        [Validation(Required=false)]
        public string OrderName { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DESC: descending order.</description></item>
        /// <item><description>ASC: ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The playback type. Valid value: </para>
        /// <list type="bullet">
        /// <item><description>vod</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vod</para>
        /// </summary>
        [NameInMap("PlayType")]
        [Validation(Required=false)]
        public string PlayType { get; set; }

        /// <summary>
        /// <para>The playback status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>complete</description></item>
        /// <item><description>playing</description></item>
        /// <item><description>unusual: A playback error occurs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>complete</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The TraceId of the player.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5e70516766285805381012d271e</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
