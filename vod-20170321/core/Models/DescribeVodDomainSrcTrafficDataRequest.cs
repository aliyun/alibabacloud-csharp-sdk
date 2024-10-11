// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainSrcTrafficDataRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. You can specify a maximum of 500 domain names in a request. Separate multiple domain names with commas (,). If you specify multiple domain names in a request, aggregation results are returned.</para>
        /// <para>If you leave this parameter empty, the origin traffic data for all accelerated domain names is queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-24T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time interval between the data entries to return. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>300</b>: 5 minutes</description></item>
        /// <item><description><b>3600</b>: 1 hour</description></item>
        /// <item><description><b>86400</b>: 1 day</description></item>
        /// </list>
        /// <remarks>
        /// <para>The time granularity supported by the Interval parameter varies based on the time range per query specified by using <c>StartTime</c> and <c>EndTime</c>. For more information, see the <b>Time granularity</b> section of this topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>If you leave this parameter empty, the origin traffic data that is generated in the last 24 hours is queried by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-22T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
