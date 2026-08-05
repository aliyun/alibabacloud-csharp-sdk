// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRecordUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain name to query.</para>
        /// <list type="bullet">
        /// <item><description>Supports single or batch domain queries. Separate multiple domain names with commas (,).</description></item>
        /// <item><description>If this parameter is left empty, the merged data of all live streaming domain names is returned by default.</description></item>
        /// <item><description>When you specify DomainName, make sure that the specified domain name is a live streaming domain name and that the caller has the required permissions on the domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC. Requirements:</para>
        /// <list type="bullet">
        /// <item><description>The end time must be later than the start time (StartTime).</description></item>
        /// <item><description>The maximum time span between the end time and the start time is 31 days. Requests that exceed 31 days fail and return an error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the queried data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><ol start="60">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="300">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="3600">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// <item><description><ol start="86400">
        /// <item><description></description></item>
        /// </ol>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified or an unsupported value is specified, the default time granularity is 300 seconds for query spans within 31 days and 86400 seconds for query spans longer than 31 days.</para>
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
        /// <para>The region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-beijing</b>: Beijing.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai</b>: Shanghai.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen</b>: Shenzhen.</para>
        /// </description></item>
        /// <item><description><para><b>cn-qingdao</b>: Qingdao.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Singapore.</para>
        /// </description></item>
        /// <item><description><para><b>eu-central-1</b>: Germany.</para>
        /// </description></item>
        /// <item><description><para><b>ap-northeast-1</b>: Tokyo.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-5</b>: Jakarta.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The grouping key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domain</b>: groups query results by domain name.</description></item>
        /// <item><description><b>record_fmt</b>: groups query results by recording type.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify one or more values. Separate multiple values with commas (,). Default value: <c>domain,record_fmt</c>. If this parameter is set to empty or <c>null</c>, the results are not grouped by the preceding keys.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>domain,record_fmt</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
        /// <list type="bullet">
        /// <item><description>The minimum data granularity is 5 minutes.</description></item>
        /// <item><description>If this parameter is not specified, data of the last 24 hours is returned by default.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The start time can be set to a point in time within the last 90 days from the current time, accurate to the second.</para>
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
