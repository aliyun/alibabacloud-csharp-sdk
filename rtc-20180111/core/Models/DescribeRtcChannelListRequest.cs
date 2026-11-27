// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcChannelListRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aoe****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The channel ID. Only a single ID is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testChannel</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: greater than <b>0</b>. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: greater than <b>0</b>. Default value: 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The service area. By default, all areas are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn</b>: China.</para>
        /// </description></item>
        /// <item><description><para><b>us</b>: United States.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("ServiceArea")]
        [Validation(Required=false)]
        public string ServiceArea { get; set; }

        /// <summary>
        /// <para>The sort order. By default, the records are sorted in descending order of StartTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The query time in UTC. The format is yyyy-MM-ddTHH:mm:ssZ. The time granularity is one day.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("TimePoint")]
        [Validation(Required=false)]
        public string TimePoint { get; set; }

        /// <summary>
        /// <para>The user ID. Only a single ID is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testUser</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
