// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDelayedStreamingUsageRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain name to query.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a single domain name or multiple domain names. Separate multiple domain names with commas (,).</description></item>
        /// <item><description>If this parameter is left empty, the aggregated data of all live streaming domain names is returned by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. The time span cannot exceed 10 hours. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the queried data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>300</description></item>
        /// <item><description>3600</description></item>
        /// <item><description>86400</description></item>
        /// </list>
        /// <para>If this parameter is left empty or set to an unsupported value, the default value 3600 is used.</para>
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
        /// <para>The live center to query. You can specify multiple regions. Separate multiple regions with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-beijing: Beijing</description></item>
        /// <item><description>cn-shanghai: Shanghai</description></item>
        /// <item><description>cn-shenzhen: Shenzhen</description></item>
        /// <item><description>cn-qingdao: Qingdao</description></item>
        /// <item><description>ap-southeast-1: Singapore</description></item>
        /// <item><description>eu-central-1: Germany</description></item>
        /// <item><description>ap-northeast-1: Tokyo</description></item>
        /// <item><description>ap-southeast-5: Jakarta</description></item>
        /// </list>
        /// <para>If this parameter is left empty, the aggregated data of all regions is returned by default.</para>
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
        /// <para>The grouping key. If this parameter is left empty, user data is aggregated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>domain: domain name. If the SplitBy (grouping key) parameter is set to domain, the Domain response parameter takes effect.</description></item>
        /// <item><description>region: live center region. If the SplitBy (grouping key) parameter is set to region, the Region response parameter takes effect.</description></item>
        /// <item><description>stream: stream name. If the SplitBy (grouping key) parameter is set to stream, the stream response parameter takes effect.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can query data only when the parameter corresponding to the grouping key is not empty. Otherwise, an error is returned. For example, when DomainName is empty, you cannot specify domain as the grouping key.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC. By default, data of the last seven days is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The stream name. Separate multiple stream names with commas (,). By default, the data of all stream names is aggregated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
