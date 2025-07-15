// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRecordUsageDataRequest : TeaModel {
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
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC. Value requirements:</para>
        /// <list type="bullet">
        /// <item><description>The end time is later than the start time.</description></item>
        /// <item><description>The time range between the start time and end time is up to 31 days. If the time range is more than 31 days, the request fails and an error is reported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the query. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>60</description></item>
        /// <item><description>300</description></item>
        /// <item><description>3600</description></item>
        /// <item><description>86400</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter or specify an invalid value: The time granularity of the query for a time range that is less than or equal to 31 days is 300 seconds by default. The time granularity of the query for a time range that is more than 31 days is 86400 seconds by default.</para>
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
        /// <para>The ID of the region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-beijing</b>: China (Beijing)</description></item>
        /// <item><description><b>cn-shanghai</b>: China (Shanghai)</description></item>
        /// <item><description><b>cn-shenzhen</b>: China (Shenzhen)</description></item>
        /// <item><description><b>cn-qingdao</b>: China (Qingdao)</description></item>
        /// <item><description><b>ap-southeast-1</b>: Singapore</description></item>
        /// <item><description><b>eu-central-1</b>: Germany (Frankfurt)</description></item>
        /// <item><description><b>ap-northeast-1</b>: Japan (Tokyo)</description></item>
        /// <item><description><b>ap-southeast-5</b>: Indonesia (Jakarta)</description></item>
        /// </list>
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
        /// <para>The key that is used to group data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domain</b>: groups results by domain name.</description></item>
        /// <item><description><b>record_fmt</b>: groups results by recording type.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can select one option or both. If you want to select both options, separate them with a comma (,). The default value is <c>domain,record_fmt</c>. If you leave this parameter empty or set the value to <c>null</c>, this parameter is ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>domain,record_fmt</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description>The minimum data granularity is 5 minutes.</description></item>
        /// <item><description>If you do not specify this parameter, the data in the last 24 hours is returned.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The earliest start time that you can specify is 90 days back from the current time, accurate to seconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
