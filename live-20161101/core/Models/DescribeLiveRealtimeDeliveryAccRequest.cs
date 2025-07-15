// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRealtimeDeliveryAccRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain.</para>
        /// <list type="bullet">
        /// <item><description>You can query one or more domain names. If you specify multiple domain names, separate them with commas (,).</description></item>
        /// <item><description>If you leave this parameter empty, the data of all domain names within your Alibaba Cloud account is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>The end time must be later than the start time. The maximum time range that can be specified is one year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:05:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the query. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>300</b></description></item>
        /// <item><description><b>3600</b></description></item>
        /// <item><description><b>86400</b></description></item>
        /// </list>
        /// <para>If you specify an invalid value or do not specify this parameter, the default value is used. If the specified time range is no more than three days, the default value is 300. If the specified time range is more than three days and no more than 30 days, the default value is 3600. If the specified time range is more than 30 days, the default value is 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The name of the Logstore to which log entries are delivered. If you leave this parameter empty, the data of all Logstores is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logstore_example</para>
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project that is used for real-time log delivery. If you leave this parameter empty, the data of all Log Service projects is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_example</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
