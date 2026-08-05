// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainMonitoringUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain to query.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a single domain name or multiple domain names. Separate multiple domain names with commas (,).</description></item>
        /// <item><description>If this parameter is left empty, the merged data of all live streaming domain names is returned by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-10T22:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The monitoring session ID. If this parameter is left empty, the merged data of all monitoring sessions is returned by default. You can specify multiple IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>e62af24d-a354-3b0c-9f1f-da592c4b****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The time granularity for the query. Valid values: <b>3600</b> (hour) and <b>86400</b> (day).</para>
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
        /// <para>The live center region. If this parameter is left empty, the merged data of all regions is returned by default. You can specify multiple regions. Separate multiple regions with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

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
        /// <para>The grouping key. Default value: <b>resolution</b>, which indicates grouping by resolution. Valid values: <b>domain</b>, <b>region</b>, <b>instance</b>, and <b>resolution</b>. You can specify multiple values. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>resolution</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description>The minimum data granularity is 1 hour.</description></item>
        /// <item><description>If this parameter is not specified, data of the last 24 hours is returned by default.</description></item>
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
