// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePushProxyUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The ingest domain name of the streamer to query.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a single domain name or multiple domain names separated by commas (,).</description></item>
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
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The live center to query. You can specify multiple regions separated by commas (,). Valid values:</para>
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
        /// <para>cn-beijing</para>
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
        /// <para>The grouping key. If this parameter is left empty, the default value is region, and the aggregated data is returned. You can specify multiple values separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>domain: the domain name. If SplitBy is set to domain, the Domain field in the response takes effect.</description></item>
        /// <item><description>region (default): the live center region. If SplitBy is set to region, the Region field in the response takes effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>region</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC. By default, data from the last seven days is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
