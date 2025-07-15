// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainMonitoringUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The main streaming domain to query.</para>
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
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-10T22:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the monitoring session. If you leave this parameter empty, data of all monitoring sessions is queried by default. Separate multiple session IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>e62af24d-a354-3b0c-9f1f-da592c4b****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The time granularity. Valid values: <b>3600</b> and <b>86400</b>. 3600 specifies that data is queried by hour and 86400 specifies that data is queried by day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region of the live center. If you leave this parameter empty, data of all regions is queried by default. Separate multiple regions with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The key that is used to group data. Valid values: <b>domain</b>, <b>region</b>, <b>instance</b>, and <b>resolution</b>. Default value: <b>resolution</b>. resolution specifies that data is grouped by resolution. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>resolution</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format.</para>
        /// <list type="bullet">
        /// <item><description>The time must be in UTC.</description></item>
        /// <item><description>The minimum data granularity is 1 hour.</description></item>
        /// <item><description>If you leave this parameter empty, data in the previous 24 hours is queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
