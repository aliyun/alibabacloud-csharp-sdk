// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamMonitorListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the monitoring session.</para>
        /// <remarks>
        /// <para> You can obtain the monitoring session ID from the response parameter MonitorId of the <a href="https://help.aliyun.com/document_detail/2848129.html">CreateLiveStreamMonitor</a> operation. If you leave this parameter empty, the data of all monitoring sessions is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("MonitorId")]
        [Validation(Required=false)]
        public string MonitorId { get; set; }

        /// <summary>
        /// <para>The sorting order of monitoring sessions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Monitoring sessions are sorted by status.</description></item>
        /// <item><description>1: Monitoring sessions are sorted by start time in descending order.</description></item>
        /// <item><description>2: Monitoring sessions are sorted by start time in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderRule")]
        [Validation(Required=false)]
        public int? OrderRule { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of monitoring sessions to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The status of the monitoring session. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Monitoring</description></item>
        /// <item><description>0: Unmonitored</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
