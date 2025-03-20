// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainMax95BpsDataRequest : TeaModel {
        /// <summary>
        /// <para>The cycle to query the 95th percentile bandwidth data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>day (default)</description></item>
        /// <item><description>month</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("Cycle")]
        [Validation(Required=false)]
        public string Cycle { get; set; }

        /// <summary>
        /// <para>The domain name to be queried for acceleration. If the parameter is empty, the data merged from all accelerated domain names will be returned by default.</para>
        /// <remarks>
        /// <para>Batch domain name queries are not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>End time point. The date format follows the ISO8601 representation and uses UTC time, in the format yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-12T13:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Start time point. The date format follows the ISO8601 representation and uses UTC time, in the format yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The start time point for getting the data. The date format follows the ISO8601 representation and uses UTC time, in the format yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-21T10:00:00Z</para>
        /// </summary>
        [NameInMap("TimePoint")]
        [Validation(Required=false)]
        public string TimePoint { get; set; }

    }

}
