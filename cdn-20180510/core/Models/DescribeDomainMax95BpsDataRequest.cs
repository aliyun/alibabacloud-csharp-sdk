// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainMax95BpsDataRequest : TeaModel {
        /// <summary>
        /// <para>The cycle to query the 95th percentile bandwidth data. Default value: <b>day</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b>: queries the 95th percentile bandwidth data by day.</description></item>
        /// <item><description><b>month</b>: queries the 95th percentile bandwidth data by month.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("Cycle")]
        [Validation(Required=false)]
        public string Cycle { get; set; }

        /// <summary>
        /// <para>The accelerated domain name. If you do not specify a domain name, data of all domain names is queried.</para>
        /// <remarks>
        /// <para>You cannot specify multiple domain names in a DescribeDomainMax95BpsData request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-22T08:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-21T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-21T10:00:00Z</para>
        /// </summary>
        [NameInMap("TimePoint")]
        [Validation(Required=false)]
        public string TimePoint { get; set; }

    }

}
