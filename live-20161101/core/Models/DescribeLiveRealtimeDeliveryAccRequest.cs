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
        /// <item><description>You can specify a single domain name or multiple domain names. Separate multiple domain names with commas (,).</description></item>
        /// <item><description>If this parameter is not specified, the merged data of all live streaming domain names is returned by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <para>The end time must be later than the start time. The interval between the start time and end time cannot exceed one year.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:05:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the queried data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>300</b></description></item>
        /// <item><description><b>3600</b></description></item>
        /// <item><description><b>86400</b></description></item>
        /// </list>
        /// <para>If this parameter is not specified or the specified value is not supported, the default value is 300 seconds when the time span does not exceed 3 days, 3600 seconds when the time span exceeds 3 days, and 86400 seconds when the time span exceeds 30 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The Logstore for real-time log delivery. If this parameter is not specified, the merged data of all Logstores is returned by default.</para>
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
        /// <para>The Project for real-time log delivery. If this parameter is not specified, the merged data of all Projects is returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_example</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
